using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace WarframeNET
{
    public class Alerts
    {
        public List<Alert> Content { get; set; }

        internal Alerts() { }
    }

    public class Alert
    {
        public string Id { get; set; }

        [JsonProperty("activation")]
        public DateTime StartTime { get; set; }

        [JsonProperty("expiry")]
        public DateTime EndTime { get; set; }

        public Mission Mission { get; set; }

        internal Alert() { }
    }
}