using System;
using System.Collections.Generic;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;

using WorldState.Data.Enums;

namespace WorldState.Data.Models
{
    [JsonObject(NamingStrategyType = typeof(CamelCaseNamingStrategy), ItemNullValueHandling = NullValueHandling.Ignore)]
    public class Invasion
    {
        [JsonProperty]
        public string Id { get; private set; }

        [JsonProperty]
        public DateTimeOffset ActivatesAt { get; private set; }

        [JsonProperty]
        public string Node { get; private set; }

        [JsonProperty("desc")]
        public string Description { get; private set; }

        [JsonProperty]
        public MissionReward AttackerReward { get; private set; }

        [JsonProperty("attackingFaction", ItemConverterType = typeof(StringEnumConverter))]
        public Faction Attacker { get; private set; }

        [JsonProperty]
        public MissionReward DefenderReward { get; private set; }

        [JsonProperty("defendingFaction", ItemConverterType = typeof(StringEnumConverter))]
        public Faction Defender { get; private set; }

        [JsonProperty("vsInfestation")]
        public bool HasInfestation { get; private set; }

        [JsonProperty]
        public long Count { get; private set; }

        [JsonProperty]
        public long RequiredRuns { get; private set; }

        [JsonProperty]
        public double Completion { get; private set; }

        [JsonProperty]
        public bool Completed { get; private set; }

        [JsonProperty]
        public string Eta { get; private set; }

        [JsonProperty]
        public List<string> RewardTypes { get; private set; }
    }
}
