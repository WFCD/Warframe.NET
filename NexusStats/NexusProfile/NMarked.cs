using Newtonsoft.Json;

namespace WarframeNET.NexusStats
{
    /// <summary>
    /// Marking information of a player in NexusProfile.
    /// <seealso cref="NexusProfile"/>
    /// </summary>
    public class NMarked
    {
        /// <summary>
        /// Is the player marked to death by Stalker?
        /// </summary>
        [JsonProperty("stalker")]
        public bool IsMarkedByStalker { get; set; }

        /// <summary>
        /// Is the player marked to death by The Grustrag Three?
        /// </summary>
        [JsonProperty("g3")]
        public bool IsMarkedByG3 { get; set; }

        /// <summary>
        /// Is the player marked to death by Zanuka?
        /// </summary>
        [JsonProperty("zanuka")]
        public bool IsMarkedByZanuka { get; set; }
    }
}
