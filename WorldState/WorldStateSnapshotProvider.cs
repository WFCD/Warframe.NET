using System;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using WorldState.Data;

namespace WorldState
{
    /// <summary>
    /// <para><see cref="WorldStateProvider"/> implementation that sources 
    /// from a cached <see cref="WarframeWorldState"/> snapshot,
    /// which can later be set to arbitrary values for testing.</para>
    /// <para>All streams provided are <see cref="MemoryStream"/>s created from the snapshot.</para>
    /// </summary>
    public class WorldStateSnapshotProvider : WorldStateProvider
    {
        public WarframeWorldState WorldState { get; set; }

        private readonly JsonSerializer serializer = JsonSerializer.CreateDefault();

        public WorldStateSnapshotProvider(Platform platform, string filePath) : base(platform)
        {
            if (!File.Exists(filePath)) throw new ArgumentException("File not found.", nameof(filePath));

            using (var stream = File.OpenRead(filePath))
            using (var reader = new StreamReader(stream))
            using (var jsonReader = new JsonTextReader(reader))
            {
                WorldState = serializer.Deserialize<WarframeWorldState>(jsonReader);
            }

        }

        public WorldStateSnapshotProvider(Platform platform, WarframeWorldState snapshot) : base(platform)
        {
            WorldState = snapshot;
        }

#pragma warning disable 1998 // Disable CS1998: async methods lack await.

        public override async Task<StreamReader> StreamWorldStateAsync()
        {
            var memory = new MemoryStream();
            using (var writer = new StreamWriter(memory, Encoding.UTF8, 4096, true))
            using (var jsonWriter = new JsonTextWriter(writer))
            {
                serializer.Serialize(jsonWriter, WorldState);
            }

            return new StreamReader(memory);
        }

        public override async Task<StreamReader> StreamAlertsAsync()
        {
            var memory = new MemoryStream();
            using (var writer = new StreamWriter(memory, Encoding.UTF8, 4096, true))
            using (var jsonWriter = new JsonTextWriter(writer))
            {
                serializer.Serialize(jsonWriter, WorldState.Alerts);
            }

            return new StreamReader(memory);
        }

        public override async Task<StreamReader> StreamAcolytesAsync()
        {
            var memory = new MemoryStream();
            using (var writer = new StreamWriter(memory, Encoding.UTF8, 4096, true))
            using (var jsonWriter = new JsonTextWriter(writer))
            {
                serializer.Serialize(jsonWriter, WorldState.Acolytes);
            }

            return new StreamReader(memory);
        }

        public override async Task<StreamReader> StreamCetusCycleAsync()
        {
            var memory = new MemoryStream();
            using (var writer = new StreamWriter(memory, Encoding.UTF8, 4096, true))
            using (var jsonWriter = new JsonTextWriter(writer))
            {
                serializer.Serialize(jsonWriter, WorldState.CetusCycle);
            }

            return new StreamReader(memory);
        }

        public override async Task<StreamReader> StreamConclaveChallengesAsync()
        {
            var memory = new MemoryStream();
            using (var writer = new StreamWriter(memory, Encoding.UTF8, 4096, true))
            using (var jsonWriter = new JsonTextWriter(writer))
            {
                serializer.Serialize(jsonWriter, WorldState.ConclaveChallenges);
            }

            return new StreamReader(memory);
        }

        public override async Task<StreamReader> StreamDailyDealsAsync()
        {
            var memory = new MemoryStream();
            using (var writer = new StreamWriter(memory, Encoding.UTF8, 4096, true))
            using (var jsonWriter = new JsonTextWriter(writer))
            {
                serializer.Serialize(jsonWriter, WorldState.DailyDeals);
            }

            return new StreamReader(memory);
        }

        public override async Task<StreamReader> StreamEarthCycleAsync()
        {
            var memory = new MemoryStream();
            using (var writer = new StreamWriter(memory, Encoding.UTF8, 4096, true))
            using (var jsonWriter = new JsonTextWriter(writer))
            {
                serializer.Serialize(jsonWriter, WorldState.EarthCycle);
            }

            return new StreamReader(memory);
        }

        public override async Task<StreamReader> StreamEventsAsync()
        {
            var memory = new MemoryStream();
            using (var writer = new StreamWriter(memory, Encoding.UTF8, 4096, true))
            using (var jsonWriter = new JsonTextWriter(writer))
            {
                serializer.Serialize(jsonWriter, WorldState.Events);
            }

            return new StreamReader(memory);
        }

        public override async Task<StreamReader> StreamFlashSalesAsync()
        {
            var memory = new MemoryStream();
            using (var writer = new StreamWriter(memory, Encoding.UTF8, 4096, true))
            using (var jsonWriter = new JsonTextWriter(writer))
            {
                serializer.Serialize(jsonWriter, WorldState.FlashSales);
            }

            return new StreamReader(memory);
        }

        public override async Task<StreamReader> StreamConstructionStatusAsync()
        {
            var memory = new MemoryStream();
            using (var writer = new StreamWriter(memory, Encoding.UTF8, 4096, true))
            using (var jsonWriter = new JsonTextWriter(writer))
            {
                serializer.Serialize(jsonWriter, WorldState.ConstructionStatus);
            }

            return new StreamReader(memory);
        }

        public override async Task<StreamReader> StreamGlobalUpgradesAsync()
        {
            var memory = new MemoryStream();
            using (var writer = new StreamWriter(memory, Encoding.UTF8, 4096, true))
            using (var jsonWriter = new JsonTextWriter(writer))
            {
                serializer.Serialize(jsonWriter, WorldState.GlobalUpgrades);
            }

            return new StreamReader(memory);
        }

        public override async Task<StreamReader> StreamInvasionsAsync()
        {
            var memory = new MemoryStream();
            using (var writer = new StreamWriter(memory, Encoding.UTF8, 4096, true))
            using (var jsonWriter = new JsonTextWriter(writer))
            {
                serializer.Serialize(jsonWriter, WorldState.Invasions);
            }

            return new StreamReader(memory);
        }

        public override async Task<StreamReader> StreamNewsAsync()
        {
            var memory = new MemoryStream();
            using (var writer = new StreamWriter(memory, Encoding.UTF8, 4096, true))
            using (var jsonWriter = new JsonTextWriter(writer))
            {
                serializer.Serialize(jsonWriter, WorldState.News);
            }

            return new StreamReader(memory);
        }

        public override async Task<StreamReader> StreamNightwaveAsync()
        {
            var memory = new MemoryStream();
            using (var writer = new StreamWriter(memory, Encoding.UTF8, 4096, true))
            using (var jsonWriter = new JsonTextWriter(writer))
            {
                serializer.Serialize(jsonWriter, WorldState.Nightwave);
            }

            return new StreamReader(memory);
        }

        public override async Task<StreamReader> StreamOrbVallisCycleAsync()
        {
            var memory = new MemoryStream();
            using (var writer = new StreamWriter(memory, Encoding.UTF8, 4096, true))
            using (var jsonWriter = new JsonTextWriter(writer))
            {
                serializer.Serialize(jsonWriter, WorldState.OrbVallisCycle);
            }

            return new StreamReader(memory);
        }

        public override async Task<StreamReader> StreamRivenModsAsync()
        {
            throw new NotImplementedException("Rivens are not currently included in stable World State.");
        }

        public override async Task<StreamReader> StreamSimarisTargetAsync()
        {
            var memory = new MemoryStream();
            using (var writer = new StreamWriter(memory, Encoding.UTF8, 4096, true))
            using (var jsonWriter = new JsonTextWriter(writer))
            {
                serializer.Serialize(jsonWriter, WorldState.SimarisTarget);
            }

            return new StreamReader(memory);
        }

        public override async Task<StreamReader> StreamSortieAsync()
        {
            var memory = new MemoryStream();
            using (var writer = new StreamWriter(memory, Encoding.UTF8, 4096, true))
            using (var jsonWriter = new JsonTextWriter(writer))
            {
                serializer.Serialize(jsonWriter, WorldState.Sortie);
            }

            return new StreamReader(memory);
        }

        public override async Task<StreamReader> StreamSyndicateMissionsAsync()
        {
            var memory = new MemoryStream();
            using (var writer = new StreamWriter(memory, Encoding.UTF8, 4096, true))
            using (var jsonWriter = new JsonTextWriter(writer))
            {
                serializer.Serialize(jsonWriter, WorldState.SyndicateMissions);
            }

            return new StreamReader(memory);
        }

        public override async Task<StreamReader> StreamVoidFissureMissionsAsync()
        {
            var memory = new MemoryStream();
            using (var writer = new StreamWriter(memory, Encoding.UTF8, 4096, true))
            using (var jsonWriter = new JsonTextWriter(writer))
            {
                serializer.Serialize(jsonWriter, WorldState.VoidFissureMissions);
            }

            return new StreamReader(memory);
        }

        public override async Task<StreamReader> StreamVoidTraderAsync()
        {
            var memory = new MemoryStream();
            using (var writer = new StreamWriter(memory, Encoding.UTF8, 4096, true))
            using (var jsonWriter = new JsonTextWriter(writer))
            {
                serializer.Serialize(jsonWriter, WorldState.VoidTrader);
            }

            return new StreamReader(memory);
        }

#pragma warning restore 1998

        protected override void Dispose(bool disposing) {}
    }
}
