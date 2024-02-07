using System;
using System.Runtime.Serialization;
using JustCSharp.ShopeeSDK.Response;

namespace JustCSharp.ShopeeSDK.Exceptions;

public class ShopeeException : Exception
{
    public ShopeeException()
    {
    }

    public ShopeeException(string message) : base(message)
    {
    }

    public ShopeeException(string message, Exception innerException) : base(message, innerException)
    {
    }

    public IShopeeResponse Response { get; set; }
}