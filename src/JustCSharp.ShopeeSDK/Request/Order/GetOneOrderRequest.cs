using System.Text.Json.Serialization;
using JustCSharp.ShopeeSDK.Attributes;
using JustCSharp.ShopeeSDK.Response.Order;
using RestSharp;

namespace JustCSharp.ShopeeSDK.Request.Order;

public class GetOneOrderRequest : ShopeeRequestBase<GetOneOrderResponse>
{
    public override string ApiUrl => "order/get_one_order";

    public override Method Method => Method.GET;

    [JsonIgnore]
    [QueryPropertyName("order_id")]
    public long OrderId { get; set; }
}