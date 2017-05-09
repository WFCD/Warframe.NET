using System;

namespace WarframeNET
{
    public class PersistentEnemy
    {
        public string AgentType { get; set; }

        public string Id { get; set; }

        public int Rank { get; set; }

        public string Region { get; set; }

        public float FleeDamage { get; set; }

        public float HealthPercent { get; set; }

        public bool IsDiscovered { get; set; }

        public bool IsUsingTicketing { get; set; }

        public string LastDiscoveredAt { get; set; }

        public DateTime LastDiscoveredTime { get; set; }

        public string LocationTag { get; set; }

        internal PersistentEnemy() { }
    }
}