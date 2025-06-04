using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace JustCSharp.ShopeeSDK.Domain.Finance;

public class OrderIncomeComponent
{
    [JsonPropertyName("order_info")]
    public OrderInfo OrderInfo { get; set; }

    [JsonPropertyName("seller_income_breakdown")]
    public SellerIncomeBreakdown SellerIncomeBreakdown { get; set; }

    [JsonPropertyName("buyer_payment_breakdown")]
    public BuyerPaymentBreakdown BuyerPaymentBreakdown { get; set; }

    [JsonPropertyName("order_item_list")]
    public OrderItemList OrderItemList { get; set; }

    [JsonPropertyName("adjustment_info")]
    public AdjustmentInfo AdjustmentInfo { get; set; }

    [JsonPropertyName("error_codes")]
    public List<int> ErrorCodes { get; set; }
}

public class OrderInfo
{
    [JsonPropertyName("order_id")]
    public long OrderId { get; set; }

    [JsonPropertyName("order_sn")]
    public string OrderSn { get; set; }

    [JsonPropertyName("is_cb_sip_aff_order")]
    public bool IsCbSipAffOrder { get; set; }

    [JsonPropertyName("shipping_carrier")]
    public string ShippingCarrier { get; set; }

    [JsonPropertyName("released_time")]
    public int ReleasedTime { get; set; }

    [JsonPropertyName("source")]
    public string Source { get; set; }

    [JsonPropertyName("status")]
    public int Status { get; set; }
}

public class SellerIncomeBreakdown
{
    [JsonPropertyName("breakdown")]
    public List<Breakdown> Breakdown { get; set; }
}

public class BuyerPaymentBreakdown
{
    [JsonPropertyName("breakdown")]
    public List<Breakdown> Breakdown { get; set; }
}

public class Breakdown
{
    [JsonPropertyName("field_id")]
    public int FieldId { get; set; }

    [JsonPropertyName("field_name")]
    public string FieldName { get; set; }

    [JsonPropertyName("amount")]
    public double Amount { get; set; }

    [JsonPropertyName("display_name")]
    public string DisplayName { get; set; }

    [JsonPropertyName("sub_breakdown")]
    public List<SubBreakdown> SubBreakdown { get; set; }

    [JsonPropertyName("ext_info")]
    public ExtInfo ExtInfo { get; set; }

    [JsonPropertyName("caption")]
    public string Caption { get; set; }

    /// <summary>
    /// Tổng tiền sản phẩm
    /// </summary>
    public const string ProductPriceField = "MERCHANDISE_SUBTOTAL";
    
    /// <summary>
    /// Tổng phí vận chuyển
    /// </summary>
    public const string ShippingField = "SHIPPING_SUBTOTAL";
    
    /// <summary>
    /// Phụ phí
    /// </summary>
    public const string FeeField = "FEES_AND_CHARGES";
    
    /// <summary>
    /// Tổng phụ dịch vụ giá trị gia tăng cho người mua
    /// </summary>
    public const string ValueAddedServicesSubtotalField = "VALUE_ADDED_SERVICES_SUBTOTAL";
    
    /// <summary>
    /// Doanh Thu Đơn Hàng
    /// </summary>
    public const string EscrowAmountField = "ESCROW_AMOUNT";
    
    /// <summary>
    /// Phí vận chuyển
    /// </summary>
    public const string ShippingFeeField = "SHIPPING_FEE";
    
    /// <summary>
    /// Shopee Voucher
    /// </summary>
    public const string ShopeeVoucherField = "SHOPEE_VOUCHER_DISCOUNT";
    
    /// <summary>
    /// Mã giảm giá của Shop
    /// </summary>
    public const string SellerVoucherField = "SELLER_VOUCHER_DISCOUNT";
    
    /// <summary>
    /// Tổng tiền Thanh toán
    /// </summary>
    public const string BuyerPaidAmountField = "BUYER_PAID_AMOUNT";
}

public class SubBreakdown
{
    [JsonPropertyName("field_id")]
    public int FieldId { get; set; }

    [JsonPropertyName("field_name")]
    public string FieldName { get; set; }

    [JsonPropertyName("amount")]
    public double Amount { get; set; }

    [JsonPropertyName("display_name")]
    public string DisplayName { get; set; }

    [JsonPropertyName("caption")]
    public string Caption { get; set; }

    [JsonPropertyName("link")]
    public string Link { get; set; }

    [JsonPropertyName("ext_info")]
    public ExtInfo ExtInfo { get; set; }
    
    /// <summary>
    /// Giá sản phẩm
    /// </summary>
    public const string ProductPriceField = "PRODUCT_PRICE";
    
    /// <summary>
    /// Phí vận chuyển Người mua trả
    /// </summary>
    public const string ShippingFeePaidByUserField = "SHIPPING_FEE_PAID_BY_BUYER";
    
    /// <summary>
    /// Phí vận chuyển thực tế
    /// </summary>
    public const string ActualShippingFeeField = "ACTUAL_SHIPPING_FEE";
    
    /// <summary>
    /// Phí vận chuyển được trợ giá từ Shopee
    /// </summary>
    public const string ShippingFeePaidByShopeeField = "SHIPPING_REBATE_FROM_SHOPEE";
    
    /// <summary>
    /// Phí cố định
    /// </summary>
    public const string ComissionFeeField = "COMMISSION_FEE";
    
    /// <summary>
    /// Phí dịch vụ PiShip
    /// </summary>
    public const string SellerProtectionFeeField = "SELLER_PROTECTION_FEE";
    
    /// <summary>
    /// Phí thanh toán
    /// </summary>
    public const string TransactionFeeField = "TRANSACTION_FEE";
}

public class OrderItemList
{
    [JsonPropertyName("order_items")]
    public List<OrderItem> OrderItems { get; set; }
}

public class OrderItem
{
    [JsonPropertyName("item_id")]
    public long ItemId { get; set; }

    [JsonPropertyName("model_id")]
    public long ModelId { get; set; }

    [JsonPropertyName("group_id")]
    public string GroupId { get; set; }

    [JsonPropertyName("line_item_id")]
    public long LineItemId { get; set; }

    [JsonPropertyName("price")]
    public long Price { get; set; }

    [JsonPropertyName("amount")]
    public int Amount { get; set; }

    [JsonPropertyName("subtotal")]
    public long Subtotal { get; set; }

    [JsonPropertyName("product_name")]
    public string ProductName { get; set; }

    [JsonPropertyName("product_sku")]
    public string ProductSku { get; set; }

    [JsonPropertyName("product_image")]
    public string ProductImage { get; set; }

    [JsonPropertyName("model_name")]
    public string ModelName { get; set; }

    [JsonPropertyName("model_sku")]
    public string ModelSku { get; set; }

    [JsonPropertyName("sub_type")]
    public int SubType { get; set; }

    [JsonPropertyName("bundle_item_price")]
    public int BundleItemPrice { get; set; }

    [JsonPropertyName("is_add_on_subitem")]
    public bool IsAddOnSubitem { get; set; }

    [JsonPropertyName("is_pre_order")]
    public bool IsPreOrder { get; set; }

    [JsonPropertyName("is_delivery_insured")]
    public bool IsDeliveryInsured { get; set; }

    [JsonPropertyName("returned_qty")]
    public int ReturnedQty { get; set; }

    [JsonPropertyName("cancelled_qty")]
    public int CancelledQty { get; set; }

    [JsonPropertyName("show_return_tag")]
    public bool ShowReturnTag { get; set; }

    [JsonPropertyName("show_cancellation_tag")]
    public bool ShowCancellationTag { get; set; }

    [JsonPropertyName("is_overseas_return_insured")]
    public bool IsOverseasReturnInsured { get; set; }

    [JsonPropertyName("has_spu_vsku")]
    public bool HasSpuVsku { get; set; }
}

public class AdjustmentInfo
{
    [JsonPropertyName("total_adjustment_amount")]
    public int TotalAdjustmentAmount { get; set; }

    [JsonPropertyName("amount_after_adjustment")]
    public long AmountAfterAdjustment { get; set; }
}

public class CommissionFeeInfo
{
    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("amount")]
    public int Amount { get; set; }

    [JsonPropertyName("rule_id")]
    public int RuleId { get; set; }

    [JsonPropertyName("fee_rate")]
    public int FeeRate { get; set; }
}

public class DlvSellerProtectionFeeInfo
{
    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("amount")]
    public int Amount { get; set; }
}

public class ExtInfo
{
    [JsonPropertyName("commission_fee_infos")]
    public List<CommissionFeeInfo> CommissionFeeInfos { get; set; }

    [JsonPropertyName("rsf_seller_protection_fee_info")]
    public RsfSellerProtectionFeeInfo RsfSellerProtectionFeeInfo { get; set; }

    [JsonPropertyName("dlv_seller_protection_fee_info")]
    public DlvSellerProtectionFeeInfo DlvSellerProtectionFeeInfo { get; set; }

    [JsonPropertyName("seller_txn_fee_info")]
    public SellerTxnFeeInfo SellerTxnFeeInfo { get; set; }
}

public class RsfSellerProtectionFeeInfo
{
    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("amount")]
    public int Amount { get; set; }
}

public class SellerTxnFeeInfo
{
    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("amount")]
    public int Amount { get; set; }

    [JsonPropertyName("rule_id")]
    public int RuleId { get; set; }

    [JsonPropertyName("fee_rate")]
    public int FeeRate { get; set; }
}
