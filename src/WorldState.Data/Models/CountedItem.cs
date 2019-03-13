using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace WorldState.Data.Models
{
    public class CountedItem
    {
        [JsonProperty]
        public int Count { get; private set; }

        [JsonProperty]
        public string Type { get; private set; }
    }
}
