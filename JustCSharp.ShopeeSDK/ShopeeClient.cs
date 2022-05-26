using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using JustCSharp.Data.Enums;
using JustCSharp.ShopeeSDK.Exceptions;
using JustCSharp.ShopeeSDK.Extensions;
using JustCSharp.ShopeeSDK.Request;
using JustCSharp.ShopeeSDK.Response;
using JustCSharp.Utility.Helpers;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using RestSharp;

namespace JustCSharp.ShopeeSDK;

public class ShopeeClient : IShopeeClient
{
    protected readonly IRestClient _httpClient;
    protected readonly ILogger _logger;
    protected readonly ShopeeOptions _shopeeOptions;

    public ShopeeClient(IOptions<ShopeeOptions> shopeeOptions, IRestClient httpClient, ILogger<ShopeeClient> logger)
    {
        _httpClient = httpClient;
        _logger = logger;
        _shopeeOptions = shopeeOptions.Value;
    }

    public T Execute<T>(IShopeeRequest<T> request) where T : IShopeeResponse
    {
        var restRequest = CreateRestRequest(request);
        IRestResponse<T> response = null;

        Stopwatch stopwatch = null;
        try
        {
            if (_logger.IsEnabled(LogLevel.Trace)) stopwatch = Stopwatch.StartNew();

            _logger.LogTrace("Start ExecuteAsync for {requestType}", request.GetType());

            response = _httpClient.Execute<T>(restRequest);
        }
        catch (Exception ex)
        {
            throw new ShopeeException("Failed to send request", ex);
        }
        finally
        {
            stopwatch?.Stop();
            _logger.LogTrace("End ExecuteAsync, elapsed time {elapsedTime}", stopwatch?.Elapsed);
        }

        return ProcessResponse(response);
    }

    public async Task<T> ExecuteAsync<T>(IShopeeRequest<T> request, CancellationToken cancellationToken = default)
        where T : IShopeeResponse
    {
        var restRequest = await CreateRestRequestAsync(request, cancellationToken);
        IRestResponse<T> response = null;

        Stopwatch stopwatch = null;
        try
        {
            if (_logger.IsEnabled(LogLevel.Trace)) stopwatch = Stopwatch.StartNew();

            _logger.LogTrace("Start ExecuteAsync for {requestType}", request.GetType());

            response = await _httpClient.ExecuteAsync<T>(restRequest, cancellationToken);
        }
        catch (Exception ex)
        {
            throw new ShopeeException("Failed to send request", ex);
        }
        finally
        {
            stopwatch?.Stop();
            _logger.LogTrace("End ExecuteAsync, elapsed time {elapsedTime}", stopwatch?.Elapsed);
        }

        return ProcessResponse(response);
    }

    public string GetPasswordHash([NotNull] string password)
    {
        return CryptoHelper.Hash(CryptoHelper.Hash(password, HashAlgorithmEnum.MD5).ToLower(),
            HashAlgorithmEnum.SHA256).ToLower();
    }

    protected T ProcessResponse<T>(IRestResponse<T> response)
    {
        if (response.IsSuccessful) return response.Data;

        if (response.StatusCode == HttpStatusCode.Forbidden)
            throw new ShopeeUnauthorizedException("Cookie is not set or expired", response.ErrorException);
        throw new ShopeeException(
            $"Request failed, status code: {response.StatusCode}, message: {response.ErrorMessage}",
            response.ErrorException);
    }

    protected IRestRequest CreateRestRequest<T>(IShopeeRequest<T> request) where T : IShopeeResponse
    {
        return CreateRestRequest(request, _shopeeOptions);
    }

    protected Task<IRestRequest> CreateRestRequestAsync<T>(IShopeeRequest<T> request,
        CancellationToken cancellationToken = default) where T : IShopeeResponse
    {
        return Task.FromResult(CreateRestRequest(request, _shopeeOptions));
    }

    protected IRestRequest CreateRestRequest<T>(IShopeeRequest<T> request, ShopeeOptions shopeeOptions)
        where T : IShopeeResponse
    {
        if (string.IsNullOrEmpty(request.Cookie)) throw new ShopeeUnauthorizedException("Cookies not set");

        if (request.ShopVersion <= 0) throw new ShopeeUnauthorizedException("Shop Version not correct");

        if (request is IShopeeCustomRequest shopeeCustomRequest)
            return shopeeCustomRequest.CreateRestRequest(shopeeOptions);

        var url = string.Empty;
        if (request.ApiVersion.HasValue)
            url = $"{shopeeOptions.ApiUrl}/api/v{request.ApiVersion}/{request.ApiUrl}";
        else
            url = $"{shopeeOptions.ApiUrl}/api/{request.ApiUrl}";
        var restRequest = new RestRequest(url, request.Method, DataFormat.Json);

        var cookies = ParseCookieData(request.Cookie);

        if (!cookies.TryGetValue(ShopeeParameters.ShopIdParameter, out var shopId))
            throw new ShopeeUnauthorizedException($"Cookies not contains {ShopeeParameters.ShopIdParameter}");

        restRequest.AddParameter(ShopeeParameters.ShopIdParameter, shopId, ParameterType.QueryString);
        restRequest.AddParameter(ShopeeParameters.ShopVersionParameter, request.ShopVersion, ParameterType.QueryString);

        foreach (var cookieItem in cookies) restRequest.AddCookie(cookieItem.Key, cookieItem.Value);

        if (request.BothQueryAndBody)
        {
            request.SetRestRequestQueryData(restRequest);
            request.SetRestRequestJsonData(restRequest);
        }
        else
        {
            switch (request.Method)
            {
                case Method.GET:
                    request.SetRestRequestQueryData(restRequest);
                    break;
                case Method.POST:
                    request.SetRestRequestJsonData(restRequest);
                    break;
                case Method.PUT:
                    request.SetRestRequestJsonData(restRequest);
                    break;
                case Method.DELETE:
                    request.SetRestRequestQueryData(restRequest);
                    break;
            }
        }

        return restRequest;
    }

    protected Dictionary<string, string> ParseCookieData(string cookie)
    {
        var cookieDictionary = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);

        var values = cookie.TrimEnd(';').Split(';');
        foreach (var parts in values.Select(c => c.Split(new[] {'='}, 2)))
        {
            var cookieName = parts[0].Trim();
            string cookieValue;

            if (parts.Length == 1)
                //Cookie attribute
                cookieValue = string.Empty;
            else
                cookieValue = parts[1];

            cookieDictionary[cookieName] = cookieValue;
        }

        return cookieDictionary;
    }
}