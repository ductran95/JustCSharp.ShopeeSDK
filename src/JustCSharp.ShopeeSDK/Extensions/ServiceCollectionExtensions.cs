using System;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using RestSharp;

namespace JustCSharp.ShopeeSDK.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddShopeeSDK(this IServiceCollection services,
        IConfigurationSection configurationSection)
    {
        services.AddShopeeSDKCore();

        services.Configure<ShopeeOptions>(configurationSection);

        return services;
    }

    public static IServiceCollection AddShopeeSDK(this IServiceCollection services, Action<ShopeeOptions> setupAction)
    {
        services.AddShopeeSDKCore();

        services.Configure(setupAction);

        return services;
    }

    public static IServiceCollection AddShopeeSDKCore(this IServiceCollection services)
    {
        services.TryAddSingleton<IShopeeClient, ShopeeClient>();
        services.TryAddSingleton<IRestClient, RestClient>();

        return services;
    }
}