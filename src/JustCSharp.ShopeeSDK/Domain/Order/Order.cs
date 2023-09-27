using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace JustCSharp.ShopeeSDK.Domain.Order;

public class Order
{
    [JsonPropertyName("shop_id")]
    public long  ShopId { get; set; }

    [JsonPropertyName("order_id")]
    public long OrderId { get; set; }

    [JsonPropertyName("order_sn")]
    public string OrderSn { get; set; }

    [JsonPropertyName("order_unit_migration_toggle")]
    public int OrderUnitMigrationToggle { get; set; }

    [JsonPropertyName("total_price")]
    public string TotalPrice { get; set; }

    [JsonPropertyName("shipping_method")]
    public int ShippingMethod { get; set; }

    [JsonPropertyName("shipping_address")]
    public string ShippingAddress { get; set; }

    [JsonPropertyName("shipping_fee")]
    public string ShippingFee { get; set; }

    [JsonPropertyName("actual_carrier")]
    public string ActualCarrier { get; set; }

    [JsonPropertyName("order_type")]
    public int OrderType { get; set; }

    [JsonPropertyName("payment_method")]
    public int PaymentMethod { get; set; }

    [JsonPropertyName("remark")]
    public string Remark { get; set; }

    [JsonPropertyName("status")]
    public int Status { get; set; }

    [JsonPropertyName("create_time")]
    public long  CreateTime { get; set; }

    [JsonPropertyName("complete_time")]
    public long  CompleteTime { get; set; }

    [JsonPropertyName("status_ext")]
    public int StatusExt { get; set; }

    [JsonPropertyName("logistics_status")]
    public int LogisticsStatus { get; set; }

    [JsonPropertyName("pickup_time")]
    public long PickupTime { get; set; }

    [JsonPropertyName("shipping_confirm_time")]
    public long ShippingConfirmTime { get; set; }

    [JsonPropertyName("list_type")]
    public int ListType { get; set; }

    [JsonPropertyName("arrange_pickup_by_date")]
    public long ArrangePickupByDate { get; set; }

    [JsonPropertyName("auto_cancel_3pl_ack_date")]
    public long AutoCancel3plAckDate { get; set; }

    [JsonPropertyName("auto_cancel_arrange_ship_date")]
    public long AutoCancelArrangeShipDate { get; set; }

    [JsonPropertyName("buyer_last_change_address_time")]
    public long BuyerLastChangeAddressTime { get; set; }

    [JsonPropertyName("buyer_cancel_reason")]
    public int BuyerCancelReason { get; set; }

    [JsonPropertyName("cancel_reason_ext")]
    public int CancelReasonExt { get; set; }

    [JsonPropertyName("cancel_userid")]
    public long CancelUserid { get; set; }

    [JsonPropertyName("dropshipping_info")]
    public OrderDropshippingInfo DropshippingInfo { get; set; }

    [JsonPropertyName("escrow_release_time")]
    public long EscrowReleaseTime { get; set; }

    [JsonPropertyName("instant_buyercancel_toship")]
    public bool InstantBuyercancelToship { get; set; }

    [JsonPropertyName("is_buyercancel_toship")]
    public bool IsBuyercancelToship { get; set; }

    [JsonPropertyName("logid")]
    public long Logid { get; set; }

    [JsonPropertyName("logistics_channel")]
    public int LogisticsChannel { get; set; }

    [JsonPropertyName("logistics_flag")]
    public int LogisticsFlag { get; set; }

    [JsonPropertyName("payby_date")]
    public long PaybyDate { get; set; }

    [JsonPropertyName("pickup_attempts")]
    public int PickupAttempts { get; set; }

    [JsonPropertyName("pickup_cutoff_time")]
    public long PickupCutoffTime { get; set; }

    [JsonPropertyName("price_before_discount")]
    public string PriceBeforeDiscount { get; set; }

    [JsonPropertyName("rate_by_date")]
    public long RateByDate { get; set; }

    [JsonPropertyName("buyer_rate_by_date")]
    public long BuyerRateByDate { get; set; }

    [JsonPropertyName("seller_address")]
    public OrderSellerAddress SellerAddress { get; set; }

    [JsonPropertyName("seller_address_id")]
    public long SellerAddressId { get; set; }

    [JsonPropertyName("seller_due_date")]
    public long SellerDueDate { get; set; }

    [JsonPropertyName("ship_by_date")]
    public long ShipByDate { get; set; }

    [JsonPropertyName("shipping_proof")]
    public string ShippingProof { get; set; }

    [JsonPropertyName("fulfillment_channel_id")]
    public long FulfillmentChannelId { get; set; }

    [JsonPropertyName("fulfillment_carrier_name")]
    public string FulfillmentCarrierName { get; set; }

    [JsonPropertyName("fulfillment_shipping_method")]
    public int FulfillmentShippingMethod { get; set; }

    [JsonPropertyName("masking_channel_id")]
    public long MaskingChannelId { get; set; }

    [JsonPropertyName("masking_carrier_name")]
    public string MaskingCarrierName { get; set; }

    [JsonPropertyName("checkout_carrier_name")]
    public string CheckoutCarrierName { get; set; }

    [JsonPropertyName("checkout_channel_id")]
    public long CheckoutChannelId { get; set; }

    [JsonPropertyName("buyer_address_name")]
    public string BuyerAddressName { get; set; }

    [JsonPropertyName("buyer_address_phone")]
    public string BuyerAddressPhone { get; set; }

    [JsonPropertyName("cancellation_end_date")]
    public long? CancellationEndDate { get; set; }

    [JsonPropertyName("pay_by_credit_card")]
    public bool PayByCreditCard { get; set; }

    [JsonPropertyName("note")]
    public string Note { get; set; }

    [JsonPropertyName("note_mtime")]
    public long NoteMtime { get; set; }

    [JsonPropertyName("return_id")]
    public long ReturnId { get; set; }

    [JsonPropertyName("order_ratable")]
    public bool OrderRatable { get; set; }

    [JsonPropertyName("order_items")]
    public List<OrderItem> OrderItems { get; set; }

    [JsonPropertyName("buyer_user")]
    public OrderBuyerUser BuyerUser { get; set; }

    [JsonPropertyName("shipment_config")]
    public bool ShipmentConfig { get; set; }

    [JsonPropertyName("fulfill_by_shopee")]
    public bool FulfillByShopee { get; set; }

    [JsonPropertyName("preferred_delivery_timeslot")]
    public long? PreferredDeliveryTimeslot { get; set; }

    [JsonPropertyName("buyer_cpf_id")]
    public string BuyerCpfId { get; set; }

    [JsonPropertyName("buyer_tax_id")]
    public string BuyerTaxId { get; set; }

    [JsonPropertyName("buyer_tax_type_label")]
    public string BuyerTaxTypeLabel { get; set; }

    [JsonPropertyName("is_tax_exempted")]
    public bool IsTaxExempted { get; set; }

    [JsonPropertyName("channel_hotline")]
    public string ChannelHotline { get; set; }

    [JsonPropertyName("is_affiliated_shop_order")]
    public bool IsAffiliatedShopOrder { get; set; }

    [JsonPropertyName("seller_invoice_upload_status")]
    public int SellerInvoiceUploadStatus { get; set; }

    [JsonPropertyName("credit_note_data_status")]
    public int CreditNoteDataStatus { get; set; }

    [JsonPropertyName("pre_authorization_status")]
    public object PreAuthorizationStatus { get; set; }

    [JsonPropertyName("prescription_check_status")]
    public object PrescriptionCheckStatus { get; set; }

    [JsonPropertyName("prescription_images")]
    public object PrescriptionImages { get; set; }

    [JsonPropertyName("pharmacist_name")]
    public string PharmacistName { get; set; }

    [JsonPropertyName("prescription_reject_reason")]
    public object PrescriptionRejectReason { get; set; }

    public class OrderBuyerUser
    {
        [JsonPropertyName("delivery_succ_count")]
        public int DeliverySuccCount { get; set; }

        [JsonPropertyName("user_id")]
        public long UserId { get; set; }

        [JsonPropertyName("user_name")]
        public string UserName { get; set; }

        [JsonPropertyName("portrait")]
        public string Portrait { get; set; }

        [JsonPropertyName("delivery_order_count")]
        public int DeliveryOrderCount { get; set; }

        [JsonPropertyName("rating_count")]
        public List<int> RatingCount { get; set; }

        [JsonPropertyName("rating_star")]
        public decimal RatingStar { get; set; }

        [JsonPropertyName("shop_id")]
        public long ShopId { get; set; }

        [JsonPropertyName("followed")]
        public bool Followed { get; set; }
    }

    public class OrderDropshippingInfo
    {
        [JsonPropertyName("enabled")]
        public int Enabled { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("phone_number")]
        public string PhoneNumber { get; set; }
    }

    public class ItemModel
    {
        [JsonPropertyName("model_id")]
        public long? ModelId { get; set; }

        [JsonPropertyName("item_id")]
        public long? ItemId { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("status")]
        public int Status { get; set; }

        [JsonPropertyName("sku")]
        public string Sku { get; set; }

        [JsonPropertyName("weight")]
        public int Weight { get; set; }
    }

    public class OrderItem
    {
        [JsonPropertyName("add_on_deal_id")]
        public long AddOnDealId { get; set; }

        [JsonPropertyName("amount")]
        public int Amount { get; set; }

        [JsonPropertyName("bundle_deal")]
        public object BundleDeal { get; set; }

        [JsonPropertyName("bundle_deal_id")]
        public int BundleDealId { get; set; }

        [JsonPropertyName("bundle_deal_model")]
        public List<object> BundleDealModel { get; set; }

        [JsonPropertyName("bundle_deal_product")]
        public List<object> BundleDealProduct { get; set; }

        [JsonPropertyName("group_id")]
        public string GroupId { get; set; }

        [JsonPropertyName("is_add_on_sub_item")]
        public bool IsAddOnSubItem { get; set; }

        [JsonPropertyName("is_prescription_item")]
        public bool IsPrescriptionItem { get; set; }

        [JsonPropertyName("is_virtual_sku")]
        public bool IsVirtualSku { get; set; }

        [JsonPropertyName("is_wholesale")]
        public bool IsWholesale { get; set; }

        [JsonPropertyName("item_id")]
        public long? ItemId { get; set; }

        [JsonPropertyName("item_list")]
        public List<object> ItemList { get; set; }

        [JsonPropertyName("item_model")]
        public ItemModel ItemModel { get; set; }

        [JsonPropertyName("index")]
        public int Index { get; set; }

        [JsonPropertyName("line_item_id")]
        public string LineItemId { get; set; }

        [JsonPropertyName("model_id")]
        public long? ModelId { get; set; }

        [JsonPropertyName("order_price")]
        public string OrderPrice { get; set; }

        [JsonPropertyName("product")]
        public Product Product { get; set; }

        [JsonPropertyName("status")]
        public int Status { get; set; }

        [JsonPropertyName("sub_type")]
        public int SubType { get; set; }

        [JsonPropertyName("show_rr_tag")]
        public bool ShowRrTag { get; set; }

        [JsonPropertyName("rr_tag_qty")]
        public int RrTagQty { get; set; }

        [JsonPropertyName("show_cancellation_tag")]
        public bool ShowCancellationTag { get; set; }

        [JsonPropertyName("cancellation_tag_qty")]
        public int CancellationTagQty { get; set; }
    }

    public class Product
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("images")]
        public List<string> Images { get; set; }

        [JsonPropertyName("is_pre_order")]
        public bool IsPreOrder { get; set; }

        [JsonPropertyName("item_id")]
        public long? ItemId { get; set; }

        [JsonPropertyName("model_id")]
        public long? ModelId { get; set; }

        [JsonPropertyName("status")]
        public int Status { get; set; }

        [JsonPropertyName("sku")]
        public string Sku { get; set; }

        [JsonPropertyName("weight")]
        public int Weight { get; set; }
    }

    public class OrderSellerAddress
    {
        [JsonPropertyName("address_id")]
        public long AddressId { get; set; }

        [JsonPropertyName("user_id")]
        public long UserId { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("phone")]
        public string Phone { get; set; }

        [JsonPropertyName("country")]
        public string Country { get; set; }

        [JsonPropertyName("state")]
        public string State { get; set; }

        [JsonPropertyName("city")]
        public string City { get; set; }

        [JsonPropertyName("address")]
        public string Address { get; set; }

        [JsonPropertyName("status")]
        public int Status { get; set; }

        [JsonPropertyName("zip_code")]
        public string ZipCode { get; set; }

        [JsonPropertyName("full_address")]
        public string FullAddress { get; set; }

        [JsonPropertyName("district")]
        public string District { get; set; }

        [JsonPropertyName("town")]
        public string Town { get; set; }

        [JsonPropertyName("logistics_status")]
        public int LogisticsStatus { get; set; }

        [JsonPropertyName("icno")]
        public string Icno { get; set; }
    }
}