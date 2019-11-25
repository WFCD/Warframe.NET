using System.IO;
using System.Threading.Tasks;

using Newtonsoft.Json;

using WorldState.Data.Models;
/* ReSharper has trouble figuring out the correct styling rules. */
// @formatter:off
#if NETSTANDARD1_6
using Dasync.Collections;
#elif NETSTANDARD2_1
using System;
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
                using (var reader = await client.provider.GetAlertStreamAsync().ConfigureAwait(false))
                {
                    await Enumerate<Alert>(client.serializer, yield, reader).ConfigureAwait(false);
                }
            });
        }

        #endregion

#elif NETSTANDARD2_1

        #region IAsyncEnumerable from .NET Standard 2.1

        public static IAsyncEnumerable<Alert> EnumerateAlertsAsync(this WorldStateClient client)
        {
            return Enumerate<Alert>(client.serializer, () => client.provider.GetAlertStreamAsync());
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
