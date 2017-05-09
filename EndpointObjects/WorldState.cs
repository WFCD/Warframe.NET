using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace WarframeNET
{
    public class WorldState
    {
        public DateTime Timestamp { get; set; }

        [JsonProperty("news")]
        public List<NewsArticle> WS_News { get; set; }

        [JsonProperty("events")]
        public List<Event> WS_Events { get; set; }

        [JsonProperty("alerts")]
        public List<Alert> WS_Alerts { get; set; }

        [JsonProperty("sortie")]
        public Sortie WS_Sortie { get; set; }

        [JsonProperty("syndicateMissions")]
        public List<SyndicateMission> WS_SyndicateMissions { get; set; }

        [JsonProperty("fissures")]
        public List<Fissure> WS_Fissures { get; set; }

        [JsonProperty("globalUpgrades")]
        public List<GlobalUpgrade> WS_GlobalUpgrades { get; set; }

        [JsonProperty("flashSales")]
        public List<FlashSale> WS_FlashSales { get; set; }

        [JsonProperty("invasions")]
        public Invasion WS_Invasions { get; set; }

        [JsonProperty("darkSectors")]
        public List<DarkSector> WS_DarkSectors { get; set; }

        [JsonProperty("voidTrader")]
        public VoidTrader WS_VoidTrader { get; set; }

        [JsonProperty("dailyDeals")]
        public List<DailyDeal> WS_DailyDeals { get; set; }

        [JsonProperty("simaris")]
        public Simaris WS_Simaris { get; set; }

        [JsonProperty("conclaveChallenges")]
        public List<ConclaveChallenge> WS_ConclaveChallenges { get; set; }

        [JsonProperty("persistentEnemies")]
        public List<PersistentEnemy> WS_PersistentEnemies { get; set; }

        internal WorldState() { }
    }
}