using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Http;
using Newtonsoft.Json;
using WorldState.Data.Enums;
using WorldState.Data.Models;

using static System.Console;

namespace Samples
{
    internal class Test : IDisposable
    {
        private const string Base = "https://api.warframestat.us";
        
        // HttpClient isn't available in NetStd 1.0
        // Something to consider when coding REST module.
        private static HttpClient Client = new HttpClient
        {
            BaseAddress = new Uri(Base)
        };
        
        static void Main(string[] args)
        {
            if (!Ping()) throw new WebException("Couldn't connect to WarframeStat. ARE YOU STILL ONLINE?");
            
            var fissures = GetPCFissures();
            // Do not group all the debugger conditionals into a function for shorthand.
            // Otherwise, you'll need to switch between stacks to see current variables.
            if (Debugger.IsAttached) Debugger.Break();

            var alerts = GetPCAlerts();
            if (Debugger.IsAttached) Debugger.Break();
            
            var invasions = GetPCInvasions();
            if (Debugger.IsAttached) Debugger.Break();

            if (Debugger.IsAttached)
            {
                Debug.WriteLine("EoL");
                ReadKey();
                return;
            }

            Console.WriteLine("You should run this program with debugger attached.");
        }

        static IEnumerable<Fissure> GetPCFissures()
        {
            using (var stream = Client.GetStreamAsync("/pc/fissures").Result)
            using (var reader = new StreamReader(stream))
            using (var json = new JsonTextReader(reader))
            {
                var result = JsonSerializer.CreateDefault().Deserialize<List<Fissure>>(json);
                return result;
            }
        }

        static IEnumerable<Alert> GetPCAlerts()
        {
            using (var stream = Client.GetStreamAsync("/pc/alerts").Result)
            using (var reader = new StreamReader(stream))
            using (var json = new JsonTextReader(reader))
            {
                var result = JsonSerializer.CreateDefault().Deserialize<List<Alert>>(json);
                return result;
            }
        }

        static IEnumerable<Invasion> GetPCInvasions()
        {
            using (var stream = Client.GetStreamAsync($"/pc/invasions").Result)
            using (var reader = new StreamReader(stream))
            using (var json = new JsonTextReader(reader))
            {
                var result = JsonSerializer.CreateDefault().Deserialize<List<Invasion>>(json);
                return result;
            }
        }

        static bool Ping()
        {
            // Note: I heard ".Result" is bad.
            using (var response = Client.GetAsync("/heartbeat").Result)
            {
                return response.IsSuccessStatusCode;
            }
        }

        public void Dispose()
        {
            Client.Dispose();
        }
    }
}
