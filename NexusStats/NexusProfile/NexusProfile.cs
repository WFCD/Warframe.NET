using System;
using Newtonsoft.Json;

namespace WarframeNET.NexusStats
{
    /// <summary>
    /// Warframe player profile searched by NexusBot
    /// </summary>
    public class NexusProfile
    {
        /// <summary>
        /// Name of the player.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Special statuses the player has.
        /// </summary>
        public NAccolades Accolades { get; set; }

        /// <summary>
        /// Information about the player's Mastery.
        /// </summary>
        public NMastery Mastery { get; set; }

        /// <summary>
        /// Information about the player's Clan if any.
        /// </summary>
        public NClan Clan { get; set; }

        /// <summary>
        /// List of NPCs the player is currently marked by.
        /// </summary>
        [JsonProperty("marked")]
        public NMarked Markings { get; set; }

        /// <summary>
        /// Date the profile was created by NexusBot.
        /// </summary>
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Date the profile was updated by NexusBot.
        /// </summary>
        public DateTime UpdatedAt { get; set; }

        /// <summary>
        /// If not null, Error is the type of error that occured when requesting player information.
        /// If null, no error has occured.
        /// </summary>
        public string Error { get; set; }

        /// <summary>
        /// If not null, ErrorReason is the reason of the Error.
        /// If null, no error has occured.
        /// </summary>
        [JsonProperty("reason")]
        public string ErrorReason { get; set; }
    }
}
