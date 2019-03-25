using System;

using Newtonsoft.Json;

namespace WorldState.Data.Models
{
    public class Simaris
    {
        [JsonProperty]
        public string Target { get; private set; }

        [JsonProperty]
        public bool IsTargetActive { get; private set; }

        public override String ToString()
        {
            return $"Simaris' {(IsTargetActive ? "current" : "previous")} objective {(IsTargetActive ? "is" : "was")} {Target}.";
        }
    }
}
