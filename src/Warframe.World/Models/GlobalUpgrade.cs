using System;
using Newtonsoft.Json;

namespace Warframe.World.Models
{
    public class GlobalUpgrade
    {
        [JsonProperty("activation")]
        public DateTimeOffset ActivatedAt { get; private set; }

        [JsonProperty("expiry")]
        public DateTimeOffset ExpiresAt { get; private set; }

        [JsonProperty]
        public string Upgrade { get; private set; }

        [JsonProperty]
        public string Operation { get; private set; }

        [JsonProperty("upgradeOperationValue")]
        public string OperationValue { get; private set; }

        [JsonProperty("expired")]
        public bool HasExpired { get; private set; }

        [JsonProperty("eta")]
        public string TimeRemaining { get; private set; }
    }
}
