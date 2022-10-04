using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace WarframeNet.WorldState
{
    /// <summary>
    /// Contains data about a current worldstate alert.
    /// </summary>
    public class Alert
    {
        /// <summary>
        /// Unique identifier for this alert.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; private set; }
        
        /// <summary>
        /// Used to identify specific types of alerts, may potentially be empty.
        /// <example> LotusGift </example>
        /// </summary>
        [JsonProperty("tag")]
        public string Tag { get; private set; }

        /// <summary>
        /// Time at which this alert becomes available.
        /// </summary>
        [JsonProperty("activation")]
        public DateTimeOffset ActivatedAt { get; private set; }

        /// <summary>
        /// Time at which this alert will have expired.
        /// It might still be returned by the API at this point.
        /// </summary>
        [JsonProperty("expiry")]
        public DateTimeOffset ExpiresAt { get; private set; }

        /// <summary>
        /// The mission this alert requires players to go through.
        /// </summary>
        [JsonProperty("mission")]
        public AlertMission Mission { get; private set; }

        /// <summary>
        /// Whether or not this alert is currently active.
        /// </summary>
        [JsonProperty("active")]
        public bool IsActive { get; private set; }

        /// <summary>
        /// Whether or not this alert has expired.
        /// </summary>
        [JsonProperty("expired")]
        public bool HasExpired { get; private set; }

        [JsonProperty("rewardTypes")]
        private List<string> _rewardTypes;

        /// <summary>
        /// Available reward types for this alert.
        /// </summary>
        [JsonIgnore]
        public IReadOnlyList<string> RewardTypes => _rewardTypes.AsReadOnly();
        
        /// <summary>
        /// Time until this alert starts. May be in the negatives if this alert has already started.
        /// </summary>
        [JsonProperty("startString")]
        public string StartsIn { get; private set; }
        
        /// <summary>
        /// Time until this alert expires. May be in the negatives if this alert has already expired.
        /// </summary>
        [JsonProperty("eta")]
        public string TimeRemaining { get; private set; }
    }
}