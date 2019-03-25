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

        // Todo: Discussion. See reasoning below:
        // Time Remaining doesn't make sense when the alert is inactive.
        // IsActive is always calculated against real-time so the result shouldn't be used either. The developer should MVVM/bind both ActivatesAt and ExpiresAt properties.
        // Although we could put such notes in the documentation, it really is the library consumer's job to calculate any dynamic values according to their goal.
        // Personally I think it clutters the code base to have so many helpers defined in the library. They are unnecessary most of tht time and cause misunderstandings.
        // Petition to remove TimeRemaining, ETA and IsActive/HasExpired altogether when both Activation and Expiry properties are present.
        // Or maybe, at least, move them to a helper class or extension.

        /*
        /// <summary>
        /// <para>
        /// Whether this <see cref="Alert"/> is active.
        /// </para>
        /// <para>
        /// This property is time sensitive. Consider using <see cref="ActivatesAt"/> and <see cref="ExpiresAt"/> to monitor changes.
        /// </para>
        /// </summary>
        [JsonIgnore]
        public bool IsActive => DateTime.Now >= ActivatesAt.ToLocalTime() && DateTime.Now < ExpiresAt.ToLocalTime();
        */

        /*
        /// <summary>
        /// <para>
        /// The amount of time left until this <see cref="Alert"/> expires.
        /// This property returns <see cref="TimeSpan.Zero"/> if the <see cref="Alert"/> is currently inactive.
        /// </para>
        /// <para>
        /// This property is time sensitive. Consider using <see cref="ActivatesAt"/> and <see cref="ExpiresAt"/> to monitor changes.
        /// </para>
        /// </summary>
        [JsonIgnore]
        public TimeSpan TimeRemaining => !IsActive ? TimeSpan.Zero : DateTime.Now - ExpiresAt.ToLocalTime();
        */

        // Todo: We should either keep "IsActive" or "HasExpired" for consistency.
        /*
        [JsonProperty("expired")]
        public bool HasExpired { get; private set; }
        */

        /// <summary>
        /// The mission that players must complete to receive rewards from this <see cref="Alert"/>.
        /// </summary>
        [JsonProperty]
        public AlertMission Mission { get; private set; }

        /// <summary>
        /// Potential rewards from this <see cref="Alert"/>.
        /// </summary>
        [JsonProperty]
        public List<string> RewardTypes { get; private set; }
    }
}
