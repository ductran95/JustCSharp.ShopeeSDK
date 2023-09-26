namespace JustCSharp.ShopeeSDK.Response;

public class ShopeeErrorResponse : IShopeeResponse
{
    public int Code { get; set; }
    public string Message { get; set; }
}