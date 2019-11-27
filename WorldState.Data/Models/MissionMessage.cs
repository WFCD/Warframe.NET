using System;

using Newtonsoft.Json;

namespace WorldState.Data.Models {
    public class MissionMessage
    {
        [JsonProperty]
        public string Sender { get; private set; }

        [JsonProperty("senderIcon")]
        public Uri Avatar { get; private set; }

        [JsonProperty]
        public string Subject { get; private set; }

        [JsonProperty]
        public string Message { get; private set; }

        [JsonProperty]
        public string[] Attachments { get; private set; }
    }
}
