using System.Text.Json.Serialization;

namespace JustCSharp.ShopeeSDK.Domain.Order;

public class PackageOrderAction
{
    [JsonPropertyName("can_split")]
    public bool CanSplit { get; set; }

    [JsonPropertyName("can_unsplit")]
    public bool CanUnsplit { get; set; }
}