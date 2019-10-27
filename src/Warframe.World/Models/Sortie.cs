using System;
using Newtonsoft.Json;

namespace Warframe.World.Models
{
    public class Sortie
    {
        [JsonProperty]
        public string Id { get; private set; }

        [JsonProperty("activation")]
        public DateTimeOffset ActivatedAt { get; private set; }

        [JsonProperty("expiry")]
        public DateTimeOffset ExpiresAt { get; private set; }

        [JsonProperty("active")]
        public bool IsActive { get; private set; }

        [JsonProperty]
        public string RewardPool { get; private set; }

        [JsonProperty]
        public SortieVariant[] Variants { get; private set; }

        [JsonProperty]
        public string Boss { get; private set; }

        [JsonProperty]
        public string Faction { get; private set; }

        [JsonProperty("expired")]
        public bool HasExpired { get; private set; }

        [JsonProperty("eta")]
        public string TimeRemaining { get; private set; }
    }
}
