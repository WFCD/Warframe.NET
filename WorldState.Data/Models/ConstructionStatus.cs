using Newtonsoft.Json;

namespace WorldState.Data.Models
{
    public class ConstructionStatus
    {
        [JsonProperty]
        public string Id { get; private set; }

        [JsonProperty("fomorianProgress")]
        public float Fomorian { get; private set; }

        [JsonProperty("razorbackProgress")]
        public float Razorback { get; private set; }
    }
}
