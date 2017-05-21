using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace WarframeNET
{
    /// <summary>
    /// Alert from the in-game world state.
    /// </summary>
    public class Alert
    {
        /// <summary>
        /// Id of the alert.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Start time of the alert.
        /// </summary>
        [JsonProperty("activation")]
        public DateTime StartTime { get; set; }

        /// <summary>
        /// End time of the alert.
        /// </summary>
        [JsonProperty("expiry")]
        public DateTime EndTime { get; set; }

        /// <summary>
        /// The alert's mission.
        /// </summary>
        public Mission Mission { get; set; }

        internal Alert() { }
    }
}