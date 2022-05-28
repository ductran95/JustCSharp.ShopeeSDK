using System.Collections.Generic;
using System.Text.Json.Serialization;
using JustCSharp.ShopeeSDK.Domain.Common;

namespace JustCSharp.ShopeeSDK.Domain.Order;

public class OrderItem
{
    [JsonPropertyName("add_on_deal_id")]
    public long AddOnDealId { get; set; }

    [JsonPropertyName("amount")]
    public int Amount { get; set; }

    [JsonPropertyName("bundle_deal_id")]
    public long BundleDealId { get; set; }

    [JsonPropertyName("group_id")]
    public string GroupId { get; set; }

    [JsonPropertyName("is_add_on_sub_item")]
    public bool IsAddOnSubItem { get; set; }

    [JsonPropertyName("is_wholesale")]
    public bool IsWholesale { get; set; }

    [JsonPropertyName("item_price")]
    public string ItemPrice { get; set; }

    [JsonPropertyName("item_id")]
    public long ItemId { get; set; }

    [JsonPropertyName("model_id")]
    public long ModelId { get; set; }

    [JsonPropertyName("order_price")]
    public string OrderPrice { get; set; }

    [JsonPropertyName("price_before_bundle")]
    public string PriceBeforeBundle { get; set; }

    [JsonPropertyName("snapshot_id")]
    public long SnapshotId { get; set; }

    [JsonPropertyName("status")]
    public long Status { get; set; }

    [JsonPropertyName("shop_id")]
    public long ShopId { get; set; }

    [JsonPropertyName("order_item_id")]
    public long OrderItemId { get; set; }

    [JsonPropertyName("is_virtual_sku")]
    public bool IsVirtualSku { get; set; }

    [JsonPropertyName("comm_fee_rate")]
    public string CommFeeRate { get; set; }

    [JsonPropertyName("bundle_deal")]
    public BundleDeal BundleDeal { get; set; }

    [JsonPropertyName("item_model")]
    public OrderItemModel ItemModel { get; set; }

    [JsonPropertyName("bundle_deal_model")]
    public List<BundleDealModel> BundleDealModel { get; set; }

    [JsonPropertyName("item_list")]
    public List<OrderItemSubModel> ItemList { get; set; }

    [JsonPropertyName("product")]
    public Product Product { get; set; }

    [JsonPropertyName("bundle_deal_product")]
    public List<BundleDealProduct> BundleDealProduct { get; set; }

    [JsonPropertyName("sub_type")]
    public long SubType { get; set; }
}