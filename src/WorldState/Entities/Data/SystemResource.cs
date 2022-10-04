using Newtonsoft.Json;

namespace WarframeNet.WorldState
{
    /// <summary>
    /// Represents a system resource that may be awarded at the end of a mission.
    /// </summary>
    public class SystemResource
    {
        /// <summary>
        /// The amount of resource that will be given.
        /// </summary>
        [JsonProperty("count")]
        public int Count { get; private set; }
        
        /// <summary>
        /// The type of resource that will be given.
        /// <example> Orokin Reactor </example>
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; private set; }
        
        /// <summary>
        /// Seems to be similar to <see cref="Type"/>
        /// <example> Orokin Reactor </example>
        /// </summary>
        [JsonProperty("Key")]
        public string Key { get; private set; }
    }
}
