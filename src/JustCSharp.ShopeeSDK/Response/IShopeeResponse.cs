using System.Text.Json.Serialization;

namespace JustCSharp.ShopeeSDK.Response;

public interface IShopeeResponse
{
    [JsonPropertyName("errcode")]
    int ErrorCode { get; set; }

    [JsonPropertyName("message")]
    string Message { get; set; }
}