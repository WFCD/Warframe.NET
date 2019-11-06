using System;

using WorldState.Data.Enums;

namespace WorldState.Data.Interfaces
{
    public interface IDayNightCycle : ITimeSensitive
    {
        DateTimeOffset ActivatedAt { get; }
        TimeOfDay      TimeOfDay   { get; }
    }
}
