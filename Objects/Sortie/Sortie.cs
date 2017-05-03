using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace WarframeNET
{
    public class Sortie
    {
        public string Id { get; set; }

        [JsonProperty("activation")]
        public DateTime StartTime { get; set; }

        [JsonProperty("expiry")]
        public DateTime EndTime { get; set; }

        public string RewardPool { get; set; }

        public List<SortieVariant> Variants { get; set; }

        public string Boss { get; set; }

        public string Faction { get; set; }

        internal Sortie() { }
    }

    public class SortieVariant
    {
        [Obsolete("This property is deprecated. Please use Sorties.Boss instead.", true)]
        public string Boss { get; set; }

        [Obsolete("This property is deprecated. Please use SortieVariant.Node instead.", true)]
        public string Planet { get; set; }

        public string MissionType { get; set; }

        public string Modifier { get; set; }

        public string Node { get; set; }

        internal SortieVariant() { }
    }
}

