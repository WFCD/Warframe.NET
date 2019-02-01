using System;
using Newtonsoft.Json;

namespace WorldState.Data.Models
{
    public class DailyDeal
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("item")]
        public string Item { get; set; }

        [JsonProperty("expiry")]
        public DateTime ExpiresAt { get; set; }

        [JsonProperty("originalPrice")]
        public int OriginalPrice { get; set; }

        [JsonProperty("salePrice")]
        public int SalePrice { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("sold")]
        public int Sold { get; set; }

        [JsonProperty("discount")]
        public int Discount { get; set; }
    }
}
