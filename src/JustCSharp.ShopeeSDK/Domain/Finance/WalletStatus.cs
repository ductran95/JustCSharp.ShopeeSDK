using System.Text.Json.Serialization;

namespace JustCSharp.ShopeeSDK.Domain.Finance;

public class WalletStatus
{
    [JsonPropertyName("withdrawal_no")]
    public int WithdrawalNo { get; set; }

    [JsonPropertyName("description")]
    public string Description { get; set; }

    [JsonPropertyName("max_amount")]
    public int MaxAmount { get; set; }

    [JsonPropertyName("is_active")]
    public bool IsActive { get; set; }

    [JsonPropertyName("limit_data")]
    public WalletLimitData LimitData { get; set; }

    [JsonPropertyName("remaining_withdrawals")]
    public int RemainingWithdrawals { get; set; }

    [JsonPropertyName("active_balance")]
    public int ActiveBalance { get; set; }

    [JsonPropertyName("num_of_free_times")]
    public int NumOfFreeTimes { get; set; }

    [JsonPropertyName("balance")]
    public int Balance { get; set; }

    public class WalletLimitData
    {
        [JsonPropertyName("min_limit")]
        public int MinLimit { get; set; }

        [JsonPropertyName("limit")]
        public int Limit { get; set; }

        [JsonPropertyName("is_higher_limit")]
        public int IsHigherLimit { get; set; }
    }
}