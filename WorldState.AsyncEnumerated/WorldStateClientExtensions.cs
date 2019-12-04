using System;
using System.IO;
using System.Threading.Tasks;

using Newtonsoft.Json;

using WorldState.Data.Models;
/* ReSharper has trouble figuring out the correct styling rules. */
// @formatter:off
#if NETSTANDARD1_6
using Dasync.Collections;
#elif NETSTANDARD2_1
using System.Collections.Generic;
#endif
// @formatter:on

namespace WorldState
{
    public static class WorldStateClientExtensions
    {
#if NETSTANDARD1_6
        #region IAsyncEnumerable from AsyncEnumerator package

        public static IAsyncEnumerable<Alert> EnumerateAlertsAsync(this WorldStateClient client)
        {
            return new AsyncEnumerable<Alert>(async yield =>
            {
                using (var reader = await client.provider.StreamAlertsAsync().ConfigureAwait(false))
                {
                    await Enumerate(client.serializer, yield, reader).ConfigureAwait(false);
                }
            });
        }

        public static IAsyncEnumerable<Acolyte> EnumerateAcolytesAsync(this WorldStateClient client)
        {
            return new AsyncEnumerable<Acolyte>(async yield =>
            {
                using (var reader = await client.provider.StreamAcolytesAsync().ConfigureAwait(false))
                {
                    await Enumerate(client.serializer, yield, reader).ConfigureAwait(false);
                }
            });
        }

        public static IAsyncEnumerable<ConclaveChallenge> EnumerateConclaveChallengesAsync(this WorldStateClient client)
        {
            return new AsyncEnumerable<ConclaveChallenge>(async yield =>
            {
                using (var reader = await client.provider.StreamConclaveChallengesAsync()
                                                .ConfigureAwait(false))
                {
                    await Enumerate(client.serializer, yield, reader).ConfigureAwait(false);
                }
            });
        }

        public static IAsyncEnumerable<DailyDeal> EnumerateDailyDealsAsync(this WorldStateClient client)
        {
            return new AsyncEnumerable<DailyDeal>(async yield =>
            {
                using (var reader = await client.provider.StreamDailyDealsAsync().ConfigureAwait(false))
                {
                    await Enumerate(client.serializer, yield, reader).ConfigureAwait(false);
                }
            });
        }

        public static IAsyncEnumerable<Event> EnumerateEventsAsync(this WorldStateClient client)
        {
            return new AsyncEnumerable<Event>(async yield =>
            {
                using (var reader = await client.provider.StreamEventsAsync().ConfigureAwait(false))
                {
                    await Enumerate(client.serializer, yield, reader).ConfigureAwait(false);
                }
            });
        }

        public static IAsyncEnumerable<GlobalUpgrade> EnumerateGlobalUpgradesAsync(this WorldStateClient client)
        {
            return new AsyncEnumerable<GlobalUpgrade>(async yield =>
            {
                using (var reader = await client.provider.StreamGlobalUpgradesAsync().ConfigureAwait(false))
                {
                    await Enumerate(client.serializer, yield, reader).ConfigureAwait(false);
                }
            });
        }

        public static IAsyncEnumerable<Invasion> EnumerateInvasionsAsync(this WorldStateClient client)
        {
            return new AsyncEnumerable<Invasion>(async yield =>
            {
                using (var reader = await client.provider.StreamInvasionsAsync().ConfigureAwait(false))
                {
                    await Enumerate(client.serializer, yield, reader).ConfigureAwait(false);
                }
            });
        }

        public static IAsyncEnumerable<News> EnumerateNewsAsync(this WorldStateClient client)
        {
            return new AsyncEnumerable<News>(async yield =>
            {
                using (var reader = await client.provider.StreamNewsAsync().ConfigureAwait(false))
                {
                    await Enumerate(client.serializer, yield, reader).ConfigureAwait(false);
                }
            });
        }

        public static IAsyncEnumerable<RivenMod> EnumerateRivenModsAsync(this WorldStateClient client)
        {
            return new AsyncEnumerable<RivenMod>(async yield =>
            {
                using (var reader = await client.provider.StreamRivenModsAsync()
                                                .ConfigureAwait(false))
                using (var json = new JsonTextReader(reader))
                {
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
                                await yield.ReturnAsync(client.serializer.Deserialize<RivenMod>(json))
                                           .ConfigureAwait(false);
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
                }
            });
        }

        public static IAsyncEnumerable<SyndicateMission> EnumerateSyndicateMissionsAsync(this WorldStateClient client)
        {
            return new AsyncEnumerable<SyndicateMission>(async yield =>
            {
                using (var reader = await client.provider.StreamSyndicateMissionsAsync()
                                                .ConfigureAwait(false))
                {
                    await Enumerate(client.serializer, yield, reader).ConfigureAwait(false);
                }
            });
        }

        public static IAsyncEnumerable<Fissure> EnumerateVoidFissureMissionsAsync(this WorldStateClient client)
        {
            return new AsyncEnumerable<Fissure>(async yield =>
            {
                using (var reader = await client.provider.StreamVoidFissureMissionsAsync()
                                                .ConfigureAwait(false))
                {
                    await Enumerate(client.serializer, yield, reader).ConfigureAwait(false);
                }
            });
        }

        #endregion

#elif NETSTANDARD2_1

        #region IAsyncEnumerable from .NET Standard 2.1

        public static IAsyncEnumerable<Alert> EnumerateAlertsAsync(this WorldStateClient client)
        {
            return Enumerate<Alert>(client.serializer, () => client.provider.StreamAlertsAsync());
        }

        public static IAsyncEnumerable<Acolyte> EnumerateAcolytesAsync(this WorldStateClient client)
        {
            return Enumerate<Acolyte>(client.serializer, () => client.provider.StreamAcolytesAsync());
        }

        public static IAsyncEnumerable<ConclaveChallenge> EnumerateConclaveChallengesAsync(this WorldStateClient client)
        {
            return Enumerate<ConclaveChallenge>(client.serializer,
                                                () => client.provider.StreamConclaveChallengesAsync());
        }

        public static IAsyncEnumerable<DailyDeal> EnumerateDailyDealsAsync(this WorldStateClient client)
        {
            return Enumerate<DailyDeal>(client.serializer, () => client.provider.StreamDailyDealsAsync());
        }

        public static IAsyncEnumerable<Event> EnumerateEventsAsync(this WorldStateClient client)
        {
            return Enumerate<Event>(client.serializer, () => client.provider.StreamEventsAsync());
        }

        public static IAsyncEnumerable<FlashSale> EnumerateFlashSalesAsync(this WorldStateClient client)
        {
            return Enumerate<FlashSale>(client.serializer, () => client.provider.StreamFlashSalesAsync());
        }

        public static IAsyncEnumerable<GlobalUpgrade> EnumerateGlobalUpgradesAsync(this WorldStateClient client)
        {
            return Enumerate<GlobalUpgrade>(client.serializer, () => client.provider.StreamGlobalUpgradesAsync());
        }

        public static IAsyncEnumerable<Invasion> EnumerateInvasionsAsync(this WorldStateClient client)
        {
            return Enumerate<Invasion>(client.serializer, () => client.provider.StreamInvasionsAsync());
        }

        public static IAsyncEnumerable<News> EnumerateNewsAsync(this WorldStateClient client)
        {
            return Enumerate<News>(client.serializer, () => client.provider.StreamNewsAsync());
        }

        public static async IAsyncEnumerable<RivenMod> EnumerateRivenModsAsync(this WorldStateClient client)
        {
            using var reader = await client.provider.StreamRivenModsAsync()
                                           .ConfigureAwait(false);
            using var json = new JsonTextReader(reader);

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
                        yield return client.serializer.Deserialize<RivenMod>(json);
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
        }

        public static IAsyncEnumerable<SyndicateMission> EnumerateSyndicateMissionsAsync(this WorldStateClient client)
        {
            return Enumerate<SyndicateMission>(client.serializer,
                                               () => client.provider.StreamSyndicateMissionsAsync());
        }

        public static IAsyncEnumerable<Fissure> EnumerateVoidFissureMissionsAsync(this WorldStateClient client)
        {
            return Enumerate<Fissure>(client.serializer, () => client.provider.StreamVoidFissureMissionsAsync());
        }

        #endregion

#endif

        #region Helpers

#if NETSTANDARD1_6
        private static async Task Enumerate<T>(JsonSerializer           serializer,
                                               AsyncEnumerator<T>.Yield yield,
                                               StreamReader             reader)
        {
            using (var json = new JsonTextReader(reader))
            {
                // Flag to indicate we are in a JSON array.
                var arrayStarted = false;

                while (await json.ReadAsync().ConfigureAwait(false))
                {
                    // End of array check takes priority. We are done here, no more work.
                    if (json.TokenType == JsonToken.EndArray) yield.Break();

                    // Deserialize every element in the collection and return immediately.
                    // In other words, don't wait on the entire network transfer to complete.
                    if (arrayStarted) await yield.ReturnAsync(serializer.Deserialize<T>(json)).ConfigureAwait(false);

                    // Loop until we are at the start of a collection.
                    if (json.TokenType == JsonToken.StartArray) arrayStarted = true;
                }
            }
        }

#elif NETSTANDARD2_1
        private static async IAsyncEnumerable<T> Enumerate<T>(JsonSerializer           serializer,
                                                              Func<Task<StreamReader>> readerDelegate)
        {
            using var reader = await readerDelegate.Invoke().ConfigureAwait(false);
            using var json   = new JsonTextReader(reader);

            // Flag to indicate we are in a JSON array.
            var arrayStarted = false;

            while (await json.ReadAsync().ConfigureAwait(false))
            {
                // End of array check takes priority. We are done here, no more work.
                if (json.TokenType == JsonToken.EndArray) yield break;

                // Deserialize every element in the collection and return immediately.
                // In other words, don't wait on the entire network transfer to complete.
                if (arrayStarted) yield return serializer.Deserialize<T>(json);

                // Loop until we are at the start of a collection.
                if (json.TokenType == JsonToken.StartArray) arrayStarted = true;
            }
        }
#endif

        #endregion
    }
}
