using Newtonsoft.Json;
using System;

namespace WorldState.Data.Models
{
    public class Event
    {
        [JsonProperty]
        public string Id { get; private set; }

        [JsonProperty("activation")]
        public DateTimeOffset ActivatedAt { get; private set; }

        [JsonProperty("expiry")]
        public DateTimeOffset ExpiresAt { get; private set; }

        [JsonProperty("startString")]
        public string TimeSinceStartString { get; private set; }

        [JsonProperty("active")]
        public bool IsActive { get; private set; }

        [JsonProperty]
        public string Description { get; private set; }

        [JsonProperty]
        public string Tooltip { get; private set; }

        // TODO: Find correct type for this.
        [JsonProperty]
        public object[] ConcurrentNodes { get; private set; }

        [JsonProperty]
        public string VictimNode { get; private set; }

        // TODO: Find correct type for this.
        [JsonProperty]
        public object[] Rewards { get; private set; }

        [JsonProperty("expired")]
        public bool HasExpired { get; private set; }

        [JsonProperty]
        public float Health { get; private set; }

        [JsonProperty]
        public string AffiliatedWith { get; private set; }

        [JsonProperty]
        public EventJob[] Jobs { get; private set; }

        [JsonProperty("asString")]
        public string EventAsString { get; private set; }
    }
}
