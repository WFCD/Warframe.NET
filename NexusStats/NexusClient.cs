using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace WarframeNET.NexusStats
{
    /// <summary>
    /// Client used to GET from NexusStats
    /// </summary>
    public class NexusClient
    {
        /// <summary>
        /// Get the item list from NexusStats
        /// </summary>
        /// <returns>List[NexusItemInfo]</returns>
        public async Task<List<NexusItemInfo>> GetItemListAsync()
        {
            using (var client = new HttpClient())
            {
                var response = await client.GetAsync("https://api.nexus-stats.com/warframe/v1/items/list");
                response.EnsureSuccessStatusCode();

                var json = await response.Content.ReadAsStringAsync();

                var list = JsonConvert.DeserializeObject<List<NexusItemInfo>>(json);
                return list;
            }
        }

        /// <summary>
        /// Get an item from NexusStats
        /// </summary>
        /// <param name="name"></param>
        /// <returns>NexusItem, or empty object if unknown</returns>
        public async Task<NexusItem> GetItemAsync(string name)
        {
            name = name.Replace(" ", "%20");

            using (var client = new HttpClient())
            {
                var response = await client.GetAsync($"https://api.nexus-stats.com/warframe/v1/items/{name}/statistics");
                response.EnsureSuccessStatusCode();

                var json = await response.Content.ReadAsStringAsync();

                try
                {
                    var item = JsonConvert.DeserializeObject<NexusItem>(json);
                    return item;
                }
                catch(System.Exception e)
                {
                    System.Console.WriteLine(e.StackTrace);
                    return null;
                }
            }
        }

        /// <summary>
        /// Get a player profile from NexusStats
        /// </summary>
        /// <param name="name">Name of the player.</param>
        /// <returns></returns>
        /// <seealso cref="NexusProfile"/>
        public async Task<NexusProfile> GetProfileAsync(string name)
        {
            name = name.Replace(" ", "%20");

            using (var client = new HttpClient())
            {
                var response = await client.GetAsync($"https://api.nexus-stats.com/warframe/v1/players/{name}/profile");
                response.EnsureSuccessStatusCode();

                var json = await response.Content.ReadAsStringAsync();
                var obj = JsonConvert.DeserializeObject<NexusProfile>(json);

                if (obj.Error is string error)
                {
                    System.Console.WriteLine("[WarframeNET.NexusStats] An error has occured while fetching information for player: " + name);
                    System.Console.WriteLine("[WarframeNET.NexusStats] Reason: " + obj.ErrorReason);
                    return null;
                }
                else
                {
                    return obj;
                }
            }
        }

        /// <summary>
        /// Create a new instance of NexusClient
        /// </summary>
        public NexusClient() { }
    }
}
