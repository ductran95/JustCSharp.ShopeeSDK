using System.Text.Json.Serialization;

namespace JustCSharp.ShopeeSDK.Domain.Order;

public class BundleDealRule
{
    [JsonPropertyName("rule_type")]
    public long RuleType { get; set; }

    [JsonPropertyName("min_amount")]
    public long MinAmount { get; set; }

    [JsonPropertyName("fix_price")]
    public string FixPrice { get; set; }

    [JsonPropertyName("discount_percentage")]
    public string DiscountPercentage { get; set; }

    [JsonPropertyName("discount_value")]
    public string DiscountValue { get; set; }
}