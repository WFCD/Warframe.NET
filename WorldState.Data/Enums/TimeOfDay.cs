using System.Runtime.Serialization;

namespace WorldState.Data.Enums
{
    public enum TimeOfDay
    {
        Unknown,

        [EnumMember(Value = "day")]
        Day,

        [EnumMember(Value = "night")]
        Night
    }
}
