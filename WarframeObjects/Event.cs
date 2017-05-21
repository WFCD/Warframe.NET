using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace WarframeNET
{
    /// <summary>
    /// In-game event
    /// </summary>
    public class Event
    {
        /// <summary>
        /// Id of the event.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Description of the event.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Tooltip of the event.
        /// </summary>
        public string Tooltip { get; set; }

        /// <summary>
        /// Faction of the event.
        /// </summary>
        public string Faction { get; set; }

        /// <summary>
        /// Node of the event.
        /// </summary>
        public string Node { get; set; }

        /// <summary>
        /// Victim node of the event.
        /// </summary>
        public string VictimNode { get; set; }

        /// <summary>
        /// List of concurrent nodes.
        /// </summary>
        public List<string> ConcurrentNodes { get; set; }

        /// <summary>
        /// Start time of the event.
        /// </summary>
        [JsonProperty("activation")]
        public DateTime StartTime { get; set; }

        /// <summary>
        /// End time of the event.
        /// </summary>
        [JsonProperty("expiry")]
        public DateTime EndTime { get; set; }

        /// <summary>
        /// List of event rewards.
        /// </summary>
        public List<Reward> Rewards { get; set; }

        /// <summary>
        /// Small score interval.
        /// </summary>
        public int? SmallInterval { get; set; }

        /// <summary>
        /// Large score interval.
        /// </summary>
        public int? LargeInterval { get; set; }

        /// <summary>
        /// Maximum score yet.
        /// </summary>
        public int MaximumScore { get; set; }

        internal Event() { }
    }
}