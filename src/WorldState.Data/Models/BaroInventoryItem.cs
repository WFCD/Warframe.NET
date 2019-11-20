using Newtonsoft.Json;

namespace WorldState.Data.Models
{
    public class BaroInventoryItem
    {
        [JsonProperty]
        public string Name { get; private set; }

        [JsonProperty]
        public int Ducats { get; private set; }

        [JsonProperty]
        public int Credits { get; private set; }
    }
}
