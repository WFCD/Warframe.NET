using Newtonsoft.Json;

namespace WarframeNet.WorldState
{
    /// <summary>
    /// Interim step for an event reward system.
    /// </summary>
    public class InterimStep
    {
        /// <summary>
        /// Required amount to reach the goal.
        /// </summary>
        [JsonProperty("goal")]
        public int Goal { get; private set; }
    }
}