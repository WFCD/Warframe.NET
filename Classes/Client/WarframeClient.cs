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
        /// Get the current state of a Warframe World State Endpoint.
        /// </summary>
        /// <typeparam name="T"> The object to return. Must be from WarframeNET and a correct endpoint.</typeparam>
        /// <param name="platform"> The platform to get info from. See the Platform class.</param>
        /// <returns></returns>
        public async Task<T> GetWorldEndpointAsync<T>(string platform)
        {
            var type = typeof(T);

            if (type.Namespace != nameof(WarframeNET))
            {
                throw new OutOfNamespaceException($"Objects given must be from the WarframeNET namespace");
            }

            if (!Platform.List.Any(x => x == platform))
            {
                throw new PlatformNotFoundException($"Unknown game platform \"{platform}\"");
            }

            var name = Functions.ToCamel(nameof(T));

            if (!Endpoint.List.Any(x => x == (name)))
            {
                throw new EndpointNotFoundException($"Unknown api endpoint {nameof(T)}");
            }

            using (var client = new HttpClient())
            {
                #pragma warning disable 0618
                string endpoint = Endpoint.WorldState + platform + name;
                #pragma warning restore 0618
                var response = await client.GetAsync(endpoint);

                var json = await response.Content.ReadAsStringAsync();

                T obj = JsonConvert.DeserializeObject<T>(json);

                return obj;
            }
        }

        public WarframeClient() { }
    }
}
