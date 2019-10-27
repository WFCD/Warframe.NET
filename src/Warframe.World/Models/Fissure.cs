using System;
using Newtonsoft.Json;
using Warframe.World.Enums;

namespace Warframe.World.Models
{
    public class Fissure
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
        public string Node { get; private set; }

        [JsonProperty]
        public string MissionType { get; private set; }

        [JsonProperty]
        public string Enemy { get; private set; }

        [JsonProperty("tierNum")]
        public FissureTier Tier { get; private set; }

        [JsonProperty("tier")]
        public string TierName { get; private set; }

        [JsonProperty("expired")]
        public bool HasExpired { get; private set; }

        [JsonProperty("eta")]
        public string TimeRemaining { get; private set; }
    }
}
