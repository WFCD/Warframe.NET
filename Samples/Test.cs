using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net;

using Newtonsoft.Json;

using WorldState.Data.Models;

using static System.Console;

namespace Samples
{
    internal class Test
    {
        static void Main(string[] args)
        {
            var invasions = ParseInvasions();
            if (Debugger.IsAttached) Debugger.Break();

            ReadKey();
        }

        static List<Invasion> ParseInvasions()
        {
            using (var client = new WebClient())
            using (var stream = client.OpenRead("https://api.warframestat.us/pc/invasions"))
            using (var reader = new StreamReader(stream))
            using (var json = new JsonTextReader(reader))
            {
                var result = JsonSerializer.CreateDefault().Deserialize<List<Invasion>>(json);
                return result;
            }
        }
    }
}
