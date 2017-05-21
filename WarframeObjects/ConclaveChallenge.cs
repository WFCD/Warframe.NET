using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace WarframeNET
{
    /// <summary>
    /// Conclave Challenge from the in-game world state.
    /// </summary>
    public class ConclaveChallenge
    {
        /// <summary>
        /// Id of the challenge. 
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Description of the challenge.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// End time of the challenge.
        /// </summary>
        [JsonProperty("expiry")]
        public DateTime EndTime { get; set; }

        /// <summary>
        /// Amount of challenges.
        /// </summary>
        public int Amount { get; set; }

        /// <summary>
        /// Mode of the challenge.
        /// </summary>
        public string Mode { get; set; }

        /// <summary>
        /// Category of the challenge.
        /// </summary>
        public string Category { get; set; }

        internal ConclaveChallenge() { }
    }
}