namespace WarframeNET
{
    /// <summary>
    /// Resource bonuses in mission rewards.
    /// </summary>
    public class CountedItem
    {
        /// <summary>
        /// Count of the resource.
        /// </summary>
        public int Count { get; set; }

        /// <summary>
        /// Type of the resource.
        /// </summary>
        public string Type { get; set; }

        internal CountedItem() { }
    }
}
