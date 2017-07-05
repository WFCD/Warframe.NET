using Newtonsoft.Json;

namespace WarframeNET.NexusStats
{
    /// <summary>
    /// Special statuses of a player inside NexusProfile.
    /// <seealso cref="NexusProfile"/>
    /// </summary>
    public class NAccolades
    {
        /// <summary>
        /// Is the player a Founder?
        /// </summary>
        [JsonProperty("founder")]
        public bool IsFounder { get; set; }

        /// <summary>
        /// Is the player a Guide of the Lotus?
        /// </summary>
        [JsonProperty("guide")]
        public bool IsGuide { get; set; }

        /// <summary>
        /// Is the player a Moderator?
        /// </summary>
        [JsonProperty("moderator")]
        public bool IsModerator { get; set; }

        /// <summary>
        /// Is the player a Partner?
        /// </summary>
        [JsonProperty("partner")]
        public bool IsPartner { get; set; }

        /// <summary>
        /// Is the player a Staff member?
        /// </summary>
        [JsonProperty("staff")]
        public bool IsStaff { get; set; }
    }
}
