using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace WarframeNET
{
    /// <summary>
    /// The base client to GET json from Warframe's World State API.
    /// </summary>
    public class WarframeClient
    {
        /// <summary>
        /// Get the current world state for a given platform.
        /// </summary>
        /// <param name="platform"> The platform to get info from. <seealso cref="Platform"/> </param>
        /// <returns>The WorldState <seealso cref="WorldState"/></returns>
        public async Task<WorldState> GetWorldStateAsync(string platform)
        {
            if (!Platform.List.Where(x => x == platform).Any())
            {
                throw new PlatformNotFoundException($"Unknown game platform \"{platform}\"");
            }

            WorldState state = await Functions.GetWorldStateAsync(platform);
            return state;
        }

        /// <summary>
        /// Get the current alerts for a given platform.
        /// </summary>
        /// <param name="platform"> The platform to get info from. <seealso cref="Platform"/></param>
        /// <returns>A list of Alerts <seealso cref="Alert"/></returns>
        public async Task<List<Alert>> GetAlertsAsync(string platform)
        {
            if (!Platform.List.Where(x => x == platform).Any())
            {
                throw new PlatformNotFoundException($"Unknown game platform \"{platform}\"");
            }

            WorldState state = await Functions.GetWorldStateAsync(platform);
            return state.WS_Alerts;
        }

        /// <summary>
        /// Get the current conclave challenges for a given platform.
        /// </summary>
        /// <param name="platform"> The platform to get info from. <seealso cref="Platform"/></param>
        /// <returns>A list of Conclave Challenges <seealso cref="ConclaveChallenge"/></returns>
        public async Task<List<ConclaveChallenge>> GetConclaveChallengesAsync(string platform)
        {
            if (!Platform.List.Where(x => x == platform).Any())
            {
                throw new PlatformNotFoundException($"Unknown game platform \"{platform}\"");
            }

            WorldState state = await Functions.GetWorldStateAsync(platform);
            return state.WS_ConclaveChallenges;
        }

        /// <summary>
        /// Get the current daily deals for a given platform.
        /// </summary>
        /// <param name="platform"> The platform to get info from. <seealso cref="Platform"/></param>
        /// <returns>A list of Daily Deals <seealso cref="DailyDeal"/></returns>
        public async Task<List<DailyDeal>> GetDailyDealsAsync(string platform)
        {
            if (!Platform.List.Where(x => x == platform).Any())
            {
                throw new PlatformNotFoundException($"Unknown game platform \"{platform}\"");
            }

            WorldState state = await Functions.GetWorldStateAsync(platform);
            return state.WS_DailyDeals;
        }

        /// <summary>
        /// Gets the dark sectors for a given platform.
        /// </summary>
        /// <param name="platform"> The platform to get info from. <seealso cref="Platform"/></param>
        /// <returns>A list of Alerts <seealso cref="DarkSector"/></returns>
        public async Task<List<DarkSector>> GetDarkSectorsAsync(string platform)
        {
            if (!Platform.List.Where(x => x == platform).Any())
            {
                throw new PlatformNotFoundException($"Unknown game platform \"{platform}\"");
            }

            WorldState state = await Functions.GetWorldStateAsync(platform);
            return state.WS_DarkSectors;
        }

        /// <summary>
        /// Get the current events for a given platform.
        /// </summary>
        /// <param name="platform"> The platform to get info from. <seealso cref="Platform"/></param>
        /// <returns>A list of Events <seealso cref="Event"/></returns>
        public async Task<List<Event>> GetEventsAsync(string platform)
        {
            if (!Platform.List.Where(x => x == platform).Any())
            {
                throw new PlatformNotFoundException($"Unknown game platform \"{platform}\"");
            }

            WorldState state = await Functions.GetWorldStateAsync(platform);
            return state.WS_Events;
        }

        /// <summary>
        /// Get the current fissures for a given platform.
        /// </summary>
        /// <param name="platform"> The platform to get info from. <seealso cref="Platform"/></param>
        /// <returns>A list of Fissures <seealso cref="Fissure"/></returns>
        public async Task<List<Fissure>> GetFissuresAsync(string platform)
        {
            if (!Platform.List.Where(x => x == platform).Any())
            {
                throw new PlatformNotFoundException($"Unknown game platform \"{platform}\"");
            }

            WorldState state = await Functions.GetWorldStateAsync(platform);
            return state.WS_Fissures;
        }


        /// <summary>
        /// Get the current flash sales for a given platform.
        /// </summary>
        /// <param name="platform"> The platform to get info from. <seealso cref="Platform"/></param>
        /// <returns>A list of Flash Sales <seealso cref="FlashSale"/></returns>
        public async Task<List<FlashSale>> GetFlashSalesAsync(string platform)
        {
            if (!Platform.List.Where(x => x == platform).Any())
            {
                throw new PlatformNotFoundException($"Unknown game platform \"{platform}\"");
            }

            WorldState state = await Functions.GetWorldStateAsync(platform);
            return state.WS_FlashSales;
        }

        /// <summary>
        /// Get the current global upgrades for a given platform.
        /// </summary>
        /// <param name="platform"> The platform to get info from. <seealso cref="Platform"/></param>
        /// <returns>A list of Global Upgrades <seealso cref="GlobalUpgrade"/></returns>
        public async Task<List<GlobalUpgrade>> GetGlobalUpgradesAsync(string platform)
        {
            if (!Platform.List.Where(x => x == platform).Any())
            {
                throw new PlatformNotFoundException($"Unknown game platform \"{platform}\"");
            }

            WorldState state = await Functions.GetWorldStateAsync(platform);
            return state.WS_GlobalUpgrades;
        }

        /// <summary>
        /// Get the current invasions for a given platform.
        /// </summary>
        /// <param name="platform"> The platform to get info from. <seealso cref="Platform"/></param>
        /// <returns>A list of Invasions <seealso cref="Invasion"/></returns>
        public async Task<List<Invasion>> GetInvasionsAsync(string platform)
        {
            if (!Platform.List.Where(x => x == platform).Any())
            {
                throw new PlatformNotFoundException($"Unknown game platform \"{platform}\"");
            }

            WorldState state = await Functions.GetWorldStateAsync(platform);
            return state.WS_Invasions;
        }

        /// <summary>
        /// Get the current news for a given platform.
        /// </summary>
        /// <param name="platform"> The platform to get info from. <seealso cref="Platform"/></param>
        /// <returns>A list of News Articles <seealso cref="NewsArticle"/></returns>
        public async Task<List<NewsArticle>> GetNewsAsync(string platform)
        {
            if (!Platform.List.Where(x => x == platform).Any())
            {
                throw new PlatformNotFoundException($"Unknown game platform \"{platform}\"");
            }

            WorldState state = await Functions.GetWorldStateAsync(platform);
            return state.WS_News;
        }

        /// <summary>
        /// Get the current persistent enemies for a given platform.
        /// </summary>
        /// <param name="platform"> The platform to get info from. <seealso cref="Platform"/></param>
        /// <returns>A list of Persistent Enemies <seealso cref="PersistentEnemy"/></returns>
        public async Task<List<PersistentEnemy>> GetPersistentEnemiesAsync(string platform)
        {
            if (!Platform.List.Where(x => x == platform).Any())
            {
                throw new PlatformNotFoundException($"Unknown game platform \"{platform}\"");
            }

            WorldState state = await Functions.GetWorldStateAsync(platform);
            return state.WS_PersistentEnemies;
        }

        /// <summary>
        /// Get the current news for a given platform.
        /// </summary>
        /// <param name="platform"> The platform to get info from. <seealso cref="Platform"/></param>
        /// <returns>The current Simaris mission <seealso cref="Simaris"/></returns>
        [System.Obsolete("This endpoint is obsolete and shouldn't be used anymore.")]
        public async Task<Simaris> GetSimarisAsync(string platform)
        {
            if (!Platform.List.Where(x => x == platform).Any())
            {
                throw new PlatformNotFoundException($"Unknown game platform \"{platform}\"");
            }

            WorldState state = await Functions.GetWorldStateAsync(platform);
            return state.WS_Simaris;
        }

        /// <summary>
        /// Get the current sortie for a given platform.
        /// </summary>
        /// <param name="platform"> The platform to get info from. <seealso cref="Platform"/></param>
        /// <returns>The current Sortie<seealso cref="Sortie"/></returns>
        public async Task<Sortie> GetSortieAsync(string platform)
        {
            if (!Platform.List.Where(x => x == platform).Any())
            {
                throw new PlatformNotFoundException($"Unknown game platform \"{platform}\"");
            }

            WorldState state = await Functions.GetWorldStateAsync(platform);
            return state.WS_Sortie;
        }

        /// <summary>
        /// Get the current syndicate missions for a given platform.
        /// </summary>
        /// <param name="platform"> The platform to get info from. <seealso cref="Platform"/></param>
        /// <returns>A list of News Articles <seealso cref="NewsArticle"/></returns>
        public async Task<List<SyndicateMission>> GetSyndicateMissionsAsync(string platform)
        {
            if (!Platform.List.Where(x => x == platform).Any())
            {
                throw new PlatformNotFoundException($"Unknown game platform \"{platform}\"");
            }

            WorldState state = await Functions.GetWorldStateAsync(platform);
            return state.WS_SyndicateMissions;
        }
        /// <summary>
        /// Get the current void trader for a given platform.
        /// </summary>
        /// <param name="platform"> The platform to get info from. <seealso cref="Platform"/></param>
        /// <returns>The current Void Trader's items. <seealso cref="VoidTrader"/></returns>
        public async Task<VoidTrader> GetVoidTraderAsync(string platform)
        {
            if (!Platform.List.Where(x => x == platform).Any())
            {
                throw new PlatformNotFoundException($"Unknown game platform \"{platform}\"");
            }

            WorldState state = await Functions.GetWorldStateAsync(platform);
            return state.WS_VoidTrader;
        }

        /// <summary>
        /// Get the timestamp of the last modification of the World State.
        /// </summary>
        /// <param name="platform"> The platform to get info from. <seealso cref="Platform"/></param>
        /// <returns>DateTime (last modification) <seealso cref="NewsArticle"/></returns>
        public async Task<System.DateTime> GetTimestampAsync(string platform)
        {
            if (!Platform.List.Where(x => x == platform).Any())
            {
                throw new PlatformNotFoundException($"Unknown game platform \"{platform}\"");
            }

            WorldState state = await Functions.GetWorldStateAsync(platform);
            return state.Timestamp;
        }

        /// <summary>
        /// Usage: new WarframeClient();
        /// </summary>
        public WarframeClient() { }
    }
}
