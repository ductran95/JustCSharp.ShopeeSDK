using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using JustCSharp.ShopeeSDK.Exceptions;
using JustCSharp.ShopeeSDK.Extensions;
using JustCSharp.ShopeeSDK.Request;
using JustCSharp.ShopeeSDK.Response;
using JustCSharp.Utility;
using JustCSharp.Utility.Helpers;
using Microsoft.Extensions.Logging;
using RestSharp;

namespace JustCSharp.ShopeeSDK;

public class ShopeeClient : IShopeeClient, IDisposable
{
    protected readonly RestClient _httpClient;
    protected readonly ILogger _logger;
    protected readonly ShopeeSDKOptions _shopeeSdkOptions;

    public ShopeeClient(ShopeeSDKOptions shopeeSdkOptions, ILogger<ShopeeClient> logger)
    {
        _httpClient = new RestClient(new RestClientOptions()
        {
            UserAgent = "Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/117.0.0.0 Safari/537.36"
        });
        _logger = logger;
        _shopeeSdkOptions = shopeeSdkOptions;
    }

    public T Execute<T>(IShopeeRequest<T> request) where T : IShopeeResponse
    {
        var restRequest = CreateRestRequest(request);
        RestResponse<T> response = null;

        try
        {
            _logger.LogTrace("Start ExecuteAsync for {requestType}", request.GetType());

            response = _httpClient.Execute<T>(restRequest);
        }
        catch (Exception ex)
        {
            throw new ShopeeException("Failed to send request", ex);
        }
        finally
        {
            _logger.LogTrace("End ExecuteAsync");
        }

        return ProcessResponse(response);
    }

    public async Task<T> ExecuteAsync<T>(IShopeeRequest<T> request, CancellationToken cancellationToken = default)
        where T : IShopeeResponse
    {
        var restRequest = await CreateRestRequestAsync(request, cancellationToken);
        RestResponse<T> response = null;

        try
        {
            _logger.LogTrace("Start ExecuteAsync for {requestType}", request.GetType());

            response = await _httpClient.ExecuteAsync<T>(restRequest, cancellationToken);
        }
        catch (Exception ex)
        {
            throw new ShopeeException("Failed to send request", ex);
        }
        finally
        {
            _logger.LogTrace("End ExecuteAsync");
        }

        return ProcessResponse(response);
    }

    public string GetPasswordHash([NotNull] string password)
    {
        return CryptoHelper.Hash(CryptoHelper.Hash(password, HashAlgorithmType.MD5).ToLower(),
            HashAlgorithmType.SHA256).ToLower();
    }

    protected T ProcessResponse<T>(RestResponse<T> response)
    {
        if (response.IsSuccessful) return response.Data;

        if (response.StatusCode == HttpStatusCode.Forbidden)
            throw new ShopeeUnauthorizedException("Cookie is not set or expired", response.ErrorException);
        throw new ShopeeException(
            $"Request failed, status code: {response.StatusCode}, message: {response.ErrorMessage}",
            response.ErrorException);
    }

    protected RestRequest CreateRestRequest<T>(IShopeeRequest<T> request) where T : IShopeeResponse
    {
        return CreateRestRequest(request, _shopeeSdkOptions);
    }

    protected Task<RestRequest> CreateRestRequestAsync<T>(IShopeeRequest<T> request,
        CancellationToken cancellationToken = default) where T : IShopeeResponse
    {
        return Task.FromResult(CreateRestRequest(request, _shopeeSdkOptions));
    }

    protected RestRequest CreateRestRequest<T>(IShopeeRequest<T> request, ShopeeSDKOptions shopeeSdkOptions)
        where T : IShopeeResponse
    {
        if (string.IsNullOrEmpty(request.Cookie)) throw new ShopeeUnauthorizedException("Cookies not set");

        if (request.ShopVersion <= 0) throw new ShopeeUnauthorizedException("Shop Version not correct");

        if (request is IShopeeCustomRequest shopeeCustomRequest)
            return shopeeCustomRequest.CreateRestRequest(shopeeSdkOptions);

        var url = string.Empty;
        if (request.ApiVersion.HasValue)
            url = $"{shopeeSdkOptions.ApiUrl}/api/v{request.ApiVersion}/{request.ApiUrl}";
        else
            url = $"{shopeeSdkOptions.ApiUrl}/api/{request.ApiUrl}";
        var restRequest = new RestRequest(url, request.Method);

        var cookies = ParseCookieData(request.Cookie);

        if (!cookies.TryGetValue(ShopeeParameters.ShopIdParameter, out var shopId))
            throw new ShopeeUnauthorizedException($"Cookies not contains {ShopeeParameters.ShopIdParameter}");

        restRequest.AddParameter(ShopeeParameters.ShopIdParameter, shopId, ParameterType.QueryString);
        restRequest.AddParameter(ShopeeParameters.ShopVersionParameter, request.ShopVersion, ParameterType.QueryString);

        var cookieHeader = string.Join("; ", cookies.Select(x => $"{x.Key}={x.Value}"));
        restRequest.AddOrUpdateHeader("cookie", cookieHeader);

        if (request.BothQueryAndBody)
        {
            request.SetRestRequestQueryData(restRequest);
            request.SetRestRequestJsonData(restRequest);
        }
        else
        {
            switch (request.Method)
            {
                case Method.Get:
                    request.SetRestRequestQueryData(restRequest);
                    break;
                case Method.Post:
                    request.SetRestRequestJsonData(restRequest);
                    break;
                case Method.Put:
                    request.SetRestRequestJsonData(restRequest);
                    break;
                case Method.Delete:
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

    public void Dispose()
    {
        _httpClient?.Dispose();
    }
}