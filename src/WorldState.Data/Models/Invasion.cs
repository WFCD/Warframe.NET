using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace WorldState.Data.Models
{
    public class Invasion
    {
        [JsonProperty]
        public string Id { get; private set; }

        [JsonProperty]
        public string Node { get; set; }

        [JsonProperty("desc")]
        public string Description { get; private set; }

        [JsonProperty("vsInfestion")]
        public bool IsVsInfestion { get; private set; }

        [JsonProperty]
        public string AttackingFaction { get; private set; }

        [JsonProperty]
        public string DefendingFaction { get; private set; }

        [JsonProperty]
        public Reward AttackerReward { get; private set; }

        [JsonProperty]
        public Reward DefenderReward { get; private set; }

        [JsonProperty("activation")]
        public DateTimeOffset StartTime { get; private set; }

        [JsonProperty]
        public int RequiredRuns { get; private set; }

        [JsonProperty]
        public float Completion { get; private set; }

        [JsonProperty("completed")]
        public bool IsCompleted { get; private set; }
    }
}
