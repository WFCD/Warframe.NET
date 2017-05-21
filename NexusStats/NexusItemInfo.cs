using System.Collections.Generic;
using Newtonsoft.Json;
namespace WarframeNET.NexusStats
{
    /// <summary>
    /// An item returned from NexusStats' Item List
    /// </summary>
    public class NexusItemInfo
    {
        /// <summary>
        /// The item's ID.
        /// </summary>
        [JsonProperty("_id")]
        public string _id { get; set; }
        
        /// <summary>
        /// The name of the item.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The type of the item.
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// The category of the item.
        /// </summary>
        public string Category { get; set; }

        /// <summary>
        /// The components of the item.
        /// </summary>
        public List<string> Components { get; set; }

        /// <summary>
        /// The rank of the item.
        /// </summary>
        public int? Ranks { get; set; }

        internal NexusItemInfo() { }
    }
}