using Newtonsoft.Json;

namespace WorldState.Data.Models
{
    public class MissionObjective
    {
        [JsonProperty]
        public int Goal { get; private set; }

        [JsonProperty]
        public MissionReward[] Rewards { get; private set; }

        [JsonProperty]
        public MissionMessage[] Messages { get; private set; }

        [JsonProperty]
        public int WinnerCount { get; private set; }
    }
}
