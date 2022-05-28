using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace JustCSharp.ShopeeSDK.Response.Order;

public class PackagePagingResponse<T> where T : class
{
    [JsonPropertyName("total")]
    public int Total { get; set; }

    [JsonPropertyName("page_number")]
    public int PageNumber { get; set; }

    [JsonPropertyName("page_size")]
    public int PageSize { get; set; }

    [JsonPropertyName("package_list")]
    public List<T> PackageList { get; set; }
}