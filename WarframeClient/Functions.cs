using System;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;

namespace WarframeNET
{
    internal static class Functions
    {
        private static readonly Lazy<HttpClient> persistentClient = new Lazy<HttpClient>();

        public static string ToCamel(string text)
        {
            char firstCamel = text[0];
            firstCamel = char.ToLower(firstCamel);
            string final = $"{firstCamel}";

            for (int i = 1; i < text.Length; i++)
            {
                final += text[i];
            }

            return final;
        }

        public static async Task<WorldState> GetWorldStateAsync(string platform)
        {
                #pragma warning disable 0618
                string endpoint = Endpoint.WorldState + platform;
                #pragma warning restore 0618

                var response = await persistentClient.Value.GetAsync(endpoint);
                response.EnsureSuccessStatusCode();
                var json = await response.Content.ReadAsStringAsync();
                WorldState state = JsonConvert.DeserializeObject<WorldState>(json);

                return state;
        }
    }
}