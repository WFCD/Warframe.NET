using Newtonsoft.Json;

namespace WorldState.Data.Models
{
    public class Simaris
    {
        [JsonProperty("target")]
        public string Target { get; private set; }

        [JsonProperty("isTargetActive")]
        public bool IsTargetActive { get; private set; }
    }
}
