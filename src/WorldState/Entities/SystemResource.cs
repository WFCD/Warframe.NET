using Newtonsoft.Json;

namespace WarframeNet.WorldState
{
    public class SystemResource
    {
        [JsonProperty]
        public int Count { get; private set; }

        [JsonProperty]
        public string Type { get; private set; }
    }
}
