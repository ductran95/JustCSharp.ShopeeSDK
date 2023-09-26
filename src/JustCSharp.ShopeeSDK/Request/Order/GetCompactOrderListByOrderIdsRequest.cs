using System.Collections.Generic;
using System.Text.Json.Serialization;
using JustCSharp.ShopeeSDK.Attributes;
using JustCSharp.ShopeeSDK.Domain.Order;
using JustCSharp.ShopeeSDK.Response.Order;
using RestSharp;

namespace JustCSharp.ShopeeSDK.Request.Order;

public class GetCompactOrderListByOrderIdsRequest : ShopeeRequestBase<GetOrderListByOrderIdsResponse>
{
    public override string ApiUrl => "order/get_compact_order_list_by_order_ids_multi_shop";

    public override Method Method => Method.Post;

    [QueryIgnore]
    [JsonPropertyName("need_invoice_status")]
    public int NeedInvoiceStatus { get; set; }

    [QueryIgnore]
    [JsonPropertyName("orders")]
    public List<OrderIdData> Orders { get; set; }
}