using System;
using System.Collections.Generic;

namespace WarframeNET
{
    public class PersistentEnemies
    {
        public List<PersistentEnemy> Content { get; set; }

        internal PersistentEnemies() { }
    }

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