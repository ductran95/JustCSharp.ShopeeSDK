using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace JustCSharp.ShopeeSDK.Response.Order;

public class OrderListingResponse<T> where T : class
{
    [JsonPropertyName("orders")]
    public List<T> Orders { get; set; }
}