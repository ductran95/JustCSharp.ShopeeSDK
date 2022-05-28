using System.Collections.Generic;
using System.Text.Json.Serialization;
using JustCSharp.ShopeeSDK.Domain.Common;
using JustCSharp.ShopeeSDK.Domain.Order;

namespace JustCSharp.ShopeeSDK.Domain.Finance;

public class FinanceOrder
{
    [JsonPropertyName("comm_fee")]
    public string CommFee { get; set; }

    [JsonPropertyName("shipping_method")]
    public long ShippingMethod { get; set; }

    [JsonPropertyName("fulfill_by_shopee")]
    public bool FulfillByShopee { get; set; }

    [JsonPropertyName("payment_method")]
    public long PaymentMethod { get; set; }

    [JsonPropertyName("wallet_discount")]
    public string WalletDiscount { get; set; }

    [JsonPropertyName("shop_id")]
    public long ShopId { get; set; }

    [JsonPropertyName("add_on_deal_id")]
    public long AddOnDealId { get; set; }

    [JsonPropertyName("buyer_address_name")]
    public string BuyerAddressName { get; set; }

    [JsonPropertyName("complete_time")]
    public long CompleteTime { get; set; }

    [JsonPropertyName("fulfillment_shipping_method")]
    public long FulfillmentShippingMethod { get; set; }

    [JsonPropertyName("actual_shipping_fee")]
    public string ActualShippingFee { get; set; }

    [JsonPropertyName("ship_by_date")]
    public long ShipByDate { get; set; }

    [JsonPropertyName("cancel_time")]
    public long CancelTime { get; set; }

    [JsonPropertyName("buyer_cpf_id")]
    public string BuyerCpfId { get; set; }

    [JsonPropertyName("return_id")]
    public long ReturnId { get; set; }

    [JsonPropertyName("checkout_id")]
    public long CheckoutId { get; set; }

    [JsonPropertyName("voucher_code")]
    public string VoucherCode { get; set; }

    [JsonPropertyName("total_price")]
    public string TotalPrice { get; set; }

    [JsonPropertyName("tax_amount")]
    public string TaxAmount { get; set; }

    [JsonPropertyName("first_item_is_wholesale")]
    public bool FirstItemIsWholesale { get; set; }

    [JsonPropertyName("is_buyercancel_toship")]
    public bool IsBuyercancelToship { get; set; }

    [JsonPropertyName("list_type")]
    public long ListType { get; set; }

    [JsonPropertyName("first_item_count")]
    public long FirstItemCount { get; set; }

    [JsonPropertyName("shipping_confirm_time")]
    public long ShippingConfirmTime { get; set; }

    [JsonPropertyName("payby_date")]
    public long PaybyDate { get; set; }

    [JsonPropertyName("seller_service_fee")]
    public string SellerServiceFee { get; set; }

    [JsonPropertyName("status_ext")]
    public long StatusExt { get; set; }

    [JsonPropertyName("pay_by_credit_card")]
    public bool PayByCreditCard { get; set; }

    [JsonPropertyName("first_item_return")]
    public bool FirstItemReturn { get; set; }

    [JsonPropertyName("logistics_status")]
    public long LogisticsStatus { get; set; }

    [JsonPropertyName("create_time")]
    public long CreateTime { get; set; }

    [JsonPropertyName("auto_cancel_3pl_ack_date")]
    public long AutoCancel3plAckDate { get; set; }

    [JsonPropertyName("price_before_discount")]
    public string PriceBeforeDiscount { get; set; }

    [JsonPropertyName("seller_due_date")]
    public long SellerDueDate { get; set; }

    [JsonPropertyName("coins_cash_by_voucher")]
    public string CoinsCashByVoucher { get; set; }

    [JsonPropertyName("channel_hotline")]
    public string ChannelHotline { get; set; }

    [JsonPropertyName("item_count")]
    public long ItemCount { get; set; }

    [JsonPropertyName("shipment_config")]
    public bool ShipmentConfig { get; set; }

    [JsonPropertyName("logistics_channel")]
    public long LogisticsChannel { get; set; }

    [JsonPropertyName("coin_used")]
    public string CoinUsed { get; set; }

    [JsonPropertyName("origin_shipping_fee")]
    public string OriginShippingFee { get; set; }

    [JsonPropertyName("actual_price")]
    public string ActualPrice { get; set; }

    [JsonPropertyName("order_id")]
    public long OrderId { get; set; }

    [JsonPropertyName("pickup_time")]
    public long PickupTime { get; set; }

    [JsonPropertyName("auto_cancel_arrange_ship_date")]
    public long AutoCancelArrangeShipDate { get; set; }

    [JsonPropertyName("is_affiliated_shop_order")]
    public bool IsAffiliatedShopOrder { get; set; }

    [JsonPropertyName("voucher_price")]
    public string VoucherPrice { get; set; }

    [JsonPropertyName("trans_detail_shipping_fee")]
    public string TransDetailShippingFee { get; set; }

    [JsonPropertyName("buyer_is_rated")]
    public long BuyerIsRated { get; set; }

    [JsonPropertyName("express_channel")]
    public long ExpressChannel { get; set; }

    [JsonPropertyName("logistics_extra_data")]
    public string LogisticsExtraData { get; set; }

    [JsonPropertyName("dropshipping_info")]
    public DropshippingInfo DropshippingInfo { get; set; }

    [JsonPropertyName("remark")]
    public string Remark { get; set; }

    [JsonPropertyName("buyer_txn_fee")]
    public string BuyerTxnFee { get; set; }

    [JsonPropertyName("checkout_carrier_name")]
    public string CheckoutCarrierName { get; set; }

    [JsonPropertyName("checkout_shipping_method")]
    public long CheckoutShippingMethod { get; set; }

    [JsonPropertyName("cancel_reason_ext")]
    public long CancelReasonExt { get; set; }

    [JsonPropertyName("coin_offset")]
    public string CoinOffset { get; set; }

    [JsonPropertyName("shipping_proof_status")]
    public long ShippingProofStatus { get; set; }

    [JsonPropertyName("buyer_address_phone")]
    public string BuyerAddressPhone { get; set; }

    [JsonPropertyName("fulfillment_carrier_name")]
    public string FulfillmentCarrierName { get; set; }

    [JsonPropertyName("masking_carrier_name")]
    public string MaskingCarrierName { get; set; }

    [JsonPropertyName("forder_id")]
    public string ForderId { get; set; }

    [JsonPropertyName("buyer_paid_amount")]
    public string BuyerPaidAmount { get; set; }

    [JsonPropertyName("ratecancel_by_date")]
    public long RatecancelByDate { get; set; }

    [JsonPropertyName("first_item_model")]
    public string FirstItemModel { get; set; }

    [JsonPropertyName("buyer_user")]
    public BuyerUser BuyerUser { get; set; }

    [JsonPropertyName("instant_buyercancel_toship")]
    public bool InstantBuyercancelToship { get; set; }

    [JsonPropertyName("parcel_no")]
    public long ParcelNo { get; set; }

    [JsonPropertyName("is_request_cancellation")]
    public bool IsRequestCancellation { get; set; }

    [JsonPropertyName("order_sn")]
    public string OrderSn { get; set; }

    [JsonPropertyName("cancel_by")]
    public string CancelBy { get; set; }

    [JsonPropertyName("preferred_delivery_timeslot")]
    public object PreferredDeliveryTimeslot { get; set; }

    [JsonPropertyName("note_mtime")]
    public long NoteMtime { get; set; }

    [JsonPropertyName("delivery_time")]
    public long DeliveryTime { get; set; }

    [JsonPropertyName("pickup_attempts")]
    public long PickupAttempts { get; set; }

    [JsonPropertyName("logistics_flag")]
    public long LogisticsFlag { get; set; }

    [JsonPropertyName("voucher_absorbed_by_seller")]
    public bool VoucherAbsorbedBySeller { get; set; }

    [JsonPropertyName("shipping_address")]
    public string ShippingAddress { get; set; }

    [JsonPropertyName("shipping_fee")]
    public string ShippingFee { get; set; }

    [JsonPropertyName("shipping_traceno")]
    public string ShippingTraceno { get; set; }

    [JsonPropertyName("pickup_cutoff_time")]
    public long PickupCutoffTime { get; set; }

    [JsonPropertyName("fulfillment_channel_id")]
    public long FulfillmentChannelId { get; set; }

    [JsonPropertyName("buyer_last_change_address_time")]
    public long BuyerLastChangeAddressTime { get; set; }

    [JsonPropertyName("currency")]
    public string Currency { get; set; }

    [JsonPropertyName("escrow_release_time")]
    public long EscrowReleaseTime { get; set; }

    [JsonPropertyName("shipping_proof")]
    public string ShippingProof { get; set; }

    [JsonPropertyName("logid")]
    public long Logid { get; set; }

    [JsonPropertyName("checkout_channel_id")]
    public long CheckoutChannelId { get; set; }

    [JsonPropertyName("order_type")]
    public long OrderType { get; set; }

    [JsonPropertyName("paid_amount")]
    public string PaidAmount { get; set; }

    [JsonPropertyName("credit_card_promotion_discount")]
    public string CreditCardPromotionDiscount { get; set; }

    [JsonPropertyName("carrier_shipping_fee")]
    public long CarrierShippingFee { get; set; }

    [JsonPropertyName("rate_by_date")]
    public long RateByDate { get; set; }

    [JsonPropertyName("order_ratable")]
    public bool OrderRatable { get; set; }

    [JsonPropertyName("note")]
    public string Note { get; set; }

    [JsonPropertyName("shipping_fee_discount")]
    public long ShippingFeeDiscount { get; set; }

    [JsonPropertyName("card_txn_fee_info")]
    public CardTxnFeeInfo CardTxnFeeInfo { get; set; }

    [JsonPropertyName("status")]
    public int Status { get; set; }

    [JsonPropertyName("first_item_name")]
    public string FirstItemName { get; set; }

    [JsonPropertyName("buyer_cancel_reason")]
    public long BuyerCancelReason { get; set; }

    [JsonPropertyName("cancellation_end_date")]
    public object CancellationEndDate { get; set; }

    [JsonPropertyName("order_item_price_infos")]
    public object OrderItemPriceInfos { get; set; }

    [JsonPropertyName("order_items")]
    public List<OrderItem> OrderItems { get; set; }

    [JsonPropertyName("actual_carrier")]
    public string ActualCarrier { get; set; }

    [JsonPropertyName("used_voucher")]
    public long UsedVoucher { get; set; }

    [JsonPropertyName("seller_address_id")]
    public long SellerAddressId { get; set; }

    [JsonPropertyName("masking_channel_id")]
    public long MaskingChannelId { get; set; }

    [JsonPropertyName("cancel_userid")]
    public long CancelUserid { get; set; }

    [JsonPropertyName("user_id")]
    public long UserId { get; set; }

    [JsonPropertyName("seller_address")]
    public SellerAddress SellerAddress { get; set; }

    [JsonPropertyName("coins_by_voucher")]
    public long CoinsByVoucher { get; set; }

    [JsonPropertyName("arrange_pickup_by_date")]
    public long ArrangePickupByDate { get; set; }
}