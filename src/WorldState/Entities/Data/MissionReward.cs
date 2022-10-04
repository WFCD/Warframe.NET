using System.Collections.Generic;
using Newtonsoft.Json;

namespace WarframeNet.WorldState
{
    /// <summary>
    /// Represents a reward awarded at the completion of a mission.
    /// </summary>
    public class MissionReward
    {
        [JsonProperty("items")]
        private List<string> _items;

        /// <summary>
        /// List of items this mission gives. May be empty.
        /// </summary>
        [JsonIgnore]
        public IReadOnlyList<string> Items => _items.AsReadOnly();
        
        [JsonProperty("countedItems")]
        private List<SystemResource> _resources;

        /// <summary>
        /// List of resources that will be given. 
        /// </summary>
        [JsonIgnore]
        public IReadOnlyList<SystemResource> Resources => _resources.AsReadOnly();

        /// <summary>
        /// Amount of credits that will be rewarded.
        /// </summary>
        [JsonProperty("credits")]
        public int Credits { get; private set; }

        /// <summary>
        /// If any, a thumbnail for the reward.
        /// </summary>
        [JsonProperty("thumbnail")]
        public string Thumbnail { get; private set; }

        /// <summary>
        /// Color of the reward returned by the API in decimal form.
        /// </summary>
        [JsonProperty("color")]
        public int Color { get; private set; }
        
        /// <summary>
        /// String representation of the item's name and amount.
        /// </summary>
        [JsonProperty("itemString")]
        public string ItemString { get; private set; }
        
        [JsonProperty("asString")]
        private string AsString { get;  set; }

        public override string ToString()
        {
            return AsString;
        }
    }
}
