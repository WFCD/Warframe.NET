using System;
using Newtonsoft.Json;

namespace WorldState.Data.Models
{
    public class ConclaveChallenge
    {
        [JsonProperty("id")]
        public string Id { get; private set; }

        [JsonProperty("description")]
        public string Description { get; private set; }

        [JsonProperty("expiry")]
        public DateTimeOffset Expiry { get; private set; }

        [JsonProperty("amount")]
        public int Amount { get; private set; }

        [JsonProperty("mode")]
        public string Mode { get; private set; }

        [JsonProperty("category")]
        public string Category { get; private set; }
        
        [JsonProperty("expired")]
        public bool Expired { get; private set; }

        [JsonProperty("daily")]
        public bool Daily { get; private set; }

        [JsonProperty("rootChallenge")]
        public bool RootChallenge { get; private set; }
    }
}
