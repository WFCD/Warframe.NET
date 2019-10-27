using Newtonsoft.Json;

namespace Warframe.World.Models
{
    public class AlertMission
    {
        [JsonProperty]
        public string Node { get; private set; }

        [JsonProperty]
        public string Type { get; private set; }

        [JsonProperty]
        public string Faction { get; private set; }

        [JsonProperty]
        public MissionReward Reward { get; private set; }

        [JsonProperty("minEnemyLevel")]
        public int MinimumEnemyLevel { get; private set; }
        
        [JsonProperty("maxEnemyLevel")]
        public int MaximumEnemyLevel { get; private set; }

        [JsonProperty("maxWaveNum")]
        public int MaximumWaveNumber { get; private set; }

        [JsonProperty("nightmare")]
        public bool IsNightmare { get; private set; }

        [JsonProperty("archwingRequired")]
        public bool IsArchwingRequired { get; private set; }
    }
}
