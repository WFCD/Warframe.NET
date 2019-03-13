using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace WorldState.Data.Models
{
    public class VoidTrader
    {
        [JsonProperty]
        public string Id { get; private set; }

        [JsonProperty("activation")]
        public DateTimeOffset ActivatedAt { get; private set; }

        [JsonProperty("expiry")]
        public DateTimeOffset ExpiresAt { get; private set; }

        [JsonProperty]
        public string Character { get; private set; }

        [JsonProperty]
        public string Location { get; private set; }

        [JsonProperty]
        public VoidTraderItem[] Inventory { get; private set; }
    }

    public class VoidTraderItem
    {
        [JsonProperty]
        public string Item { get; private set; }

        [JsonProperty]
        public int Ducats { get; private set; }

        [JsonProperty]
        public int Credits { get; private set; }
    }
}
