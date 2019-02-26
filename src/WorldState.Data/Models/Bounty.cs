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

        // I don't like surprises, so the following two shortcuts are guarded.
        [JsonIgnore]
        public int? MinimumEnemyLevel => EnemyLevels.Count >= 1 ? (int?) EnemyLevels[0] : null;

        [JsonIgnore]
        public int? MaximumEnemyLevel => EnemyLevels.Count >= 2 ? (int?) EnemyLevels[1] : null;
    }
}
