using System;

using Newtonsoft.Json;

using WorldState.Data.Interfaces;

namespace WorldState.Data.Models
{
    public class Nightwave : ITimeSensitive
    {
        [JsonProperty]
        public string Id { get; private set; }

        [JsonProperty]
        public string Tag { get; private set; }

        [JsonProperty("activation")]
        public DateTimeOffset ActivatedAt { get; private set; }

        [JsonProperty("expiry")]
        public DateTimeOffset ExpiresAt { get; private set; }

        [JsonProperty]
        public int Season { get; private set; }

        [JsonProperty]
        public int Phase { get; private set; }

        [JsonProperty]
        public NightwaveChallenge[] PossibleChallenges { get; private set; }

        [JsonProperty]
        public NightwaveChallenge[] ActiveChallenges { get; private set; }

        [JsonProperty]
        public string[] RewardTypes { get; private set; }
    }
}
