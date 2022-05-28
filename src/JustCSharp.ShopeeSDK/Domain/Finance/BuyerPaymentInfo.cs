using System.Text.Json.Serialization;

namespace JustCSharp.ShopeeSDK.Domain.Finance;

public class BuyerPaymentInfo
{
    [JsonPropertyName("pay_by_credit_card")]
    public bool PayByCreditCard { get; set; }

    [JsonPropertyName("shopee_voucher")]
    public double ShopeeVoucher { get; set; }

    [JsonPropertyName("credit_card_promotion")]
    public double CreditCardPromotion { get; set; }

    [JsonPropertyName("seller_voucher")]
    public double SellerVoucher { get; set; }

    [JsonPropertyName("shopee_coins_redeemed")]
    public double ShopeeCoinsRedeemed { get; set; }

    [JsonPropertyName("import_tax")]
    public double ImportTax { get; set; }

    [JsonPropertyName("shipping_fee")]
    public double ShippingFee { get; set; }

    [JsonPropertyName("coin_used")]
    public long CoinUsed { get; set; }

    [JsonPropertyName("merchant_subtotal")]
    public double MerchantSubtotal { get; set; }
}