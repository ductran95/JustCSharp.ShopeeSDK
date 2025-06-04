using System.Text.Json.Serialization;
using JustCSharp.ShopeeSDK.Attributes;
using JustCSharp.ShopeeSDK.Response;
using RestSharp;

namespace JustCSharp.ShopeeSDK.Request;

public abstract class ShopeeRequestBase<T> : IShopeeRequest<T> where T : IShopeeResponse
{
    [JsonIgnore]
    [QueryIgnore]
    public virtual bool BothQueryAndBody { get; } = false;

    [JsonIgnore]
    [QueryIgnore]
    public virtual int? ApiVersion { get; } = 4;

    [JsonIgnore]
    [QueryIgnore]
    public virtual string ApiUrl { get; }

    [JsonIgnore]
    [QueryIgnore]
    public virtual Method Method { get; }

    [JsonIgnore]
    [QueryIgnore]
    public string Cookie { get; set; }

    [JsonIgnore]
    [QueryIgnore]
    public int ShopVersion { get; set; }
}