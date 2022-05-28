using System;

namespace JustCSharp.ShopeeSDK.Attributes;

[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
public class QueryIgnoreAttribute : Attribute
{
}