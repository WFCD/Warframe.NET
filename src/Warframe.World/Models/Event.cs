using System;
using Newtonsoft.Json;

namespace Warframe.World.Models
{
    public class Event
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
        public string Description { get; private set; }

        [JsonProperty]
        public string Tooltip { get; private set; }

        [JsonProperty]
        public string[] ConcurrentNodes { get; private set; }

        [JsonProperty]
        public string VictimNode { get; private set; }

        [JsonProperty]
        public MissionReward[] Rewards { get; private set; }

        [JsonProperty("expired")]
        public bool HasExpired { get; private set; }

        [JsonProperty]
        public float Health { get; private set; }

        [JsonProperty]
        public string AffiliatedWith { get; private set; }

        [JsonProperty("jobs")]
        public Bounty[] Bounties { get; private set; }
    }
}
