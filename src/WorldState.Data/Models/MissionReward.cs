using System;
using System.Collections.Generic;

using Newtonsoft.Json;

namespace WorldState.Data.Models
{
    public class MissionReward
    {
        [JsonProperty]
        public List<string> Items { get; private set; }

        [JsonProperty("countedItems")]
        public List<SystemResource> Resources { get; private set; }

        [JsonProperty]
        public int Credits { get; private set; }

        [JsonProperty]
        public Uri Thumbnail { get; private set; }

        [JsonProperty]
        public int Color { get; private set; }
    }
}
