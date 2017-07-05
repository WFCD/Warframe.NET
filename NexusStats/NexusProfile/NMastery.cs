using Newtonsoft.Json;

namespace WarframeNET.NexusStats
{
    /// <summary>
    /// Mastery information of a player in NexusProfile.
    /// <seealso cref="NexusProfile"/>
    /// </summary>
    public class NMastery
    {
        /// <summary>
        /// Rank of the player.
        /// </summary>
        public NRank Rank { get; set; }

        /// <summary>
        /// Current XP of the player.
        /// </summary>
        public int XP { get; set; }

        /// <summary>
        /// Amount of XP required to level up.
        /// </summary>
        [JsonProperty("xpUntilNextRank")]
        public int RemainingXP { get; set; }
    }
}
