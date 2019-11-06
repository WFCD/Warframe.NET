using Newtonsoft.Json;

using System;

using WorldState.Data.Interfaces;

namespace WorldState.Data.Models
{
    public class Event : ITimeSensitive
    {
        [JsonProperty]
        public string Id { get; private set; }

        [JsonProperty("description")]
        public string Name { get; private set; }

        [JsonProperty("tooltip")]
        public string Description { get; private set; }

        [JsonProperty("activation")]
        public DateTimeOffset ActivatedAt { get; private set; }

        [JsonProperty("expiry")]
        public DateTimeOffset ExpiresAt { get; private set; }

        [JsonProperty]
        public int CurrentScore { get; private set; }

        [JsonProperty]
        public int MaximumScore { get; private set; }

        [JsonProperty]
        public int? SmallInterval { get; private set; }

        [JsonProperty]
        public int? LargeInterval { get; private set; }

        [JsonProperty]
        public string[] ConcurrentNodes { get; private set; }

        [JsonProperty]
        public string VictimNode { get; private set; }

        [JsonProperty("scoreLocTag")]
        public string ScoreTag { get; private set; }

        [JsonProperty]
        public MissionReward[] Rewards { get; private set; }

        [JsonProperty]
        public float Health { get; private set; }

        [JsonProperty("affiliatedWith")]
        public string Affiliation { get; private set; }

        [JsonProperty]
        public MissionObjective[] InterimSteps { get; private set; }

        [JsonProperty("jobs")]
        public Bounty[] Bounties { get; private set; }

        [JsonProperty]
        public string[] RegionDrops { get; private set; }

        [JsonProperty]
        public string[] ArchwingDrops { get; private set; }

        [JsonProperty]
        public bool? IsPersonal { get; private set; }

        [JsonProperty]
        public bool? IsCommunity { get; private set; }
    }
}
