using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace WarframeNET
{
    /// <summary>
    /// The current World State of Warframe. Please note the API might be ahead of the game.
    /// </summary>
    public class WorldState
    {
        /// <summary>
        /// Date of the World State's last change.
        /// </summary>
        public DateTime Timestamp { get; set; }

        /// <summary>
        /// Current game news.
        /// </summary>
        [JsonProperty("news")]
        public List<NewsArticle> WS_News { get; set; }

        /// <summary>
        /// Current game events.
        /// </summary>
        [JsonProperty("events")]
        public List<Event> WS_Events { get; set; }

        /// <summary>
        /// Current game alerts. 
        /// </summary>
        [JsonProperty("alerts")]
        public List<Alert> WS_Alerts { get; set; }

        /// <summary>
        /// Current game sortie.
        /// </summary>
        [JsonProperty("sortie")]
        public Sortie WS_Sortie { get; set; }

        /// <summary>
        /// Current game syndicate missions.
        /// </summary>
        [JsonProperty("syndicateMissions")]
        public List<SyndicateMission> WS_SyndicateMissions { get; set; }

        /// <summary>
        /// Current game fissures.
        /// </summary>
        [JsonProperty("fissures")]
        public List<Fissure> WS_Fissures { get; set; }

        /// <summary>
        /// Current global upgrades.
        /// </summary>
        [JsonProperty("globalUpgrades")]
        public List<GlobalUpgrade> WS_GlobalUpgrades { get; set; }

        /// <summary>
        /// Current game flash sales.
        /// </summary>
        [JsonProperty("flashSales")]
        public List<FlashSale> WS_FlashSales { get; set; }

        /// <summary>
        /// Current game invasions.
        /// </summary>
        [JsonProperty("invasions")]
        public List<Invasion> WS_Invasions { get; set; }

        /// <summary>
        /// Current game dark sectors and battles.
        /// </summary>
        [JsonProperty("darkSectors")]
        public List<DarkSector> WS_DarkSectors { get; set; }

        /// <summary>
        /// Current Void Trader and his items.
        /// </summary>
        [JsonProperty("voidTrader")]
        public VoidTrader WS_VoidTrader { get; set; }

        /// <summary>
        /// Current Daily Deals.
        /// </summary>
        [JsonProperty("dailyDeals")]
        public List<DailyDeal> WS_DailyDeals { get; set; }

        /// <summary>
        /// Simaris targets. Obsolete, targets are now player related.
        /// </summary>
        [JsonProperty("simaris")]
        public Simaris WS_Simaris { get; set; }

        /// <summary>
        /// Current conclave challenges.
        /// </summary>
        [JsonProperty("conclaveChallenges")]
        public List<ConclaveChallenge> WS_ConclaveChallenges { get; set; }

        /// <summary>
        /// Persistent Enemies.
        /// </summary>
        [JsonProperty("persistentEnemies")]
        public List<PersistentEnemy> WS_PersistentEnemies { get; set; }

        /// <summary>
        /// Current Earth Cycle Data.
        /// </summary>
        [JsonProperty("earthCycle")]
        public EarthCycle WS_EarthCycle { get; set; }

        /// <summary>
        /// Current Cetus Cycle Data.
        /// </summary>
        [JsonProperty("cetusCycle")]
        public CetusCycle WS_CetusCycle { get; set; }


        internal WorldState() { }
    }
}