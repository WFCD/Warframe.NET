using System;
using System.IO;
using System.Threading.Tasks;

namespace WorldState
{
    /// <summary>
    /// <para>JSON text streams provider for World State clients. JSONs provided by implementation must conform to schemas documented on
    /// <a href="https://docs.warframestat.us/">warframestat.us</a>.</para>
    /// <para>For an implementation sample, see <see cref="WarframeStatusProvider"/>.</para>
    /// </summary>
    public abstract class WorldStateProvider : IDisposable
    {
        public Platform Platform { get; }

        public WorldStateProvider(Platform platform)
        {
            Platform = platform;
        }

        public abstract Task<StreamReader> GetWorldStateStreamAsync();
        public abstract Task<StreamReader> GetAlertStreamAsync();
        public abstract Task<StreamReader> GetAcolytesStreamAsync();
        public abstract Task<StreamReader> GetCetusCycleStreamAsync();
        public abstract Task<StreamReader> GetConclaveChallengesStreamAsync();
        public abstract Task<StreamReader> GetDailyDealsStreamAsync();
        public abstract Task<StreamReader> GetEarthCycleStreamAsync();
        public abstract Task<StreamReader> GetEventsStreamAsync();
        public abstract Task<StreamReader> GetFlashSalesStreamAsync();
        public abstract Task<StreamReader> GetFleetConstructionProgressStreamAsync();
        public abstract Task<StreamReader> GetGlobalUpgradesStreamAsync();
        public abstract Task<StreamReader> GetInvasionsStreamAsync();
        public abstract Task<StreamReader> GetNewsStreamAsync();
        public abstract Task<StreamReader> GetNightwaveStreamAsync();
        public abstract Task<StreamReader> GetOrbVallisCycleStreamAsync();
        public abstract Task<StreamReader> GetRivenModsStreamAsync();
        public abstract Task<StreamReader> GetSimarisSanctuaryStreamAsync();
        public abstract Task<StreamReader> GetSortieStreamAsync();
        public abstract Task<StreamReader> GetSyndicateMissionsStreamAsync();
        public abstract Task<StreamReader> GetVoidFissureMissionsStreamAsync();
        public abstract Task<StreamReader> GetVoidTraderStreamAsync();

        #region IDisposale

        protected abstract void Dispose(bool disposing);

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        #endregion
    }
}
