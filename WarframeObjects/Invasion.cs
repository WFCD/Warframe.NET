using System;
using Newtonsoft.Json;

namespace WarframeNET
{
    /// <summary>
    /// In-game invasion.
    /// </summary>
    public class Invasion
    {
        /// <summary>
        /// Id of the invasion.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Node of the invasion.
        /// </summary>
        public string Node { get; set; }

        /// <summary>
        /// Description of the invasion.
        /// </summary>
        [JsonProperty("desc")]
        public string Description { get; set; }

        /// <summary>
        /// Is the invasion versus infected?
        /// </summary>
        public bool IsVsInfestation { get; set; }

        /// <summary>
        /// Attacking faction of the invasion.
        /// </summary>
        public string AttackingFaction { get; set; }

        /// <summary>
        /// Defending faction of the invasion.
        /// </summary>
        public string DefendingFaction { get; set; }

        /// <summary>
        /// Reward for attackers.
        /// </summary>
        public Reward AttackerReward { get; set; }

        /// <summary>
        /// Reward for defenders.
        /// </summary>
        public Reward DefenderReward { get; set; }

        /// <summary>
        /// Start time of the invasion.
        /// </summary>
        [JsonProperty("activation")]
        public DateTime StartTime { get; set; }

        /// <summary>
        /// Count of invasions.
        /// </summary>
        public int Count { get; set; }

        /// <summary>
        /// Required runs for the invasion.
        /// </summary>
        public int RequiredRuns { get; set; }

        /// <summary>
        /// Current completion of the invasion.
        /// </summary>
        public float Completion { get; set; }

        /// <summary>
        /// Is the invasion completed?
        /// </summary>
        [JsonProperty("completed")]
        public bool IsCompleted { get; set; }

        internal Invasion() { }
    }
}