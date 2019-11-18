using Newtonsoft.Json;
using System;

using WorldState.Data.Interfaces;

namespace WorldState.Data.Models
{
    public class Alert : ITimeSensitive
    {
        [JsonProperty]
        public string Id { get; private set; }

        [JsonProperty("activation")]
        public DateTimeOffset ActivatedAt { get; private set; }

        [JsonProperty("expiry")]
        public DateTimeOffset ExpiresAt { get; private set; }

        [JsonProperty]
        public AlertMission Mission { get; private set; }

        [JsonProperty]
        public string[] RewardTypes { get; private set; }

        [JsonProperty("eta")]
        public string TimeRemaining { get; private set; }
    }
}