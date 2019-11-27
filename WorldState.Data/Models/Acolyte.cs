using System;

using Newtonsoft.Json;

namespace WorldState.Data.Models
{
    public class Acolyte
    {
        [JsonProperty("pid")]
        public string Id { get; private set; }

        [JsonProperty]
        public string AgentType { get; private set; }

        [JsonProperty("locationTag")]
        public string Location { get; private set; }

        [JsonProperty]
        public int Rank { get; private set; }

        [JsonProperty("healthPercent")]
        public float Health { get; private set; }

        [JsonProperty("fleeDamage")]
        public float FleeDamage { get; private set; }

        [JsonProperty]
        public string Region { get; private set; }

        [JsonProperty("lastDiscoveredTime")]
        public DateTimeOffset LastDiscoveryAt { get; private set; }

        [JsonProperty("lastDiscoveredAt")]
        public string LastDiscoveryNode { get; private set; }

        [JsonProperty("isDiscovered")]
        public bool IsRevealed { get; private set; }

        [JsonProperty("isUsingTicketing")]
        public bool UsesTicketing { get; private set; }
    }
}
