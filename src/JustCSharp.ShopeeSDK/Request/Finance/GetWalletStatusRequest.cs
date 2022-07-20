using System.Text.Json.Serialization;
using JustCSharp.ShopeeSDK.Attributes;
using JustCSharp.ShopeeSDK.Response.Finance;
using RestSharp;

namespace JustCSharp.ShopeeSDK.Request.Finance;

public class GetWalletStatusRequest : ShopeeRequestBase<GetWalletStatusResponse>
{
    public override string ApiUrl => "finance/get_wallet_status";

    public override Method Method => Method.Get;

    [JsonIgnore]
    [QueryPropertyName("wallet_type")]
    public int WalletType { get; set; }

    [JsonIgnore]
    [QueryPropertyName("bank_account_id")]
    public long BankAccountId { get; set; }
}