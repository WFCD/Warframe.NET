using Newtonsoft.Json;

namespace Warframe.World.Models
{
    public class Simaris
    {
        [JsonProperty]
        public string Target { get; private set; }

        [JsonProperty]
        public bool TargetActive { get; private set; }
    }
}
