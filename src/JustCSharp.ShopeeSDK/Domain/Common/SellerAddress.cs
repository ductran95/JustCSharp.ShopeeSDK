using System.Text.Json.Serialization;

namespace JustCSharp.ShopeeSDK.Domain.Common;

public class SellerAddress
{
    [JsonPropertyName("address_id")]
    public long AddressId { get; set; }

    [JsonPropertyName("user_id")]
    public long UserId { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("phone")]
    public string Phone { get; set; }

    [JsonPropertyName("country")]
    public string Country { get; set; }

    [JsonPropertyName("state")]
    public string State { get; set; }

    [JsonPropertyName("city")]
    public string City { get; set; }

    [JsonPropertyName("address")]
    public string Address { get; set; }

    [JsonPropertyName("status")]
    public long Status { get; set; }

    [JsonPropertyName("ctime")]
    public long Ctime { get; set; }

    [JsonPropertyName("mtime")]
    public long Mtime { get; set; }

    [JsonPropertyName("zip_code")]
    public string ZipCode { get; set; }

    [JsonPropertyName("def_time")]
    public long DefTime { get; set; }

    [JsonPropertyName("full_address")]
    public string FullAddress { get; set; }

    [JsonPropertyName("district")]
    public string District { get; set; }

    [JsonPropertyName("town")]
    public string Town { get; set; }

    [JsonPropertyName("logistics_status")]
    public long LogisticsStatus { get; set; }

    [JsonPropertyName("icno")]
    public string Icno { get; set; }

    [JsonPropertyName("ext_info")]
    public ExtInfo ExtInfo { get; set; }
}