using System.Text.Json.Serialization;

namespace JustCSharp.ShopeeSDK.Domain.Finance;

public class WalletStatus : IShopeeObject
{
    [JsonPropertyName("withdrawal_no")]
    public long WithdrawalNo { get; set; }

    [JsonPropertyName("description")]
    public string Description { get; set; }

    [JsonPropertyName("max_amount")]
    public double MaxAmount { get; set; }

    [JsonPropertyName("is_active")]
    public bool IsActive { get; set; }

    [JsonPropertyName("limit_data")]
    public WalletStatusLimitData LimitData { get; set; }

    [JsonPropertyName("remaining_withdrawals")]
    public long RemainingWithdrawals { get; set; }

    [JsonPropertyName("num_of_free_times")]
    public long NumOfFreeTimes { get; set; }

    [JsonPropertyName("balance")]
    public double Balance { get; set; }
}