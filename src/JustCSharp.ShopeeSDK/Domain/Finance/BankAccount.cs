using System.Text.Json.Serialization;

namespace JustCSharp.ShopeeSDK.Domain.Finance;

public class BankAccount
{
    [JsonPropertyName("status")]
    public int Status { get; set; }

    [JsonPropertyName("bank_name")]
    public string BankName { get; set; }

    [JsonPropertyName("extra_data")]
    public string ExtraData { get; set; }

    [JsonPropertyName("account_type")]
    public int AccountType { get; set; }

    [JsonPropertyName("logo")]
    public string Logo { get; set; }

    [JsonPropertyName("icon_url")]
    public string IconUrl { get; set; }

    [JsonPropertyName("company_id")]
    public string CompanyId { get; set; }

    [JsonPropertyName("bank_account_id")]
    public int BankAccountId { get; set; }

    [JsonPropertyName("currency")]
    public string Currency { get; set; }

    [JsonPropertyName("account_number")]
    public string AccountNumber { get; set; }

    [JsonPropertyName("mtime")]
    public int Mtime { get; set; }

    [JsonPropertyName("ic_number")]
    public string IcNumber { get; set; }

    [JsonPropertyName("logo_url")]
    public string LogoUrl { get; set; }

    [JsonPropertyName("bank_name_id")]
    public int BankNameId { get; set; }

    [JsonPropertyName("account_name")]
    public string AccountName { get; set; }

    [JsonPropertyName("icon")]
    public string Icon { get; set; }
}