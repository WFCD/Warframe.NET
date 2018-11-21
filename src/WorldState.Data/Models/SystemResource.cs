using Newtonsoft.Json;

namespace WorldState.Data.Models
{
    public class SystemResource
    {
        [JsonProperty]
        public int Count { get; private set; }

        [JsonProperty]
        public string Type { get; private set; }
    }
}
