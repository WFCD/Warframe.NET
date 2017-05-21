using Newtonsoft.Json;

namespace WarframeNET.NexusStats
{
    /// <summary>
    /// Interval of the stats of an item on NexusStats.
    /// </summary>
    public class NexusMarketInterval
    {
        /// <summary>
        /// Average price of an item.
        /// </summary>
        [JsonProperty("avg")]
        public float Average { get; set; }

        /// <summary>
        /// Minimum price of an item.
        /// </summary>
        public int Min { get; set; }

        /// <summary>
        /// Maximum price of an item.
        /// </summary>
        public int Max { get; set; }

        /// <summary>
        /// Supply stats of an item.
        /// </summary>
        public NexusMarketStat Supply { get; set; }

        /// <summary>
        /// Demand stats of an item.
        /// </summary>
        public NexusMarketStat Demand { get; set; }

        internal NexusMarketInterval() { }
    }
}
