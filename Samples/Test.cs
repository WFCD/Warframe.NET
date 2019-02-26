using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Http;
using Newtonsoft.Json;

using WorldState.Data.Models;

using static System.Console;

namespace Samples
{
    internal class Test : IDisposable
    {
        private const string Base = "https://api.warframestat.us";
        
        static HttpClient Client = new HttpClient
        {
            BaseAddress = new Uri(Base)
        };
        
        static void Main(string[] args)
        {
            if (!Ping()) throw new WebException("Couldn't connect to WarframeStat.");

            var alerts = GetPCAlerts();
            if (Debugger.IsAttached) Debugger.Break();
            
            var invasions = GetPCInvasions();
            if (Debugger.IsAttached) Debugger.Break();

            if (Debugger.IsAttached)
            {
                Debug.WriteLine("EoL");
                return;
            }

            Console.WriteLine("You should run this program with debugger attached.");
            ReadKey();
        }

        static List<Alert> GetPCAlerts()
        {
            using (var stream = Client.GetStreamAsync("/pc/alerts").Result)
            using (var reader = new StreamReader(stream))
            using (var json = new JsonTextReader(reader))
            {
                var result = JsonSerializer.CreateDefault().Deserialize<List<Alert>>(json);
                return result;
            }
        }

        static List<Invasion> GetPCInvasions()
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
            var response = Client.GetAsync("/heartbeat").Result;
            return response.IsSuccessStatusCode;
        }

        public void Dispose()
        {
            Client.Dispose();
        }
    }
}
