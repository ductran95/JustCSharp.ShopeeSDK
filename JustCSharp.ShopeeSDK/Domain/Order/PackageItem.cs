using System.Text.Json.Serialization;

namespace JustCSharp.ShopeeSDK.Domain.Order;

public class PackageItem
{
    [JsonPropertyName("item_id")]
    public long ItemId { get; set; }

    [JsonPropertyName("model_id")]
    public long ModelId { get; set; }

    [JsonPropertyName("item_price")]
    public long ItemPrice { get; set; }

    [JsonPropertyName("quantity")]
    public long Quantity { get; set; }

    [JsonPropertyName("virtual_item_id")]
    public long VirtualItemId { get; set; }

    [JsonPropertyName("order_item_id")]
    public long OrderItemId { get; set; }

    [JsonPropertyName("virtual_model_id")]
    public long VirtualModelId { get; set; }

    [JsonPropertyName("group_id")]
    public long GroupId { get; set; }
}