using System;
using System.Runtime.Serialization;

namespace JustCSharp.ShopeeSDK.Exceptions;

public class ShopeeUnauthorizedException : ShopeeException
{
    public ShopeeUnauthorizedException()
    {
    }

    public ShopeeUnauthorizedException(string message) : base(message)
    {
    }

    public ShopeeUnauthorizedException(string message, Exception innerException) : base(message, innerException)
    {
    }
}