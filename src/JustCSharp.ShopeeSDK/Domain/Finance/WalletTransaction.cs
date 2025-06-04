using System.Text.Json.Serialization;

namespace JustCSharp.ShopeeSDK.Domain.Finance;

public class WalletTransaction
{
    [JsonPropertyName("status")]
    public int Status { get; set; }

    [JsonPropertyName("money_flow")]
    public int MoneyFlow { get; set; }

    [JsonPropertyName("order_sn")]
    public string OrderSn { get; set; }

    [JsonPropertyName("order_id")]
    public string OrderId { get; set; }

    [JsonPropertyName("created_at")]
    public long CreatedAt { get; set; }

    [JsonPropertyName("target_id")]
    public string TargetId { get; set; }

    [JsonPropertyName("request_type")]
    public int RequestType { get; set; }

    [JsonPropertyName("transaction_type")]
    public int TransactionType { get; set; }

    [JsonPropertyName("amount")]
    public double Amount { get; set; }

    [JsonPropertyName("request_id")]
    public string RequestId { get; set; }

    [JsonPropertyName("reason")]
    public string Reason { get; set; }

    [JsonPropertyName("user_id")]
    public string UserId { get; set; }

    [JsonPropertyName("refund_sn")]
    public string RefundSn { get; set; }

    [JsonPropertyName("user_name")]
    public string UserName { get; set; }

    [JsonPropertyName("product_name")]
    public string ProductName { get; set; }

    [JsonPropertyName("transaction_id")]
    public string TransactionId { get; set; }

    [JsonPropertyName("action_id")]
    public string ActionId { get; set; }

    [JsonPropertyName("target_type")]
    public int? TargetType { get; set; }

    [JsonPropertyName("source")]
    public int? Source { get; set; }

    [JsonPropertyName("bank_details")]
    public BankDetails BankDetails { get; set; }

    [JsonPropertyName("withdrawal_type")]
    public int? WithdrawalType { get; set; }
}

public class BankDetails
{
    [JsonPropertyName("bank_name")]
    public string BankName { get; set; }

    [JsonPropertyName("bank_account_status")]
    public int BankAccountStatus { get; set; }

    [JsonPropertyName("bank_account_id")]
    public int BankAccountId { get; set; }

    [JsonPropertyName("bank_account_type")]
    public int BankAccountType { get; set; }

    [JsonPropertyName("bank_account_name")]
    public string BankAccountName { get; set; }

    [JsonPropertyName("card_type")]
    public int CardType { get; set; }

    [JsonPropertyName("bank_name_id")]
    public int BankNameId { get; set; }

    [JsonPropertyName("bank_account_number")]
    public string BankAccountNumber { get; set; }
}