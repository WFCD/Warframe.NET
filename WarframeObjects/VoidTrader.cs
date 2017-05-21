using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace WarframeNET
{
    /// <summary>
    /// In-game void trader.
    /// </summary>
    public class VoidTrader
    {
        /// <summary>
        /// Id of the void trader.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Start time of the void trader.
        /// </summary>
        [JsonProperty("activation")]
        public DateTime StartTime { get; set; }

        /// <summary>
        /// End time of the void trader.
        /// </summary>
        [JsonProperty("expiry")]
        public DateTime EndTime { get; set; }

        /// <summary>
        /// Character who plays the trader.
        /// </summary>
        public string Character { get; set; }

        /// <summary>
        /// Location of the trader.
        /// </summary>
        public string Location { get; set; }

        /// <summary>
        /// The trader's inventory.
        /// </summary>
        public List<VoidTraderItem> Inventory { get; set; }

        internal VoidTrader() { }
    }

    /// <summary>
    /// Item the void trader is currently selling.
    /// </summary>
    public class VoidTraderItem
    {
        /// <summary>
        /// The item's name.
        /// </summary>
        public string Item { get; set; }

        /// <summary>
        /// Cost in ducats.
        /// </summary>
        public int Ducats { get; set; }

        /// <summary>
        /// Cost in credit.
        /// </summary>
        public int Credits { get; set; }

        internal VoidTraderItem() { }
    }
}