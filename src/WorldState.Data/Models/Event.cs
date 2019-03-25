using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace WorldState.Data.Models
{
#pragma warning disable CA1716
    // Name "Event" may conflict with keyword and prevent this class from being used in other CLR languages.
    // But we are doing C#, besides there are @s to save the day anyway.
    // Ignoring warning CA1716.
    public class Event
#pragma warning restore CA1716
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
        public string Description { get; private set; }

        [JsonProperty]
        public string Tooltip { get; private set; }

        [JsonProperty]
        public List<string> ConcurrentNodes { get; private set; }

        [JsonProperty]
        public string VictimNode { get; private set; }

        [JsonProperty]
        public List<MissionReward> Rewards { get; private set; }

        /*
        [JsonProperty("expired")]
        public bool HasExpired { get; private set; }
        */

        [JsonProperty]
        public float Health { get; private set; }

        [JsonProperty]
        public string AffiliatedWith { get; private set; }

        [JsonProperty("jobs")]
        public List<Bounty> Bounties { get; private set; }
    }
}
