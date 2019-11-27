using System;

using Newtonsoft.Json;

using WorldState.Data.Interfaces;

namespace WorldState.Data.Models
{
    public class VoidTrader : ITimeSensitive
    {
        [JsonProperty]
        public string Id { get; private set; }

        [JsonProperty("activation")]
        public DateTimeOffset ActivatedAt { get; private set; }

        [JsonProperty("expiry")]
        public DateTimeOffset ExpiresAt { get; private set; }

        [JsonProperty]
        public string Character { get; private set; }

        [JsonProperty]
        public string Location { get; private set; }

        [JsonProperty]
        public BaroInventoryItem[] Inventory { get; private set; }
    }
}
