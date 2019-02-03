using System;
using Newtonsoft.Json;

namespace WarframeNET
{
    public class CetusCycle
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("expiry")]
        public DateTime? EndTime { get; set; }

        [JsonProperty("isDay")]
        public bool IsDay { get; set; }

        [JsonProperty("timeLeft")]
        public string TimeRemaining { get; set; }

        [JsonProperty("isCetus")]
        public bool IsCetus { get; set; }

        public string TimeOfDay()
        {
            if (IsDay) { return "Day"; }

            return "Night";
        }
    }
}
