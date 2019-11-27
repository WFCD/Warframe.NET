using System;

using WorldState.Data.Enums;

namespace WorldState.Data.Interfaces
{
    public interface IDayNightCycle : ITimeSensitive
    {
        TimeOfDay      TimeOfDay   { get; }
    }
}
