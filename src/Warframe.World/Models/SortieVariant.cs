using System;
using Newtonsoft.Json;

namespace Warframe.World.Models
{
    public class SortieVariant
    {
        [Obsolete("This property isn't used anymore and will most likely always return \"Deprecated\"")]
        [JsonProperty]
        public string Boss { get; private set; }

        [Obsolete("This property isn't used anymore and will most likely always return \"Deprecated\"")]
        [JsonProperty]
        public string Planet { get; private set; }

        [JsonProperty]
        public string MissionType { get; private set; }

        [JsonProperty]
        public string Modifier { get; private set; }

        [JsonProperty]
        public string ModifierDescription { get; private set; }

        [JsonProperty]
        public string Node { get; private set; }
    }
}
