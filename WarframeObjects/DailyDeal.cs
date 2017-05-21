using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace WarframeNET
{
    /// <summary>
    /// Daily deals! Darvos fire sale! Buy, or I burn it...
    /// </summary>
    public class DailyDeal
    {
        /// <summary>
        /// Name of the item.
        /// </summary>
        public string Item { get; set; }

        /// <summary>
        /// Id of the item.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Original price of the item.
        /// </summary>
        public int OriginalPrice { get; set; }

        /// <summary>
        /// Sale price of the item.
        /// </summary>
        public int SalePrice { get; set; }

        /// <summary>
        /// Quantity of available items.
        /// </summary>
        public int Total { get; set; }

        /// <summary>
        /// Amount of sold items.
        /// </summary>
        public int Sold { get; set; }

        /// <summary>
        /// End time of the deal.
        /// </summary>
        [JsonProperty("expiry")]
        public DateTime EndTime { get; set; }

        internal DailyDeal() { }
    }
}