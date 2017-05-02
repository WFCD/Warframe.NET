using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace WarframeNET
{
    public class Alerts
    {
        /// <summary>
        /// Get a collection of Alerts.
        /// </summary>
        public List<Alert> Content { get; set; }
    }

    public class Alert
    {
        public string Id { get; set; }

        [JsonProperty("activation")]
        public DateTime StartTime { get; set; }

        [JsonProperty("expiry")]
        public DateTime EndTime { get; set; }

        public Mission Mission { get; set; }
    }

    public class Mission
    {
        public string Node { get; set; }

        public string Type { get; set; }

        public string Faction { get; set; }

        public Reward Reward { get; set; }

        [JsonProperty("minEnemyLevel")]
        public int EnemyMinLevel { get; set; }

        [JsonProperty("maxEnemyLevel")]
        public int EnemyMaxLevel { get; set; }

        [JsonProperty("nightmare")]
        public bool IsNightmare { get; set; }

        [JsonProperty("archwingRequired")]
        public bool IsArchwingRequired { get; set; }

        [JsonProperty("maxWaveNum")]
        public int WaveMaxNumber { get; set; }
    }
}