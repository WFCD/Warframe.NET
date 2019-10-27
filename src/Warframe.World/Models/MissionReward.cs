using Newtonsoft.Json;

namespace Warframe.World.Models
{
    public class MissionReward
    {
        [JsonProperty]
        public string[] Items { get; private set; }

        [JsonProperty("countedItems")]
        public SystemResource[] Resources { get; private set; }

        [JsonProperty]
        public int Credits { get; private set; }

        [JsonProperty]
        public string Thumbnail { get; private set; }

        [JsonProperty]
        public int Color { get; private set; }
    }
}
