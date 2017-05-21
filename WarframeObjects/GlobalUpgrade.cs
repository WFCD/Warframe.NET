using System;
using Newtonsoft.Json;

namespace WarframeNET
{
    /// <summary>
    /// In-game global upgrade.
    /// </summary>
    public class GlobalUpgrade
    {
        /// <summary>
        /// Operation of the G.U.
        /// </summary>
        public string Operation { get; set; }

        /// <summary>
        /// Upgrade of the operation.
        /// </summary>
        public string Upgrade { get; set; }

        /// <summary>
        /// Value of the Operation's upgrade.
        /// </summary>
        public string UpgradeOperationValue { get; set; }

        /// <summary>
        /// Start time of the upgrade.
        /// </summary>
        [JsonProperty("activation")]
        public DateTime StartTime { get; set; }

        /// <summary>
        /// End time of the upgrade.
        /// </summary>
        [JsonProperty("expiry")]
        public DateTime EndTime { get; set; }

        internal GlobalUpgrade() { }
    }
}