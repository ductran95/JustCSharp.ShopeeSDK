using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using JustCSharp.ShopeeSDK.Attributes;
using JustCSharp.ShopeeSDK.Response.Finance;
using RestSharp;

namespace JustCSharp.ShopeeSDK.Request.Finance;

public class GetWalletTransactionsRequest : ShopeeRequestBase<GetWalletTransactionsResponse>
{
    public override string ApiUrl => "finance/get_wallet_transactions_v2";

    public override Method Method => Method.Post;

    [QueryIgnore]
    [JsonPropertyName("wallet_type")]
    public int WalletType { get; set; }
    
    [QueryIgnore]
    [JsonPropertyName("start_time")]
    public long StartTimeInUnix { get; set; }
    
    [QueryIgnore]
    [JsonPropertyName("end_time")]
    public long EndTimeInUnix { get; set; }

    [QueryIgnore]
    [JsonIgnore]
    public DateTimeOffset StartTime
    {
        set => StartTimeInUnix = value.ToUnixTimeSeconds();
    }
    
    [QueryIgnore]
    [JsonIgnore]
    public DateTimeOffset EndTime
    {
        set => EndTimeInUnix = value.ToUnixTimeSeconds();
    }
    
    [QueryIgnore]
    [JsonPropertyName("pagination")]
    public PaginationRequest Pagination { get; set; }

    [QueryIgnore]
    [JsonPropertyName("transaction_types")]
    public List<int> TransactionTypes { get; set; } = AllTransactionTypes;

    public static readonly List<int> AllTransactionTypes = new List<int>
    {
        101, 102, 402, 405, 460, 407, 408, 411, 414, 419, 464, 463, 473, 401, 404, 406, 412, 415, 461, 413, 418, 462,
        465, 468, 471, 472, 502, 501, 503, 450, 301, 505, 504, 302, 451, 303, 203, 201, 4001, 4000, 801, 802
    };

    public class PaginationRequest
    {
        [JsonPropertyName("cursor")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string Cursor { get; set; }

        [JsonPropertyName("direction")]
        public int? Direction { get; set; } = 1;

        [JsonPropertyName("limit")]
        public int Limit { get; set; }
    }
}