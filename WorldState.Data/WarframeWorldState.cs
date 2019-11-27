using System;

using Newtonsoft.Json;

using WorldState.Data.Models;

namespace WorldState.Data
{
    public class WarframeWorldState
    {
        [JsonProperty]
        public DateTimeOffset Timestamp { get; private set; }

        [JsonProperty]
        public News[] News { get; private set; }

        [JsonProperty]
        public Event[] Events { get; private set; }

        [JsonProperty]
        public Alert[] Alerts { get; private set; }

        [JsonProperty]
        public Sortie Sortie { get; private set; }

        [JsonProperty]
        public SyndicateMission[] SyndicateMissions { get; private set; }

        [JsonProperty("fissures")]
        public Fissure[] VoidFissureMissions { get; private set; }

        [JsonProperty]
        public GlobalUpgrade[] GlobalUpgrades { get; private set; }

        [JsonProperty]
        public FlashSale[] FlashSales { get; private set; }

        [JsonProperty]
        public Invasion[] Invasions { get; private set; }

        [JsonProperty]
        public VoidTrader VoidTrader { get; private set; }

        [JsonProperty]
        public DailyDeal[] DailyDeals { get; private set; }

        [JsonProperty("simaris")]
        public Simaris SimarisTarget { get; private set; }

        [JsonProperty]
        public ConclaveChallenge[] ConclaveChallenges { get; private set; }

        [JsonProperty("persistentEnemies")]
        public Acolyte[] Acolytes { get; private set; }

        [JsonProperty]
        public EarthCycle EarthCycle { get; private set; }

        [JsonProperty]
        public CetusCycle CetusCycle { get; private set; }

        [JsonProperty("constructionProgress")]
        public ConstructionStatus ConstructionStatus { get; private set; }

        [JsonProperty("vallisCycle")]
        public OrbVallisCycle OrbVallisCycle { get; private set; }

        [JsonProperty]
        public Nightwave Nightwave { get; private set; }
    }
}
