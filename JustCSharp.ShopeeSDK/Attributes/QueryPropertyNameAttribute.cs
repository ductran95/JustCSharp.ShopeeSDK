using System;

namespace JustCSharp.ShopeeSDK.Attributes;

[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
public class QueryPropertyNameAttribute : Attribute
{
    public QueryPropertyNameAttribute(string name)
    {
        Name = name;
    }

    public string Name { get; }
}