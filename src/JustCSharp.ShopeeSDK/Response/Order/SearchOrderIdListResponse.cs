using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace JustCSharp.ShopeeSDK.Response.Order;

public class SearchOrderIdListResponse : ShopeeResponseBase<OrderIdListResponse>
{
    
}

public class OrderIdListResponse
{
    [JsonPropertyName("index_list")]
    public List<IndexListResponse> IndexList { get; set; }

    [JsonPropertyName("pagination")]
    public PaginationResponse Pagination { get; set; }
    
    [JsonPropertyName("search_notice_info")]
    public SearchNoticeInfoResponse SearchNoticeInfo { get; set; }
    
    public class IndexListResponse
    {
        [JsonPropertyName("order_id")]
        public long OrderId { get; set; }

        [JsonPropertyName("shop_id")]
        public long ShopId { get; set; }

        [JsonPropertyName("region_id")]
        public string RegionId { get; set; }
    }
    
    public class PaginationResponse
    {
        [JsonPropertyName("total")]
        public int Total { get; set; }

        [JsonPropertyName("page_number")]
        public int PageNumber { get; set; }

        [JsonPropertyName("page_size")]
        public int PageSize { get; set; }

        [JsonPropertyName("next_page_sentinel")]
        public string NextPageSentinel { get; set; }

        [JsonPropertyName("previous_page_sentinel")]
        public string PreviousPageSentinel { get; set; }
    }
    
    public class SearchNoticeInfoResponse
    {
        [JsonPropertyName("search_notice_value")]
        public string SearchNoticeValue { get; set; }

        [JsonPropertyName("search_notice_timestamp_list")]
        public List<SearchNoticeTimestampResponse> SearchNoticeTimestampList { get; set; }
    }

    public class SearchNoticeTimestampResponse
    {
        [JsonPropertyName("timestamp")]
        public int Timestamp { get; set; }

        [JsonPropertyName("placeholder")]
        public string Placeholder { get; set; }
    }
}