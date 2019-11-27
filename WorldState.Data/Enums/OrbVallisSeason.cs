using System.Runtime.Serialization;

namespace WorldState.Data.Enums
{
    public enum OrbVallisSeason
    {
        Unknown,

        [EnumMember(Value = "cold")]
        Cold,

        [EnumMember(Value = "warm")]
        Warm
    }
}
