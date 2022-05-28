using System.Text.Json.Serialization;

namespace JustCSharp.ShopeeSDK.Domain.Order;

public class OrderItemSubModel
{
    [JsonPropertyName("item_id")]
    public long ItemId { get; set; }

    [JsonPropertyName("model_id")]
    public long ModelId { get; set; }

    [JsonPropertyName("amount")]
    public int Amount { get; set; }

    [JsonPropertyName("item_price")]
    public string ItemPrice { get; set; }

    [JsonPropertyName("snapshot_id")]
    public long SnapshotId { get; set; }

    [JsonPropertyName("is_virtual_sku")]
    public bool IsVirtualSku { get; set; }
}