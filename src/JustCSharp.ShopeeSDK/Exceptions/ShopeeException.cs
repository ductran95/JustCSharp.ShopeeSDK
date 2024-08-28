using System;
using System.Linq;
using System.Runtime.Serialization;
using JustCSharp.ShopeeSDK.Response;
using RestSharp;

namespace JustCSharp.ShopeeSDK.Exceptions;

public class ShopeeException : Exception
{
    public RestRequest Request { get; private set; }
    public RestResponse Response { get; private set; }
    
    public ShopeeException(RestRequest request = null, RestResponse response = null)
    {
        Request = request;
        Response = response;
        AppendRequestData();
    }

    public ShopeeException(string message, RestRequest request = null, RestResponse response = null) : base(message)
    {
        Request = request;
        Response = response;
        AppendRequestData();
    }

    public ShopeeException(string message, Exception innerException, RestRequest request = null, RestResponse response = null) : base(message, innerException)
    {
        Request = request;
        Response = response;
        AppendRequestData();
    }

    protected void AppendRequestData()
    {
        if (Request != null)
        {
            Data[nameof(Request.Resource)] = Request.Resource;
            Data[nameof(Request.Method)] = Request.Method;
            Data[nameof(Request.Attempts)] = Request.Attempts;
            Data[nameof(Request.Parameters)] = Request.Parameters.ToList();
        }
        
        if (Response != null)
        {
            Data[nameof(Response.StatusCode)] = Response.StatusCode;
            Data[nameof(Response.Content)] = Response.Content;
            Data[nameof(Response.ContentLength)] = Response.ContentLength;
            Data[nameof(Response.ContentType)] = Response.ContentType;
            Data[nameof(Response.Headers)] = Response.Headers?.ToList();
            Data[nameof(Response.ResponseUri)] = Response.ResponseUri;
        }
    }
}
