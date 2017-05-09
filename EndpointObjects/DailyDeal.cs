using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace WarframeNET
{
    public class DailyDeal
    {
        public string Item { get; set; }

        public string Id { get; set; }

        public int OriginalPrice { get; set; }

        public int SalePrice { get; set; }

        public int Total { get; set; }

        public int Sold { get; set; }

        [JsonProperty("expiry")]
        public DateTime EndTime { get; set; }

        internal DailyDeal() { }
    }
}