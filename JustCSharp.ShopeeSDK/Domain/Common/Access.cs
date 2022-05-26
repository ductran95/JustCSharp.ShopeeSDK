using System.Text.Json.Serialization;

namespace JustCSharp.ShopeeSDK.Domain.Common;

public class Access
{
    [JsonPropertyName("hide_likes")]
    public long HideLikes { get; set; }

    [JsonPropertyName("wallet_setting")]
    public long WalletSetting { get; set; }

    [JsonPropertyName("seller_coin_setting")]
    public long SellerCoinSetting { get; set; }

    [JsonPropertyName("seller_wholesale_setting")]
    public long SellerWholesaleSetting { get; set; }

    [JsonPropertyName("seller_ads_setting")]
    public long SellerAdsSetting { get; set; }
}