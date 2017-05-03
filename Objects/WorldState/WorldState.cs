using System;
using Newtonsoft.Json;

namespace WarframeNET
{
    public class WorldState
    {
        public DateTime Timestamp { get; set; }

        [JsonProperty("news")]
        public News WS_News { get; set; }

        [JsonProperty("events")]
        public Events WS_Events { get; set; }

        [JsonProperty("alerts")]
        public Alerts WS_Alerts { get; set; }

        [JsonProperty("sortie")]
        public Sortie WS_Sortie { get; set; }

        [JsonProperty("syndicateMissions")]
        public SyndicateMissions WS_SyndicateMissions { get; set; }

        [JsonProperty("fissures")]
        public Fissures WS_Fissures { get; set; }

        [JsonProperty("globalUpgrades")]
        public GlobalUpgrades WS_GlobalUpgrades { get; set; }

        [JsonProperty("flashSales")]
        public FlashSales WS_FlashSales { get; set; }

        [JsonProperty("invasions")]
        public Invasions WS_Invasions { get; set; }

        [JsonProperty("darkSectors")]
        public DarkSectors WS_DarkSectors { get; set; }

        [JsonProperty("voidTrader")]
        public VoidTrader WS_VoidTrader { get; set; }

        [JsonProperty("dailyDeals")]
        public DailyDeals WS_DailyDeals { get; set; }

        [JsonProperty("simaris")]
        public Simaris WS_Simaris { get; set; }

        [JsonProperty("conclaveChallenges")]
        public ConclaveChallenges WS_ConclaveChallenges { get; set; }

        [JsonProperty("persistentEnemies")]
        public PersistentEnemies WS_PersistentEnemies { get; set; }

        internal WorldState() { }
    }
}