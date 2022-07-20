using System.Text.Json.Serialization;
using JustCSharp.ShopeeSDK.Attributes;
using JustCSharp.ShopeeSDK.Response.Finance;
using RestSharp;

namespace JustCSharp.ShopeeSDK.Request.Finance;

public class GetIncomeTransactionHistoryDetailRequest : ShopeeRequestBase<GetIncomeTransactionHistoryDetailResponse>
{
    public override string ApiUrl => "finance/income_transaction_history_detail";

    public override Method Method => Method.Get;

    [JsonIgnore]
    [QueryPropertyName("order_id")]
    public long OrderId { get; set; }
}