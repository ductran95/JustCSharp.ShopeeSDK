using System.Text.Json.Serialization;

namespace JustCSharp.ShopeeSDK.Domain.Common;

public class AddressInfo
{
    [JsonPropertyName("mcount")]
    public long Mcount { get; set; }

    [JsonPropertyName("mcount_create_time")]
    public long McountCreateTime { get; set; }

    [JsonPropertyName("in_white_list")]
    public bool InWhiteList { get; set; }
}