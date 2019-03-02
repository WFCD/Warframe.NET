using System;
using System.Collections.Generic;

using Newtonsoft.Json;

namespace WorldState.Data.Models
{
    public class Alert
    {
        /// <summary>
        /// The unique ID of this <see cref="Alert"/>.
        /// </summary>
        [JsonProperty]
        public string Id { get; private set; }

        /// <summary>
        /// The moment that this <see cref="Alert"/> begins.
        /// </summary>
        [JsonProperty("activation")]
        public DateTimeOffset ActivatesAt { get; private set; }

        /// <summary>
        /// The moment that this <see cref="Alert"/> ends.
        /// </summary>
        [JsonProperty("expiry")]
        public DateTimeOffset ExpiresAt { get; private set; }

        /// <summary>
        /// <para>
        /// Whether this <see cref="Alert"/> is active.
        /// </para>
        /// <para>
        /// This property is time sensitive. Consider using <see cref="ActivatesAt"/> and <see cref="ExpiresAt"/> to monitor changes.
        /// </para>
        /// </summary>
        [JsonIgnore]
        public bool IsActive => DateTime.Now > ActivatesAt.ToLocalTime() && DateTime.Now < ExpiresAt.ToLocalTime();

        /// <summary>
        /// <para>
        /// The amount of time left for this <see cref="Alert"/>.
        /// This property always returns <see cref="TimeSpan.Zero"/> if the <see cref="Alert"/> is currently inactive.
        /// </para>
        /// <para>
        /// This property is time sensitive. Consider using <see cref="ActivatesAt"/> and <see cref="ExpiresAt"/> to monitor changes.
        /// </para>
        /// </summary>
        [JsonIgnore]
        public TimeSpan TimeRemaining => !IsActive ? TimeSpan.Zero : DateTime.Now - ExpiresAt.ToLocalTime();

        // We should either keep "IsActive" or "HasExpired" for consistency.
        /*
        [JsonProperty("expired")]
        public bool HasExpired { get; private set; }
        */

        /// <summary>
        /// The mission that players must complete to receive rewards for this <see cref="Alert"/>.
        /// </summary>
        [JsonProperty]
        public AlertMission Mission { get; private set; }

        /// <summary>
        /// Potential rewards for this <see cref="Alert"/>.
        /// </summary>
        [JsonProperty]
        public List<string> RewardTypes { get; private set; }
    }
}
