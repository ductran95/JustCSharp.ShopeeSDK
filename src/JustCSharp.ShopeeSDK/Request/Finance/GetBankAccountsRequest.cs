using System.Text.Json.Serialization;
using JustCSharp.ShopeeSDK.Attributes;
using JustCSharp.ShopeeSDK.Response.Finance;
using RestSharp;

namespace JustCSharp.ShopeeSDK.Request.Finance;

public class GetBankAccountsRequest : ShopeeRequestBase<GetBankAccountsResponse>
{
    public override bool BothQueryAndBody => true;

    public override string ApiUrl => "finance/get_bank_accounts";

    public override Method Method => Method.POST;

    [JsonIgnore]
    [QueryPropertyName("page_number")]
    public int PageNumber { get; set; }

    [JsonIgnore]
    [QueryPropertyName("page_size")]
    public int PageSize { get; set; }

    [QueryIgnore]
    [JsonPropertyName("password_hash")]
    public string PasswordHash { get; set; }
}