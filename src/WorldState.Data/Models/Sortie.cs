using Newtonsoft.Json;

using System;

using WorldState.Data.Interfaces;

namespace WorldState.Data.Models
{
    public class Sortie : ITimeSensitive
    {
        [JsonProperty]
        public string Id { get; private set; }

        [JsonProperty("activation")]
        public DateTimeOffset ActivatedAt { get; private set; }

        [JsonProperty("expiry")]
        public DateTimeOffset ExpiresAt { get; private set; }

        [JsonProperty]
        public string RewardPool { get; private set; }

        [JsonProperty]
        public SortieVariant[] Variants { get; private set; }

        [JsonProperty]
        public string Boss { get; private set; }

        [JsonProperty]
        public string Faction { get; private set; }
    }
}
