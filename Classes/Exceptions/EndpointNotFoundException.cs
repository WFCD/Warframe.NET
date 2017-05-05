using System;

namespace WarframeNET
{
    [Serializable]
    public class EndpointNotFoundException : Exception
    {
        public EndpointNotFoundException() { }

        public EndpointNotFoundException(string message) : base (message) { }

        public EndpointNotFoundException(string message, Exception inner) : base (message, inner) { }
    }
}