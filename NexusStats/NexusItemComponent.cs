using Newtonsoft.Json;
using System.Collections.Generic;

namespace WarframeNET.NexusStats
{
    /// <summary>
    /// Stats for the components of an item.
    /// </summary>
    public class NexusItemComponent
    {
        /// <summary>
        /// Name of the component.
        /// </summary>
        public string Name { get; set; }
        
        /// <summary>
        /// Average price of the component.
        /// </summary>
        [JsonProperty("avg")]
        public float Average { get; set; }

        /// <summary>
        /// Median price of the component.
        /// </summary>
        public float Median { get; set; }

        /// <summary>
        /// Minimum price of the component.
        /// </summary>
        public int Min { get; set; }

        /// <summary>
        /// Maximum price of the component.
        /// </summary>
        public int Max { get; set; }

        /// <summary>
        /// Supply stats of the component.
        /// </summary>
        public NexusMarketStat Supply { get; set; }

        /// <summary>
        /// Demand stats of the component.
        /// </summary>
        public NexusMarketStat Demand { get; set; }

        /// <summary>
        /// Intervals of stat changes for the component.
        /// </summary>
        public List<NexusMarketInterval> Interval { get; set; }

        internal NexusItemComponent() { }
    }
}
