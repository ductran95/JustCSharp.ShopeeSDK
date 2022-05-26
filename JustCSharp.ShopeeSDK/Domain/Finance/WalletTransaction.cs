using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace JustCSharp.ShopeeSDK.Domain.Finance;

public class WalletTransaction : IShopeeObject
{
    [JsonPropertyName("withdrawal_split_length")]
    public long WithdrawalSplitLength { get; set; }

    [JsonPropertyName("orders")]
    public List<object> Orders { get; set; }

    [JsonPropertyName("fast_escrow_deduct_id")]
    public string FastEscrowDeductId { get; set; }

    [JsonPropertyName("wallet_type")]
    public long WalletType { get; set; }

    [JsonPropertyName("fast_escrow_group_id")]
    public string FastEscrowGroupId { get; set; }

    [JsonPropertyName("trans_fee")]
    public double TransFee { get; set; }

    [JsonPropertyName("type")]
    public long Type { get; set; }

    [JsonPropertyName("refund_sn")]
    public string RefundSn { get; set; }

    [JsonPropertyName("bank_account_id")]
    public long BankAccountId { get; set; }

    [JsonPropertyName("withdrawal_type")]
    public long WithdrawalType { get; set; }

    [JsonPropertyName("admin_fee")]
    public double AdminFee { get; set; }

    [JsonPropertyName("brand_validation_id")]
    public long BrandValidationId { get; set; }

    [JsonPropertyName("user_id")]
    public long UserId { get; set; }

    [JsonPropertyName("paid_amount")]
    public double PaidAmount { get; set; }

    [JsonPropertyName("fast_escrow_repayment_id")]
    public string FastEscrowRepaymentId { get; set; }

    [JsonPropertyName("withdrawal_total_amount")]
    public double WithdrawalTotalAmount { get; set; }

    [JsonPropertyName("source")]
    public long Source { get; set; }

    [JsonPropertyName("user_name")]
    public string UserName { get; set; }

    [JsonPropertyName("product_name")]
    public string ProductName { get; set; }

    [JsonPropertyName("transaction_id")]
    public long TransactionId { get; set; }

    [JsonPropertyName("item_length")]
    public long ItemLength { get; set; }

    [JsonPropertyName("status")]
    public int Status { get; set; }

    [JsonPropertyName("cancel_time")]
    public long CancelTime { get; set; }

    [JsonPropertyName("fast_escrow_repay_id")]
    public string FastEscrowRepayId { get; set; }

    [JsonPropertyName("cancel_reason")]
    public string CancelReason { get; set; }

    [JsonPropertyName("description")]
    public string Description { get; set; }

    [JsonPropertyName("withdraw_target_type")]
    public long WithdrawTargetType { get; set; }

    [JsonPropertyName("target_id")]
    public string TargetId { get; set; }

    [JsonPropertyName("bank_account_name")]
    public string BankAccountName { get; set; }

    [JsonPropertyName("reason")]
    public string Reason { get; set; }

    [JsonPropertyName("order_sn")]
    public string OrderSn { get; set; }

    [JsonPropertyName("bank_account_number")]
    public string BankAccountNumber { get; set; }

    [JsonPropertyName("ctime")]
    public long Ctime { get; set; }

    [JsonPropertyName("withdrawal_target_type")]
    public long WithdrawalTargetType { get; set; }

    [JsonPropertyName("current_balance")]
    public double CurrentBalance { get; set; }

    [JsonPropertyName("complete_time")]
    public long CompleteTime { get; set; }

    [JsonPropertyName("amount")]
    public double Amount { get; set; }

    [JsonPropertyName("fast_escrow_order_id")]
    public string FastEscrowOrderId { get; set; }

    [JsonPropertyName("fast_escrow_settle_id")]
    public string FastEscrowSettleId { get; set; }

    [JsonPropertyName("withdrawal_split_idx")]
    public long WithdrawalSplitIdx { get; set; }
}