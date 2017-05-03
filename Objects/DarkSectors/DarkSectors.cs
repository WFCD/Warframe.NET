using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace WarframeNET
{
    public class DarkSectors
    {
        public List<DarkSector> Content { get; set; }

        internal DarkSectors() { }
    }

    public class DarkSector
    {
        public string Id { get; set; }

        public string RailType { get; set; }

        public bool IsAlliance { get; set; }

        public string DeployerName { get; set; }

        public string DeployerClan { get; set; }

        public string DefenderName { get; set; }

        public string DefenderMOTD { get; set; }

        public int DefenderPoolRemaining { get; set; }

        public int DefenderMaxPool { get; set; }

        public int DefenderRailHealReserve { get; set; }

        [JsonProperty("defenderDeployemntActivation")]
        public DateTime DefenderStartTime { get; set; }

        public int CreditTaxRate { get; set; }

        public int ItemsTaxRate { get; set; }

        public int MemberItemsTaxRate { get; set; }

        public int DamagePerMission { get; set; }

        public int BattlePayReserve { get; set; }

        public int PerMissionBattlePay { get; set; }

        public string BattlePaySetBy { get; set; }

        public string BattlePaySetByClan { get; set; }

        public string TaxChangedBy { get; set; }

        public string TaxChangedByClan { get; set; }

        public Mission Mission { get; set; }

        public List<DarkSectorBattle> History { get; set; }

        internal DarkSector() { }
    }

    public class DarkSectorBattle
    {
        public string Defender { get; set; }

        [JsonProperty("defenderIsAlliance")]
        public bool IsDefenderAlliance { get; set; }

        public string Attacker { get; set; }

        [JsonProperty("attackerIsAlliance")]
        public bool IsAttackerAlliance { get; set; }

        public string Winner { get; set; }

        [JsonProperty("start")]
        public DateTime StartTime { get; set; }

        [JsonProperty("end")]
        public DateTime EndTime { get; set; }

        internal DarkSectorBattle() { }
    }
}