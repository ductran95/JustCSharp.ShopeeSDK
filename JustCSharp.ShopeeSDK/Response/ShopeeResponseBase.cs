using System.Text.Json.Serialization;

namespace JustCSharp.ShopeeSDK.Response;

public abstract class ShopeeResponseBase<T> : IShopeeResponse where T : class
{
    [JsonPropertyName("user_message")]
    public virtual string UserMessage { get; set; }

    [JsonPropertyName("data")]
    public virtual T Data { get; set; }

    public virtual int ErrorCode { get; set; }

    public virtual string Message { get; set; }
}