using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace WorldState.Data.Models
{
    public class Reward
    {
        [JsonProperty]
        public string[] Items { get; private set; }

        [JsonProperty]
        public CountedItem[] CountedItems { get; private set; }

        [JsonProperty]
        public int Credits { get; private set; }
    }
}
