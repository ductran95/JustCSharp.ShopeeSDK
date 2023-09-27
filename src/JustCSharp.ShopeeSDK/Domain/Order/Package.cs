using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace JustCSharp.ShopeeSDK.Domain.Order;

public class Package
{
    [JsonPropertyName("order_info")]
    public PackageOrderInfo OrderInfo { get; set; }

    public class Item
    {
        [JsonPropertyName("group_id")]
        public string GroupId { get; set; }

        [JsonPropertyName("model_id")]
        public long ModelId { get; set; }

        [JsonPropertyName("order_item_id")]
        public long OrderItemId { get; set; }

        [JsonPropertyName("virtual_item_id")]
        public long VirtualItemId { get; set; }

        [JsonPropertyName("virtual_model_id")]
        public long VirtualModelId { get; set; }

        [JsonPropertyName("line_item_id")]
        public string LineItemId { get; set; }

        [JsonPropertyName("index")]
        public int Index { get; set; }

        [JsonPropertyName("show_rr_tag")]
        public bool ShowRrTag { get; set; }

        [JsonPropertyName("rr_tag_qty")]
        public int RrTagQty { get; set; }

        [JsonPropertyName("show_cancellation_tag")]
        public bool ShowCancellationTag { get; set; }

        [JsonPropertyName("cancellation_tag_qty")]
        public int CancellationTagQty { get; set; }

        [JsonPropertyName("is_prescription_item")]
        public bool IsPrescriptionItem { get; set; }
    }

    public class OrderAction
    {
        [JsonPropertyName("can_split")]
        public int CanSplit { get; set; }

        [JsonPropertyName("can_unsplit")]
        public int CanUnsplit { get; set; }
    }

    public class PackageOrderInfo
    {
        [JsonPropertyName("order_id")]
        public long OrderId { get; set; }

        [JsonPropertyName("split_up")]
        public int SplitUp { get; set; }

        [JsonPropertyName("package_list")]
        public List<PackageList> PackageList { get; set; }

        [JsonPropertyName("order_action")]
        public OrderAction OrderAction { get; set; }
    }

    public class PackageList
    {
        [JsonPropertyName("package_number")]
        public string PackageNumber { get; set; }

        [JsonPropertyName("parcel_no")]
        public int ParcelNo { get; set; }

        [JsonPropertyName("channel_id")]
        public long ChannelId { get; set; }

        [JsonPropertyName("items")]
        public List<Item> Items { get; set; }

        [JsonPropertyName("seller_remark")]
        public string SellerRemark { get; set; }

        [JsonPropertyName("status")]
        public int Status { get; set; }

        [JsonPropertyName("total_price")]
        public long TotalPrice { get; set; }

        [JsonPropertyName("allocating_status")]
        public int AllocatingStatus { get; set; }

        [JsonPropertyName("auto_cancel_layer2")]
        public int AutoCancelLayer2 { get; set; }

        [JsonPropertyName("consignment_no")]
        public string ConsignmentNo { get; set; }

        [JsonPropertyName("first_mile_tn")]
        public string FirstMileTn { get; set; }

        [JsonPropertyName("logistics_flag")]
        public int LogisticsFlag { get; set; }

        [JsonPropertyName("package_logistics_status")]
        public int PackageLogisticsStatus { get; set; }

        [JsonPropertyName("plp_number")]
        public string PlpNumber { get; set; }

        [JsonPropertyName("shipping_method")]
        public int ShippingMethod { get; set; }

        [JsonPropertyName("shipping_status")]
        public int ShippingStatus { get; set; }

        [JsonPropertyName("third_party_tn")]
        public string ThirdPartyTn { get; set; }

        [JsonPropertyName("tracking_info")]
        public List<TrackingInfo> TrackingInfo { get; set; }

        [JsonPropertyName("checkout_carrier_name")]
        public string CheckoutCarrierName { get; set; }

        [JsonPropertyName("checkout_channel_id")]
        public long CheckoutChannelId { get; set; }

        [JsonPropertyName("fulfillment_channel_id")]
        public long FulfillmentChannelId { get; set; }

        [JsonPropertyName("fulfillment_carrier_name")]
        public string FulfillmentCarrierName { get; set; }

        [JsonPropertyName("fulfillment_shipping_method")]
        public int FulfillmentShippingMethod { get; set; }

        [JsonPropertyName("is_prescription_order")]
        public bool IsPrescriptionOrder { get; set; }

        [JsonPropertyName("prescription_check_status")]
        public int PrescriptionCheckStatus { get; set; }

        [JsonPropertyName("prescription_images")]
        public object PrescriptionImages { get; set; }

        [JsonPropertyName("code")]
        public int Code { get; set; }

        [JsonPropertyName("transify_key")]
        public string TransifyKey { get; set; }
    }

    public class TrackingInfo
    {
        [JsonPropertyName("id")]
        public long Id { get; set; }

        [JsonPropertyName("ctime")]
        public long Ctime { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("flag")]
        public int Flag { get; set; }

        [JsonPropertyName("logid")]
        public long Logid { get; set; }
    }
}