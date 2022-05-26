using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace JustCSharp.ShopeeSDK.Response;

public class ShopeePagingResponse<T> where T : class
{
    [JsonPropertyName("page_info")]
    public ShopeePagingInfoResponse PageInfo { get; set; }

    [JsonPropertyName("list")]
    public List<T> List { get; set; }
}

public class ShopeePagingInfoResponse
{
    [JsonPropertyName("total")]
    public int Total { get; set; }

    [JsonPropertyName("page_number")]
    public int PageNumber { get; set; }

    [JsonPropertyName("page_size")]
    public int PageSize { get; set; }
}