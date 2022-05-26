namespace JustCSharp.ShopeeSDK.Response;

public class ShopeeErrorResponse : IShopeeResponse
{
    public int ErrorCode { get; set; }
    public string Message { get; set; }
}