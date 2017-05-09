using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace WarframeNET
{
    public class ConclaveChallenge
    {
        public string Id { get; set; }

        public string Description { get; set; }

        [JsonProperty("expiry")]
        public DateTime EndTime { get; set; }

        public int Amount { get; set; }

        public string Mode { get; set; }

        public string Category { get; set; }

        internal ConclaveChallenge() { }
    }
}