using System;
using System.Linq;
using System.Reflection;
using JustCSharp.Data.Constants;
using JustCSharp.ShopeeSDK.Attributes;
using JustCSharp.ShopeeSDK.Request;
using JustCSharp.ShopeeSDK.Response;
using RestSharp;

namespace JustCSharp.ShopeeSDK.Extensions;

public static class ShopeeRequestExtensions
{
    public static void SetRestRequestQueryData<T>(this IShopeeRequest<T> request, RestRequest restRequest)
        where T : IShopeeResponse
    {
        // get only not ignored properties
        var properties = request.GetType().GetProperties(ReflectionConstants.SearchPropertyFlags)
            .Where(x => x.GetCustomAttribute<QueryIgnoreAttribute>() == null).ToList();

        foreach (var property in properties)
        {
            var name = property.Name;

            var jsonPropNameAttr = property.GetCustomAttribute<QueryPropertyNameAttribute>();
            if (jsonPropNameAttr != null && !string.IsNullOrEmpty(jsonPropNameAttr.Name)) name = jsonPropNameAttr.Name;

            var data = property.GetValue(request);
            var stringData = string.Empty;

            switch (data)
            {
                case DateTime dateTimeObj:
                    if (property.Name.EndsWith("Date") || name.EndsWith("date"))
                        stringData = dateTimeObj.ToString("yyyy-MM-dd");
                    else
                        stringData = dateTimeObj.ToString("o");
                    break;

                default:
                    stringData = data?.ToString() ?? string.Empty;
                    break;
            }

            restRequest.AddParameter(name, stringData, ParameterType.QueryString);
        }
    }

    public static void SetRestRequestJsonData<T>(
        this IShopeeRequest<T> request,
        RestRequest restRequest)
        where T : IShopeeResponse
    {
        restRequest.AddJsonBody(request);
    }
}