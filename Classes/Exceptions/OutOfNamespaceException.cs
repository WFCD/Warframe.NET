using System;

namespace WarframeNET
{
    [Serializable]
    public class OutOfNamespaceException : Exception
    {
        public OutOfNamespaceException() { }

        public OutOfNamespaceException(string message) : base (message) { }

        public OutOfNamespaceException(string message, Exception inner) : base (message, inner) { }
    }
}