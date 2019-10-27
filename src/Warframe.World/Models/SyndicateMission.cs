using System;
using Newtonsoft.Json;

namespace Warframe.World.Models
{
    public class SyndicateMission
    {
        [JsonProperty]
        public string Id { get; private set; }

        [JsonProperty("activation")]
        public DateTimeOffset ActivatedAt { get; private set; }

        [JsonProperty("expiry")]
        public DateTimeOffset ExpiresAt { get; private set; }

        [JsonProperty("active")]
        public bool IsActive { get; private set; }

        [JsonProperty]
        public string Syndicate { get; private set; }

        [JsonProperty]
        public string[] Nodes { get; private set; }

        [JsonProperty("jobs")]
        public Bounty[] Bounties { get; private set; }

        [JsonProperty("eta")]
        public string TimeRemaining { get; private set; }
    }
}
