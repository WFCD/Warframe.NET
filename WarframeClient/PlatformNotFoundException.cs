using System;

namespace WarframeNET
{
    /// <summary>
    /// Thrown when a platform isn't valid.
    /// </summary>
    [Serializable]
    public class PlatformNotFoundException : Exception
    {
        public PlatformNotFoundException() { }

        public PlatformNotFoundException(string message) : base(message) { }

        public PlatformNotFoundException(string message, Exception inner) : base(message, inner) { }
    }
}