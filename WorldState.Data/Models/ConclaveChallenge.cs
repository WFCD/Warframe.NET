using System;

using Newtonsoft.Json;

using WorldState.Data.Interfaces;

namespace WorldState.Data.Models
{
    public class ConclaveChallenge : ITimeSensitive
    {
        [JsonProperty]
        public string Id { get; private set; }

        [JsonProperty]
        public string Description { get; private set; }

        [JsonProperty("activation")]
        public DateTimeOffset ActivatedAt { get; private set; }

        [JsonProperty("expiry")]
        public DateTimeOffset ExpiresAt { get; private set; }

        [JsonProperty]
        public int Amount { get; private set; }

        [JsonProperty]
        public string Mode { get; private set; }

        [JsonProperty]
        public string Category { get; private set; }

        [JsonProperty("daily")]
        public bool IsDailyChallenge { get; private set; }

        [JsonProperty("rootChallenge")]
        public bool IsRootChallenge { get; private set; }
    }
}
