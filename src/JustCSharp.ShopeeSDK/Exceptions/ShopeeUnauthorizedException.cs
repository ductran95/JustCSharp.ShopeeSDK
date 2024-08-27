using System;
using System.Runtime.Serialization;
using RestSharp;

namespace JustCSharp.ShopeeSDK.Exceptions;

public class ShopeeUnauthorizedException : ShopeeException
{
    public ShopeeUnauthorizedException(RestRequest request = null, RestResponse response = null) : base(request, response)
    {
    }

    public ShopeeUnauthorizedException(string message, RestRequest request = null, RestResponse response = null) : base(message, request, response)
    {
    }

    public ShopeeUnauthorizedException(string message, Exception innerException, RestRequest request = null, RestResponse response = null) : base(message, innerException, request, response)
    {
    }
}