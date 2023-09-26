using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace JustCSharp.ShopeeSDK.Domain.Order;

public class PackageData
{
    [JsonPropertyName("channel_id")]
    public int ChannelId { get; set; }

    [JsonPropertyName("consignment_no")]
    public string ConsignmentNo { get; set; }

    [JsonPropertyName("dropoff_b2c")]
    public int DropoffB2c { get; set; }

    [JsonPropertyName("expire_time")]
    public int ExpireTime { get; set; }

    [JsonPropertyName("extra_flag")]
    public int ExtraFlag { get; set; }

    [JsonPropertyName("first_mile_tn")]
    public string FirstMileTn { get; set; }

    [JsonPropertyName("logistics_flag")]
    public int LogisticsFlag { get; set; }

    [JsonPropertyName("pickup_time")]
    public int PickupTime { get; set; }

    [JsonPropertyName("ref1")]
    public string Ref1 { get; set; }

    [JsonPropertyName("seller_remark")]
    public string SellerRemark { get; set; }

    [JsonPropertyName("shipping_method")]
    public string ShippingMethod { get; set; }

    [JsonPropertyName("third_party_tn")]
    public string ThirdPartyTn { get; set; }

    [JsonPropertyName("checkout_carrier_name")]
    public string CheckoutCarrierName { get; set; }

    [JsonPropertyName("checkout_channel_id")]
    public int CheckoutChannelId { get; set; }

    [JsonPropertyName("package_number")]
    public string PackageNumber { get; set; }

    [JsonPropertyName("package_logistics_status")]
    public int PackageLogisticsStatus { get; set; }

    [JsonPropertyName("package_shipping_status")]
    public int PackageShippingStatus { get; set; }

    [JsonPropertyName("is_pickup")]
    public int IsPickup { get; set; }

    [JsonPropertyName("item_list")]
    public List<PackageItem> ItemList { get; set; }

    [JsonPropertyName("order_action")]
    public PackageOrderAction OrderAction { get; set; }

    [JsonPropertyName("order_id")]
    public object OrderId { get; set; }

    [JsonPropertyName("order_sn")]
    public string OrderSn { get; set; }

    [JsonPropertyName("parcel_no")]
    public int ParcelNo { get; set; }

    [JsonPropertyName("parcel_price")]
    public string ParcelPrice { get; set; }

    [JsonPropertyName("region_id")]
    public string RegionId { get; set; }

    [JsonPropertyName("ship_by_date")]
    public int ShipByDate { get; set; }

    [JsonPropertyName("shipping_confirm_time")]
    public int ShippingConfirmTime { get; set; }

    [JsonPropertyName("shop_id")]
    public int ShopId { get; set; }

    [JsonPropertyName("split_up")]
    public int SplitUp { get; set; }

    [JsonPropertyName("allocating_status")]
    public int AllocatingStatus { get; set; }

    [JsonPropertyName("tracking_info")]
    public PackageTrackingInfo TrackingInfo { get; set; }

    [JsonPropertyName("fulfillment_carrier_name")]
    public string FulfillmentCarrierName { get; set; }

    [JsonPropertyName("fulfillment_shipping_method")]
    public int FulfillmentShippingMethod { get; set; }

    [JsonPropertyName("fulfillment_channel_id")]
    public int FulfillmentChannelId { get; set; }

    [JsonPropertyName("preferred_delivery_timeslot")]
    public object PreferredDeliveryTimeslot { get; set; }

    [JsonPropertyName("is_affiliated_shop_order")]
    public bool IsAffiliatedShopOrder { get; set; }

    [JsonPropertyName("plp_number")]
    public string PlpNumber { get; set; }

    [JsonPropertyName("code")]
    public int Code { get; set; }

    [JsonPropertyName("transify_key")]
    public string TransifyKey { get; set; }

    [JsonPropertyName("rts_status")]
    public int RtsStatus { get; set; }

    [JsonPropertyName("is_prescription_order")]
    public bool IsPrescriptionOrder { get; set; }

    [JsonPropertyName("prescription_check_status")]
    public int PrescriptionCheckStatus { get; set; }

    [JsonPropertyName("prescription_images")]
    public object PrescriptionImages { get; set; }

    [JsonPropertyName("acl1_arrange_ship_date")]
    public int Acl1ArrangeShipDate { get; set; }

    [JsonPropertyName("acl2_ack_date_3pl")]
    public int Acl2AckDate3pl { get; set; }

    [JsonPropertyName("pre_authorization_status")]
    public object PreAuthorizationStatus { get; set; }

    [JsonPropertyName("order_create_time")]
    public int OrderCreateTime { get; set; }

    [JsonPropertyName("btn_info_list")]
    public object BtnInfoList { get; set; }

    public class PackageItem
    {
        [JsonPropertyName("item_id")]
        public object ItemId { get; set; }

        [JsonPropertyName("model_id")]
        public object ModelId { get; set; }

        [JsonPropertyName("order_item_id")]
        public object OrderItemId { get; set; }

        [JsonPropertyName("group_id")]
        public long GroupId { get; set; }

        [JsonPropertyName("line_item_id")]
        public string LineItemId { get; set; }

        [JsonPropertyName("index")]
        public int Index { get; set; }

        [JsonPropertyName("amount")]
        public int Amount { get; set; }

        [JsonPropertyName("virtual_item_id")]
        public int VirtualItemId { get; set; }

        [JsonPropertyName("virtual_model_id")]
        public int VirtualModelId { get; set; }

        [JsonPropertyName("is_prescription_item")]
        public bool IsPrescriptionItem { get; set; }

        [JsonPropertyName("show_rr_tag")]
        public bool ShowRrTag { get; set; }

        [JsonPropertyName("rr_tag_qty")]
        public int RrTagQty { get; set; }

        [JsonPropertyName("show_cancellation_tag")]
        public bool ShowCancellationTag { get; set; }

        [JsonPropertyName("cancellation_tag_qty")]
        public int CancellationTagQty { get; set; }
    }

    public class PackageOrderAction
    {
        [JsonPropertyName("can_split")]
        public bool CanSplit { get; set; }

        [JsonPropertyName("can_unsplit")]
        public bool CanUnsplit { get; set; }
    }

    public class PackageTrackingInfo
    {
        [JsonPropertyName("logistics_logs")]
        public List<object> LogisticsLogs { get; set; }
    }
}