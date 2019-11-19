using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

using Newtonsoft.Json;

using WorldState.Data.Models;

namespace WorldState
{
    public class WorldStateClient : IDisposable
    {
        public HttpClient HttpClient { get; }
        public Platform   Platform   { get; }

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

        public Task<ConstructionProgress> FleetConstructionProgress()
        {
            builder.Path = platformAsString + WorldStateEndpoints.Construction;
            return Get<ConstructionProgress>(builder);
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
