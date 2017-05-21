using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace WarframeNET
{
    /// <summary>
    /// In-game syndicate mission.
    /// </summary>
    public class SyndicateMission
    {
        /// <summary>
        /// Id of the syndicate mission.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Start time of the syndicate mission.
        /// </summary>
        [JsonProperty("activation")]
        public DateTime StartTime { get; set; }

        /// <summary>
        /// End time of the syndicate mission.
        /// </summary>
        [JsonProperty("expiry")]
        public DateTime EndTime { get; set; }

        /// <summary>
        /// Syndicate of the mission.
        /// </summary>
        public string Syndicate { get; set; }

        /// <summary>
        /// Nodes on which you can start the mission.
        /// </summary>
        public List<string> Nodes { get; set; }

        internal SyndicateMission() { }
    }
}