using System.Text.Json.Serialization;

namespace JustCSharp.ShopeeSDK.Response;

public abstract class ShopeeResponseBase<T> : IShopeeResponse where T : class
{
    [JsonPropertyName("user_message")]
    public virtual string UserMessage { get; set; }

    [JsonPropertyName("data")]
    public virtual T Data { get; set; }

    [JsonPropertyName("code")]
    public virtual int Code { get; set; }

    [JsonPropertyName("message")]
    public virtual string Message { get; set; }
}