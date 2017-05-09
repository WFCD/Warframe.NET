using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace WarframeNET
{
    public class VoidTrader
    {
        public string Id { get; set; }

        [JsonProperty("activation")]
        public DateTime StartTime { get; set; }

        [JsonProperty("expiry")]
        public DateTime EndTime { get; set; }

        public string Character { get; set; }

        public string Location { get; set; }

        public List<VoidTraderItems> Inventory { get; set; }

        internal VoidTrader() { }
    }

    public class VoidTraderItems
    {
        public string Item { get; set; }

        public int Ducats { get; set; }

        public int Credits { get; set; }

        internal VoidTraderItems() { }
    }
}