using System;

namespace WorldState
{
    public static class WorldStateEndpoints
    {
        public static Uri Base { get; } = new Uri("https://api.warframestat.us");

        public const string Alerts             = "/alerts";
        public const string Acolytes           = "/persistentEnemies";
        public const string CetusCycle         = "/cetusCycle";
        public const string ConclaveChallenges = "/conclaveChallenges";
        public const string Construction       = "/constructionProgress";
        public const string DailyDeals         = "/dailyDeals";
        public const string EarthRotation      = "/earthCycle";
        public const string Events             = "/events";
        public const string FlashSales         = "/flashSales";
        public const string GlobalBoosts       = "/globalUpgrades";
        public const string Invasions          = "/invasions";
        public const string News               = "/news";
        public const string Nightwave          = "/nightwave";
        public const string OrbVallis          = "/vallisCycle";
        public const string Rivens             = "/rivens";
        public const string Sanctuary          = "/simaris";
        public const string Sorties            = "/sortie";
        public const string SyndicateMissions  = "/syndicateMissions";
        public const string VoidMissions       = "/fissures";
        public const string VoidTrader         = "/voidTrader";

        public const string PC      = "/pc";
        public const string PS4     = "/ps4";
        public const string XboxOne = "/xb1";
        public const string Switch  = "/swi";

        public static string PlatformToPath(Platform platform)
        {
            switch (platform)
            {
            case Platform.PC:      return PC;
            case Platform.PS4:     return PS4;
            case Platform.XboxOne: return XboxOne;
            case Platform.Switch:  return Switch;
            default:               throw new ArgumentOutOfRangeException(nameof(platform));
            }
        }
    }
}
