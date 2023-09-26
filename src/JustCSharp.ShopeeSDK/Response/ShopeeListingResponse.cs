using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace JustCSharp.ShopeeSDK.Response;

public class ShopeeListingResponse<T> where T : class
{
    [JsonPropertyName("list")]
    public List<T> List { get; set; }
}