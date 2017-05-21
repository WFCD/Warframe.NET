using System.Collections.Generic;

namespace WarframeNET
{
    /// <summary>
    /// In-game reward.
    /// </summary>
    public class Reward
    {
        /// <summary>
        /// List of rewarded items.
        /// </summary>
        public List<string> Items { get; set; }

        /// <summary>
        /// List of rewarded resources.
        /// </summary>
        public List<CountedItem> CountedItems { get; set; }

        /// <summary>
        /// Credits rewarded.
        /// </summary>
        public int Credits { get; set; }

        internal Reward() { }
    }
}