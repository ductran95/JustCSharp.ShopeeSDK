using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace JustCSharp.ShopeeSDK.Domain.Order;

// Root myDeserializedClass = JsonSerializer.Deserialize<Root>(myJsonResponse);

public class OrderData
{
    [JsonPropertyName("shop_id")]
    public long  ShopId { get; set; }

    [JsonPropertyName("user_id")]
    public long  UserId { get; set; }

    [JsonPropertyName("order_id")]
    public long OrderId { get; set; }

    [JsonPropertyName("order_sn")]
    public string OrderSn { get; set; }

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

    [JsonPropertyName("payment_method_name")]
    public string PaymentMethodName { get; set; }

    [JsonPropertyName("remark")]
    public string Remark { get; set; }

    [JsonPropertyName("status")]
    public int Status { get; set; }

    [JsonPropertyName("create_time")]
    public long  CreateTime { get; set; }

    [JsonPropertyName("delivery_time")]
    public long  DeliveryTime { get; set; }

    [JsonPropertyName("complete_time")]
    public long  CompleteTime { get; set; }

    [JsonPropertyName("status_ext")]
    public int StatusExt { get; set; }

    [JsonPropertyName("logistics_status")]
    public int LogisticsStatus { get; set; }

    [JsonPropertyName("pickup_time")]
    public long  PickupTime { get; set; }

    [JsonPropertyName("shipping_confirm_time")]
    public int ShippingConfirmTime { get; set; }

    [JsonPropertyName("list_type")]
    public int ListType { get; set; }

    [JsonPropertyName("arrange_pickup_by_date")]
    public int ArrangePickupByDate { get; set; }

    [JsonPropertyName("auto_cancel_3pl_ack_date")]
    public int AutoCancel3plAckDate { get; set; }

    [JsonPropertyName("auto_cancel_arrange_ship_date")]
    public int AutoCancelArrangeShipDate { get; set; }

    [JsonPropertyName("buyer_is_rated")]
    public int BuyerIsRated { get; set; }

    [JsonPropertyName("buyer_last_change_address_time")]
    public int BuyerLastChangeAddressTime { get; set; }

    [JsonPropertyName("buyer_txn_fee")]
    public string BuyerTxnFee { get; set; }

    [JsonPropertyName("buyer_cancel_reason")]
    public int BuyerCancelReason { get; set; }

    [JsonPropertyName("cancel_reason_ext")]
    public int CancelReasonExt { get; set; }

    [JsonPropertyName("cancel_time")]
    public int CancelTime { get; set; }

    [JsonPropertyName("cancel_userid")]
    public int CancelUserid { get; set; }

    [JsonPropertyName("coin_offset")]
    public string CoinOffset { get; set; }

    [JsonPropertyName("dropshipping_info")]
    public OrderDropshippingInfo DropshippingInfo { get; set; }

    [JsonPropertyName("escrow_release_time")]
    public int EscrowReleaseTime { get; set; }

    [JsonPropertyName("first_item_count")]
    public int FirstItemCount { get; set; }

    [JsonPropertyName("first_item_is_wholesale")]
    public bool FirstItemIsWholesale { get; set; }

    [JsonPropertyName("first_item_model")]
    public string FirstItemModel { get; set; }

    [JsonPropertyName("first_item_name")]
    public string FirstItemName { get; set; }

    [JsonPropertyName("first_item_return")]
    public bool FirstItemReturn { get; set; }

    [JsonPropertyName("instant_buyercancel_toship")]
    public bool InstantBuyercancelToship { get; set; }

    [JsonPropertyName("is_buyercancel_toship")]
    public bool IsBuyercancelToship { get; set; }

    [JsonPropertyName("logid")]
    public int Logid { get; set; }

    [JsonPropertyName("logistics_channel")]
    public int LogisticsChannel { get; set; }

    [JsonPropertyName("logistics_extra_data")]
    public string LogisticsExtraData { get; set; }

    [JsonPropertyName("logistics_flag")]
    public int LogisticsFlag { get; set; }

    [JsonPropertyName("pickup_attempts")]
    public int PickupAttempts { get; set; }

    [JsonPropertyName("pickup_cutoff_time")]
    public int PickupCutoffTime { get; set; }

    [JsonPropertyName("shipping_proof")]
    public string ShippingProof { get; set; }

    [JsonPropertyName("shipping_proof_status")]
    public int ShippingProofStatus { get; set; }

    [JsonPropertyName("payby_date")]
    public int PaybyDate { get; set; }

    [JsonPropertyName("price_before_discount")]
    public string PriceBeforeDiscount { get; set; }

    [JsonPropertyName("rate_by_date")]
    public int RateByDate { get; set; }

    [JsonPropertyName("ratecancel_by_date")]
    public int RatecancelByDate { get; set; }

    [JsonPropertyName("seller_address")]
    public OrderSellerAddress SellerAddress { get; set; }

    [JsonPropertyName("seller_address_id")]
    public int SellerAddressId { get; set; }

    [JsonPropertyName("seller_due_date")]
    public int SellerDueDate { get; set; }

    [JsonPropertyName("ship_by_date")]
    public int ShipByDate { get; set; }

    [JsonPropertyName("tax_amount")]
    public string TaxAmount { get; set; }

    [JsonPropertyName("used_voucher")]
    public object UsedVoucher { get; set; }

    [JsonPropertyName("voucher_absorbed_by_seller")]
    public bool VoucherAbsorbedBySeller { get; set; }

    [JsonPropertyName("voucher_code")]
    public string VoucherCode { get; set; }

    [JsonPropertyName("wallet_discount")]
    public string WalletDiscount { get; set; }

    [JsonPropertyName("fulfillment_channel_id")]
    public int FulfillmentChannelId { get; set; }

    [JsonPropertyName("fulfillment_carrier_name")]
    public string FulfillmentCarrierName { get; set; }

    [JsonPropertyName("fulfillment_shipping_method")]
    public int FulfillmentShippingMethod { get; set; }

    [JsonPropertyName("masking_channel_id")]
    public int MaskingChannelId { get; set; }

    [JsonPropertyName("masking_carrier_name")]
    public string MaskingCarrierName { get; set; }

    [JsonPropertyName("checkout_shipping_method")]
    public int CheckoutShippingMethod { get; set; }

    [JsonPropertyName("checkout_carrier_name")]
    public string CheckoutCarrierName { get; set; }

    [JsonPropertyName("checkout_channel_id")]
    public int CheckoutChannelId { get; set; }

    [JsonPropertyName("coins_cash_by_voucher")]
    public string CoinsCashByVoucher { get; set; }

    [JsonPropertyName("buyer_address_name")]
    public string BuyerAddressName { get; set; }

    [JsonPropertyName("buyer_address_phone")]
    public string BuyerAddressPhone { get; set; }

    [JsonPropertyName("cancellation_end_date")]
    public string CancellationEndDate { get; set; }

    [JsonPropertyName("coin_used")]
    public string CoinUsed { get; set; }

    [JsonPropertyName("pay_by_credit_card")]
    public bool PayByCreditCard { get; set; }

    [JsonPropertyName("return_id")]
    public int ReturnId { get; set; }

    [JsonPropertyName("express_channel")]
    public int ExpressChannel { get; set; }

    [JsonPropertyName("order_ratable")]
    public bool OrderRatable { get; set; }

    [JsonPropertyName("order_items")]
    public List<OrderItem> OrderItems { get; set; }

    [JsonPropertyName("order_unit_migration_toggle")]
    public int OrderUnitMigrationToggle { get; set; }

    [JsonPropertyName("is_tax_exempted")]
    public bool IsTaxExempted { get; set; }

    [JsonPropertyName("buyer_user")]
    public OrderBuyerUser BuyerUser { get; set; }

    [JsonPropertyName("shipment_config")]
    public bool ShipmentConfig { get; set; }

    [JsonPropertyName("fulfill_by_shopee")]
    public bool FulfillByShopee { get; set; }

    [JsonPropertyName("preferred_delivery_timeslot")]
    public object PreferredDeliveryTimeslot { get; set; }

    [JsonPropertyName("is_affiliated_shop_order")]
    public bool IsAffiliatedShopOrder { get; set; }

    [JsonPropertyName("invoice_data_status")]
    public int InvoiceDataStatus { get; set; }

    [JsonPropertyName("invoice_download_status")]
    public int? InvoiceDownloadStatus { get; set; }

    [JsonPropertyName("is_prescription_order")]
    public bool IsPrescriptionOrder { get; set; }

    [JsonPropertyName("prescription_check_status")]
    public int PrescriptionCheckStatus { get; set; }

    [JsonPropertyName("prescription_images")]
    public object PrescriptionImages { get; set; }

    public class Access
    {
        [JsonPropertyName("hide_likes")]
        public int HideLikes { get; set; }

        [JsonPropertyName("wallet_setting")]
        public int WalletSetting { get; set; }

        [JsonPropertyName("seller_coin_setting")]
        public int SellerCoinSetting { get; set; }

        [JsonPropertyName("seller_wholesale_setting")]
        public int SellerWholesaleSetting { get; set; }

        [JsonPropertyName("seller_ads_setting")]
        public int SellerAdsSetting { get; set; }
    }

    public class AddressInfo
    {
        [JsonPropertyName("mcount")]
        public int Mcount { get; set; }

        [JsonPropertyName("mcount_create_time")]
        public int McountCreateTime { get; set; }

        [JsonPropertyName("in_white_list")]
        public bool InWhiteList { get; set; }
    }

    public class OrderBuyerUser
    {
        [JsonPropertyName("delivery_succ_count")]
        public int DeliverySuccCount { get; set; }

        [JsonPropertyName("hide_likes")]
        public int HideLikes { get; set; }

        [JsonPropertyName("user_id")]
        public int UserId { get; set; }

        [JsonPropertyName("user_name")]
        public string UserName { get; set; }

        [JsonPropertyName("portrait")]
        public string Portrait { get; set; }

        [JsonPropertyName("phone_public")]
        public bool PhonePublic { get; set; }

        [JsonPropertyName("language")]
        public string Language { get; set; }

        [JsonPropertyName("cb_option")]
        public int CbOption { get; set; }

        [JsonPropertyName("ext_info")]
        public ExtInfo ExtInfo { get; set; }

        [JsonPropertyName("delivery_order_count")]
        public int DeliveryOrderCount { get; set; }

        [JsonPropertyName("buyer_rating")]
        public int BuyerRating { get; set; }

        [JsonPropertyName("rating_count")]
        public List<int> RatingCount { get; set; }

        [JsonPropertyName("rating_star")]
        public decimal RatingStar { get; set; }

        [JsonPropertyName("shop_id")]
        public int ShopId { get; set; }

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

    public class ExtInfo
    {
        [JsonPropertyName("geo_info")]
        public string GeoInfo { get; set; }

        [JsonPropertyName("access")]
        public Access Access { get; set; }

        [JsonPropertyName("disable_new_device_login_otp")]
        public bool DisableNewDeviceLoginOtp { get; set; }

        [JsonPropertyName("gender")]
        public int Gender { get; set; }

        [JsonPropertyName("smid_status")]
        public int SmidStatus { get; set; }

        [JsonPropertyName("ba_check_status")]
        public int BaCheckStatus { get; set; }

        [JsonPropertyName("feed_private")]
        public bool FeedPrivate { get; set; }

        [JsonPropertyName("delivery_address_id")]
        public int DeliveryAddressId { get; set; }

        [JsonPropertyName("birth_timestamp")]
        public int BirthTimestamp { get; set; }

        [JsonPropertyName("holiday_mode_on")]
        public bool HolidayModeOn { get; set; }

        [JsonPropertyName("tos_accepted_time")]
        public int TosAcceptedTime { get; set; }

        [JsonPropertyName("address_info")]
        public AddressInfo AddressInfo { get; set; }
    }

    public class ItemModel
    {
        [JsonPropertyName("model_id")]
        public long? ModelId { get; set; }

        [JsonPropertyName("item_id")]
        public long? ItemId { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("price")]
        public string Price { get; set; }

        [JsonPropertyName("currency")]
        public string Currency { get; set; }

        [JsonPropertyName("status")]
        public int Status { get; set; }

        [JsonPropertyName("price_before_discount")]
        public string PriceBeforeDiscount { get; set; }

        [JsonPropertyName("promotion_id")]
        public int PromotionId { get; set; }

        [JsonPropertyName("rebate_price")]
        public string RebatePrice { get; set; }

        [JsonPropertyName("sold")]
        public int Sold { get; set; }

        [JsonPropertyName("ctime")]
        public int Ctime { get; set; }

        [JsonPropertyName("mtime")]
        public int Mtime { get; set; }

        [JsonPropertyName("sku")]
        public string Sku { get; set; }
    }

    public class OrderItem
    {
        [JsonPropertyName("add_on_deal_id")]
        public int AddOnDealId { get; set; }

        [JsonPropertyName("amount")]
        public int Amount { get; set; }

        [JsonPropertyName("bundle_deal_id")]
        public int BundleDealId { get; set; }

        [JsonPropertyName("group_id")]
        public string GroupId { get; set; }

        [JsonPropertyName("is_add_on_sub_item")]
        public bool IsAddOnSubItem { get; set; }

        [JsonPropertyName("is_wholesale")]
        public bool IsWholesale { get; set; }

        [JsonPropertyName("item_price")]
        public string ItemPrice { get; set; }

        [JsonPropertyName("item_id")]
        public long? ItemId { get; set; }

        [JsonPropertyName("index")]
        public int Index { get; set; }

        [JsonPropertyName("line_item_id")]
        public string LineItemId { get; set; }

        [JsonPropertyName("model_id")]
        public long? ModelId { get; set; }

        [JsonPropertyName("order_price")]
        public string OrderPrice { get; set; }

        [JsonPropertyName("price_before_bundle")]
        public string PriceBeforeBundle { get; set; }

        [JsonPropertyName("snapshot_id")]
        public long? SnapshotId { get; set; }

        [JsonPropertyName("status")]
        public int Status { get; set; }

        [JsonPropertyName("shop_id")]
        public int ShopId { get; set; }

        [JsonPropertyName("is_virtual_sku")]
        public bool IsVirtualSku { get; set; }

        [JsonPropertyName("bundle_deal")]
        public object BundleDeal { get; set; }

        [JsonPropertyName("item_model")]
        public ItemModel ItemModel { get; set; }

        [JsonPropertyName("bundle_deal_model")]
        public object BundleDealModel { get; set; }

        [JsonPropertyName("item_list")]
        public object ItemList { get; set; }

        [JsonPropertyName("product")]
        public Product Product { get; set; }

        [JsonPropertyName("bundle_deal_product")]
        public object BundleDealProduct { get; set; }

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

        [JsonPropertyName("is_prescription_item")]
        public bool IsPrescriptionItem { get; set; }
    }

    public class Product
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("images")]
        public List<string> Images { get; set; }

        [JsonPropertyName("brand")]
        public string Brand { get; set; }

        [JsonPropertyName("cat_id")]
        public int CatId { get; set; }

        [JsonPropertyName("cmt_count")]
        public int CmtCount { get; set; }

        [JsonPropertyName("condition")]
        public int Condition { get; set; }

        [JsonPropertyName("ctime")]
        public int Ctime { get; set; }

        [JsonPropertyName("currency")]
        public string Currency { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("estimated_days")]
        public int EstimatedDays { get; set; }

        [JsonPropertyName("is_pre_order")]
        public bool IsPreOrder { get; set; }

        [JsonPropertyName("item_id")]
        public long? ItemId { get; set; }

        [JsonPropertyName("model_id")]
        public long? ModelId { get; set; }

        [JsonPropertyName("liked_count")]
        public int LikedCount { get; set; }

        [JsonPropertyName("price")]
        public string Price { get; set; }

        [JsonPropertyName("price_before_discount")]
        public string PriceBeforeDiscount { get; set; }

        [JsonPropertyName("shop_id")]
        public int ShopId { get; set; }

        [JsonPropertyName("sold")]
        public int Sold { get; set; }

        [JsonPropertyName("status")]
        public int Status { get; set; }

        [JsonPropertyName("sku")]
        public string Sku { get; set; }

        [JsonPropertyName("snapshot_id")]
        public long? SnapshotId { get; set; }
    }

    public class OrderSellerAddress
    {
        [JsonPropertyName("address_id")]
        public int AddressId { get; set; }

        [JsonPropertyName("user_id")]
        public int UserId { get; set; }

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

        [JsonPropertyName("ctime")]
        public int Ctime { get; set; }

        [JsonPropertyName("mtime")]
        public int Mtime { get; set; }

        [JsonPropertyName("zip_code")]
        public string ZipCode { get; set; }

        [JsonPropertyName("def_time")]
        public int DefTime { get; set; }

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

        [JsonPropertyName("ext_info")]
        public ExtInfo ExtInfo { get; set; }
    }
}