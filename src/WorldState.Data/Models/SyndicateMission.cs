using Newtonsoft.Json;

using System;
using System.Collections.Generic;

namespace WorldState.Data.Models
{
    public class SyndicateMission
    {
        [JsonProperty]
        public string Id { get; private set; }

        [JsonProperty("activation")]
        public DateTimeOffset ActivatesAt { get; private set; }

        [JsonProperty("expiry")]
        public DateTimeOffset ExpiresAt { get; private set; }

        [JsonIgnore]
        public bool IsActive => DateTime.Now >= ActivatesAt.ToLocalTime() && DateTime.Now < ExpiresAt.ToLocalTime();

        [JsonProperty]
        public string Syndicate { get; private set; }

        [JsonProperty]
        public List<string> Nodes { get; private set; }

        [JsonProperty("jobs")]
        public List<Bounty> Bounties { get; private set; }

        [JsonProperty("eta")]
        public string TimeRemaining { get; private set; }
    }
}
