using System;

using Newtonsoft.Json;

namespace WorldState.Data.Models
{
    public class Invasion
    {
        [JsonProperty]
        public string Id { get; private set; }

        [JsonProperty("desc")]
        public string Name { get; private set; }

        [JsonProperty]
        public string Node { get; private set; }

        [JsonProperty("activation")]
        public DateTimeOffset ActivatedAt { get; private set; }

        [JsonProperty]
        public string AttackingFaction { get; private set; }

        [JsonProperty]
        public string DefendingFaction { get; private set; }

        [JsonProperty("count")]
        public int CurrentValue { get; private set; }

        [JsonProperty("requiredRuns")]
        public int TargetValue { get; private set; }

        [JsonProperty]
        public MissionReward[] AttackerRewards { get; private set; }

        [JsonProperty]
        public MissionReward[] DefenderRewards { get; private set; }

        [JsonProperty("vsInfestation")]
        public bool IsVersusInfestation { get; private set; }
    }
}
