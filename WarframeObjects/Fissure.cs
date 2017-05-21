using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace WarframeNET
{
    /// <summary>
    /// In-game fissure.
    /// </summary>
    public class Fissure
    {
        /// <summary>
        /// Id of the fissure.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Node of the fissure.
        /// </summary>
        public string Node { get; set; }

        /// <summary>
        /// The mission type of the fissure.
        /// </summary>
        public string MissionType { get; set; }

        /// <summary>
        /// Enemy of the fissure.
        /// </summary>
        public string Enemy { get; set; }

        /// <summary>
        /// Tier of the fissure.
        /// </summary>
        public string Tier { get; set; }

        /// <summary>
        /// Tier number of the fissure.
        /// </summary>
        [JsonProperty("tierNum")]
        public int TierNumber { get; set; }

        /// <summary>
        /// Fissure start time.
        /// </summary>
        [JsonProperty("activation")]
        public DateTime StartTime { get; set; }

        /// <summary>
        /// Fissure end time.
        /// </summary>
        [JsonProperty("expiry")]
        public DateTime EndTime { get; set; }

        internal Fissure() { }
    }
}