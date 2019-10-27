using Newtonsoft.Json;

namespace Warframe.World.Models
{
    public class Bounty
    {
        [JsonProperty]
        public string Id { get; private set; }

        [JsonProperty]
        public string[] RewardPool { get; private set; }

        [JsonProperty]
        public string Type { get; private set; }

        [JsonProperty]
        public int[] EnemyLevels { get; private set; }

        [JsonProperty]
        public int[] StandingStages { get; private set; }

        [JsonIgnore]
        public int StageCount { get { return StandingStages.Length; } }

        [JsonIgnore]
        public int MinimumEnemyLevel { get { return EnemyLevels[0]; } }

        [JsonIgnore]
        public int MaximumEnemyLevel { get { return EnemyLevels[1]; } }
    }
}
