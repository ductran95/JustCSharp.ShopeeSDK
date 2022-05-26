using System.Text.Json.Serialization;
using JustCSharp.ShopeeSDK.Attributes;
using JustCSharp.ShopeeSDK.Response;
using RestSharp;

namespace JustCSharp.ShopeeSDK.Request;

public interface IShopeeRequest<T> where T : IShopeeResponse
{
    [JsonIgnore]
    [QueryIgnore]
    bool BothQueryAndBody { get; }

    [JsonIgnore]
    [QueryIgnore]
    int? ApiVersion { get; }

    [JsonIgnore]
    [QueryIgnore]
    string ApiUrl { get; }

    [JsonIgnore]
    [QueryIgnore]
    Method Method { get; }

    [JsonIgnore]
    [QueryIgnore]
    string Cookie { get; set; }

    [JsonIgnore]
    [QueryIgnore]
    int ShopVersion { get; set; }
}

public interface IShopeeCustomRequest
{
    IRestRequest CreateRestRequest(ShopeeOptions shopeeOptions);
}