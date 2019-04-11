using System;
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
    public class WarframeClient : IDisposable
    {
        /// <summary>
        /// Get the current world state for a given platform.
        /// </summary>
        /// <param name="platform"> The platform to get info from. <seealso cref="Platform"/> </param>
        /// <returns>The WorldState <seealso cref="WorldState"/></returns>
        public async Task<WorldState> GetWorldStateAsync(string platform)
        {
            if (!Platform.List.Any(x => x == platform))
            {
                throw new PlatformNotFoundException($"Unknown game platform \"{platform}\"");
            }

#pragma warning disable 0618
            var endpoint = Endpoint.WorldState + platform;
#pragma warning restore 0618

            var response = await HttpClient.GetAsync(endpoint).ConfigureAwait(false);
            var json = await response.EnsureSuccessStatusCode().Content.ReadAsStringAsync().ConfigureAwait(false);
            var state = JsonConvert.DeserializeObject<WorldState>(json);

            return state;
        }

        private async Task<T> Get<T>(string platform, Func<WorldState, T> func)
        {
            return func(await GetWorldStateAsync(platform).ConfigureAwait(false));
        }

        /// <summary>
        /// Get the current alerts for a given platform.
        /// </summary>
        /// <param name="platform"> The platform to get info from. <seealso cref="Platform"/></param>
        /// <returns>A list of Alerts <seealso cref="Alert"/></returns>
        public async Task<List<Alert>> GetAlertsAsync(string platform) => await Get(platform, ws => ws.Alerts).ConfigureAwait(false);

        public async Task<CetusCycle> GetCetusCycleAsync(string platform) => await Get(platform, ws => ws.CetusCycle).ConfigureAwait(false);

        /// <summary>
        /// Get the current conclave challenges for a given platform.
        /// </summary>
        /// <param name="platform"> The platform to get info from. <seealso cref="Platform"/></param>
        /// <returns>A list of Conclave Challenges <seealso cref="ConclaveChallenge"/></returns>
        public async Task<List<ConclaveChallenge>> GetConclaveChallengesAsync(string platform) => await Get(platform, ws => ws.ConclaveChallenges).ConfigureAwait(false);

        /// <summary>
        /// Get the current daily deals for a given platform.
        /// </summary>
        /// <param name="platform"> The platform to get info from. <seealso cref="Platform"/></param>
        /// <returns>A list of Daily Deals <seealso cref="DailyDeal"/></returns>
        public async Task<List<DailyDeal>> GetDailyDealsAsync(string platform) => await Get(platform, ws => ws.DailyDeals).ConfigureAwait(false);

        /// <summary>
        /// Gets the dark sectors for a given platform.
        /// </summary>
        /// <param name="platform"> The platform to get info from. <seealso cref="Platform"/></param>
        /// <returns>A list of Alerts <seealso cref="DarkSector"/></returns>
        public async Task<List<DarkSector>> GetDarkSectorsAsync(string platform) => await Get(platform, ws => ws.DarkSectors).ConfigureAwait(false);

        public async Task<EarthCycle> GetEarthCycleAsync(string platform) => await Get(platform, ws => ws.EarthCycle).ConfigureAwait(false);

        /// <summary>
        /// Get the current events for a given platform.
        /// </summary>
        /// <param name="platform"> The platform to get info from. <seealso cref="Platform"/></param>
        /// <returns>A list of Events <seealso cref="Event"/></returns>
        public async Task<List<Event>> GetEventsAsync(string platform) => await Get(platform, ws => ws.Events).ConfigureAwait(false);

        /// <summary>
        /// Get the current fissures for a given platform.
        /// </summary>
        /// <param name="platform"> The platform to get info from. <seealso cref="Platform"/></param>
        /// <returns>A list of Fissures <seealso cref="Fissure"/></returns>
        public async Task<List<Fissure>> GetFissuresAsync(string platform) => await Get(platform, ws => ws.Fissures).ConfigureAwait(false);

        /// <summary>
        /// Get the current flash sales for a given platform.
        /// </summary>
        /// <param name="platform"> The platform to get info from. <seealso cref="Platform"/></param>
        /// <returns>A list of Flash Sales <seealso cref="FlashSale"/></returns>
        public async Task<List<FlashSale>> GetFlashSalesAsync(string platform) => await Get(platform, ws => ws.FlashSales).ConfigureAwait(false);

        /// <summary>
        /// Get the current global upgrades for a given platform.
        /// </summary>
        /// <param name="platform"> The platform to get info from. <seealso cref="Platform"/></param>
        /// <returns>A list of Global Upgrades <seealso cref="GlobalUpgrade"/></returns>
        public async Task<List<GlobalUpgrade>> GetGlobalUpgradesAsync(string platform) => await Get(platform, ws => ws.GlobalUpgrades).ConfigureAwait(false);

        /// <summary>
        /// Get the current invasions for a given platform.
        /// </summary>
        /// <param name="platform"> The platform to get info from. <seealso cref="Platform"/></param>
        /// <returns>A list of Invasions <seealso cref="Invasion"/></returns>
        public async Task<List<Invasion>> GetInvasionsAsync(string platform) => await Get(platform, ws => ws.Invasions).ConfigureAwait(false);

        public async Task<InvasionFleetConstructionProgress> GetInvasionFleetConstructionProgressAsync(string platform) => await Get(platform, ws => ws.InvasionFleetConstructionProgress).ConfigureAwait(false);

        /// <summary>
        /// Get the current news for a given platform.
        /// </summary>
        /// <param name="platform"> The platform to get info from. <seealso cref="Platform"/></param>
        /// <returns>A list of News Articles <seealso cref="NewsArticle"/></returns>
        public async Task<List<NewsArticle>> GetNewsAsync(string platform) => await Get(platform, ws => ws.News).ConfigureAwait(false);

        public async Task<Nightwave> GetNightwaveAsync(string platform) => await Get(platform, ws => ws.Nightwave).ConfigureAwait(false);

        /// <summary>
        /// Get the current persistent enemies for a given platform.
        /// </summary>
        /// <param name="platform"> The platform to get info from. <seealso cref="Platform"/></param>
        /// <returns>A list of Persistent Enemies <seealso cref="PersistentEnemy"/></returns>
        public async Task<List<PersistentEnemy>> GetPersistentEnemiesAsync(string platform) => await Get(platform, ws => ws.PersistentEnemies).ConfigureAwait(false);

        /// <summary>
        /// Get the current news for a given platform.
        /// </summary>
        /// <param name="platform"> The platform to get info from. <seealso cref="Platform"/></param>
        /// <returns>The current Simaris mission <seealso cref="Simaris"/></returns>
        [Obsolete("This endpoint is obsolete and shouldn't be used anymore.")]
        public async Task<Simaris> GetSimarisAsync(string platform) => await Get(platform, ws => ws.WS_Simaris).ConfigureAwait(false);

        /// <summary>
        /// Get the current sortie for a given platform.
        /// </summary>
        /// <param name="platform"> The platform to get info from. <seealso cref="Platform"/></param>
        /// <returns>The current Sortie<seealso cref="Sortie"/></returns>
        public async Task<Sortie> GetSortieAsync(string platform) => await Get(platform, ws => ws.Sortie).ConfigureAwait(false);

        /// <summary>
        /// Get the current syndicate missions for a given platform.
        /// </summary>
        /// <param name="platform"> The platform to get info from. <seealso cref="Platform"/></param>
        /// <returns>A list of News Articles <seealso cref="NewsArticle"/></returns>
        public async Task<List<SyndicateMission>> GetSyndicateMissionsAsync(string platform) => await Get(platform, ws => ws.SyndicateMissions).ConfigureAwait(false);

        public async Task<VallisCycle> GetVallisCycleAsync(string platform) => await Get(platform, ws => ws.VallisCycle).ConfigureAwait(false);

        /// <summary>
        /// Get the current void trader for a given platform.
        /// </summary>
        /// <param name="platform"> The platform to get info from. <seealso cref="Platform"/></param>
        /// <returns>The current Void Trader's items. <seealso cref="VoidTrader"/></returns>
        public async Task<VoidTrader> GetVoidTraderAsync(string platform) => await Get(platform, ws => ws.VoidTrader).ConfigureAwait(false);

        /// <summary>
        /// Get the timestamp of the last modification of the World State.
        /// </summary>
        /// <param name="platform"> The platform to get info from. <seealso cref="Platform"/></param>
        /// <returns>DateTime (last modification) <seealso cref="NewsArticle"/></returns>
        public async Task<DateTime> GetTimestampAsync(string platform) => await Get(platform, ws => ws.Timestamp).ConfigureAwait(false);

        private readonly HttpClient HttpClient;

        /// <summary>
        /// Usage: new WarframeClient();
        /// </summary>
        public WarframeClient()
        {
            HttpClient = new HttpClient();
        }

        public void Dispose()
        {
            HttpClient.Dispose();
        }
    }
}
