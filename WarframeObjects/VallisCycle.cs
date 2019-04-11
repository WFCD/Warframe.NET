using System;
using Newtonsoft.Json;

namespace WarframeNET
{
    public class VallisCycle
    {
        public string Id { get; set; }

        public DateTime? Expiry { get; set; }

        public bool IsWarm { get; set; }

        [JsonProperty("timeLeft")]
        public string TimeRemaining { get; set; }

        public string ShortString { get; set; }
    }
}