using System.Collections.Generic;
using System.Text.Json.Serialization;
using JustCSharp.ShopeeSDK.Domain.Finance;

namespace JustCSharp.ShopeeSDK.Response.Finance;

public class GetWalletTransactionsResponse : ShopeeResponseBase<GetWalletTransactionsResponse.DetailResponse>
{
    public class DetailResponse
    {
        [JsonPropertyName("wallet_type")]
        public int WalletType { get; set; }

        [JsonPropertyName("pagination")]
        public Pagination Pagination { get; set; }

        [JsonPropertyName("prev_pagination")]
        public PrevPagination PrevPagination { get; set; }

        [JsonPropertyName("transactions")]
        public List<WalletTransaction> Transactions { get; set; }
    }
    
    public class Pagination
    {
        [JsonPropertyName("direction")]
        public int Direction { get; set; }

        [JsonPropertyName("has_more")]
        public bool HasMore { get; set; }

        [JsonPropertyName("cursor_type")]
        public int CursorType { get; set; }

        [JsonPropertyName("cursor")]
        public string Cursor { get; set; }

        [JsonPropertyName("limit")]
        public int Limit { get; set; }

        [JsonPropertyName("is_desc")]
        public bool IsDesc { get; set; }
    }

    public class PrevPagination
    {
        [JsonPropertyName("direction")]
        public int Direction { get; set; }

        [JsonPropertyName("has_more")]
        public bool HasMore { get; set; }

        [JsonPropertyName("cursor_type")]
        public int CursorType { get; set; }

        [JsonPropertyName("cursor")]
        public string Cursor { get; set; }

        [JsonPropertyName("limit")]
        public int Limit { get; set; }

        [JsonPropertyName("is_desc")]
        public bool IsDesc { get; set; }
    }
}

