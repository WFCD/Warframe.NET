using System;
using System.Collections.Generic;
using Newtonsoft.Json;


namespace WarframeNET
{
    public class GlobalUpgrades
    {
        public List<GlobalUpgrade> Content { get; set; }
    }

    public class GlobalUpgrade
    {
        public string Operation { get; set; }

        public string Upgrade { get; set; }

        [JsonProperty("activation")]
        public DateTime StartTime { get; set; }

        [JsonProperty("expiry")]
        public DateTime EndTime { get; set; }

        // TODO: FIND THE REAL TYPE
        public object UpgradeOperationValue { get; set; }
    }
}