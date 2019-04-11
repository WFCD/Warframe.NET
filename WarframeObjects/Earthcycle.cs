using System;
using Newtonsoft.Json;

namespace WarframeNET
{
    public class EarthCycle
    {
        public string Id { get; set; }
        public DateTime Expiry { get; set; }
        public bool IsDay { get; set; }

        [JsonProperty("timeLeft")]
        public string TimeRemaining { get; set; }

        public string TimeLeft { get => TimeRemaining; set => TimeRemaining = value; }

        public string TimeOfDay()
        {
            if (IsDay) { return "Day"; }
            else { return "Night"; }
        }
    }
}