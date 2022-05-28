using System.Text.Json.Serialization;

namespace JustCSharp.ShopeeSDK.Domain.Finance;

public class WalletStatusLimitData : IShopeeObject
{
    [JsonPropertyName("min_limit")]
    public double MinLimit { get; set; }

    [JsonPropertyName("limit")]
    public double Limit { get; set; }

    [JsonPropertyName("is_higher_limit")]
    public long IsHigherLimit { get; set; }
}