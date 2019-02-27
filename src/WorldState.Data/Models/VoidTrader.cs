using System;

using Newtonsoft.Json;

namespace WorldState.Data.Models
{
    public class VoidTrader
    {
        [JsonProperty]
        public string Id { get; private set; }

        [JsonProperty("activation")]
        public DateTimeOffset ActivatesAt { get; private set; }

        [JsonProperty("expiry")]
        public DateTimeOffset ExpiresAt { get; private set; }

        // Should compare with DateTime.Now?
        [JsonProperty("active")]
        public bool IsActive { get; private set; }

        [JsonProperty("character")]
        public string CharacterName { get; private set; }

        [JsonProperty]
        public string Location { get; private set; }

        // What is this?
        [JsonProperty]
        protected string PsId { get; private set; }

        // Todo: Inventory. No docs.
    }
}
