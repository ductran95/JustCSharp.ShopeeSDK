using System.Text.Json.Serialization;

namespace JustCSharp.ShopeeSDK.Domain.Finance;

public class WalletStatus
{
    [JsonPropertyName("wallet_available_balance")]
    public decimal WalletAvailableBalance { get; set; }

    [JsonPropertyName("wallet_active_balance")]
    public decimal WalletActiveBalance { get; set; }

    [JsonPropertyName("wallet_blocked_balance")]
    public decimal WalletBlockedBalance { get; set; }

    [JsonPropertyName("shopeepay_available_balance")]
    public decimal ShopeepayAvailableBalance { get; set; }

    [JsonPropertyName("shopeepay_allowed_topupable_balance")]
    public decimal ShopeepayAllowedTopupableBalance { get; set; }

    [JsonPropertyName("bank_min_amount_per_transaction")]
    public decimal BankMinAmountPerTransaction { get; set; }

    [JsonPropertyName("bank_split_amount_threshold")]
    public decimal BankSplitAmountThreshold { get; set; }

    [JsonPropertyName("bank_remaining_daily_withdrawal_limit_amount")]
    public decimal BankRemainingDailyWithdrawalLimitAmount { get; set; }

    [JsonPropertyName("shopeepay_min_amount_per_transaction")]
    public decimal ShopeepayMinAmountPerTransaction { get; set; }

    [JsonPropertyName("shopeepay_split_amount_threshold")]
    public decimal ShopeepaySplitAmountThreshold { get; set; }

    [JsonPropertyName("shopeepay_remaining_daily_withdrawal_limit_amount")]
    public decimal ShopeepayRemainingDailyWithdrawalLimitAmount { get; set; }

    [JsonPropertyName("is_higher_daily_withdrawal_limit_type")]
    public bool IsHigherDailyWithdrawalLimitType { get; set; }

    [JsonPropertyName("daily_withdrawal_limit_amount")]
    public decimal DailyWithdrawalLimitAmount { get; set; }

    [JsonPropertyName("remaining_free_weekly_manual_withdrawal_num")]
    public int RemainingFreeWeeklyManualWithdrawalNum { get; set; }

    [JsonPropertyName("remaining_total_daily_manual_withdrawal_num")]
    public int RemainingTotalDailyManualWithdrawalNum { get; set; }

    [JsonPropertyName("is_seller_withdrawal_maintenance_group_active")]
    public bool IsSellerWithdrawalMaintenanceGroupActive { get; set; }

    [JsonPropertyName("seller_withdrawal_maintenance_group_description")]
    public string SellerWithdrawalMaintenanceGroupDescription { get; set; }

    [JsonPropertyName("is_seller_auto_withdrawal_maintenance_group_active")]
    public bool IsSellerAutoWithdrawalMaintenanceGroupActive { get; set; }

    [JsonPropertyName("seller_auto_withdrawal_maintenance_group_description")]
    public string SellerAutoWithdrawalMaintenanceGroupDescription { get; set; }

    [JsonPropertyName("is_wallet_frozen")]
    public bool IsWalletFrozen { get; set; }

    [JsonPropertyName("has_wallet_password")]
    public bool HasWalletPassword { get; set; }

    [JsonPropertyName("is_seller")]
    public bool IsSeller { get; set; }
}