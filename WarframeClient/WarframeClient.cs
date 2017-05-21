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
        /// <returns></returns>
        public async Task<WorldState> GetWorldStateAsync(string platform)
        {
            if (!Platform.List.Where(x => x == platform).Any())
            {
                throw new PlatformNotFoundException($"Unknown game platform \"{platform}\"");
            }

            using (var client = new HttpClient())
            {
                #pragma warning disable 0618
                string endpoint = Endpoint.WorldState + platform;
                #pragma warning restore 0618

                // What? Let me use my own "obsolete" stuff >:]

                var response = await client.GetAsync(endpoint);

                response.EnsureSuccessStatusCode();

                var json = await response.Content.ReadAsStringAsync();

                WorldState state = JsonConvert.DeserializeObject<WorldState>(json);

                return state;
            }

        }

        /// <summary>
        /// Get a specific endpoint from the Warframe World State
        /// </summary>
        /// <param name="platform"> Platform to check on <seealso cref="Platform"/> </param>
        /// <param name="endpoint"> Endpoint to get <seealso cref="Endpoint"/> </param>
        /// <returns> Here's a list of possible return types:
        /// List`1[WarframeNET.Alert]
        /// List`1[WarframeNET.ConclaveChallenge]
        /// List`1[WarframeNET.DailyDeal]
        /// List`1[WarframeNET.DarkSector]
        /// List`1[WarframeNET.Event]
        /// List`1[WarframeNET.FlashSale]
        /// List`1[WarframeNET.Fissure]
        /// List`1[WarframeNET.GlobalUpgrade]
        /// List`1[WarframeNET.Invasion]
        /// List`1[WarframeNET.NewsArticle]
        /// List`1[WarframeNET.PersistentEnemy]
        /// WarframeNET.Simaris
        /// WarframeNET.Sortie
        /// List`1[WarframeNET.SyndicateMission]
        /// WarframeNET.VoidTrader</returns>
        public async Task<dynamic> GetWorldEndpointAsync(string platform, string endpoint)
        {
            if (!Platform.List.Any(x => x == platform))
            {
                throw new PlatformNotFoundException($"Unknown game platform \"{platform}\"");
            }

            if (!Endpoint.List.Any(x => x == endpoint))
            {
                throw new EndpointNotFoundException($"Unknown api endpoint \"{endpoint}\"");
            }

            WorldState WorldState;

            using (var client = new HttpClient())
            {
                #pragma warning disable 0618
                string EndUrl = Endpoint.WorldState + platform;
                var response = await client.GetAsync(EndUrl);

                response.EnsureSuccessStatusCode();

                var json = await response.Content.ReadAsStringAsync();

                WorldState = JsonConvert.DeserializeObject<WorldState>(json);
            }

            switch (endpoint)
            {
                case Endpoint.Alerts: return WorldState.WS_Alerts;;
                case Endpoint.ConclaveChallenges: return WorldState.WS_ConclaveChallenges;
                case Endpoint.DailyDeals: return WorldState.WS_DailyDeals;
                case Endpoint.DarkSectors: return WorldState.WS_DarkSectors;
                case Endpoint.Events: return WorldState.WS_Events;
                case Endpoint.Fissures: return WorldState.WS_Fissures;
                case Endpoint.FlashSales: return WorldState.WS_FlashSales;
                case Endpoint.GlobalUpgrades: return WorldState.WS_GlobalUpgrades;
                case Endpoint.Invasions: return WorldState.WS_Invasions;
                case Endpoint.News: return WorldState.WS_News;
                case Endpoint.PersistentEnemies: return WorldState.WS_PersistentEnemies;
                case Endpoint.Simaris: return WorldState.WS_Simaris;
                case Endpoint.Sortie: return WorldState.WS_Sortie;
                case Endpoint.SyndicateMissions: return WorldState.WS_SyndicateMissions;
                case Endpoint.VoidTrader: return WorldState.WS_VoidTrader;
                default: return null;
                #pragma warning restore 0618
            }
        }

        /// <summary>
        /// Usage: new WarframeClient();
        /// </summary>
        public WarframeClient() { }
    }
}
