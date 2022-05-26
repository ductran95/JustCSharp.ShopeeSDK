using System.Text.Json.Serialization;

namespace JustCSharp.ShopeeSDK.Domain.Finance;

public class OrderLog
{
    [JsonPropertyName("ctime")]
    public long Ctime { get; set; }

    [JsonPropertyName("new_status")]
    public int NewStatus { get; set; }

    [JsonPropertyName("shop_id")]
    public long ShopId { get; set; }

    [JsonPropertyName("mtime")]
    public long Mtime { get; set; }

    [JsonPropertyName("release_time")]
    public long ReleaseTime { get; set; }

    [JsonPropertyName("old_status")]
    public int OldStatus { get; set; }

    [JsonPropertyName("id")]
    public long Id { get; set; }
}