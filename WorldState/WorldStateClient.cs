using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using Newtonsoft.Json;

using WorldState.Data;
using WorldState.Data.Models;

namespace WorldState
{
    public sealed class WorldStateClient : IDisposable
    {
        public Platform Platform     => provider.Platform;
        public Type     DataProvider => provider.GetType();

        internal readonly WorldStateProvider provider;
        internal readonly JsonSerializer     serializer;

        public WorldStateClient(Platform platform)
        {
            if (!Enum.IsDefined(typeof(Platform), platform)) throw new ArgumentOutOfRangeException(nameof(platform));

            provider   = new WarframeStatusProvider(platform);
            serializer = JsonSerializer.CreateDefault();
        }

        public WorldStateClient(Platform platform, WorldStateProvider streamProvider)
        {
            if (!Enum.IsDefined(typeof(Platform), platform)) throw new ArgumentOutOfRangeException(nameof(platform));

            provider   = streamProvider;
            serializer = JsonSerializer.CreateDefault();
        }

        /*
        public WorldStateClient(Platform platform, CultureInfo culture)
        {
            if (culture == null) throw new ArgumentNullException(nameof(culture));

            HttpClient = new HttpClient();
            HttpClient.DefaultRequestHeaders
                      .AcceptLanguage
                      .Add(new StringWithQualityHeaderValue(Utilities.CultureToLanguage(culture)));
        }
        */

        #region IDisposable

        public void Dispose()
        {
            provider?.Dispose();
        }

        #endregion

        #region REST APIs

        public async Task<WarframeWorldState> GetWorldStateAsync()
        {
            using (var reader = await provider.GetWorldStateStreamAsync()
                                              .ConfigureAwait(false))
            using (var json = new JsonTextReader(reader))
            {
                return serializer.Deserialize<WarframeWorldState>(json);
            }
        }

        public async Task<IEnumerable<Alert>> GetAlertsAsync()
        {
            using (var reader = await provider.GetAlertStreamAsync()
                                              .ConfigureAwait(false))
            using (var json = new JsonTextReader(reader))
            {
                return serializer.Deserialize<List<Alert>>(json);
            }
        }

        public async Task<IEnumerable<Acolyte>> GetAcolytesAsync()
        {
            using (var reader = await provider.GetAcolytesStreamAsync()
                                              .ConfigureAwait(false))
            using (var json = new JsonTextReader(reader))
            {
                return serializer.Deserialize<List<Acolyte>>(json);
            }
        }

        public async Task<CetusCycle> GetCetusCycleAsync()
        {
            using (var reader = await provider.GetCetusCycleStreamAsync()
                                              .ConfigureAwait(false))
            using (var json = new JsonTextReader(reader))
            {
                return serializer.Deserialize<CetusCycle>(json);
            }
        }

        public async Task<IEnumerable<ConclaveChallenge>> GetConclaveChallengesAsync()
        {
            using (var reader = await provider.GetConclaveChallengesStreamAsync()
                                              .ConfigureAwait(false))
            using (var json = new JsonTextReader(reader))
            {
                return serializer.Deserialize<List<ConclaveChallenge>>(json);
            }
        }

        public async Task<ConstructionStatus> GetConstructionStatusAsync()
        {
            using (var reader = await provider.GetConstructionStatusStreamAsync()
                                              .ConfigureAwait(false))
            using (var json = new JsonTextReader(reader))
            {
                return serializer.Deserialize<ConstructionStatus>(json);
            }
        }

        public async Task<IEnumerable<DailyDeal>> GetDailyDealsAsync()
        {
            using (var reader = await provider.GetDailyDealsStreamAsync()
                                              .ConfigureAwait(false))
            using (var json = new JsonTextReader(reader))
            {
                return serializer.Deserialize<List<DailyDeal>>(json);
            }
        }

        public async Task<EarthCycle> GetEarthCycleAsync()
        {
            using (var reader = await provider.GetEarthCycleStreamAsync()
                                              .ConfigureAwait(false))
            using (var json = new JsonTextReader(reader))
            {
                return serializer.Deserialize<EarthCycle>(json);
            }
        }

        public async Task<IEnumerable<Event>> GetEventsAsync()
        {
            using (var reader = await provider.GetEventsStreamAsync()
                                              .ConfigureAwait(false))
            using (var json = new JsonTextReader(reader))
            {
                return serializer.Deserialize<List<Event>>(json);
            }
        }

        public async Task<IEnumerable<FlashSale>> GetFlashSalesAsync()
        {
            using (var reader = await provider.GetFlashSalesStreamAsync()
                                              .ConfigureAwait(false))
            using (var json = new JsonTextReader(reader))
            {
                return serializer.Deserialize<List<FlashSale>>(json);
            }
        }

        public async Task<IEnumerable<GlobalUpgrade>> GetGlobalUpgradesAsync()
        {
            using (var reader = await provider.GetGlobalUpgradesStreamAsync()
                                              .ConfigureAwait(false))
            using (var json = new JsonTextReader(reader))
            {
                return serializer.Deserialize<List<GlobalUpgrade>>(json);
            }
        }

        public async Task<IEnumerable<Invasion>> GetInvasionsAsync()
        {
            using (var reader = await provider.GetInvasionsStreamAsync()
                                              .ConfigureAwait(false))
            using (var json = new JsonTextReader(reader))
            {
                return serializer.Deserialize<List<Invasion>>(json);
            }
        }

        public async Task<IEnumerable<News>> GetNewsAsync()
        {
            using (var reader = await provider.GetNewsStreamAsync()
                                              .ConfigureAwait(false))
            using (var json = new JsonTextReader(reader))
            {
                return serializer.Deserialize<List<News>>(json);
            }
        }

        public async Task<Nightwave> GetNightwaveAsync()
        {
            using (var reader = await provider.GetNightwaveStreamAsync()
                                              .ConfigureAwait(false))
            using (var json = new JsonTextReader(reader))
            {
                return serializer.Deserialize<Nightwave>(json);
            }
        }

        public async Task<OrbVallisCycle> GetOrbVallisCycleAsync()
        {
            using (var reader = await provider.GetOrbVallisCycleStreamAsync()
                                              .ConfigureAwait(false))
            using (var json = new JsonTextReader(reader))
            {
                return serializer.Deserialize<OrbVallisCycle>(json);
            }
        }

        public async Task<IEnumerable<RivenMod>> GetRivenModsAsync()
        {
            using (var reader = await provider.GetRivenModsStreamAsync()
                                              .ConfigureAwait(false))
            using (var json = new JsonTextReader(reader))
            {
                var rivens = new List<RivenMod>(400);

                // Riven stats API is differently modeled as each mod variant is put under a dynamic key.
                // This flag indicates that a key-check has completed and the value SHOULD be deserialized.
                var shouldDeserialize = false;

                while (await json.ReadAsync().ConfigureAwait(false))
                {
                    // We are about to read the value of a known key, which may contain mod stats.
                    if (shouldDeserialize)
                    {
                        // Double-check for null or key name collision.
                        if (json.TokenType == JsonToken.StartObject)
                        {
                            // Deserialize model immediately if all checks passed.
                            rivens.Add(serializer.Deserialize<RivenMod>(json));
                        }

                        // Continue search for the next mod.
                        shouldDeserialize = false;
                        continue;
                    }

                    // #DontKnowDontCare
                    if (json.TokenType != JsonToken.PropertyName ||
                        json.ValueType != typeof(string))
                    {
                        continue;
                    }

                    // Read the key name to determine if the value (will read in the next loop) may contain mod stats.
                    // Currently recognizes:
                    // (1) "rerolled" key whose value is a JSON object.
                    // (2) "unrolled" key whose value is a JSON object.
                    var name = (string) json.Value;
                    if (name.Equals("unrolled", StringComparison.OrdinalIgnoreCase) ||
                        name.Equals("rerolled", StringComparison.OrdinalIgnoreCase))
                    {
                        shouldDeserialize = true;
                    }
                }

                return rivens;
            }
        }

        public async Task<Simaris> GetSimarisTargetAsync()
        {
            using (var reader = await provider.GetSimarisTargetStreamAsync()
                                              .ConfigureAwait(false))
            using (var json = new JsonTextReader(reader))
            {
                return serializer.Deserialize<Simaris>(json);
            }
        }

        public async Task<Sortie> GetSortieAsync()
        {
            using (var reader = await provider.GetSortieStreamAsync()
                                              .ConfigureAwait(false))
            using (var json = new JsonTextReader(reader))
            {
                return serializer.Deserialize<Sortie>(json);
            }
        }

        public async Task<IEnumerable<SyndicateMission>> GetSyndicateMissionsAsync()
        {
            using (var reader = await provider.GetSyndicateStreamAsync()
                                              .ConfigureAwait(false))
            using (var json = new JsonTextReader(reader))
            {
                return serializer.Deserialize<List<SyndicateMission>>(json);
            }
        }

        public async Task<IEnumerable<Fissure>> GetVoidFissureMissionsAsync()
        {
            using (var reader = await provider.GetVoidFissureMissionsStreamAsync()
                                              .ConfigureAwait(false))
            using (var json = new JsonTextReader(reader))
            {
                return serializer.Deserialize<List<Fissure>>(json);
            }
        }

        public async Task<VoidTrader> GetVoidTraderAsync()
        {
            using (var reader = await provider.GetVoidTraderStreamAsync()
                                              .ConfigureAwait(false))
            using (var json = new JsonTextReader(reader))
            {
                return serializer.Deserialize<VoidTrader>(json);
            }
        }

        #endregion
    }
}
