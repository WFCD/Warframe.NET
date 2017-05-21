using System;

namespace WarframeNET
{
    /// <summary>
    /// Endpoints for the Warframe World State API
    /// </summary>
    public static class Endpoint
    {
        /// <summary>
        /// Basic URL without any endpoint for the world state parser.
        /// </summary>
        [Obsolete("This is not the worldstate endpoint. To GET from the worldstate, please use WarframeClient.GetWorldStateAsync()")]
        public const string WorldState = "https://ws.warframestat.us/";

        /// <summary>
        /// Alerts.
        /// </summary>
        public const string Alerts = "alerts";

        /// <summary>
        /// Conclave Challenges.
        /// </summary>
        public const string ConclaveChallenges = "conclaveChallenges";

        /// <summary>
        /// Daily Deals.
        /// </summary>
        public const string DailyDeals = "dailyDeals";

        /// <summary>
        /// Dark Sectors.
        /// </summary>
        public const string DarkSectors = "darkSectors";

        /// <summary>
        /// Events.
        /// </summary>
        public const string Events = "events";

        /// <summary>
        /// Flash Sales.
        /// </summary>
        public const string FlashSales = "flashSales";

        /// <summary>
        /// Fissures.
        /// </summary>
        public const string Fissures = "fissures";

        /// <summary>
        /// Global Upgrades.
        /// </summary>
        public const string GlobalUpgrades = "globalUpgrades";

        /// <summary>
        /// Invasions.
        /// </summary>
        public const string Invasions = "invasions";

        /// <summary>
        /// News.
        /// </summary>
        public const string News = "news";

        /// <summary>
        /// Persistent Enemies.
        /// </summary>
        public const string PersistentEnemies = "persistentEnemies";

        /// <summary>
        /// Simaris.
        /// </summary>
        public const string Simaris = "simaris";

        /// <summary>
        /// Sortie.
        /// </summary>
        public const string Sortie = "sortie";

        /// <summary>
        /// Syndicate Missions.
        /// </summary>
        public const string SyndicateMissions = "syndicateMissions";

        /// <summary>
        /// Void Trader.
        /// </summary>
        public const string VoidTrader = "voidTrader";

        /// <summary>
        /// List of correct endpoints.
        /// </summary>
        public static readonly string[] List = { Alerts, ConclaveChallenges, DailyDeals, DarkSectors, Events, FlashSales, Fissures, GlobalUpgrades, Invasions, News, PersistentEnemies, Simaris, Sortie, SyndicateMissions, VoidTrader };
    }
}