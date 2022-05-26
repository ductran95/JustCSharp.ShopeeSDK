using System.Text.Json.Serialization;

namespace JustCSharp.ShopeeSDK.Domain.Finance;

public class BankAccount
{
    [JsonPropertyName("status")]
    public long Status { get; set; }

    [JsonPropertyName("bank_name")]
    public string BankName { get; set; }

    [JsonPropertyName("account_type")]
    public long AccountType { get; set; }

    [JsonPropertyName("company_id")]
    public string CompanyId { get; set; }

    [JsonPropertyName("bank_account_id")]
    public long BankAccountId { get; set; }

    [JsonPropertyName("currency")]
    public string Currency { get; set; }

    [JsonPropertyName("account_number")]
    public string AccountNumber { get; set; }

    [JsonPropertyName("mtime")]
    public long Mtime { get; set; }

    [JsonPropertyName("ic_number")]
    public string IcNumber { get; set; }

    [JsonPropertyName("bank_name_id")]
    public long BankNameId { get; set; }

    [JsonPropertyName("account_name")]
    public string AccountName { get; set; }
}