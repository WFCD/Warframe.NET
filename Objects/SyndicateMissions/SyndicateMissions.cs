using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace WarframeNET
{
    public class SyndicateMissions
    {
        public List<SyndicateMission> Content { get; set; }
    }

    public class SyndicateMission
    {
        public string Id { get; set; }

        [JsonProperty("activation")]
        public DateTime StartTime { get; set; }

        [JsonProperty("expiry")]
        public DateTime EndTime { get; set; }

        public string Syndicate { get; set; }

        public List<string> Nodes { get; set; }
    }
}