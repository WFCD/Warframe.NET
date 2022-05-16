using Newtonsoft.Json;

namespace WarframeNet.WorldState
{
    public class Simaris
    {
        [JsonProperty]
        public string Target { get; private set; }

        [JsonProperty]
        public bool TargetActive { get; private set; }
    }
}
