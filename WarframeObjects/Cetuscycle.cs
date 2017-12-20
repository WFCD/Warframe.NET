using System;

namespace WarframeNET
{
    public class CetusCycle
    {
        public string id { get; set; }
        public DateTime expiry { get; set; }
        public bool isDay { get; set; }
        public string timeLeft { get; set; }
        public bool isCetus { get; set; }

        public string TimeOfDay()
        {
            if(isDay) { return "Day"; }
            else { return "Night"; }
        }

    }
}
