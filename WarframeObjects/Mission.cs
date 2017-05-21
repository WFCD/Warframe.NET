using Newtonsoft.Json;

namespace WarframeNET
{
    /// <summary>
    /// In-game mission.
    /// </summary>
    public class Mission
    {
        /// <summary>
        /// Node of the mission.
        /// </summary>
        public string Node { get; set; }

        /// <summary>
        /// Type of the mission.
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Faction of the mission.
        /// </summary>
        public string Faction { get; set; }

        /// <summary>
        /// Reward on mission completion.
        /// </summary>
        public Reward Reward { get; set; }

        /// <summary>
        /// Minimum enemy level.
        /// </summary>
        [JsonProperty("minEnemyLevel")]
        public int EnemyMinLevel { get; set; }

        /// <summary>
        /// Maximum enemy level.
        /// </summary>
        [JsonProperty("maxEnemyLevel")]
        public int EnemyMaxLevel { get; set; }

        /// <summary>
        /// Is the mission a nightmare?
        /// </summary>
        [JsonProperty("nightmare")]
        public bool IsNightmare { get; set; }

        /// <summary>
        /// Is an archwing required?
        /// </summary>
        [JsonProperty("archwingRequired")]
        public bool IsArchwingRequired { get; set; }

        /// <summary>
        /// Maximum number of waves.
        /// </summary>
        [JsonProperty("maxWaveNum")]
        public int WaveMaxNumber { get; set; }

        internal Mission() { }
    }
}