using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace JustCSharp.ShopeeSDK.Domain.Order;

public class PackageTrackingInfo
{
    [JsonPropertyName("driver_name")]
    public string DriverName { get; set; }

    [JsonPropertyName("driver_phone")]
    public string DriverPhone { get; set; }

    [JsonPropertyName("logistics_logs")]
    public List<object> LogisticsLogs { get; set; }
}