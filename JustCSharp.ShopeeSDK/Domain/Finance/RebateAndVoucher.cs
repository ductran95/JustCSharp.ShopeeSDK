using System.Text.Json.Serialization;

namespace JustCSharp.ShopeeSDK.Domain.Finance;

public class RebateAndVoucher
{
    [JsonPropertyName("product_discount_rebate_from_shopee")]
    public double ProductDiscountRebateFromShopee { get; set; }

    [JsonPropertyName("voucher_code")]
    public double VoucherCode { get; set; }

    [JsonPropertyName("seller_absorbed_coin_cash_back")]
    public double SellerAbsorbedCoinCashBack { get; set; }

    [JsonPropertyName("estimated_shipping_rebate_from_shopee")]
    public double EstimatedShippingRebateFromShopee { get; set; }

    [JsonPropertyName("shipping_rebate_from_shopee")]
    public double ShippingRebateFromShopee { get; set; }
}