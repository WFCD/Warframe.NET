using Newtonsoft.Json;

namespace WorldState.Data.Models
{
    public class FleetConstruction
    {
        [JsonProperty]
        public string Id { get; private set; }

        /// <summary>
        /// Fomorian fleet construction progress (percent).
        /// </summary>
        [JsonProperty("fomorianProgress")]
        public double Fomorian { get; private set; }

        /// <summary>
        /// Razorback fleet construction progress (percent).
        /// </summary>
        [JsonProperty("razorbackProgress")]
        public double Razorback { get; private set; }

        /// <summary>
        /// Unknown enemy fleet construction progress (percent).
        /// </summary>
        [JsonProperty("unknownProgress")]
        public double Unknown { get; private set; }
    }
}
