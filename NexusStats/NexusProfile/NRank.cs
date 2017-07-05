using Newtonsoft.Json;

namespace WarframeNET
{
    /// <summary>
    /// Rank information of a player in NexusProfile.
    /// <seealso cref="NexusProfile"/>
    /// </summary>
    public class NRank
    {
        /// <summary>
        /// Name of the Rank.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Mastery Level number.
        /// </summary>
        public int Number { get; set; }

        /// <summary>
        /// Name of the next Rank.
        /// </summary>
        [JsonProperty("next")]
        public string NextRankName { get; set; }
    }
}
