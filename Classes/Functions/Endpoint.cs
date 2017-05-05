using System;

namespace WarframeNET
{
    public struct Endpoint
    {
        [Obsolete("This is the default endpoint. To GET from that endpoint, please use WarframeClient.GetWorldStateAsync()")]
        public const string WorldState = "https://ws.warframestat.us/";

        public const string Alerts = "alerts";

        public const string ConclaveChallenges = "conclaveChallenges";

        public const string DailyDeals = "dailyDeals";

        public const string DarkSectors = "darkSectors";

        public const string Events = "events";

        public const string FlashSales = "flashSales";

        public const string Fissures = "fissures";

        public const string GlobalUpgrades = "globalUpgrades";

        public const string Invasions = "invasions";

        public const string News = "news";

        public const string PersistentEnemies = "persistentEnemies";

        public const string Simaris = "simaris";

        public const string Sortie = "sortie";

        public const string SyndicateMissions = "syndicateMissions";

        public const string VoidTrader = "voidTrader";
    }
}