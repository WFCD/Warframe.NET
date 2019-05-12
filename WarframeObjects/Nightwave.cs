using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace WarframeNET
{
    public class Nightwave : IFiniteEvent
    {
        public string Id { get; set; }

        public DateTime Activation { get; set; }

        public string StartString { get; set; }

        [JsonProperty("expiry")]
        public DateTime EndTime { get; set; }

        [JsonProperty("active")]
        public bool IsActive { get; set; }

        public int Season { get; set; }

        public string Tag { get; set; }

        public int Phase { get; set; }

        public IEnumerable<NightwaveChallenge> PossibleChallenges { get; set; }

        public IEnumerable<NightwaveChallenge> AvailableChallenges { get; set; }

        public IEnumerable<string> RewardTypes { get; set; }
    }

    public class NightwaveChallenge : IFiniteEvent
    {
        public string Id { get; set; }

        public DateTime Activation { get; set; }

        public string StartString { get; set; }

        [JsonProperty("expiry")]
        public DateTime EndTime { get; set; }

        [JsonProperty("active")]
        public bool IsActive { get; set; }

        public bool IsDaily { get; set; }

        public bool IsElite { get; set; }

        [JsonProperty("desc")]
        public string Description { get; set; }

        public string Title { get; set; }

        public int Reputation { get; set; }
    }
}
