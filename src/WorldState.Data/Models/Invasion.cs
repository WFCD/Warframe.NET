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
        public String Id { get; private set; }

        [JsonProperty]
        public DateTimeOffset Activation { get; private set; }

        [JsonProperty]
        public String Node { get; private set; }

        [JsonProperty("desc")]
        public String Description { get; private set; }

        public MissionReward AttackerReward { get; private set; }

        [JsonProperty("attackingFaction", ItemConverterType = typeof(StringEnumConverter))]
        public Faction Attacker { get; private set; }

        [JsonProperty]
        public MissionReward DefenderReward { get; private set; }

        [JsonProperty("defendingFaction", ItemConverterType = typeof(StringEnumConverter))]
        public Faction Defender { get; private set; }

        [JsonProperty("vsInfestation")]
        public Boolean HasInfestation { get; private set; }

        [JsonProperty]
        public Int64 Count { get; private set; }

        [JsonProperty]
        public Int64 RequiredRuns { get; private set; }

        [JsonProperty]
        public Double Completion { get; private set; }

        [JsonProperty]
        public Boolean Completed { get; private set; }

        [JsonProperty]
        public String Eta { get; private set; }

        [JsonProperty]
        public List<String> RewardTypes { get; private set; }
    }
}
