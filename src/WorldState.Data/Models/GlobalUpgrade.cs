using Newtonsoft.Json;

using System;

namespace WorldState.Data.Models
{
    public class GlobalUpgrade
    {
        [JsonProperty("activation")]
        public DateTimeOffset ActivatedAt { get; private set; }

        [JsonProperty("expiry")]
        public DateTimeOffset ExpiresAt { get; private set; }

        [JsonIgnore]
        public bool IsActive => DateTime.Now < ExpiresAt.ToLocalTime() && DateTime.Now >= ActivatedAt.ToLocalTime();

        [JsonProperty]
        public string Upgrade { get; private set; }

        [JsonProperty]
        public string Operation { get; private set; }

        [JsonProperty("upgradeOperationValue")]
        public string OperationValue { get; private set; }

        [JsonProperty("eta")]
        public string TimeRemaining { get; private set; }
    }
}
