namespace WarframeNET.NexusStats
{
    /// <summary>
    /// Clan information of a player in NexusProfile.
    /// <seealso cref="NexusProfile"/>
    /// </summary>
    public class NClan
    {
        /// <summary>
        /// Name of the Clan.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Rank of the Clan.
        /// </summary>
        public int Rank { get; set; }

        /// <summary>
        /// Type of the Clan.
        /// </summary>
        public string Type { get; set; }
    }
}
