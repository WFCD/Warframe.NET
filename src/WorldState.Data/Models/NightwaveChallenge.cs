using System;

using Newtonsoft.Json;

using WorldState.Data.Interfaces;

namespace WorldState.Data.Models
{
    public class NightwaveChallenge : ITimeSensitive
    {
        [JsonProperty]
        public string Id { get; private set; }

        [JsonProperty("title")]
        public string Name { get; private set; }

        [JsonProperty("desc")]
        public string Description { get; private set; }

        [JsonProperty("activation")]
        public DateTimeOffset ActivatedAt { get; private set; }

        [JsonProperty("expiry")]
        public DateTimeOffset ExpiresAt { get; private set; }

        [JsonProperty]
        public int Reputation { get; private set; }

        [JsonProperty("isDaily")]
        public bool IsDailyChallenge { get; private set; }

        [JsonProperty("isElite")]
        public bool IsEliteChallenge { get; private set; }
    }
}
