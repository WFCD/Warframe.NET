using Newtonsoft.Json;

using System;
using System.Collections.Generic;

namespace WorldState.Data.Models
{
    public class Alert
    {
        [JsonProperty]
        public string Id { get; private set; }

        [JsonProperty("activation")]
        public DateTimeOffset ActivatedAt { get; private set; }

        [JsonProperty("expiry")]
        public DateTimeOffset ExpiresAt { get; private set; }

        [JsonProperty]
        public AlertMission Mission { get; private set; }

        [JsonProperty("active")]
        public bool IsActive { get; private set; }

        [JsonProperty("expired")]
        public bool HasExpired { get; private set; }

        [JsonProperty]
        public List<String> RewardTypes { get; private set; }

        [JsonProperty("eta")]
        public string TimeRemaining { get; private set; }
    }
}
