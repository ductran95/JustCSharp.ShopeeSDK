using JustCSharp.ShopeeSDK.Response.Shop;
using RestSharp;

namespace JustCSharp.ShopeeSDK.Request.Shop;

public class GetShopInfoRequest : ShopeeRequestBase<GetShopInfoResponse>
{
    public override int? ApiVersion => null;
    public override string ApiUrl => "selleraccount/shop_info/";

    public override Method Method => Method.Get;
}