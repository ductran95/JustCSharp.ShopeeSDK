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
        services.AddShopeeSDK(configurationSection.Bind, serviceLifetime);

        return services;
    }

    public static IServiceCollection AddShopeeSDK(this IServiceCollection services, Action<ShopeeSDKOptions> configure = null, ServiceLifetime serviceLifetime = ServiceLifetime.Singleton)
    {
        var options = new ShopeeSDKOptions();

        if (configure != null)
        {
            configure.Invoke(options);
        }
        
        services.TryAddSingleton(options);

        services.TryAdd(new ServiceDescriptor(typeof(IShopeeClient), typeof(ShopeeClient), serviceLifetime));

        return services;
    }
}