namespace WarframeNET.NexusStats
{
    /// <summary>
    /// Stats for Demand/Supply of an item.
    /// </summary>
    public class NexusMarketStat
    {
        /// <summary>
        /// Count of Demand/Supply.
        /// </summary>
        public int Count { get; set; }

        /// <summary>
        /// Percentage between Demand/Supply.
        /// </summary>
        public float Percentage { get; set; }

        internal NexusMarketStat() { }
    }
}
