using System;
using System.Text.Json.Serialization;
using JustCSharp.ShopeeSDK.Attributes;
using JustCSharp.ShopeeSDK.Response.Finance;
using RestSharp;

namespace JustCSharp.ShopeeSDK.Request.Finance;

public class GetWalletTransactionsRequest : ShopeeRequestBase<GetWalletTransactionsResponse>
{
    public override string ApiUrl => "finance/get_wallet_transactions";

    public override Method Method => Method.Get;

    [JsonIgnore]
    [QueryPropertyName("wallet_type")]
    public int WalletType { get; set; }

    [JsonIgnore]
    [QueryPropertyName("page_number")]
    public int PageNumber { get; set; }

    [JsonIgnore]
    [QueryPropertyName("page_size")]
    public int PageSize { get; set; }

    [JsonIgnore]
    [QueryPropertyName("start_date")]
    public DateTime? StartDate { get; set; }

    [JsonIgnore]
    [QueryPropertyName("end_date")]
    public DateTime? EndDate { get; set; }

    [JsonIgnore]
    [QueryPropertyName("transaction_types")]
    public string TransactionTypes { get; set; }
}