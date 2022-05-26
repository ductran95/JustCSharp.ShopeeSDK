using System.Text.Json.Serialization;
using JustCSharp.ShopeeSDK.Attributes;
using JustCSharp.ShopeeSDK.Response.Order;
using RestSharp;

namespace JustCSharp.ShopeeSDK.Request.Order;

public class GetPackageListRequest : ShopeeRequestBase<GetPackageListResponse>
{
    public override string ApiUrl => "order/get_package_list";

    public override Method Method => Method.GET;

    [JsonIgnore]
    [QueryPropertyName("page_number")]
    public int PageNumber { get; set; }

    [JsonIgnore]
    [QueryPropertyName("page_size")]
    public int PageSize { get; set; }

    [JsonIgnore]
    [QueryPropertyName("total")]
    public int Total { get; set; }

    [JsonIgnore]
    [QueryPropertyName("sort_by")]
    public string SortBy { get; set; }

    [JsonIgnore]
    [QueryPropertyName("source")]
    public string Source { get; set; }
}