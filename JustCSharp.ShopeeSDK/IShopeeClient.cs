using System.Threading;
using System.Threading.Tasks;
using JustCSharp.ShopeeSDK.Request;
using JustCSharp.ShopeeSDK.Response;

namespace JustCSharp.ShopeeSDK;

public interface IShopeeClient
{
    T Execute<T>(IShopeeRequest<T> request) where T : IShopeeResponse;

    Task<T> ExecuteAsync<T>(IShopeeRequest<T> request, CancellationToken cancellationToken = default)
        where T : IShopeeResponse;

    string GetPasswordHash(string password);
}