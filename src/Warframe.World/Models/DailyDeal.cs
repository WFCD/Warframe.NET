using System;
using Newtonsoft.Json;

namespace Warframe.World.Models
{
    public class DailyDeal
    {
        [JsonProperty]
        public string Id { get; private set; }

        [JsonProperty]
        public string Item { get; private set; }

        [JsonProperty("expiry")]
        public DateTimeOffset ExpiresAt { get; private set; }

        [JsonProperty]
        public int OriginalPrice { get; private set; }

        [JsonProperty]
        public int SalePrice { get; private set; }

        [JsonProperty]
        public int Total { get; private set; }

        [JsonProperty]
        public int Sold { get; private set; }

        [JsonProperty]
        public int Discount { get; private set; }
    }
}
