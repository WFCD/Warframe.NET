using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace WorldState
{
    /// <summary>
    /// <para>A base class that provides JSON text streams for World State clients.
    /// This class must be inherited; and the implementation must operate on JSONs that conform to schemas documented on
    /// <a href="https://docs.warframestat.us/">docs.warframestat.us</a>.</para>
    /// <para>For a sample working implementation, see <see cref="WarframeStatusProvider"/>.
    /// For an offline/testable implementation, see <see cref="LocalWorldStateProvider"/>.</para>
    /// </summary>
    public abstract class WorldStateProvider : IDisposable
    {
        /// <summary>
        /// <para>The provider retrieves World State for this particular platform.</para>
        /// <para>To obtain data for a different platform, instantiate the same provider with a different <see cref="WorldState.Platform"/>.</para>
        /// </summary>
        public Platform Platform { get; }

        /// <summary>
        /// Instantiate <see cref="WorldStateProvider"/> and set the <see cref="Platform"/>.
        /// </summary>
        /// <param name="platform"></param>
        public WorldStateProvider(Platform platform)
        {
            Platform = platform;
        }

        /// <summary>
        /// <para>Requests JSON that contains the entire World State from this provider,
        /// then creates a <see cref="StreamReader"/> that reads over JSON text.</para>
        /// </summary>
        /// <returns>An ongoing <see cref="Task"/> that returns the <see cref="StreamReader"/> at completion.</returns>
        public abstract Task<StreamReader> GetWorldStateStreamAsync();

        /// <summary>
        /// <para>Requests JSON that contains only
        /// <a href="https://warframe.fandom.com/wiki/Alert">Alert</a>s,
        /// then creates a <see cref="StreamReader"/> that reads over JSON text.</para>
        /// </summary>
        /// <returns>An async <see cref="Task"/> that returns the <see cref="StreamReader"/> at completion.</returns>
        public abstract Task<StreamReader> GetAlertStreamAsync();

        /// <summary>
        /// <para>Requests JSON that contains only
        /// <a href="https://warframe.fandom.com/wiki/Acolytes">Acolytes</a>,
        /// then creates a <see cref="StreamReader"/> that reads over JSON text.</para>
        /// </summary>
        /// <returns>An async <see cref="Task"/> that returns the <see cref="StreamReader"/> at completion.</returns>
        public abstract Task<StreamReader> GetAcolytesStreamAsync();

        /// <summary>
        /// <para>Requests JSON that contains only day/night cycle of
        /// <a href="https://warframe.fandom.com/wiki/Cetus">Cetus</a>,
        /// then creates a <see cref="StreamReader"/> that reads over JSON text.</para>
        /// </summary>
        /// <returns>An async <see cref="Task"/> that returns the <see cref="StreamReader"/> at completion.</returns>
        public abstract Task<StreamReader> GetCetusCycleStreamAsync();

        /// <summary>
        /// <para>Requests JSON that contains only
        /// <a href="https://warframe.fandom.com/wiki/Conclave">Conclave</a> challenges,
        /// then creates a <see cref="StreamReader"/> that reads over JSON text.</para>
        /// </summary>
        /// <returns>An async <see cref="Task"/> that returns the <see cref="StreamReader"/> at completion.</returns>
        public abstract Task<StreamReader> GetConclaveChallengesStreamAsync();

        /// <summary>
        /// <para>Requests JSON that contains only
        /// <a href="https://warframe.fandom.com/wiki/Darvo">Darvo</a>’s daily inventory,
        /// then creates a <see cref="StreamReader"/> that reads over JSON text.</para>
        /// </summary>
        /// <returns>An async <see cref="Task"/> that returns the <see cref="StreamReader"/> at completion.</returns>
        public abstract Task<StreamReader> GetDailyDealsStreamAsync();

        /// <summary>
        /// <para>Requests JSON that contains only day/night cycle of
        /// planet <a href="https://warframe.fandom.com/wiki/Earth">Earth</a>,
        /// then creates a <see cref="StreamReader"/> that reads over JSON text.</para>
        /// </summary>
        /// <returns>An async <see cref="Task"/> that returns the <see cref="StreamReader"/> at completion.</returns>
        public abstract Task<StreamReader> GetEarthCycleStreamAsync();

        /// <summary>
        /// <para>Requests JSON that contains only large-scale
        /// <a href="https://warframe.fandom.com/wiki/Category%3AEvent">Events</a>,
        /// then creates a <see cref="StreamReader"/> that reads over JSON text.</para>
        /// </summary>
        /// <returns>An async <see cref="Task"/> that returns the <see cref="StreamReader"/> at completion.</returns>
        public abstract Task<StreamReader> GetEventsStreamAsync();

        /// <summary>
        /// <para>Requests JSON that contains only
        /// <a href="https://warframe.fandom.com/wiki/Darvo">Darvo</a>’s Flash Sale inventory,
        /// then creates a <see cref="StreamReader"/> that reads over JSON text.</para>
        /// </summary>
        /// <returns>An async <see cref="Task"/> that returns the <see cref="StreamReader"/> at completion.</returns>
        public abstract Task<StreamReader> GetFlashSalesStreamAsync();

        /// <summary>
        /// <para>Requests JSON that contains only
        /// <a href="https://warframe.fandom.com/wiki/Invasion#Aftermath">Construction Status</a> of enemy Fomorian/Armada,
        /// then creates a <see cref="StreamReader"/> that reads over JSON text.</para>
        /// </summary>
        /// <returns>An async <see cref="Task"/> that returns the <see cref="StreamReader"/> at completion.</returns>
        public abstract Task<StreamReader> GetConstructionStatusStreamAsync();

        /// <summary>
        /// <para>Requests JSON that contains only global boost,
        /// then creates a <see cref="StreamReader"/> that reads over JSON text.</para>
        /// </summary>
        /// <returns>An async <see cref="Task"/> that returns the <see cref="StreamReader"/> at completion.</returns>
        public abstract Task<StreamReader> GetGlobalUpgradesStreamAsync();

        /// <summary>
        /// <para>Requests JSON that contains only
        /// <a href="https://warframe.fandom.com/wiki/Invasion">Invasion</a> missions,
        /// then creates a <see cref="StreamReader"/> that reads over JSON text.</para>
        /// </summary>
        /// <returns>An async <see cref="Task"/> that returns the <see cref="StreamReader"/> at completion.</returns>
        public abstract Task<StreamReader> GetInvasionsStreamAsync();

        /// <summary>
        /// <para>Requests JSON that contains only official announcements and updates,
        /// then creates a <see cref="StreamReader"/> that reads over JSON text.</para>
        /// </summary>
        /// <returns>An async <see cref="Task"/> that returns the <see cref="StreamReader"/> at completion.</returns>
        public abstract Task<StreamReader> GetNewsStreamAsync();

        /// <summary>
        /// <para>Requests JSON that contains only
        /// <a href="https://warframe.fandom.com/wiki/Nightwave">Nightwave</a> challenges,
        /// then creates a <see cref="StreamReader"/> that reads over JSON text.</para>
        /// </summary>
        /// <returns>An async <see cref="Task"/> that returns the <see cref="StreamReader"/> at completion.</returns>
        public abstract Task<StreamReader> GetNightwaveStreamAsync();

        /// <summary>
        /// <para>Requests JSON that contains only warm/cold cycle of
        /// <a href="https://warframe.fandom.com/wiki/Orb_Vallis">The Orb Vallis</a>,
        /// then creates a <see cref="StreamReader"/> that reads over JSON text.</para>
        /// </summary>
        /// <returns>An async <see cref="Task"/> that returns the <see cref="StreamReader"/> at completion.</returns>
        public abstract Task<StreamReader> GetOrbVallisCycleStreamAsync();

        /// <summary>
        /// <para>Requests JSON that contains only statistics of
        /// <a href="https://warframe.fandom.com/wiki/Riven_Mods">Riven Mods</a>,
        /// then creates a <see cref="StreamReader"/> that reads over JSON text.</para>
        /// </summary>
        /// <returns>An async <see cref="Task"/> that returns the <see cref="StreamReader"/> at completion.</returns>
        public abstract Task<StreamReader> GetRivenModsStreamAsync();

        /// <summary>
        /// <para>Requests JSON that contains only
        /// <a href="https://warframe.fandom.com/wiki/Cephalon_Simaris">Simaris’</a> target,
        /// then creates a <see cref="StreamReader"/> that reads over JSON text.</para>
        /// </summary>
        /// <returns>An async <see cref="Task"/> that returns the <see cref="StreamReader"/> at completion.</returns>
        public abstract Task<StreamReader> GetSimarisTargetStreamAsync();

        /// <summary>
        /// <para>Requests JSON that contains only
        /// <a href="https://warframe.fandom.com/wiki/Sortie">Srotie</a> missions,
        /// then creates a <see cref="StreamReader"/> that reads over JSON text.</para>
        /// </summary>
        /// <returns>An async <see cref="Task"/> that returns the <see cref="StreamReader"/> at completion.</returns>
        public abstract Task<StreamReader> GetSortieStreamAsync();

        /// <summary>
        /// <para>Requests JSON that contains only
        /// <a href="https://warframe.fandom.com/wiki/Syndicate">Syndicate</a> missions,
        /// then creates a <see cref="StreamReader"/> that reads over JSON text.</para>
        /// </summary>
        /// <returns>An async <see cref="Task"/> that returns the <see cref="StreamReader"/> at completion.</returns>
        public abstract Task<StreamReader> GetSyndicateStreamAsync();

        /// <summary>
        /// <para>Requests JSON that contains only
        /// <a href="https://warframe.fandom.com/wiki/Void_Fissure">Void Fissure</a> missions,
        /// then creates a <see cref="StreamReader"/> that reads over JSON text.</para>
        /// </summary>
        /// <returns>An async <see cref="Task"/> that returns the <see cref="StreamReader"/> at completion.</returns>
        public abstract Task<StreamReader> GetVoidFissureMissionsStreamAsync();

        /// <summary>
        /// <para>Requests JSON that contains only
        /// <a href="https://warframe.fandom.com/wiki/Baro_Ki'Teer">Baro Ki'Teer</a>’s inventory,
        /// then creates a <see cref="StreamReader"/> that reads over JSON text.</para>
        /// </summary>
        /// <returns>An async <see cref="Task"/> that returns the <see cref="StreamReader"/> at completion.</returns>
        public abstract Task<StreamReader> GetVoidTraderStreamAsync();

        #region IDisposale

        /// <summary>
        /// <para>An <see cref="IDisposable"/> interface is added to the abstract base class,
        /// so that clients who hold a reference to this base class can effectively dispose unmanaged resources
        /// used by implementations.</para>
        /// <para>If an implementation uses unmanaged resources,
        /// such as <see cref="Stream"/>s or <see cref="HttpClient"/>s,
        /// it should implement this method and dispose those resources when the <see cref="disposing"/> parameter is true.</para>
        /// <para>However, if an implementation doesn't use unmanaged resources,
        /// implementation of this method can be simply blank.</para>
        /// </summary>
        /// <param name="disposing"></param>
        protected abstract void Dispose(bool disposing);

        /// <summary>
        /// <para>Dispose method for <see cref="IDisposable"/> interface
        /// where resource disposal is delegated to <see cref="Dispose(bool)"/>.</para>
        /// <para>DO NOT provide implementation for, or hide this method in a derived class!
        /// Use <see cref="Dispose(bool)"/> instead.</para>
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        #endregion
    }
}
