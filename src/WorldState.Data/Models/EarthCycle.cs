using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace WorldState.Data.Models
{
    public class EarthCycle
    {
        [JsonProperty]
        public string Id { get; private set; }

        [JsonProperty]
        public DateTimeOffset Expiry { get; private set; }

        [JsonProperty]
        public bool IsDay { get; private set; }

        [JsonProperty]
        public string TimeLeft { get; private set; }
    }
}
