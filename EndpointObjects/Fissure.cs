using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace WarframeNET
{
    public class Fissure
    {
        public string Id { get; set; }

        public string Node { get; set; }

        public string MissionType { get; set; }

        public string Enemy { get; set; }

        public string Tier { get; set; }

        [JsonProperty("tierNum")]
        public int TierNumber { get; set; }

        [JsonProperty("activation")]
        public DateTime StartTime { get; set; }

        [JsonProperty("expiry")]
        public DateTime EndTime { get; set; }

        internal Fissure() { }
    }
}