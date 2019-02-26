using System;
using System.Collections.Generic;

using Newtonsoft.Json;

namespace WorldState.Data.Models
{
    public class Bounty
    {
        [JsonProperty]
        public string Id { get; private set; }

        [JsonProperty]
        public List<string> RewardPool { get; private set; }

        [JsonProperty]
        public string Type { get; private set; }

        [JsonProperty]
        public List<int> EnemyLevels { get; private set; }

        [JsonProperty]
        public List<int> StandingStages { get; private set; }

        [JsonIgnore]
        public int StageCount => StandingStages.Count;

        [JsonIgnore]
        public int MinimumEnemyLevel => EnemyLevels[0];

        [JsonIgnore]
        public int MaximumEnemyLevel => EnemyLevels[1];
    }
}
