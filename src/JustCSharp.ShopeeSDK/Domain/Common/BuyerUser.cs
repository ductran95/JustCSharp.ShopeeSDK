using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace JustCSharp.ShopeeSDK.Domain.Common;

public class BuyerUser
{
    [JsonPropertyName("delivery_succ_count")]
    public long DeliverySuccCount { get; set; }

    [JsonPropertyName("hide_likes")]
    public long HideLikes { get; set; }

    [JsonPropertyName("user_id")]
    public long? UserId { get; set; }

    [JsonPropertyName("user_name")]
    public string UserName { get; set; }

    [JsonPropertyName("portrait")]
    public string Portrait { get; set; }

    [JsonPropertyName("phone_public")]
    public bool PhonePublic { get; set; }

    [JsonPropertyName("language")]
    public string Language { get; set; }

    [JsonPropertyName("cb_option")]
    public long? CbOption { get; set; }

    [JsonPropertyName("ext_info")]
    public ExtInfo ExtInfo { get; set; }

    [JsonPropertyName("delivery_order_count")]
    public long DeliveryOrderCount { get; set; }

    [JsonPropertyName("buyer_rating")]
    public double BuyerRating { get; set; }

    [JsonPropertyName("rating_count")]
    public List<int> RatingCount { get; set; }

    [JsonPropertyName("rating_star")]
    public double RatingStar { get; set; }

    [JsonPropertyName("shop_id")]
    public long? ShopId { get; set; }

    [JsonPropertyName("followed")]
    public bool? Followed { get; set; }
}