using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace WorldState
{
    public class LocalWorldStateProvider : WorldStateProvider
    {
        public LocalWorldStateProvider(Platform platform) : base(platform) { }

        public override async Task<StreamReader> GetWorldStateStreamAsync()
        {
            return null;
        }

        public override async Task<StreamReader> GetAlertStreamAsync()
        {
            return null;
        }

        public override async Task<StreamReader> GetAcolytesStreamAsync()
        {
            return null;
        }

        public override async Task<StreamReader> GetCetusCycleStreamAsync()
        {
            return null;
        }

        public override async Task<StreamReader> GetConclaveChallengesStreamAsync()
        {
            return null;
        }

        public override async Task<StreamReader> GetDailyDealsStreamAsync()
        {
            return null;
        }

        public override async Task<StreamReader> GetEarthCycleStreamAsync()
        {
            return null;
        }

        public override async Task<StreamReader> GetEventsStreamAsync()
        {
            return null;
        }

        public override async Task<StreamReader> GetFlashSalesStreamAsync()
        {
            return null;
        }

        public override async Task<StreamReader> GetConstructionStatusStreamAsync()
        {
            return null;
        }

        public override async Task<StreamReader> GetGlobalUpgradesStreamAsync()
        {
            return null;
        }

        public override async Task<StreamReader> GetInvasionsStreamAsync()
        {
            return null;
        }

        public override async Task<StreamReader> GetNewsStreamAsync()
        {
            return null;
        }

        public override async Task<StreamReader> GetNightwaveStreamAsync()
        {
            return null;
        }

        public override async Task<StreamReader> GetOrbVallisCycleStreamAsync()
        {
            return null;
        }

        public override async Task<StreamReader> GetRivenModsStreamAsync()
        {
            return null;
        }

        public override async Task<StreamReader> GetSimarisTargetStreamAsync()
        {
            return null;
        }

        public override async Task<StreamReader> GetSortieStreamAsync()
        {
            return null;
        }

        public override async Task<StreamReader> GetSyndicateStreamAsync()
        {
            return null;
        }

        public override async Task<StreamReader> GetVoidFissureMissionsStreamAsync()
        {
            return null;
        }

        public override async Task<StreamReader> GetVoidTraderStreamAsync()
        {
            return null;
        }

        protected override void Dispose(bool disposing) { }
    }
}
