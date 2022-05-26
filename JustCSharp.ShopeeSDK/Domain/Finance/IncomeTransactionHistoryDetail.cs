using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace JustCSharp.ShopeeSDK.Domain.Finance;

public class IncomeTransactionHistoryDetail
{
    [JsonPropertyName("status")]
    public int Status { get; set; }

    [JsonPropertyName("ctime")]
    public long Ctime { get; set; }

    [JsonPropertyName("payment_info")]
    public PaymentInfo PaymentInfo { get; set; }

    [JsonPropertyName("order_id")]
    public long OrderId { get; set; }

    [JsonPropertyName("is_cb_sip_a_shop")]
    public bool IsCbSipAShop { get; set; }

    [JsonPropertyName("buyer_payment_info")]
    public BuyerPaymentInfo BuyerPaymentInfo { get; set; }

    [JsonPropertyName("payout_amount")]
    public long PayoutAmount { get; set; }

    [JsonPropertyName("seller_absorbed_discount")]
    public double SellerAbsorbedDiscount { get; set; }

    [JsonPropertyName("shipping_carrier")]
    public string ShippingCarrier { get; set; }

    [JsonPropertyName("source")]
    public object Source { get; set; }

    [JsonPropertyName("amount")]
    public double Amount { get; set; }

    [JsonPropertyName("pri_currency_region")]
    public string PriCurrencyRegion { get; set; }

    [JsonPropertyName("exchange_rate")]
    public int ExchangeRate { get; set; }

    [JsonPropertyName("release_time")]
    public long ReleaseTime { get; set; }

    [JsonPropertyName("price_before_discount")]
    public double PriceBeforeDiscount { get; set; }

    [JsonPropertyName("order_logs")]
    public List<OrderLog> OrderLogs { get; set; }

    [JsonPropertyName("using_wallet")]
    public bool UsingWallet { get; set; }

    [JsonPropertyName("id")]
    public long Id { get; set; }

    [JsonPropertyName("rebate_price")]
    public double RebatePrice { get; set; }
}