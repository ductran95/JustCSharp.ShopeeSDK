namespace JustCSharp.ShopeeSDK;

public class ShopeeOptions
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