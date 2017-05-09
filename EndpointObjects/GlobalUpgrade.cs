using System;
using Newtonsoft.Json;

namespace WarframeNET
{
    public class GlobalUpgrade
    {
        public string Operation { get; set; }

        public string Upgrade { get; set; }

        public string UpgradeOperationValue { get; set; }

        [JsonProperty("activation")]
        public DateTime StartTime { get; set; }

        [JsonProperty("expiry")]
        public DateTime EndTime { get; set; }

        internal GlobalUpgrade() { }
    }
}