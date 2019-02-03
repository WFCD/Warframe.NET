using System;

namespace WarframeNET
{
    public interface ITimedEvent
    {
        DateTime EndTime { get; }
    }
}
