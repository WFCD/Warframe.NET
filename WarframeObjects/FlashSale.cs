using System;
using Newtonsoft.Json;

namespace WarframeNET
{
    /// <summary>
    /// In-game flash sale.
    /// </summary>
    public class FlashSale
    {
        /// <summary>
        /// Item sold.
        /// </summary>
        public string Item { get; set; }

        /// <summary>
        /// Id of the flash sale.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Discount on the price.
        /// </summary>
        public int Discount { get; set; }

        /// <summary>
        /// End time of the flash sale.
        /// </summary>
        [JsonProperty("expiry")]
        public DateTime EndTime { get; set; }

        /// <summary>
        /// Override for premium.
        /// </summary>
        public int PremiumOverride { get; set; }

        /// <summary>
        /// Is the item featured?
        /// </summary>
        public bool IsFeatured { get; set; }

        /// <summary>
        /// Is the item popular?
        /// </summary>
        public bool IsPopular { get; set; }

        internal FlashSale() { }
    }
}