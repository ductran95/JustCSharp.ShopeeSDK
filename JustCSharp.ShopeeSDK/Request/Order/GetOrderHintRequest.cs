using System.Text.Json.Serialization;
using JustCSharp.ShopeeSDK.Attributes;
using JustCSharp.ShopeeSDK.Response.Order;
using RestSharp;

namespace JustCSharp.ShopeeSDK.Request.Order;

public class GetOrderHintRequest : ShopeeRequestBase<GetOrderHintResponse>
{
    public override string ApiUrl => "order/get_order_hint";

    public override Method Method => Method.GET;

    [JsonIgnore]
    [QueryPropertyName("keyword")]
    public string Keyword { get; set; }
}