using System.Text.Json.Serialization;

namespace JustCSharp.ShopeeSDK.Domain.Common;

public class CardTxnFeeInfo
{
    [JsonPropertyName("card_txn_fee")]
    public string CardTxnFee { get; set; }

    [JsonPropertyName("rule_id")]
    public long RuleId { get; set; }
}