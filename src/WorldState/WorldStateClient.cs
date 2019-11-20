using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

using WorldState.Data.Models;

namespace WorldState
{
    public class WorldStateClient : IDisposable
    {
        public Platform Platform { get; }

        internal HttpClient HttpClient { get; }

        private JsonSerializer serializer;
        private UriBuilder     builder;
        private string         platformAsString;

        public WorldStateClient(Platform platform)
        {
            HttpClient = new HttpClient();
            Platform   = platform;

            builder          = new UriBuilder(WorldStateEndpoints.Base);
            platformAsString = PlatformToString(platform);
            serializer       = JsonSerializer.CreateDefault();
        }

        public WorldStateClient(Platform platform, Uri baseUrl)
        {
            if (baseUrl == null) throw new ArgumentNullException(nameof(baseUrl));

            HttpClient = new HttpClient();
            Platform   = platform;

            builder          = new UriBuilder(baseUrl);
            platformAsString = PlatformToString(platform);
            serializer       = JsonSerializer.CreateDefault();
        }

        public WorldStateClient(Platform platform, Uri baseUrl, HttpMessageHandler messageHandler)
        {
            if (baseUrl == null) throw new ArgumentNullException(nameof(baseUrl));

            HttpClient = new HttpClient(messageHandler);
            Platform   = platform;

            builder          = new UriBuilder(baseUrl);
            platformAsString = PlatformToString(platform);
            serializer       = JsonSerializer.CreateDefault();
        }

        #region IDisposable

        protected virtual void Dispose(bool isDisposing)
        {
            if (!isDisposing) return;

            HttpClient?.Dispose();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        #endregion

        #region REST APIs

        public Task<Alert[]> Alerts()
        {
            builder.Path = platformAsString + WorldStateEndpoints.Alerts;
            return Get<Alert[]>(builder);
        }

        public Task<Acolyte[]> Acolytes()
        {
            builder.Path = platformAsString + WorldStateEndpoints.Acolytes;
            return Get<Acolyte[]>(builder);
        }

        public Task<CetusCycle> CetusCycle()
        {
            builder.Path = platformAsString + WorldStateEndpoints.CetusCycle;
            return Get<CetusCycle>(builder);
        }

        public Task<ConclaveChallenge[]> ConclaveChallenges()
        {
            builder.Path = platformAsString + WorldStateEndpoints.Conclaves;
            return Get<ConclaveChallenge[]>(builder);
        }

        public Task<DailyDeal[]> DailyDeals()
        {
            builder.Path = platformAsString + WorldStateEndpoints.DailyDeal;
            return Get<DailyDeal[]>(builder);
        }

        public Task<EarthCycle> EarthCycle()
        {
            builder.Path = platformAsString + WorldStateEndpoints.EarthRotation;
            return Get<EarthCycle>(builder);
        }

        public Task<Event[]> Events()
        {
            builder.Path = platformAsString + WorldStateEndpoints.Events;
            return Get<Event[]>(builder);
        }

        public Task<FlashSale[]> FlashSales()
        {
            builder.Path = platformAsString + WorldStateEndpoints.FlashSales;
            return Get<FlashSale[]>(builder);
        }

        public Task<ConstructionProgress> FleetConstructionProgress()
        {
            builder.Path = platformAsString + WorldStateEndpoints.Construction;
            return Get<ConstructionProgress>(builder);
        }

        public Task<GlobalUpgrade[]> GlobalUpgrades()
        {
            builder.Path = platformAsString + WorldStateEndpoints.GlobalBoosts;
            return Get<GlobalUpgrade[]>(builder);
        }

        public Task<Invasion[]> Invasions()
        {
            builder.Path = platformAsString + WorldStateEndpoints.Invasions;
            return Get<Invasion[]>(builder);
        }

        public Task<News[]> News()
        {
            builder.Path = platformAsString + WorldStateEndpoints.News;
            return Get<News[]>(builder);
        }

        public Task<Nightwave> Nightwave()
        {
            builder.Path = platformAsString + WorldStateEndpoints.Nightwave;
            return Get<Nightwave>(builder);
        }

        public Task<OrbVallisCycle> OrbVallisCycle()
        {
            builder.Path = platformAsString + WorldStateEndpoints.OrbVallis;
            return Get<OrbVallisCycle>(builder);
        }

        public async Task<RivenMod[]> RivenMods()
        {
            builder.Path = platformAsString + WorldStateEndpoints.Rivens;
            var json = (await Get<JToken>(builder).ConfigureAwait(false));

            if (json == null) return Array.Empty<RivenMod>();

            var mods = new List<RivenMod>(350);
            foreach (var category in json.Values())
            {
                foreach (var weapon in category.Values())
                {
                    foreach (var variant in weapon.Values())
                    {
                        if (!variant.HasValues) continue;

                        mods.Add(variant.ToObject<RivenMod>());
                    }
                }
            }

            return mods.ToArray();
        }

        public Task<Simaris> SimarisSanctuary()
        {
            builder.Path = platformAsString + WorldStateEndpoints.Sanctuary;
            return Get<Simaris>(builder);
        }

        public Task<Sortie[]> Sorties()
        {
            builder.Path = platformAsString + WorldStateEndpoints.Sortie;
            return Get<Sortie[]>(builder);
        }

        public Task<SyndicateMission[]> SyndicateMissions()
        {
            builder.Path = platformAsString + WorldStateEndpoints.SyndicateMissions;
            return Get<SyndicateMission[]>(builder);
        }

        public Task<Fissure[]> VoidFissureMissions()
        {
            builder.Path = platformAsString + WorldStateEndpoints.VoidMissions;
            return Get<Fissure[]>(builder);
        }

        public Task<VoidTrader> VoidTrader()
        {
            builder.Path = platformAsString + WorldStateEndpoints.VoidTrader;
            return Get<VoidTrader>(builder);
        }

        #endregion

        #region Helpers

        private static string PlatformToString(Platform platform)
        {
            switch (platform)
            {
            case Platform.PC:      return "/pc";
            case Platform.PS4:     return "/ps4";
            case Platform.XboxOne: return "/xb1";
            case Platform.Switch:  return "/swi";
            default:               throw new ArgumentOutOfRangeException(nameof(platform));
            }
        }

        private async Task<T> Get<T>(UriBuilder uri)
        {
            using (var stream = await HttpClient.GetStreamAsync(uri.Uri)
                                                .ConfigureAwait(false))
            using (var reader = new JsonTextReader(new StreamReader(stream, true)))
            {
                return serializer.Deserialize<T>(reader);
            }
        }

        #endregion
    }
}
