using Newtonsoft.Json;

using System;

using WorldState.Data.Interfaces;

namespace WorldState.Data.Models
{
    public class GlobalUpgrade : ITimeSensitive
    {
        [JsonProperty("start")]
        public DateTimeOffset ActivatedAt { get; private set; }

        [JsonProperty("end")]
        public DateTimeOffset ExpiresAt { get; private set; }

        [JsonProperty]
        public string Upgrade { get; private set; }

        [JsonProperty]
        public string Operation { get; private set; }

        [JsonProperty("upgradeOperationValue")]
        public string OperationValue { get; private set; }
    }
}
