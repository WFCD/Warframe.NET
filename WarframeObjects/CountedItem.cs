namespace WarframeNET
{
    /// <summary>
    /// Resource bonuses in mission rewards.
    /// </summary>
    [System.Diagnostics.DebuggerDisplay("CountedItem {Type} x{Count}")]
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
