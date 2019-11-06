using Newtonsoft.Json;

using System;

using WorldState.Data.Interfaces;

namespace WorldState.Data.Models
{
    public class FlashSale : ITimeSensitive
    {
        [JsonProperty]
        public string Id { get; private set; }

        [JsonProperty]
        public string Item { get; private set; }

        [JsonProperty("activation")]
        public DateTimeOffset ActivatedAt { get; private set; }

        [JsonProperty("expiry")]
        public DateTimeOffset ExpiresAt { get; private set; }

        [JsonProperty]
        public int Discount { get; private set; }

        [JsonProperty]
        public int RegularOverride { get; private set; }

        [JsonProperty]
        public int PremiumOverride { get; private set; }

        [JsonProperty]
        public bool IsFeatured { get; private set; }

        [JsonProperty]
        public bool IsPopular { get; private set; }
    }
}
