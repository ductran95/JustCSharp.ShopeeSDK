using System.Collections.Generic;
using System.Text.Json.Serialization;
using JustCSharp.ShopeeSDK.Attributes;
using JustCSharp.ShopeeSDK.Response.Finance;
using RestSharp;

namespace JustCSharp.ShopeeSDK.Request.Finance;

public class GetOrderIncomeComponentRequest : ShopeeRequestBase<GetOrderIncomeComponentResponse>
{
    public override string ApiUrl => "accounting/pc/seller_income/income_detail/get_order_income_components";
    public override int? ApiVersion => 4;
    public override Method Method => Method.Post;

    [QueryIgnore]
    [JsonPropertyName("order_id")]
    public long OrderId { get; set; }

    [QueryIgnore]
    [JsonPropertyName("components")]
    public List<int> Components { get; set; } = BuyerComponents;
    
    public static readonly List<int> BuyerComponents = new() { 2, 3, 4, 5 };
    public static readonly List<int> SellerComponents = new() { 2, 6 };
}