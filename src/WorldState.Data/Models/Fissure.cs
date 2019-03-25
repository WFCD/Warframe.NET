using Newtonsoft.Json;
using System;
using WorldState.Data.Enums;

namespace WorldState.Data.Models
{
    public class Fissure
    {
        [JsonProperty]
        public string Id { get; private set; }

        [JsonProperty("activation")]
        public DateTimeOffset ActivatesAt { get; private set; }

        [JsonProperty("expiry")]
        public DateTimeOffset ExpiresAt { get; private set; }

        [JsonIgnore]
        public bool IsActive => DateTime.Now >= ActivatesAt.ToLocalTime() && DateTime.Now<ExpiresAt.ToLocalTime();

        [JsonProperty]
        public string Node { get; private set; }

        [JsonProperty]
        public string MissionType { get; private set; }

        [JsonProperty]
        public string Enemy { get; private set; }

        [JsonProperty("tierNum")]
        public FissureTier Tier { get; private set; }

        // Todo: Is this property really necessary?
        // Everything's ToString'ed before printing. A single property "Tier" should be enough.
        [JsonProperty("tier")]
        public string TierName { get; private set; }

        [JsonProperty("expired")]
        public bool HasExpired { get; private set; }

        [JsonProperty("eta")]
        public string TimeRemaining { get; private set; }
    }
}
