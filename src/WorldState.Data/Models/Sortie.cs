using Newtonsoft.Json;

using System;
using System.Collections.Generic;

using Newtonsoft.Json.Converters;

using WorldState.Data.Enums;

namespace WorldState.Data.Models
{
    public class Sortie
    {
        [JsonProperty]
        public string Id { get; private set; }

        [JsonProperty("activation")]
        public DateTimeOffset ActivatesAt { get; private set; }

        [JsonProperty("expiry")]
        public DateTimeOffset ExpiresAt { get; private set; }

        [JsonIgnore]
        public bool IsActive => DateTime.Now >= ActivatesAt.ToLocalTime() && DateTime.Now < ExpiresAt.ToLocalTime();

        [JsonProperty]
        public string RewardPool { get; private set; }

        [JsonProperty]
        public List<SortieVariant> Variants { get; private set; }

        [JsonProperty]
        public string Boss { get; private set; }

        [JsonProperty(ItemConverterType = typeof(StringEnumConverter))]
        public Faction Faction { get; private set; }

        /*
        [JsonProperty("expired")]
        public bool HasExpired { get; private set; }
        */

        [JsonProperty("eta")]
        public string TimeRemaining { get; private set; }
    }
}
