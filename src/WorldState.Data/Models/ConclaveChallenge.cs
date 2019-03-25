using System;

using Newtonsoft.Json;

namespace WorldState.Data.Models
{
    public class ConclaveChallenge
    {
        /// <summary>
        /// The unique ID of this <see cref="ConclaveChallenge"/>.
        /// </summary>
        [JsonProperty]
        public string Id { get; private set; }

        [JsonProperty]
        public string Description { get; private set; }

        /// <summary>
        /// The moment that this <see cref="ConclaveChallenge"/> ends.
        /// </summary>
        [JsonProperty("expiry")]
        public DateTimeOffset ExpiresAt { get; private set; }

        /* Todo: See discussions about activation flags on model Alert.
        [JsonIgnore]
        public bool IsActive => DateTime.Now < ExpiresAt.ToLocalTime();
        */

        [JsonProperty]
        public int Amount { get; private set; }

        [JsonProperty]
        public string Mode { get; private set; }

        // Todo: Duplicate (string representation) of Daily? Remove.
        [JsonProperty]
        public string Category { get; private set; }

        // We should either keep "IsActive" or "HasExpired" for consistency.
        /*
        [JsonProperty]
        public bool Expired { get; private set; }
        */

        [JsonProperty]
        public bool Daily { get; private set; }

        [JsonProperty]
        public bool RootChallenge { get; private set; }

        public override String ToString()
        {
            return $"{Description} on {Mode} {Amount} {(Amount > 1 ? "times" : "time")} " +
                   $"in a {(Daily ? "day" : "week")}.";
        }
    }
}
