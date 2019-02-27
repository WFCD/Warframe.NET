using System;

using Newtonsoft.Json;

namespace WorldState.Data.Models
{
    [Obsolete("This information is not in use anymore. It may be purged from servers.")]
    public class DarkSector
    {
        [JsonProperty]
        public string Id { get; private set; }

        [JsonProperty]
        public bool IsAlliance { get; private set; }

        [JsonProperty]
        public string DefenderName { get; private set; }

        [JsonProperty]
        public int DefenderDeploymentActivation { get; private set; }

        [JsonProperty]
        public string DefenderMessage { get; private set; }

        [JsonProperty]
        public string DeployerName { get; private set; }
    }
}
