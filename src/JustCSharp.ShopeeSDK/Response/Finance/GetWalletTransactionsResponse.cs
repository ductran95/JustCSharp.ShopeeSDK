using JustCSharp.ShopeeSDK.Domain.Finance;

namespace JustCSharp.ShopeeSDK.Response.Finance;

public class GetWalletTransactionsResponse : ShopeeResponseBase<ShopeePagingResponse<WalletTransaction>>
{
}