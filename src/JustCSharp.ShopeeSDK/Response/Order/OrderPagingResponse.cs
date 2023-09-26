using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace JustCSharp.ShopeeSDK.Response.Order;

public class OrderPagingResponse<T> where T : class
{
    [JsonPropertyName("from_seller_data")]
    public bool FromSellerData { get; set; }
    
    [JsonPropertyName("orders")]
    public List<T> Orders { get; set; }
    
    [JsonPropertyName("page_info")]
    public ShopeePagingInfoResponse PageInfo { get; set; }
}