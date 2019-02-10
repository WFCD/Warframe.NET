using Newtonsoft.Json;

namespace WorldState.Data.Models
{
    public class Simaris
    {
        [JsonProperty]
        public string Target { get; private set; }

        [JsonProperty]
        public bool TargetActive { get; private set; }
    }
}
