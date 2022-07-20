using System.Text.Json.Serialization;
using JustCSharp.ShopeeSDK.Attributes;
using JustCSharp.ShopeeSDK.Response.Finance;
using RestSharp;

namespace JustCSharp.ShopeeSDK.Request.Finance;

public class GetOneOrderRequest : ShopeeRequestBase<GetOneOrderResponse>
{
    public override string ApiUrl => "finance/get_one_order";

    public override Method Method => Method.Get;

    [JsonIgnore]
    [QueryPropertyName("order_id")]
    public long OrderId { get; set; }
}