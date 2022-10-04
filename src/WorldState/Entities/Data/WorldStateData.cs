using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace WarframeNet.WorldState
{
    /// <summary>
    /// Class containing the entirety of the world state.
    /// Returned by the Root endpoint
    /// </summary>
    public class WorldStateData
    {
        /// <summary>
        /// Time of the world state's last update.
        /// </summary>
        [JsonProperty("timestamp")] 
        public DateTimeOffset Timestamp { get; private set; }

        [JsonProperty("news")]
        private List<News> _news;

        /// <summary>
        /// Contains news currently displayed in the Orbiter.
        /// </summary>
        [JsonIgnore]
        public IReadOnlyList<News> News => _news.AsReadOnly();

        [JsonProperty("events")]
        private List<WorldEvent> _events;

        [JsonIgnore]
        public IReadOnlyList<WorldEvent> Events => _events.AsReadOnly();
    }
}