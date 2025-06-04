using System.Text.Json.Serialization;

namespace JustCSharp.ShopeeSDK.Response;

public abstract class ShopeeResponseV4Base<T> : IShopeeResponse where T : class
{
    [JsonPropertyName("data")]
    public virtual T Data { get; set; }

    [JsonPropertyName("err")]
    public virtual int Code { get; set; }

    [JsonPropertyName("error_msg")]
    public virtual string Message { get; set; }
}