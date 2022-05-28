using System.Text.Json.Serialization;

namespace JustCSharp.ShopeeSDK.Domain.Finance;

public class ShippingSubtotal
{
    [JsonPropertyName("estimated_shipping_rebate_from_shopee")]
    public double EstimatedShippingRebateFromShopee { get; set; }

    [JsonPropertyName("shipping_fee_paid_by_shopee_on_your_behalf")]
    public double ShippingFeePaidByShopeeOnYourBehalf { get; set; }

    [JsonPropertyName("shipping_fee_reverse")]
    public double ShippingFeeReverse { get; set; }

    [JsonPropertyName("shipping_rebate_from_shopee")]
    public double ShippingRebateFromShopee { get; set; }

    [JsonPropertyName("shipping_fee_paid_by_buyer")]
    public double ShippingFeePaidByBuyer { get; set; }

    [JsonPropertyName("shipping_fee_discount_3pl")]
    public double ShippingFeeDiscount3pl { get; set; }
}