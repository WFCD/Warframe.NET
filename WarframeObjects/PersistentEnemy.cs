using System;

namespace WarframeNET
{
    /// <summary>
    /// In-game persistent enemy.
    /// </summary>
    public class PersistentEnemy
    {
        /// <summary>
        /// Type of the agent.
        /// </summary>
        public string AgentType { get; set; }

        /// <summary>
        /// Id of the enemy.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Rank of the enemy.
        /// </summary>
        public int Rank { get; set; }

        /// <summary>
        /// Region of the enemy.
        /// </summary>
        public string Region { get; set; }

        /// <summary>
        /// Damage when fleeing.
        /// </summary>
        public float FleeDamage { get; set; }

        /// <summary>
        /// Current HP.
        /// </summary>
        public float HealthPercent { get; set; }

        /// <summary>
        /// Has the enemy been discovered?
        /// </summary>
        public bool IsDiscovered { get; set; }

        /// <summary>
        /// Is the enemy using ticketing?
        /// </summary>
        public bool IsUsingTicketing { get; set; }

        /// <summary>
        /// Last location of the enemy if discovered.
        /// </summary>
        public string LastDiscoveredAt { get; set; }

        /// <summary>
        /// Time of the last discovery.
        /// </summary>
        public DateTime LastDiscoveredTime { get; set; }

        /// <summary>
        /// Tag of the location.
        /// </summary>
        public string LocationTag { get; set; }

        internal PersistentEnemy() { }
    }
}