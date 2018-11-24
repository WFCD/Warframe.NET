using Newtonsoft.Json;

namespace WorldState.Data.Models
{
    public class EventJob
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
    }
}
