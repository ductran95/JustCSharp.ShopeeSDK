using System;
using System.Runtime.Serialization;

namespace JustCSharp.ShopeeSDK.Exceptions;

public class ShopeeUnauthorizedException : ShopeeException
{
    public ShopeeUnauthorizedException()
    {
    }

    protected ShopeeUnauthorizedException(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }

    public ShopeeUnauthorizedException(string message) : base(message)
    {
    }

    public ShopeeUnauthorizedException(string message, Exception innerException) : base(message, innerException)
    {
    }
}