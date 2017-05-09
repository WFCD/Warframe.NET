using System;
using Newtonsoft.Json;

namespace WarframeNET
{
    public class Invasion
    {
        public string Id { get; set; }

        public string Node { get; set; }

        [JsonProperty("desc")]
        public string Description { get; set; }

        public bool IsVsInfestation { get; set; }

        public string AttackingFaction { get; set; }

        public string DefendingFaction { get; set; }

        public Reward AttackerReward { get; set; }

        public Reward DefenderReward { get; set; }

        [JsonProperty("activation")]
        public DateTime StartTime { get; set; }

        public int Count { get; set; }

        public int RequiredRuns { get; set; }

        public float Completion { get; set; }

        public bool IsCompleted { get; set; }

        internal Invasion() { }
    }
}