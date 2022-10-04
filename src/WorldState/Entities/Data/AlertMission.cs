using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace WarframeNet.WorldState
{
    /// <summary>
    /// Contains information about an alert's mission.
    /// </summary>
    public class AlertMission
    {
        /// <summary>
        /// Node this mission takes place in.
        /// <example> Ani (Void) </example>
        /// </summary>
        [JsonProperty("node")]
        public string Node { get; private set; }

        /// <summary>
        /// The type of mission this is.
        /// <example> Survival </example>
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; private set; }
        
        /// <summary>
        /// Simple description of this mission.
        /// <example> Gift From The Lotus </example>
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; private set; }

        /// <summary>
        /// The faction that controls the mission's node. Generally determines enemy type.
        /// <example> Orokin </example>
        /// </summary>
        [JsonProperty("faction")]
        public string Faction { get; private set; }

        /// <summary>
        /// The reward(s) this mission will give upon completion.
        /// </summary>
        [JsonProperty("reward")]
        public MissionReward Reward { get; private set; }

        /// <summary>
        /// Minimum level for enemies in this mission.
        /// </summary>
        [JsonProperty("minEnemyLevel")]
        public int MinimumEnemyLevel { get; private set; }
        
        /// <summary>
        /// Maximum level for enemies in this mission.
        /// </summary>
        [JsonProperty("maxEnemyLevel")]
        public int MaximumEnemyLevel { get; private set; }

        /// <summary>
        /// Maximum wave number for this mission.
        /// </summary>
        [JsonProperty("maxWaveNum")]
        public int MaximumWaveNumber { get; private set; }

        /// <summary>
        /// Whether or not this mission is in Nightmare Mode.
        /// </summary>
        [JsonProperty("nightmare")]
        public bool IsNightmare { get; private set; }

        /// <summary>
        /// Whether or not an Archwing is required to play this mission.
        /// </summary>
        [JsonProperty("archwingRequired")]
        public bool IsArchwingRequired { get; private set; }
        
        /// <summary>
        /// Whether or not this mission makes use of the Archwing underwater (i.e. Sharkwing).
        /// </summary>
        [JsonProperty("isSharkwing")]
        public bool IsSharkwing { get; private set; }
        
        /// <summary>
        /// @todo: document this
        /// </summary>
        [JsonProperty("levelOverride")]
        public string LevelOverride { get; private set; }
        
        /// <summary>
        /// @todo: document this
        /// </summary>
        [JsonProperty("enemySpec")]
        public string EnemySpec { get; private set; }
        
        [JsonProperty("advancedSpawners")] 
        private List<string> _advancedSpawners;

        /// <summary>
        /// @todo: document this
        /// </summary>
        [JsonIgnore] 
        public IReadOnlyList<string> AdvancedSpawners => _advancedSpawners.AsReadOnly();
        
        [JsonProperty("requiredItems")] 
        private List<string> _requiredItems;

        /// <summary>
        /// Items required to participate in this mission.
        /// </summary>
        [JsonIgnore]
        public IReadOnlyList<string> RequiredItems => _requiredItems.AsReadOnly();
        
        [JsonProperty("levelAuras")]
        private List<string> _levelAuras;

        /// <summary>
        /// @todo: document this
        /// </summary>
        [JsonIgnore]
        public IReadOnlyList<string> LevelAuras => _levelAuras.AsReadOnly();
    }
}
