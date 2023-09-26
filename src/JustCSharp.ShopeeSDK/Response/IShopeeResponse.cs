using System.Text.Json.Serialization;

namespace JustCSharp.ShopeeSDK.Response;

public interface IShopeeResponse
{
    [JsonPropertyName("code")]
    int Code { get; set; }

    [JsonPropertyName("message")]
    string Message { get; set; }
}