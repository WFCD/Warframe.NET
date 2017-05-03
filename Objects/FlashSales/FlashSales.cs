using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace WarframeNET
{
    public class FlashSales
    {
        public List<FlashSale> Content { get; set; }
    }

    public class FlashSale
    {
        public string Item { get; set; }

        public string Id { get; set; }

        public int Discount { get; set; }

        [JsonProperty("expiry")]
        public DateTime EndTime { get; set; }

        public int PremiumOverride { get; set; }

        public bool IsFeatured { get; set; }

        public bool IsPopular { get; set; }
    }
}