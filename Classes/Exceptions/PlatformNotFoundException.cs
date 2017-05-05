using System;

namespace WarframeNET
{
    [Serializable]
    public class PlatformNotFoundException : Exception
    {
        public PlatformNotFoundException() { }

        public PlatformNotFoundException(string message) : base(message) { }

        public PlatformNotFoundException(string message, Exception inner) : base(message, inner) { }
    }
}