using Newtonsoft.Json;
using System;

namespace WorldState.Data.Models
{
    public class Alert
    {
        [JsonProperty]
        public string Id { get; private set; }

        [JsonProperty("activation")]
        public DateTime ActivatedAt { get; private set; }

        [JsonProperty("expiry")]
        public DateTime ExpiredAt { get; private set; }

        [JsonProperty]
        public AlertMission Mission { get; private set; }

        [JsonProperty("active")]
        public bool IsActive { get; private set; }

        [JsonProperty("expired")]
        public bool HasExpired { get; private set; }

        [JsonProperty("eta")]
        public string TimeRemainingString { get; private set; }

        [JsonProperty]
        public string[] RewardTypes { get; private set; }
    }
}