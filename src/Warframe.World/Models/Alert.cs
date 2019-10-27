using System;
using Newtonsoft.Json;

namespace Warframe.World.Models
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
        public string[] RewardTypes { get; private set; }

        [JsonProperty("eta")]
        public string TimeRemaining { get; private set; }
    }
}