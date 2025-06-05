using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace JustCSharp.ShopeeSDK.Domain.Order;

public class CompactOrderData
{
    [JsonPropertyName("shop_id")]
    public long ShopId { get; set; }

    [JsonPropertyName("order_id")]
    public long OrderId { get; set; }

    [JsonPropertyName("order_sn")]
    public string OrderSn { get; set; }

    [JsonPropertyName("order_unit_migration_toggle")]
    public int OrderUnitMigrationToggle { get; set; }

    [JsonPropertyName("shipping_method")]
    public int ShippingMethod { get; set; }

    [JsonPropertyName("shipping_fee")]
    public string ShippingFee { get; set; }

    [JsonPropertyName("actual_carrier")]
    public string ActualCarrier { get; set; }

    [JsonPropertyName("payment_method")]
    public int PaymentMethod { get; set; }

    [JsonPropertyName("payment_method_name")]
    public string PaymentMethodName { get; set; }

    [JsonPropertyName("remark")]
    public string Remark { get; set; }

    [JsonPropertyName("status")]
    public int Status { get; set; }

    [JsonPropertyName("complete_time")]
    public long CompleteTime { get; set; }

    [JsonPropertyName("create_time")]
    public long CreateTime { get; set; }

    [JsonPropertyName("status_ext")]
    public int StatusExt { get; set; }

    [JsonPropertyName("logistics_status")]
    public int LogisticsStatus { get; set; }

    [JsonPropertyName("list_type")]
    public int ListType { get; set; }

    [JsonPropertyName("buyer_is_rated")]
    public int BuyerIsRated { get; set; }

    [JsonPropertyName("cancel_reason_ext")]
    public int CancelReasonExt { get; set; }

    [JsonPropertyName("cancel_user_id")]
    public long CancelUserId { get; set; }

    [JsonPropertyName("escrow_release_time")]
    public long EscrowReleaseTime { get; set; }

    [JsonPropertyName("instant_buyercancel_toship")]
    public bool InstantBuyercancelToship { get; set; }

    [JsonPropertyName("is_buyercancel_toship")]
    public bool IsBuyercancelToship { get; set; }

    [JsonPropertyName("logistics_channel")]
    public int LogisticsChannel { get; set; }

    [JsonPropertyName("logistics_flag")]
    public int LogisticsFlag { get; set; }

    [JsonPropertyName("payby_date")]
    public long PaybyDate { get; set; }

    [JsonPropertyName("pickup_attempts")]
    public int PickupAttempts { get; set; }

    [JsonPropertyName("price_before_discount")]
    public string PriceBeforeDiscount { get; set; }

    [JsonPropertyName("rate_comment")]
    public string RateComment { get; set; }

    [JsonPropertyName("rate_star")]
    public decimal RateStar { get; set; }

    [JsonPropertyName("rate_by_date")]
    public long RateByDate { get; set; }

    [JsonPropertyName("buyer_rate_by_date")]
    public long BuyerRateByDate { get; set; }

    [JsonPropertyName("ratecancel_by_date")]
    public long RatecancelByDate { get; set; }

    [JsonPropertyName("seller_address")]
    public CompactSellerAddress SellerAddress { get; set; }

    [JsonPropertyName("seller_address_id")]
    public long SellerAddressId { get; set; }

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

    [JsonPropertyName("checkout_shipping_method")]
    public int CheckoutShippingMethod { get; set; }

    [JsonPropertyName("checkout_carrier_name")]
    public string CheckoutCarrierName { get; set; }

    [JsonPropertyName("checkout_channel_id")]
    public long CheckoutChannelId { get; set; }

    [JsonPropertyName("cancellation_end_date")]
    public long? CancellationEndDate { get; set; }

    [JsonPropertyName("return_id")]
    public long ReturnId { get; set; }

    [JsonPropertyName("order_ratable")]
    public bool OrderRatable { get; set; }

    [JsonPropertyName("order_items")]
    public List<OrderItem> OrderItems { get; set; }

    [JsonPropertyName("buyer_user")]
    public CompactBuyerUser BuyerUser { get; set; }

    [JsonPropertyName("invoice_status")]
    public int InvoiceStatus { get; set; }

    [JsonPropertyName("invoice_download_status")]
    public object InvoiceDownloadStatus { get; set; }

    [JsonPropertyName("is_affiliated_shop_order")]
    public bool IsAffiliatedShopOrder { get; set; }

    [JsonPropertyName("seller_invoice_download_status")]
    public int SellerInvoiceDownloadStatus { get; set; }

    [JsonPropertyName("seller_invoice_upload_status")]
    public int SellerInvoiceUploadStatus { get; set; }

    [JsonPropertyName("credit_note_data_status")]
    public int CreditNoteDataStatus { get; set; }

    [JsonPropertyName("third_party_tn")]
    public List<string> ThirdPartyTn { get; set; }

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
        public long McountCreateTime { get; set; }

        [JsonPropertyName("in_white_list")]
        public bool InWhiteList { get; set; }
    }

    public class CompactBuyerUser
    {
        [JsonPropertyName("delivery_succ_count")]
        public int? DeliverySuccCount { get; set; }

        [JsonPropertyName("hide_likes")]
        public int HideLikes { get; set; }

        [JsonPropertyName("user_id")]
        public long UserId { get; set; }

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
        public long ShopId { get; set; }

        [JsonPropertyName("followed")]
        public bool Followed { get; set; }
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
        public long DeliveryAddressId { get; set; }

        [JsonPropertyName("birth_timestamp")]
        public long BirthTimestamp { get; set; }

        [JsonPropertyName("holiday_mode_on")]
        public bool HolidayModeOn { get; set; }

        [JsonPropertyName("tos_accepted_time")]
        public long TosAcceptedTime { get; set; }

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
        public long? PromotionId { get; set; }

        [JsonPropertyName("rebate_price")]
        public string RebatePrice { get; set; }

        [JsonPropertyName("sold")]
        public int Sold { get; set; }

        [JsonPropertyName("ctime")]
        public long Ctime { get; set; }

        [JsonPropertyName("mtime")]
        public long Mtime { get; set; }

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

        [JsonPropertyName("index")]
        public int Index { get; set; }

        [JsonPropertyName("is_add_on_sub_item")]
        public bool IsAddOnSubItem { get; set; }

        [JsonPropertyName("is_wholesale")]
        public bool IsWholesale { get; set; }

        [JsonPropertyName("item_price")]
        public string ItemPrice { get; set; }

        [JsonPropertyName("item_id")]
        public long? ItemId { get; set; }

        [JsonPropertyName("model_id")]
        public long? ModelId { get; set; }

        [JsonPropertyName("line_item_id")]
        public string LineItemId { get; set; }

        [JsonPropertyName("order_price")]
        public string OrderPrice { get; set; }

        [JsonPropertyName("price_before_bundle")]
        public string PriceBeforeBundle { get; set; }

        [JsonPropertyName("snapshot_id")]
        public long? SnapshotId { get; set; }

        [JsonPropertyName("status")]
        public int Status { get; set; }

        [JsonPropertyName("shop_id")]
        public long ShopId { get; set; }

        [JsonPropertyName("show_rr_tag")]
        public bool ShowRrTag { get; set; }

        [JsonPropertyName("order_item_id")]
        public long OrderItemId { get; set; }

        [JsonPropertyName("rr_tag_qty")]
        public int RrTagQty { get; set; }

        [JsonPropertyName("show_cancellation_tag")]
        public bool ShowCancellationTag { get; set; }

        [JsonPropertyName("cancellation_tag_qty")]
        public int CancellationTagQty { get; set; }

        [JsonPropertyName("is_virtual_sku")]
        public bool IsVirtualSku { get; set; }

        [JsonPropertyName("comm_fee_rate")]
        public string CommFeeRate { get; set; }

        [JsonPropertyName("bundle_deal")]
        public object BundleDeal { get; set; }

        [JsonPropertyName("item_model")]
        public ItemModel ItemModel { get; set; }

        [JsonPropertyName("bundle_deal_model")]
        public List<object> BundleDealModel { get; set; }

        [JsonPropertyName("item_list")]
        public List<object> ItemList { get; set; }

        [JsonPropertyName("product")]
        public Product Product { get; set; }

        [JsonPropertyName("bundle_deal_product")]
        public List<object> BundleDealProduct { get; set; }

        [JsonPropertyName("sub_type")]
        public int SubType { get; set; }
    }

    public class Product
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("images")]
        public List<string> Images { get; set; }

        [JsonPropertyName("branch")]
        public string Branch { get; set; }

        [JsonPropertyName("brand")]
        public string Brand { get; set; }

        [JsonPropertyName("cat_id")]
        public long CatId { get; set; }

        [JsonPropertyName("cmt_count")]
        public int CmtCount { get; set; }

        [JsonPropertyName("condition")]
        public int Condition { get; set; }

        [JsonPropertyName("ctime")]
        public long Ctime { get; set; }

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
        public long ShopId { get; set; }

        [JsonPropertyName("sold")]
        public int Sold { get; set; }

        [JsonPropertyName("status")]
        public int Status { get; set; }

        [JsonPropertyName("sku")]
        public string Sku { get; set; }

        [JsonPropertyName("snapshot_id")]
        public long? SnapshotId { get; set; }
    }

    public class CompactSellerAddress
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

        [JsonPropertyName("ctime")]
        public long Ctime { get; set; }

        [JsonPropertyName("mtime")]
        public long Mtime { get; set; }

        [JsonPropertyName("zip_code")]
        public string ZipCode { get; set; }

        [JsonPropertyName("def_time")]
        public long DefTime { get; set; }

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