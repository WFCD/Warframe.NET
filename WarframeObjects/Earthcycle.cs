using System;

namespace WarframeNET
{
    public class Earthcycle
    {
        public long id { get; set; }
        public DateTime expiry { get; set; }
        public bool isDay { get; set; }
        public string timeLeft { get; set; }
    }
}