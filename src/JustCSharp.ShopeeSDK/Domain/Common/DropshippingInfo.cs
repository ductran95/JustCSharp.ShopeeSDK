using System.Text.Json.Serialization;

namespace JustCSharp.ShopeeSDK.Domain.Common;

public class DropshippingInfo
{
    [JsonPropertyName("enabled")]
    public long Enabled { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("phone_number")]
    public string PhoneNumber { get; set; }
}