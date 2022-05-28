using System.Collections.Generic;
using System.Text.Json.Serialization;
using JustCSharp.ShopeeSDK.Attributes;
using JustCSharp.ShopeeSDK.Domain.Order;
using JustCSharp.ShopeeSDK.Response.Order;
using RestSharp;

namespace JustCSharp.ShopeeSDK.Request.Order;

public class GetOrderListByOrderIdsRequest : ShopeeRequestBase<GetOrderListByOrderIdsResponse>
{
    public override string ApiUrl => "order/get_order_list_by_order_ids_multi_shop";

    public override Method Method => Method.POST;

    [QueryIgnore]
    [JsonPropertyName("from_seller_data")]
    public bool FromSellerData { get; set; }

    [QueryIgnore]
    [JsonPropertyName("orders")]
    public List<OrderIdData> Orders { get; set; }
}