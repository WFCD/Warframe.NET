using System;
using Newtonsoft.Json;

namespace WorldState.Data.Models
{
    public class ConclaveChallenge
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("expiry")]
        public DateTime Expiry { get; set; }

        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("mode")]
        public string Mode { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }
        
        [JsonProperty("expired")]
        public bool Expired { get; set; }

        [JsonProperty("daily")]
        public bool Daily { get; set; }

        [JsonProperty("rootChallenge")]
        public bool RootChallenge { get; set; }
    }
}
