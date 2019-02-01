using System;
using Newtonsoft.Json;

namespace WorldState.Data.Models
{
    public class DailyDeal
    {
        [JsonProperty("id")]
        public string Id { get; private set; }

        [JsonProperty("item")]
        public string Item { get; private set; }

        [JsonProperty("expiry")]
        public DateTime ExpiresAt { get; private set; }

        [JsonProperty("originalPrice")]
        public int OriginalPrice { get; private set; }

        [JsonProperty("salePrice")]
        public int SalePrice { get; private set; }

        [JsonProperty("total")]
        public int Total { get; private set; }

        [JsonProperty("sold")]
        public int Sold { get; private set; }

        [JsonProperty("discount")]
        public int Discount { get; private set; }
    }
}
