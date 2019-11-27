using Newtonsoft.Json;

namespace WorldState.Data.Models
{
    public class RivenMod
    {
        [JsonProperty("itemType")]
        public string Type { get; private set; }

        [JsonProperty]
        public string Compatibility { get; private set; }

        [JsonProperty]
        public bool Rerolled { get; private set; }

        [JsonProperty("avg")]
        public float Average { get; private set; }

        [JsonProperty("median")]
        public float Median { get; private set; }

        [JsonProperty("stddev")]
        public float StandardDeviation { get; private set; }

        [JsonProperty("min")]
        public float Minimum { get; private set; }

        [JsonProperty("max")]
        public float Maximum { get; private set; }

        [JsonProperty("pop")]
        public float Population { get; private set; }
    }
}
