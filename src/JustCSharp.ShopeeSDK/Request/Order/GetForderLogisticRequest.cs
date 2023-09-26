using System.Text.Json.Serialization;
using JustCSharp.ShopeeSDK.Attributes;
using JustCSharp.ShopeeSDK.Response.Order;
using RestSharp;

namespace JustCSharp.ShopeeSDK.Request.Order;

public class GetForderLogisticRequest : ShopeeRequestBase<GetForderLogisticResponse>
{
    public override string ApiUrl => "order/get_forder_logistics";

    public override Method Method => Method.Get;

    [JsonIgnore]
    [QueryPropertyName("order_id")]
    public long OrderId { get; set; }
}