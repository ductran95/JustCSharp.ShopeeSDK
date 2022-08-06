namespace JustCSharp.ShopeeSDK;

public class ShopeeSDKOptions
{
    public string ApiUrl { get; set; } = ShopeeConstants.ProdApiUrl;

    public void UseTestEnvironment()
    {
        ApiUrl = ShopeeConstants.TestApiUrl;
    }

    public void UseProdEnvironment()
    {
        ApiUrl = ShopeeConstants.ProdApiUrl;
    }
}