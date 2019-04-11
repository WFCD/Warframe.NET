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
        public List<NewsArticle> News { get; set; }

        /// <summary>
        /// Current game events.
        /// </summary>
        public List<Event> Events { get; set; }

        /// <summary>
        /// Current game alerts. 
        /// </summary>
        public List<Alert> Alerts { get; set; }

        /// <summary>
        /// Current game sortie.
        /// </summary>
        public Sortie Sortie { get; set; }

        /// <summary>
        /// Current game syndicate missions.
        /// </summary>
        public List<SyndicateMission> SyndicateMissions { get; set; }

        /// <summary>
        /// Current game fissures.
        /// </summary>
        public List<Fissure> Fissures { get; set; }

        /// <summary>
        /// Current global upgrades.
        /// </summary>
        public List<GlobalUpgrade> GlobalUpgrades { get; set; }

        /// <summary>
        /// Current game flash sales.
        /// </summary>
        public List<FlashSale> FlashSales { get; set; }

        /// <summary>
        /// Current game invasions.
        /// </summary>
        public List<Invasion> Invasions { get; set; }

        /// <summary>
        /// Current game dark sectors and battles.
        /// </summary>
        public List<DarkSector> DarkSectors { get; set; }

        /// <summary>
        /// Current Void Trader and his items.
        /// </summary>
        public VoidTrader VoidTrader { get; set; }

        /// <summary>
        /// Current Daily Deals.
        /// </summary>
        public List<DailyDeal> DailyDeals { get; set; }

        /// <summary>
        /// Current conclave challenges.
        /// </summary>
        public List<ConclaveChallenge> ConclaveChallenges { get; set; }

        /// <summary>
        /// Persistent Enemies.
        /// </summary>
        public List<PersistentEnemy> PersistentEnemies { get; set; }

        /// <summary>
        /// Current Earth Cycle Data.
        /// </summary>
        public EarthCycle EarthCycle { get; set; }

        /// <summary>
        /// Current Cetus Cycle Data.
        /// </summary>
        public CetusCycle CetusCycle { get; set; }

        [JsonProperty("constructionProgress")]
        public InvasionFleetConstructionProgress InvasionFleetConstructionProgress { get; set; }

        public VallisCycle VallisCycle { get; set; }

        public Nightwave Nightwave { get; set; }

        [Obsolete]
        public List<NewsArticle> WS_News { get => News; set => News = value; }

        [Obsolete]
        public List<Event> WS_Events { get => Events; set => Events = value; }

        [Obsolete]
        public List<Alert> WS_Alerts { get => Alerts; set => Alerts = value; }

        [Obsolete]
        public Sortie WS_Sortie { get => Sortie; set => Sortie = value; }

        [Obsolete]
        public List<SyndicateMission> WS_SyndicateMissions { get => SyndicateMissions; set => SyndicateMissions = value; }

        [Obsolete]
        public List<Fissure> WS_Fissures { get => Fissures; set => Fissures = value; }

        [Obsolete]
        public List<GlobalUpgrade> WS_GlobalUpgrades { get => GlobalUpgrades; set => GlobalUpgrades = value; }

        [Obsolete]
        public List<FlashSale> WS_FlashSales { get => FlashSales; set => FlashSales = value; }

        [Obsolete]
        public List<Invasion> WS_Invasions { get => Invasions; set => Invasions = value; }

        [Obsolete]
        public List<DarkSector> WS_DarkSectors { get => DarkSectors; set => DarkSectors = value; }

        [Obsolete]
        public VoidTrader WS_VoidTrader { get => VoidTrader; set => VoidTrader = value; }

        [Obsolete]
        public List<DailyDeal> WS_DailyDeals { get => DailyDeals; set => DailyDeals = value; }

        /// <summary>
        /// Simaris targets. Obsolete: targets are now player-specific.
        /// </summary>
        [JsonProperty("simaris")]
        public Simaris WS_Simaris { get; set; }

        [Obsolete]
        public List<ConclaveChallenge> WS_ConclaveChallenges { get => ConclaveChallenges; set => ConclaveChallenges = value; }

        [Obsolete]
        public List<PersistentEnemy> WS_PersistentEnemies { get => PersistentEnemies; set => PersistentEnemies = value; }

        [Obsolete]
        public EarthCycle WS_EarthCycle { get => EarthCycle; set => EarthCycle = value; }

        [Obsolete]
        public CetusCycle WS_CetusCycle { get => CetusCycle; set => CetusCycle = value; }

        internal WorldState() { }
    }
}