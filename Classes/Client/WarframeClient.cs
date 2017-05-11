using System;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace WarframeNET
{
    public class WarframeClient
    {
        /// <summary>
        /// Get the current world state for a given platform.
        /// </summary>
        /// <param name="platform"> The platform to get info from. See the Platform class.</param>
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
        /// <param name="platform"> Platform to check on (See Platform Class) </param>
        /// <param name="endpoint"> Endpoint to get (See Endpoint Class) </param>
        /// <returns> Selected endpoint</returns>
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
                default: return WorldState;
                #pragma warning restore 0618
            }
        }

        public WarframeClient() { }
    }
}
