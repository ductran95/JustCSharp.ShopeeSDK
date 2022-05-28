using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace JustCSharp.ShopeeSDK.Domain.Finance;

public class FeesAndCharges
{
    [JsonPropertyName("tcs_cgst_amount")]
    public double TcsCgstAmount { get; set; }

    [JsonPropertyName("credit_card_charge")]
    public double CreditCardCharge { get; set; }

    [JsonPropertyName("commission_fee")]
    public double CommissionFee { get; set; }

    [JsonPropertyName("service_fee_list")]
    public List<object> ServiceFeeList { get; set; }

    [JsonPropertyName("tds_amount")]
    public double TdsAmount { get; set; }

    [JsonPropertyName("tcs_sgst_amount")]
    public double TcsSgstAmount { get; set; }

    [JsonPropertyName("tcs_igst_amount")]
    public double TcsIgstAmount { get; set; }

    [JsonPropertyName("service_fee")]
    public double ServiceFee { get; set; }

    [JsonPropertyName("transaction_fee")]
    public double TransactionFee { get; set; }
}