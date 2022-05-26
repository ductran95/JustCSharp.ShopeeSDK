using System.Text.Json.Serialization;

namespace JustCSharp.ShopeeSDK.Domain.Common;

public class ExtInfo
{
    [JsonPropertyName("geo_info")]
    public string GeoInfo { get; set; }

    [JsonPropertyName("access")]
    public Access Access { get; set; }

    [JsonPropertyName("disable_new_device_login_otp")]
    public bool DisableNewDeviceLoginOtp { get; set; }

    [JsonPropertyName("gender")]
    public long Gender { get; set; }

    [JsonPropertyName("smid_status")]
    public long SmidStatus { get; set; }

    [JsonPropertyName("ba_check_status")]
    public long BaCheckStatus { get; set; }

    [JsonPropertyName("feed_private")]
    public bool FeedPrivate { get; set; }

    [JsonPropertyName("delivery_address_id")]
    public long DeliveryAddressId { get; set; }

    [JsonPropertyName("birth_timestamp")]
    public long BirthTimestamp { get; set; }

    [JsonPropertyName("holiday_mode_on")]
    public bool HolidayModeOn { get; set; }

    [JsonPropertyName("tos_accepted_time")]
    public long TosAcceptedTime { get; set; }

    [JsonPropertyName("address_info")]
    public AddressInfo AddressInfo { get; set; }
}