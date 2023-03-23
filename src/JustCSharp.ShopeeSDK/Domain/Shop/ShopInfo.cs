using System.Text.Json.Serialization;

namespace JustCSharp.ShopeeSDK.Domain.Shop;

public class ShopInfo
{
    [JsonPropertyName("shop_region")]
    public string ShopRegion { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("official_shop")]
    public bool OfficialShop { get; set; }

    [JsonPropertyName("shop_id")]
    public long ShopId { get; set; }

    [JsonPropertyName("is_sip_primary")]
    public bool IsSipPrimary { get; set; }

    [JsonPropertyName("cb_option")]
    public int CbOption { get; set; }
}