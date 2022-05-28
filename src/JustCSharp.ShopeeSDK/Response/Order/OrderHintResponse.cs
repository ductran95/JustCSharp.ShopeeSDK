using System.Collections.Generic;
using System.Text.Json.Serialization;
using JustCSharp.ShopeeSDK.Domain.Order;

namespace JustCSharp.ShopeeSDK.Response.Order;

public class OrderHintResponse
{
    [JsonPropertyName("orders")]
    public List<OrderData> Orders { get; set; }

    [JsonPropertyName("products")]
    public object Products { get; set; }

    [JsonPropertyName("users")]
    public object Users { get; set; }
}