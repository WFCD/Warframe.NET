using System;
using Newtonsoft.Json;

namespace Warframe.World.Models
{
    public class ConclaveChallenge
    {
        [JsonProperty]
        public string Id { get; private set; }

        [JsonProperty]
        public string Description { get; private set; }

        [JsonProperty("expiry")]
        public DateTimeOffset ExpiresAt { get; private set; }

        [JsonProperty]
        public int Amount { get; private set; }

        [JsonProperty]
        public string Mode { get; private set; }

        [JsonProperty]
        public string Category { get; private set; }
        
        [JsonProperty]
        public bool Expired { get; private set; }

        [JsonProperty]
        public bool Daily { get; private set; }

        [JsonProperty]
        public bool RootChallenge { get; private set; }
    }
}
