using System;

namespace WarframeNET
{
    public class CetusCycle
    {
        public string Id { get; set; }
        public DateTime Expiry { get; set; }
        public bool IsDay { get; set; }
        public string TimeLeft { get; set; }
        public bool IsCetus { get; set; }

        public string TimeOfDay()
        {
            return IsDay ? "Day" : "Night";
        }
    }
}
