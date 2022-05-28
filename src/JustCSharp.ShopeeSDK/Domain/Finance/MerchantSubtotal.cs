using System.Text.Json.Serialization;

namespace JustCSharp.ShopeeSDK.Domain.Finance;

public class MerchantSubtotal
{
    [JsonPropertyName("cancel_amount")]
    public double CancelAmount { get; set; }

    [JsonPropertyName("product_price")]
    public double ProductPrice { get; set; }

    [JsonPropertyName("refund_amount")]
    public double RefundAmount { get; set; }
}