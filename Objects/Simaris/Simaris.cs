using System;

namespace WarframeNET
{
    public class Simaris
    {
        [Obsolete("This property is deprecated.", true)]
        public string Target { get; set; }

        [Obsolete("This property is deprecated.", true)]
        public bool IsTargetActive { get; set; }

        internal Simaris() { }
    }
}