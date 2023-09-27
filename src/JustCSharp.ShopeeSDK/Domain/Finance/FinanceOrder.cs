using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace JustCSharp.ShopeeSDK.Domain.Finance;

public class FinanceOrder
{
    [JsonPropertyName("status_ext")]
    public int StatusExt { get; set; }

    [JsonPropertyName("shipping_method")]
    public int ShippingMethod { get; set; }

    [JsonPropertyName("order_id")]
    public long OrderId { get; set; }

    [JsonPropertyName("return_id")]
    public long  ReturnId { get; set; }

    [JsonPropertyName("order_item_price_infos")]
    public object OrderItemPriceInfos { get; set; }

    [JsonPropertyName("order_items")]
    public List<OrderItem> OrderItems { get; set; }

    [JsonPropertyName("order_chargeable_weight")]
    public long  OrderChargeableWeight { get; set; }

    [JsonPropertyName("shop_id")]
    public long  ShopId { get; set; }

    [JsonPropertyName("is_affiliated_shop_order")]
    public bool IsAffiliatedShopOrder { get; set; }

    [JsonPropertyName("list_type")]
    public int ListType { get; set; }

    [JsonPropertyName("order_sn")]
    public string OrderSn { get; set; }

    [JsonPropertyName("voucher_code")]
    public string VoucherCode { get; set; }

    [JsonPropertyName("buyer_user")]
    public FinanceBuyerUser BuyerUser { get; set; }

    [JsonPropertyName("order_unit_migration_toggle")]
    public int OrderUnitMigrationToggle { get; set; }

    public class FinanceBuyerUser
    {
        [JsonPropertyName("user_name")]
        public string UserName { get; set; }
    }

    public class ItemModel
    {
        [JsonPropertyName("item_id")]
        public long ItemId { get; set; }

        [JsonPropertyName("model_id")]
        public long ModelId { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("sku")]
        public string Sku { get; set; }
    }

    public class OrderItem
    {
        [JsonPropertyName("is_add_on_sub_item")]
        public bool IsAddOnSubItem { get; set; }

        [JsonPropertyName("bundle_deal_product")]
        public List<object> BundleDealProduct { get; set; }

        [JsonPropertyName("model_id")]
        public long ModelId { get; set; }

        [JsonPropertyName("item_id")]
        public long ItemId { get; set; }

        [JsonPropertyName("cancellation_tag_qty")]
        public long  CancellationTagQty { get; set; }

        [JsonPropertyName("add_on_deal_id")]
        public long  AddOnDealId { get; set; }

        [JsonPropertyName("line_item_id")]
        public long  LineItemId { get; set; }

        [JsonPropertyName("index")]
        public long  Index { get; set; }

        [JsonPropertyName("rr_tag_qty")]
        public long  RrTagQty { get; set; }

        [JsonPropertyName("comm_fee_rate")]
        public long  CommFeeRate { get; set; }

        [JsonPropertyName("item_model")]
        public ItemModel ItemModel { get; set; }

        [JsonPropertyName("is_delivery_insured")]
        public bool IsDeliveryInsured { get; set; }

        [JsonPropertyName("status")]
        public int Status { get; set; }

        [JsonPropertyName("bundle_deal_id")]
        public long BundleDealId { get; set; }

        [JsonPropertyName("product")]
        public Product Product { get; set; }

        [JsonPropertyName("item_list")]
        public List<object> ItemList { get; set; }

        [JsonPropertyName("campaign_fee_rate")]
        public decimal CampaignFeeRate { get; set; }

        [JsonPropertyName("show_cancellation_tag")]
        public bool ShowCancellationTag { get; set; }

        [JsonPropertyName("show_rr_tag")]
        public bool ShowRrTag { get; set; }

        [JsonPropertyName("sub_type")]
        public int SubType { get; set; }

        [JsonPropertyName("bundle_deal_model")]
        public List<object> BundleDealModel { get; set; }

        [JsonPropertyName("order_item_id")]
        public long OrderItemId { get; set; }

        [JsonPropertyName("base_sku_items")]
        public object BaseSkuItems { get; set; }

        [JsonPropertyName("bundle_deal")]
        public object BundleDeal { get; set; }

        [JsonPropertyName("amount")]
        public long Amount { get; set; }

        [JsonPropertyName("order_price")]
        public string OrderPrice { get; set; }

        [JsonPropertyName("group_id")]
        public string GroupId { get; set; }
    }

    public class Product
    {
        [JsonPropertyName("sku")]
        public string Sku { get; set; }

        [JsonPropertyName("model_id")]
        public long ModelId { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("item_id")]
        public long ItemId { get; set; }

        [JsonPropertyName("is_pre_order")]
        public bool IsPreOrder { get; set; }

        [JsonPropertyName("images")]
        public List<string> Images { get; set; }
    }
}