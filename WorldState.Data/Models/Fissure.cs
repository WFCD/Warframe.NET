using Newtonsoft.Json;

using System;

using WorldState.Data.Enums;
using WorldState.Data.Interfaces;

namespace WorldState.Data.Models
{
    public class Fissure : ITimeSensitive
    {
        [JsonProperty]
        public string Id { get; private set; }

        [JsonProperty("activation")]
        public DateTimeOffset ActivatedAt { get; private set; }

        [JsonProperty("expiry")]
        public DateTimeOffset ExpiresAt { get; private set; }

        [JsonProperty]
        public string Node { get; private set; }

        [JsonProperty]
        public string MissionType { get; private set; }

        [JsonProperty]
        public string Enemy { get; private set; }

        [JsonProperty("tierNum")]
        public FissureTier Tier { get; private set; }

        [JsonProperty("tier")]
        public string TierName { get; private set; }
    }
}
