using System;
using System.Linq;

using Newtonsoft.Json;

using WorldState.Data.Interfaces;

namespace WorldState.Data.Models
{
    public class Bounty : ITimeSensitive
    {
        [JsonProperty]
        public string Id { get; private set; }

        [JsonProperty("activation")]
        public DateTimeOffset ActivatedAt { get; private set; }

        [JsonProperty("expiry")]
        public DateTimeOffset ExpiresAt { get; private set; }

        [JsonProperty]
        public string[] RewardPool { get; private set; }

        [JsonProperty]
        public string Type { get; private set; }

        [JsonProperty]
        public int[] EnemyLevels { get; private set; }

        [JsonProperty]
        public int[] StandingStages { get; private set; }

        [JsonIgnore]
        public int StageCount => StandingStages.Length;

        // Use LINQ to avoid exceptions when collection is empty.

        [JsonIgnore]
        public int MinimumEnemyLevel => EnemyLevels.FirstOrDefault();

        [JsonIgnore]
        public int MaximumEnemyLevel => EnemyLevels.LastOrDefault();
    }
}
