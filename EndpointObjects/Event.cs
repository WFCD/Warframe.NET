using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace WarframeNET
{
    public class Event
    {
        public string Id { get; set; }

        public string Description { get; set; }

        public string Tooltip { get; set; }

        public string Faction { get; set; }

        public string Node { get; set; }

        public string VictimNode { get; set; }

        public List<string> ConcurrentNodes { get; set; }

        [JsonProperty("activation")]
        public DateTime StartTime { get; set; }

        [JsonProperty("expiry")]
        public DateTime EndTime { get; set; }

        public List<Reward> Rewards { get; set; }

        public int? SmallInterval { get; set; }

        public int? LargeInterval { get; set; }

        public int MaximumScore { get; set; }

        internal Event() { }
    }
}