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
        /// <returns></returns>
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
            
            Type type = typeof(WorldState);
            #pragma warning disable 0618
            if (endpoint != Endpoint.WorldState)
            {
                switch (endpoint)
                {
                    case Endpoint.Alerts: type = typeof(Alert); break;
                    case Endpoint.ConclaveChallenges: type = typeof(ConclaveChallenge); break;
                    case Endpoint.DailyDeals: type = typeof(DailyDeal); break;
                    case Endpoint.DarkSectors: type = typeof(DarkSector); break;
                    case Endpoint.Events: type = typeof(Event); break;
                    case Endpoint.Fissures: type = typeof(Fissure); break;
                    case Endpoint.FlashSales: type = typeof(FlashSale); break;
                    case Endpoint.GlobalUpgrades: type = typeof(GlobalUpgrade); break;
                    case Endpoint.Invasions: type = typeof(Invasion); break;
                    case Endpoint.News: type = typeof(NewsArticle); break;
                    case Endpoint.PersistentEnemies: type = typeof(PersistentEnemy); break;
                    case Endpoint.Simaris: type = typeof(Simaris); break;
                    case Endpoint.Sortie: type = typeof(Sortie); break;
                    case Endpoint.SyndicateMissions: type = typeof(SyndicateMission); break;
                    case Endpoint.VoidTrader: type = typeof(VoidTrader); break;
                }

                using (var client = new HttpClient())
                {
                    string EndUrl = Endpoint.WorldState + platform + endpoint;
                    var response = await client.GetAsync(EndUrl);

                    var json = await response.Content.ReadAsStringAsync();

                    var obj = Activator.CreateInstance(type);

                    obj = JsonConvert.DeserializeObject(json);

                    return obj;
                }
            }
            else
            {
                using (var client = new HttpClient())
                {

                    string EndUrl = Endpoint.WorldState + platform + endpoint;
                    var response = await client.GetAsync(EndUrl);

                    var json = await response.Content.ReadAsStringAsync();

                    var obj = JsonConvert.DeserializeObject<WorldState>(json);

                    return obj;
                }
            }
            #pragma warning restore 0618
        }

        public WarframeClient() { }
    }
}
