using System.Text.Json.Serialization;
using JustCSharp.ShopeeSDK.Attributes;
using JustCSharp.ShopeeSDK.Response.Order;
using RestSharp;

namespace JustCSharp.ShopeeSDK.Request.Order;

public class SearchOrderIdListRequest : ShopeeRequestBase<SearchOrderIdListResponse>
{
    public override string ApiUrl => "order/search_order_list_index";

    public override Method Method => Method.Post;

    [QueryIgnore]
    [JsonPropertyName("order_list_tab")]
    public int OrderListTab { get; set; } = OrderListTabs.All;

    [QueryIgnore]
    [JsonPropertyName("entity_type")]
    public int EntityType { get; set; } = EntityTypes.Order;

    [QueryIgnore]
    [JsonPropertyName("filter")]
    public FilterRequest Filter { get; set; }

    [QueryIgnore]
    [JsonPropertyName("pagination")]
    public PaginationRequest Pagination { get; set; }

    [QueryIgnore]
    [JsonPropertyName("sort")]
    public SortRequest Sort { get; set; }
    
    public class SortRequest
    {
        [JsonPropertyName("sort_type")]
        public int SortType { get; set; } = SortTypes.CreateTime;

        [JsonPropertyName("ascending")]
        public bool Ascending { get; set; }
        
        public static class SortTypes
        {
            public const int OrderConfirmDate = 1;
            public const int ShipByDate = 2;
            public const int CreateTime = 3;
            public const int PickupTime = 4;
            public const int ItemId = 5;
        }
    }
    
    public class PaginationRequest
    {
        [JsonPropertyName("from_page_number")]
        public int FromPageNumber { get; set; } = 1;

        [JsonPropertyName("page_number")]
        public int PageNumber { get; set; }

        [JsonPropertyName("page_size")]
        public int PageSize { get; set; }
        
        [JsonPropertyName("page_sentinel")]
        public string PageSentinel { get; set; }
    }
    
    public class FilterRequest
    {
        [JsonPropertyName("fulfillment_type")]
        public int FulfillmentType { get; set; }

        [JsonPropertyName("is_drop_off")]
        public int IsDropOff { get; set; }
        
        [JsonPropertyName("prescription_filter")]
        public int PrescriptionFilter { get; set; }

        [JsonPropertyName("fulfillment_source")]
        public int FulfillmentSource { get; set; }
        
        public static class FulfillmentTypes
        {
            public const int Default = 0;
        }
    }
    
    public static class EntityTypes
    {
        public const int Order = 1;
    }

    public static class OrderListTabs
    {
        public const int All = 100;
        public const int WaitingConfirm = 200;
        public const int WaitingForPackage = 301;
        public const int WaitingForPackageToProcess = 302;
        public const int WaitingForPackageProcessed = 303;
        public const int WaitingForPackagePending = 304;
        public const int Shipping = 400;
        public const int Completed = 500;
        public const int Cancelled = 601;
        public const int CancellingWaitingResponse = 602;
        public const int CancelledDone = 603;
        public const int ShippedFailed = 701;
        public const int Returning = 702;
        public const int Returned = 703;
        public const int ReturnFailed = 704;
        public const int LostPackage = 705;
    }
}