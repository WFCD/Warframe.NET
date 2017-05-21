using System;

namespace WarframeNET
{
    /// <summary>
    /// In-game simaris targets. Deprecated.
    /// </summary>
    public class Simaris
    {
        /// <summary>
        /// Target name.
        /// </summary>
        [Obsolete("This property is deprecated.")]
        public string Target { get; set; }

        /// <summary>
        /// Is the target still active?
        /// </summary>
        [Obsolete("This property is deprecated.")]
        public bool IsTargetActive { get; set; }

        internal Simaris() { }
    }
}