using System;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using RestSharp;

namespace JustCSharp.ShopeeSDK.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddShopeeSDK(this IServiceCollection services,
        IConfigurationSection configurationSection, ServiceLifetime serviceLifetime = ServiceLifetime.Singleton)
    {
        services.AddShopeeSDKCore(serviceLifetime);

        services.Configure<ShopeeSDKOptions>(configurationSection);

        return services;
    }

    public static IServiceCollection AddShopeeSDK(this IServiceCollection services, Action<ShopeeSDKOptions> setupAction, ServiceLifetime serviceLifetime = ServiceLifetime.Singleton)
    {
        services.AddShopeeSDKCore(serviceLifetime);

        services.Configure(setupAction);

        return services;
    }

    internal static IServiceCollection AddShopeeSDKCore(this IServiceCollection services, ServiceLifetime serviceLifetime = ServiceLifetime.Singleton)
    {
        services.TryAdd(new ServiceDescriptor(typeof(IShopeeClient), typeof(ShopeeClient), serviceLifetime));

        return services;
    }
}