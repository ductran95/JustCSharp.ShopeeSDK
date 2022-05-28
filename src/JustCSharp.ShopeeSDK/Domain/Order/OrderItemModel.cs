using System.Text.Json.Serialization;

namespace JustCSharp.ShopeeSDK.Domain.Order;

public class OrderItemModel
{
    [JsonPropertyName("model_id")]
    public object ModelId { get; set; }

    [JsonPropertyName("item_id")]
    public object ItemId { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("price")]
    public string Price { get; set; }

    [JsonPropertyName("currency")]
    public string Currency { get; set; }

    [JsonPropertyName("stock")]
    public long Stock { get; set; }

    [JsonPropertyName("status")]
    public long Status { get; set; }

    [JsonPropertyName("price_before_discount")]
    public string PriceBeforeDiscount { get; set; }

    [JsonPropertyName("promotion_id")]
    public long PromotionId { get; set; }

    [JsonPropertyName("rebate_price")]
    public string RebatePrice { get; set; }

    [JsonPropertyName("sold")]
    public long Sold { get; set; }

    [JsonPropertyName("ctime")]
    public long Ctime { get; set; }

    [JsonPropertyName("mtime")]
    public long Mtime { get; set; }

    [JsonPropertyName("sku")]
    public string Sku { get; set; }
}