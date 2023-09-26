using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace JustCSharp.ShopeeSDK.Domain.Order;

public class OrderIdData
{
    [JsonPropertyName("order_id")]
    public object OrderId { get; set; }

    [JsonPropertyName("shop_id")]
    public int ShopId { get; set; }

    [JsonPropertyName("region_id")]
    public string RegionId { get; set; }
}

