using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace WorldState
{
    /// <summary>
    /// A <see cref="WorldStateProvider"/> that uses online data from <a href="https://docs.warframestat.us/">docs.warframestat.us</a>.
    /// </summary>
    public sealed class WarframeStatusProvider : WorldStateProvider
    {
        /// <summary>
        /// Reusable <see cref="HttpClient"/> that facilitates HTTP exchanges with <a href="https://docs.warframestat.us/">docs.warframestat.us</a>.
        /// </summary>
        internal HttpClient Client { get; }

        /// <summary>
        /// The root URL of <a href="https://docs.warframestat.us/">docs.warframestat.us</a> or its mirror.
        /// </summary>
        private readonly Uri baseUri;

        /// <summary>
        /// Instantiate <see cref="WarframeStatusProvider"/> for the given platform.
        /// </summary>
        /// <param name="platform">
        /// <para>The <see cref="Platform"/> to request World State for.</para>
        /// <para>Once instantiated, the platform will be fixed in this <see cref="WorldStateProvider"/>.
        /// To obtain World State for another platform, create the same provider with a different <see cref="Platform"/>.</para>
        /// </param>
        public WarframeStatusProvider(Platform platform) : base(platform)
        {
            baseUri = WorldStateEndpoints.Base;
        }

        /// <summary>
        /// Instantiate <see cref="WarframeStatusProvider"/> with given parameters. See documentation on each parameter.
        /// </summary>
        /// <param name="platform">
        /// <para>The <see cref="Platform"/> to request World State for.</para>
        /// <para>Once instantiated, the platform will be fixed in this <see cref="WorldStateProvider"/>.
        /// To obtain World State for another platform, create the same provider with a different <see cref="Platform"/>.</para>
        /// </param>
        /// <param name="mirror">A root URL that may differ from <see cref="WorldStateEndpoints.Base"/>.</param>
        /// <param name="handler">Custom handler for HTTP requests.</param>
        public WarframeStatusProvider(Platform platform, Uri mirror, HttpMessageHandler handler) : base(platform)
        {
            baseUri = mirror;
            Client  = new HttpClient(handler);
        }

        public override Task<StreamReader> GetWorldStateStreamAsync()
        {
            return Get(new Uri(baseUri,
                               WorldStateEndpoints.PlatformToPath(Platform)));
        }

        public override Task<StreamReader> GetAlertStreamAsync()
        {
            return Get(new Uri(baseUri,
                               WorldStateEndpoints.PlatformToPath(Platform) + WorldStateEndpoints.Alerts));
        }

        public override Task<StreamReader> GetAcolytesStreamAsync()
        {
            return Get(new Uri(baseUri,
                               WorldStateEndpoints.PlatformToPath(Platform) + WorldStateEndpoints.Acolytes));
        }

        public override Task<StreamReader> GetCetusCycleStreamAsync()
        {
            return Get(new Uri(baseUri,
                               WorldStateEndpoints.PlatformToPath(Platform) + WorldStateEndpoints.CetusCycle));
        }

        public override Task<StreamReader> GetConclaveChallengesStreamAsync()
        {
            return Get(new Uri(baseUri,
                               WorldStateEndpoints.PlatformToPath(Platform) + WorldStateEndpoints.ConclaveChallenges));
        }

        public override Task<StreamReader> GetDailyDealsStreamAsync()
        {
            return Get(new Uri(baseUri,
                               WorldStateEndpoints.PlatformToPath(Platform) + WorldStateEndpoints.DailyDeals));
        }

        public override Task<StreamReader> GetEarthCycleStreamAsync()
        {
            return Get(new Uri(baseUri,
                               WorldStateEndpoints.PlatformToPath(Platform) + WorldStateEndpoints.EarthRotation));
        }

        public override Task<StreamReader> GetEventsStreamAsync()
        {
            return Get(new Uri(baseUri,
                               WorldStateEndpoints.PlatformToPath(Platform) + WorldStateEndpoints.Events));
        }

        public override Task<StreamReader> GetFlashSalesStreamAsync()
        {
            return Get(new Uri(baseUri,
                               WorldStateEndpoints.PlatformToPath(Platform) + WorldStateEndpoints.FlashSales));
        }

        public override Task<StreamReader> GetConstructionStatusStreamAsync()
        {
            return Get(new Uri(baseUri,
                               WorldStateEndpoints.PlatformToPath(Platform) + WorldStateEndpoints.Construction));
        }

        public override Task<StreamReader> GetGlobalUpgradesStreamAsync()
        {
            return Get(new Uri(baseUri,
                               WorldStateEndpoints.PlatformToPath(Platform) + WorldStateEndpoints.GlobalBoosts));
        }

        public override Task<StreamReader> GetInvasionsStreamAsync()
        {
            return Get(new Uri(baseUri,
                               WorldStateEndpoints.PlatformToPath(Platform) + WorldStateEndpoints.Invasions));
        }

        public override Task<StreamReader> GetNewsStreamAsync()
        {
            return Get(new Uri(baseUri,
                               WorldStateEndpoints.PlatformToPath(Platform) + WorldStateEndpoints.News));
        }

        public override Task<StreamReader> GetNightwaveStreamAsync()
        {
            return Get(new Uri(baseUri,
                               WorldStateEndpoints.PlatformToPath(Platform) + WorldStateEndpoints.Nightwave));
        }

        public override Task<StreamReader> GetOrbVallisCycleStreamAsync()
        {
            return Get(new Uri(baseUri,
                               WorldStateEndpoints.PlatformToPath(Platform) + WorldStateEndpoints.OrbVallis));
        }

        public override Task<StreamReader> GetRivenModsStreamAsync()
        {
            return Get(new Uri(baseUri,
                               WorldStateEndpoints.PlatformToPath(Platform) + WorldStateEndpoints.Rivens));
        }

        public override Task<StreamReader> GetSimarisTargetStreamAsync()
        {
            return Get(new Uri(baseUri,
                               WorldStateEndpoints.PlatformToPath(Platform) + WorldStateEndpoints.Sanctuary));
        }

        public override Task<StreamReader> GetSortieStreamAsync()
        {
            return Get(new Uri(baseUri,
                               WorldStateEndpoints.PlatformToPath(Platform) + WorldStateEndpoints.Sorties));
        }

        public override Task<StreamReader> GetSyndicateStreamAsync()
        {
            return Get(new Uri(baseUri,
                               WorldStateEndpoints.PlatformToPath(Platform) + WorldStateEndpoints.SyndicateMissions));
        }

        public override Task<StreamReader> GetVoidFissureMissionsStreamAsync()
        {
            return Get(new Uri(baseUri,
                               WorldStateEndpoints.PlatformToPath(Platform) + WorldStateEndpoints.VoidMissions));
        }

        public override Task<StreamReader> GetVoidTraderStreamAsync()
        {
            return Get(new Uri(baseUri,
                               WorldStateEndpoints.PlatformToPath(Platform) + WorldStateEndpoints.VoidTrader));
        }

        #region Helpers

        private async Task<StreamReader> Get(Uri uri)
        {
            var stream = await Client.GetStreamAsync(uri)
                                     .ConfigureAwait(false);
            return new StreamReader(stream, true);
        }

        #endregion

        #region IDisposable

        protected override void Dispose(bool disposing)
        {
            if (!disposing) return;

            Client?.Dispose();
        }

        #endregion
    }
}
