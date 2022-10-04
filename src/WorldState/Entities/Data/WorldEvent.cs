using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;

namespace WarframeNet.WorldState
{
    /// <summary>
    /// Contains data about a current in-game special event.
    /// </summary>
    public class WorldEvent
    {
        /// <summary>
        /// Unique identifier of the previous world event.
        /// </summary>
        [JsonProperty("previousId")]
        public string PreviousId { get; private set; }
        
        /// <summary>
        /// Unique identifier for this world event.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; private set; }

        /// <summary>
        /// Metadata provided by DE.
        /// Apparently doesn't follow any set structure.
        /// </summary>
        [JsonProperty("metadata")]
        public JObject Metadata { get; private set; }
        
        /// <summary>
        /// Short name for this world event.
        /// <example> Ghoul Purge </example>
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; private set; }

        /// <summary>
        /// Short description of the event's mission.
        /// Can be null.
        /// </summary>
        /// <example> Help Konzu rid the plains of Grineer Ghouls </example>
        [JsonProperty("tooltip")]
        public string Tooltip { get; private set; }
        
        /// <summary>
        /// String representation of this world event's information.
        /// </summary>
        [JsonProperty("asString")]
        public string AsString { get; private set; }
        
        /// <summary>
        /// Time at which this event starts.
        /// </summary>
        [JsonProperty("activation")]
        public DateTimeOffset ActivatedAt { get; private set; }

        /// <summary>
        /// Time at which this event expires.
        /// </summary>
        [JsonProperty("expiry")]
        public DateTimeOffset ExpiresAt { get; private set; }
        
        /// <summary>
        /// Time until this event starts, in string form.
        /// Can be in the negatives if this event has already started.
        /// </summary>
        [JsonProperty("startString")]
        public string StartString { get; private set; }

        /// <summary>
        /// Whether or not this event is currently active.
        /// </summary>
        [JsonProperty("active")]
        public bool IsActive { get; private set; }
        
        /// <summary>
        /// Whether or not this event has currently expired.
        /// </summary>
        [JsonProperty("expired")]
        public bool HasExpired { get; private set; }

        [JsonProperty("concurrentNodes")]
        private List<string> _concurrentNodes;

        /// <summary>
        /// The other nodes where the event takes place.
        /// </summary>
        [JsonIgnore]
        public IReadOnlyList<string> ConcurrentNodes => _concurrentNodes.AsReadOnly();

        /// <summary>
        /// The principal node victim of the event.
        /// Can be null.
        /// </summary>
        [JsonProperty("victimNode")]
        public string VictimNode { get; private set; }
        
        /// <summary>
        /// Faction with which this event is affiliated with.
        /// </summary>
        [JsonProperty("affiliatedWith")]
        public string AffiliatedWith { get; private set; }

        /// <summary>
        /// Health left on the target.
        /// Can be null.
        /// </summary>
        [JsonProperty("health")]
        public float? Health { get; private set; }
        
        /// <summary>
        /// The event's current score.
        /// Can be null.
        /// </summary>
        [JsonProperty("currentScore")]
        public int? CurrentScore { get; private set; }
        
        /// <summary>
        /// The event's first intermediate score goal.
        /// Can be null.
        /// </summary>
        [JsonProperty("smallInterval")]
        public int? SmallInterval { get; private set; }

        /// <summary>
        /// The event's second intermediate score goal.
        /// Can be null.
        /// </summary>
        [JsonProperty("largeInterval")]
        public int? LargeInterval { get; private set; }
        
        /// <summary>
        /// Score to reach to complete this event.
        /// Can be null.
        /// </summary>
        [JsonProperty("maximumScore")]
        public int? MaximumScore { get; private set; }

        [JsonProperty("rewards")]
        private List<MissionReward> _rewards;

        /// <summary>
        /// Rewards awarded for event participation.
        /// </summary>
        [JsonIgnore]
        public IReadOnlyList<MissionReward> Rewards => _rewards.AsReadOnly();

        [JsonProperty("jobs")]
        private List<Bounty> _bounties;

        /// <summary>
        /// Bounties available for players to complete during this event.
        /// </summary>
        [JsonIgnore]
        public IReadOnlyList<Bounty> Bounties => _bounties.AsReadOnly();

        [JsonProperty("previousJobs")]
        private List<Bounty> _previousBounties;
        
        /// <summary>
        /// Bounties previously available for players to complete during this event.
        /// </summary>
        [JsonIgnore]
        public IReadOnlyList<Bounty> PreviousBounties => _previousBounties.AsReadOnly();

        public override string ToString()
        {
            return !string.IsNullOrWhiteSpace(AsString) ? AsString : base.ToString();
        }
    }
}
