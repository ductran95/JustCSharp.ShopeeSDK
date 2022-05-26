using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace JustCSharp.ShopeeSDK.Domain.Order;

public class PackageData
{
    [JsonPropertyName("carrier_name")]
    public string CarrierName { get; set; }

    [JsonPropertyName("masking_carrier_name")]
    public string MaskingCarrierName { get; set; }

    [JsonPropertyName("channel_id")]
    public long ChannelId { get; set; }

    [JsonPropertyName("masking_channel_id")]
    public long MaskingChannelId { get; set; }

    [JsonPropertyName("consignment_no")]
    public string ConsignmentNo { get; set; }

    [JsonPropertyName("dropoff_b2c")]
    public long DropoffB2c { get; set; }

    [JsonPropertyName("expire_time")]
    public long ExpireTime { get; set; }

    [JsonPropertyName("extra_flag")]
    public long ExtraFlag { get; set; }

    [JsonPropertyName("first_mile_tn")]
    public string FirstMileTn { get; set; }

    [JsonPropertyName("logistics_flag")]
    public long LogisticsFlag { get; set; }

    [JsonPropertyName("pickup_time")]
    public long PickupTime { get; set; }

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
    public long CheckoutChannelId { get; set; }

    [JsonPropertyName("package_number")]
    public string PackageNumber { get; set; }

    [JsonPropertyName("forder_logistics_status")]
    public long ForderLogisticsStatus { get; set; }

    [JsonPropertyName("package_logistics_status")]
    public long PackageLogisticsStatus { get; set; }

    [JsonPropertyName("forder_shipping_status")]
    public long ForderShippingStatus { get; set; }

    [JsonPropertyName("package_shipping_status")]
    public long PackageShippingStatus { get; set; }

    [JsonPropertyName("is_pickup")]
    public long IsPickup { get; set; }

    [JsonPropertyName("is_pre_order")]
    public long IsPreOrder { get; set; }

    [JsonPropertyName("item_list")]
    public List<PackageItem> ItemList { get; set; }

    [JsonPropertyName("order_action")]
    public PackageOrderAction PackageOrderAction { get; set; }

    [JsonPropertyName("order_create_time")]
    public long OrderCreateTime { get; set; }

    [JsonPropertyName("order_id")]
    public long OrderId { get; set; }

    [JsonPropertyName("order_logistics_status")]
    public long OrderLogisticsStatus { get; set; }

    [JsonPropertyName("order_sn")]
    public string OrderSn { get; set; }

    [JsonPropertyName("parcel_no")]
    public long ParcelNo { get; set; }

    [JsonPropertyName("parcel_price")]
    public string ParcelPrice { get; set; }

    [JsonPropertyName("region_id")]
    public string RegionId { get; set; }

    [JsonPropertyName("ship_by_date")]
    public long ShipByDate { get; set; }

    [JsonPropertyName("shipping_confirm_time")]
    public long ShippingConfirmTime { get; set; }

    [JsonPropertyName("shop_id")]
    public long ShopId { get; set; }

    [JsonPropertyName("split_up")]
    public long SplitUp { get; set; }

    [JsonPropertyName("allocating_status")]
    public long AllocatingStatus { get; set; }

    [JsonPropertyName("tracking_info")]
    public PackageTrackingInfo PackageTrackingInfo { get; set; }

    [JsonPropertyName("user_id")]
    public long UserId { get; set; }

    [JsonPropertyName("fulfillment_carrier_name")]
    public string FulfillmentCarrierName { get; set; }

    [JsonPropertyName("fulfillment_shipping_method")]
    public long FulfillmentShippingMethod { get; set; }

    [JsonPropertyName("fulfillment_channel_id")]
    public long FulfillmentChannelId { get; set; }

    [JsonPropertyName("preferred_delivery_timeslot")]
    public object PreferredDeliveryTimeslot { get; set; }

    [JsonPropertyName("is_affiliated_shop_order")]
    public bool IsAffiliatedShopOrder { get; set; }

    [JsonPropertyName("plp_number")]
    public string PlpNumber { get; set; }

    [JsonPropertyName("code")]
    public long Code { get; set; }

    [JsonPropertyName("transify_key")]
    public string TransifyKey { get; set; }
}