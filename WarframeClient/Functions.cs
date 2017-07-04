using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;

namespace WarframeNET
{
    internal static class Functions
    {
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
            using (var client = new HttpClient())
            {
                #pragma warning disable 0618
                string endpoint = Endpoint.WorldState + platform;
                #pragma warning restore 0618

                var response = await client.GetAsync(endpoint);
                response.EnsureSuccessStatusCode();
                var json = await response.Content.ReadAsStringAsync();
                WorldState state = JsonConvert.DeserializeObject<WorldState>(json);

                return state;
            }
        }
    }
}