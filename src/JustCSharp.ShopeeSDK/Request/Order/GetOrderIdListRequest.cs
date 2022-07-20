using System.Text.Json.Serialization;
using JustCSharp.ShopeeSDK.Attributes;
using JustCSharp.ShopeeSDK.Response.Order;
using RestSharp;

namespace JustCSharp.ShopeeSDK.Request.Order;

public class GetOrderIdListRequest : ShopeeRequestBase<GetOrderIdListResponse>
{
    public override string ApiUrl => "order/get_order_id_list";

    public override Method Method => Method.Get;

    [JsonIgnore]
    [QueryPropertyName("page_number")]
    public int PageNumber { get; set; }

    [JsonIgnore]
    [QueryPropertyName("page_size")]
    public int PageSize { get; set; }

    [JsonIgnore]
    [QueryPropertyName("from_page_number")]
    public int FromPageNumber { get; set; }

    [JsonIgnore]
    [QueryPropertyName("total")]
    public int Total { get; set; }

    [JsonIgnore]
    [QueryPropertyName("source")]
    public string Source { get; set; }

    [JsonIgnore]
    [QueryPropertyName("is_massship")]
    public bool IsMassship { get; set; }

    [JsonIgnore]
    [QueryPropertyName("flip_direction")]
    public string FlipDirection { get; set; } = "ahead";

    [JsonIgnore]
    [QueryPropertyName("page_sentinel")]
    public string PageSentinel { get; set; } = "0,0";

    [JsonIgnore]
    [QueryPropertyName("sort_by")]
    public string SortBy { get; set; }

    [JsonIgnore]
    [QueryPropertyName("backend_offset")]
    public string BackendOffset { get; set; }
}