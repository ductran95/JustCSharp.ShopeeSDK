using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace JustCSharp.ShopeeSDK.Domain.Finance;

public class IncomeTransactionHistoryDetail
{
    [JsonPropertyName("amount")]
    public long  Amount { get; set; }

    [JsonPropertyName("buyer_payment_info")]
    public TransactionBuyerPaymentInfo BuyerPaymentInfo { get; set; }

    [JsonPropertyName("ctime")]
    public long  Ctime { get; set; }

    [JsonPropertyName("exchange_rate")]
    public long  ExchangeRate { get; set; }

    [JsonPropertyName("id")]
    public long  Id { get; set; }

    [JsonPropertyName("is_cb_sip_a_shop")]
    public bool IsCbSipAShop { get; set; }

    [JsonPropertyName("order_id")]
    public long OrderId { get; set; }

    [JsonPropertyName("order_logs")]
    public List<OrderLog> OrderLogs { get; set; }

    [JsonPropertyName("payment_info")]
    public TransactionPaymentInfo PaymentInfo { get; set; }

    [JsonPropertyName("payout_amount")]
    public long  PayoutAmount { get; set; }

    [JsonPropertyName("pri_currency_region")]
    public string PriCurrencyRegion { get; set; }

    [JsonPropertyName("price_before_discount")]
    public long  PriceBeforeDiscount { get; set; }

    [JsonPropertyName("rebate_price")]
    public long  RebatePrice { get; set; }

    [JsonPropertyName("release_time")]
    public int ReleaseTime { get; set; }

    [JsonPropertyName("seller_absorbed_discount")]
    public int SellerAbsorbedDiscount { get; set; }

    [JsonPropertyName("shipping_carrier")]
    public string ShippingCarrier { get; set; }

    [JsonPropertyName("source")]
    public string Source { get; set; }

    [JsonPropertyName("status")]
    public int Status { get; set; }

    [JsonPropertyName("using_wallet")]
    public bool UsingWallet { get; set; }

    public class TransactionBuyerPaymentInfo
    {
        [JsonPropertyName("buyer_service_fee")]
        public int BuyerServiceFee { get; set; }

        [JsonPropertyName("coin_used")]
        public int CoinUsed { get; set; }

        [JsonPropertyName("credit_card_promotion")]
        public int CreditCardPromotion { get; set; }

        [JsonPropertyName("final_buyer_txn_fee")]
        public int FinalBuyerTxnFee { get; set; }

        [JsonPropertyName("final_insurance_premium")]
        public int FinalInsurancePremium { get; set; }

        [JsonPropertyName("import_tax")]
        public int ImportTax { get; set; }

        [JsonPropertyName("iof_tax_amount")]
        public int IofTaxAmount { get; set; }

        [JsonPropertyName("merchant_subtotal")]
        public int MerchantSubtotal { get; set; }

        [JsonPropertyName("pay_by_credit_card")]
        public bool PayByCreditCard { get; set; }

        [JsonPropertyName("seller_voucher")]
        public int SellerVoucher { get; set; }

        [JsonPropertyName("shipping_fee")]
        public int ShippingFee { get; set; }

        [JsonPropertyName("shopee_coins_redeemed")]
        public int ShopeeCoinsRedeemed { get; set; }

        [JsonPropertyName("shopee_voucher")]
        public int ShopeeVoucher { get; set; }

        [JsonPropertyName("total_buyer_amount_rate")]
        public int TotalBuyerAmountRate { get; set; }
    }

    public class FeesAndCharges
    {
        [JsonPropertyName("campaign_fee")]
        public int CampaignFee { get; set; }

        [JsonPropertyName("commission_fee")]
        public int CommissionFee { get; set; }

        [JsonPropertyName("credit_card_charge")]
        public int CreditCardCharge { get; set; }

        [JsonPropertyName("escrow_product_gst_amount")]
        public int EscrowProductGstAmount { get; set; }

        [JsonPropertyName("escrow_shipping_gst_amount")]
        public int EscrowShippingGstAmount { get; set; }

        [JsonPropertyName("seller_protection_fee_amount")]
        public int SellerProtectionFeeAmount { get; set; }

        [JsonPropertyName("seller_protection_fee_list")]
        public List<SellerProtectionFeeList> SellerProtectionFeeList { get; set; }

        [JsonPropertyName("service_fee")]
        public int ServiceFee { get; set; }

        [JsonPropertyName("service_fee_list")]
        public List<ServiceFeeList> ServiceFeeList { get; set; }

        [JsonPropertyName("tcs_cgst_amount")]
        public int TcsCgstAmount { get; set; }

        [JsonPropertyName("tcs_igst_amount")]
        public int TcsIgstAmount { get; set; }

        [JsonPropertyName("tcs_sgst_amount")]
        public int TcsSgstAmount { get; set; }

        [JsonPropertyName("tds_amount")]
        public int TdsAmount { get; set; }

        [JsonPropertyName("transaction_fee")]
        public int TransactionFee { get; set; }

        [JsonPropertyName("withholding_cedular_tax")]
        public int WithholdingCedularTax { get; set; }

        [JsonPropertyName("withholding_income_tax")]
        public int WithholdingIncomeTax { get; set; }

        [JsonPropertyName("withholding_income_tax_certificate_url")]
        public WithholdingIncomeTaxCertificateUrl WithholdingIncomeTaxCertificateUrl { get; set; }

        [JsonPropertyName("withholding_product_vat_tax")]
        public int WithholdingProductVatTax { get; set; }

        [JsonPropertyName("withholding_shipping_vat_tax_amount")]
        public int WithholdingShippingVatTaxAmount { get; set; }

        [JsonPropertyName("withholding_turnover_tax")]
        public int WithholdingTurnoverTax { get; set; }

        [JsonPropertyName("withholding_turnover_tax_certificate_url")]
        public List<object> WithholdingTurnoverTaxCertificateUrl { get; set; }

        [JsonPropertyName("withholding_vat_tax")]
        public int WithholdingVatTax { get; set; }

        [JsonPropertyName("withholding_vat_tax_certificate_url")]
        public WithholdingVatTaxCertificateUrl WithholdingVatTaxCertificateUrl { get; set; }
    }

    public class MerchantSubtotal
    {
        [JsonPropertyName("cancel_amount")]
        public int CancelAmount { get; set; }

        [JsonPropertyName("product_price")]
        public int ProductPrice { get; set; }

        [JsonPropertyName("refund_amount")]
        public int RefundAmount { get; set; }

        [JsonPropertyName("sip_subsidy")]
        public int SipSubsidy { get; set; }
    }

    public class OrderLog
    {
        [JsonPropertyName("ctime")]
        public int Ctime { get; set; }

        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("mtime")]
        public int Mtime { get; set; }

        [JsonPropertyName("new_status")]
        public int NewStatus { get; set; }

        [JsonPropertyName("old_status")]
        public int OldStatus { get; set; }

        [JsonPropertyName("release_time")]
        public int ReleaseTime { get; set; }

        [JsonPropertyName("shop_id")]
        public int ShopId { get; set; }
    }

    public class TransactionPaymentInfo
    {
        [JsonPropertyName("buyer_paid_tax_amount")]
        public int BuyerPaidTaxAmount { get; set; }

        [JsonPropertyName("fees_and_charges")]
        public FeesAndCharges FeesAndCharges { get; set; }

        [JsonPropertyName("merchant_subtotal")]
        public MerchantSubtotal MerchantSubtotal { get; set; }

        [JsonPropertyName("rebate_and_voucher")]
        public RebateAndVoucher RebateAndVoucher { get; set; }

        [JsonPropertyName("shipping_subtotal")]
        public ShippingSubtotal ShippingSubtotal { get; set; }
    }

    public class RebateAndVoucher
    {
        [JsonPropertyName("estimated_shipping_rebate_from_shopee")]
        public int EstimatedShippingRebateFromShopee { get; set; }

        [JsonPropertyName("product_discount_rebate_from_shopee")]
        public int ProductDiscountRebateFromShopee { get; set; }

        [JsonPropertyName("seller_absorbed_coin_cash_back")]
        public int SellerAbsorbedCoinCashBack { get; set; }

        [JsonPropertyName("shipping_rebate_from_shopee")]
        public int ShippingRebateFromShopee { get; set; }

        [JsonPropertyName("voucher_code")]
        public int VoucherCode { get; set; }
    }

    public class SellerProtectionFeeList
    {
        [JsonPropertyName("fee_amount")]
        public int FeeAmount { get; set; }

        [JsonPropertyName("transify_key")]
        public string TransifyKey { get; set; }
    }

    public class ServiceFeeList
    {
        [JsonPropertyName("fee_amount")]
        public int FeeAmount { get; set; }

        [JsonPropertyName("rule_display_name")]
        public string RuleDisplayName { get; set; }

        [JsonPropertyName("rule_id")]
        public int RuleId { get; set; }

        [JsonPropertyName("transifykey")]
        public string Transifykey { get; set; }
    }

    public class ShippingSubtotal
    {
        [JsonPropertyName("estimated_shipping_rebate_from_shopee")]
        public int EstimatedShippingRebateFromShopee { get; set; }

        [JsonPropertyName("excess_shipping_fee")]
        public int ExcessShippingFee { get; set; }

        [JsonPropertyName("fsf_seller_protection_fee_claim_amount")]
        public int FsfSellerProtectionFeeClaimAmount { get; set; }

        [JsonPropertyName("is_order_before_escrow_verified")]
        public bool IsOrderBeforeEscrowVerified { get; set; }

        [JsonPropertyName("return_to_seller")]
        public int ReturnToSeller { get; set; }

        [JsonPropertyName("rsf_seller_protection_fee_claim_amount")]
        public int RsfSellerProtectionFeeClaimAmount { get; set; }

        [JsonPropertyName("shipping_fee_discount_3pl")]
        public int ShippingFeeDiscount3pl { get; set; }

        [JsonPropertyName("shipping_fee_paid_by_buyer")]
        public int ShippingFeePaidByBuyer { get; set; }

        [JsonPropertyName("shipping_fee_paid_by_shopee_on_your_behalf")]
        public int ShippingFeePaidByShopeeOnYourBehalf { get; set; }

        [JsonPropertyName("shipping_fee_reverse")]
        public int ShippingFeeReverse { get; set; }

        [JsonPropertyName("shipping_rebate_from_shopee")]
        public int ShippingRebateFromShopee { get; set; }
    }

    public class WithholdingIncomeTaxCertificateUrl
    {
    }

    public class WithholdingVatTaxCertificateUrl
    {
    }
}