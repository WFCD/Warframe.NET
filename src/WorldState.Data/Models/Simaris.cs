using System;

using Newtonsoft.Json;

namespace WorldState.Data.Models
{
    public class Simaris
    {
        [JsonProperty]
        public string Target { get; private set; }

        [JsonProperty("isTargetActive")]
        public bool IsActive { get; private set; }

        public override String ToString()
        {
            return $"Simaris' {(IsActive ? "current" : "previous")} objective {(IsActive ? "is" : "was")} {Target}.";
        }
    }
}
