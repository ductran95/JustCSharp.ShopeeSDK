using System.Text.Json.Serialization;

namespace JustCSharp.ShopeeSDK.Domain.Finance;

public class PaymentInfo
{
    [JsonPropertyName("shipping_subtotal")]
    public ShippingSubtotal ShippingSubtotal { get; set; }

    [JsonPropertyName("rebate_and_voucher")]
    public RebateAndVoucher RebateAndVoucher { get; set; }

    [JsonPropertyName("fees_and_charges")]
    public FeesAndCharges FeesAndCharges { get; set; }

    [JsonPropertyName("buyer_paid_tax_amount")]
    public double BuyerPaidTaxAmount { get; set; }

    [JsonPropertyName("merchant_subtotal")]
    public MerchantSubtotal MerchantSubtotal { get; set; }
}