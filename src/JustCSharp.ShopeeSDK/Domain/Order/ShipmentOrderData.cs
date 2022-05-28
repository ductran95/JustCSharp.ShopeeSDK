using System.Collections.Generic;
using System.Text.Json.Serialization;
using JustCSharp.ShopeeSDK.Domain.Common;

namespace JustCSharp.ShopeeSDK.Domain.Order;

public class ShipmentOrderData
{
    [JsonPropertyName("shop_id")]
    public long ShopId { get; set; }

    [JsonPropertyName("order_id")]
    public long OrderId { get; set; }

    [JsonPropertyName("order_sn")]
    public string OrderSn { get; set; }

    [JsonPropertyName("shipping_address")]
    public string ShippingAddress { get; set; }

    [JsonPropertyName("shipping_fee")]
    public string ShippingFee { get; set; }

    [JsonPropertyName("actual_carrier")]
    public string ActualCarrier { get; set; }

    [JsonPropertyName("payment_method")]
    public long PaymentMethod { get; set; }

    [JsonPropertyName("remark")]
    public string Remark { get; set; }

    [JsonPropertyName("status")]
    public long Status { get; set; }

    [JsonPropertyName("complete_time")]
    public long CompleteTime { get; set; }

    [JsonPropertyName("status_ext")]
    public long StatusExt { get; set; }

    [JsonPropertyName("arrange_pickup_by_date")]
    public long ArrangePickupByDate { get; set; }

    [JsonPropertyName("auto_cancel_3pl_ack_date")]
    public long AutoCancel3plAckDate { get; set; }

    [JsonPropertyName("auto_cancel_arrange_ship_date")]
    public long AutoCancelArrangeShipDate { get; set; }

    [JsonPropertyName("buyer_is_rated")]
    public long BuyerIsRated { get; set; }

    [JsonPropertyName("dropshipping_info")]
    public DropshippingInfo DropshippingInfo { get; set; }

    [JsonPropertyName("pickup_attempts")]
    public long PickupAttempts { get; set; }

    [JsonPropertyName("pickup_cutoff_time")]
    public long PickupCutoffTime { get; set; }

    [JsonPropertyName("seller_address")]
    public SellerAddress SellerAddress { get; set; }

    [JsonPropertyName("seller_address_id")]
    public long SellerAddressId { get; set; }

    [JsonPropertyName("seller_due_date")]
    public long SellerDueDate { get; set; }

    [JsonPropertyName("shipping_proof")]
    public string ShippingProof { get; set; }

    [JsonPropertyName("buyer_address_name")]
    public string BuyerAddressName { get; set; }

    [JsonPropertyName("buyer_address_phone")]
    public string BuyerAddressPhone { get; set; }

    [JsonPropertyName("cancellation_end_date")]
    public object CancellationEndDate { get; set; }

    [JsonPropertyName("order_ratable")]
    public bool OrderRatable { get; set; }

    [JsonPropertyName("order_items")]
    public List<OrderItem> OrderItems { get; set; }

    [JsonPropertyName("buyer_user")]
    public BuyerUser BuyerUser { get; set; }

    [JsonPropertyName("list_type")]
    public long ListType { get; set; }

    [JsonPropertyName("invoice_data_status")]
    public long InvoiceDataStatus { get; set; }

    [JsonPropertyName("seller_invoice_download_status")]
    public long SellerInvoiceDownloadStatus { get; set; }

    [JsonPropertyName("seller_invoice_upload_status")]
    public long SellerInvoiceUploadStatus { get; set; }

    [JsonPropertyName("credit_note_data_status")]
    public long CreditNoteDataStatus { get; set; }
}