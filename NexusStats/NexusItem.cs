using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace WarframeNET.NexusStats
{
    /// <summary>
    /// Item stats returned from NexusStats' API.
    /// </summary>
    public class NexusItem
    {
        /// <summary>
        /// Name of the item.
        /// </summary>
        [JsonProperty("title")]
        public string Name { get; set; }

        /// <summary>
        /// Type of the item.
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Market supply of the item.
        /// </summary>
        public NexusMarketStat Supply { get; set; }

        /// <summary>
        /// Market demand of the item.
        /// </summary>
        public NexusMarketStat Demand { get; set; }

        /// <summary>
        /// Components of this item if any.
        /// </summary>
        public List<NexusItemComponent> Components { get; set; }

        internal NexusItem() { }
    }
}