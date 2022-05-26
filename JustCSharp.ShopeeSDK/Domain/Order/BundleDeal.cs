using System.Collections.Generic;
using System.Text.Json.Serialization;
using JustCSharp.ShopeeSDK.Domain.Common;

namespace JustCSharp.ShopeeSDK.Domain.Order;

public class BundleDeal
{
    [JsonPropertyName("bundle_deal_id")]
    public long BundleDealId { get; set; }

    [JsonPropertyName("shopid")]
    public long Shopid { get; set; }

    [JsonPropertyName("start_time")]
    public long StartTime { get; set; }

    [JsonPropertyName("end_time")]
    public long EndTime { get; set; }

    [JsonPropertyName("ctime")]
    public object Ctime { get; set; }

    [JsonPropertyName("mtime")]
    public object Mtime { get; set; }

    [JsonPropertyName("status")]
    public long Status { get; set; }

    [JsonPropertyName("rebate_amount")]
    public long RebateAmount { get; set; }

    [JsonPropertyName("usage_limit")]
    public long UsageLimit { get; set; }

    [JsonPropertyName("flag")]
    public long Flag { get; set; }

    [JsonPropertyName("country")]
    public string Country { get; set; }

    [JsonPropertyName("bundle_deal_rule")]
    public BundleDealRule BundleDealRule { get; set; }

    [JsonPropertyName("labels")]
    public List<Label> Labels { get; set; }
}