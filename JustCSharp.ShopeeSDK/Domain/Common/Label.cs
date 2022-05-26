using System.Text.Json.Serialization;

namespace JustCSharp.ShopeeSDK.Domain.Common;

public class Label
{
    [JsonPropertyName("language")]
    public string Language { get; set; }

    [JsonPropertyName("value")]
    public string Value { get; set; }
}