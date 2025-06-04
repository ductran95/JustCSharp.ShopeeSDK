using System.Text.Json.Serialization;
using JustCSharp.ShopeeSDK.Attributes;
using JustCSharp.ShopeeSDK.Response.Finance;
using RestSharp;

namespace JustCSharp.ShopeeSDK.Request.Finance;

public class GetWalletStatusRequest : ShopeeRequestBase<GetWalletStatusResponse>
{
    public override string ApiUrl => "seller/local_wallet/get_wallet_status";
    public override int? ApiVersion => 4;

    public override Method Method => Method.Get;

    [JsonIgnore]
    [QueryPropertyName("wallet_provider")]
    public int WalletProvider { get; set; }

    [JsonIgnore]
    [QueryPropertyName("bank_account_id")]
    public long BankAccountId { get; set; }
}