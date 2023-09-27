using System.Text.Json.Serialization;

namespace JustCSharp.ShopeeSDK.Domain.Order;

public class ForderLogistic
{
    [JsonPropertyName("order_id")]
    public long OrderId { get; set; }

    [JsonPropertyName("package_number")]
    public string PackageNumber { get; set; }

    [JsonPropertyName("status")]
    public int Status { get; set; }

    [JsonPropertyName("deliver_time")]
    public long DeliverTime { get; set; }

    [JsonPropertyName("channel_id")]
    public long ChannelId { get; set; }

    [JsonPropertyName("actual_pickup_time")]
    public long ActualPickupTime { get; set; }

    [JsonPropertyName("ref1")]
    public string Ref1 { get; set; }

    [JsonPropertyName("type")]
    public int Type { get; set; }

    [JsonPropertyName("pickup_time")]
    public long PickupTime { get; set; }

    [JsonPropertyName("user_id")]
    public long UserId { get; set; }

    [JsonPropertyName("actual_deliver_time")]
    public long ActualDeliverTime { get; set; }

    [JsonPropertyName("logid")]
    public long Logid { get; set; }

    [JsonPropertyName("mtime")]
    public long Mtime { get; set; }

    [JsonPropertyName("consignment_no")]
    public string ConsignmentNo { get; set; }

    [JsonPropertyName("extra_data")]
    public string ExtraData { get; set; }

    [JsonPropertyName("channel_status")]
    public string ChannelStatus { get; set; }

    [JsonPropertyName("ctime")]
    public long Ctime { get; set; }

    [JsonPropertyName("thirdparty_tracking_number")]
    public string ThirdpartyTrackingNumber { get; set; }

    [JsonPropertyName("pickup_cutoff_time")]
    public long PickupCutoffTime { get; set; }

    [JsonPropertyName("logistical_flag")]
    public int LogisticalFlag { get; set; }

    [JsonPropertyName("pickup_attempts")]
    public int PickupAttempts { get; set; }

    [JsonPropertyName("pickup_timeslot")]
    public string PickupTimeslot { get; set; }

    [JsonPropertyName("shipping_proof")]
    public string ShippingProof { get; set; }

    [JsonPropertyName("shipping_proof_status")]
    public int ShippingProofStatus { get; set; }

    [JsonPropertyName("shipping_status")]
    public int ShippingStatus { get; set; }
}