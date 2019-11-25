using Newtonsoft.Json;

using System;

namespace WorldState.Data.Models
{
    public class News
    {
        [JsonProperty]
        public string Id { get; private set; }

        [JsonProperty]
        public string Message { get; private set; }

        [JsonProperty]
        public Uri Link { get; private set; }

        [JsonProperty]
        public Uri ImageLink { get; private set; }

        [JsonProperty("priority")]
        public bool HasPriority { get; private set; }

        [JsonProperty]
        public DateTimeOffset Date { get; private set; }

        [JsonProperty("update")]
        public bool IsUpdate { get; private set; }

        [JsonProperty("primeAccess")]
        public bool IsPrimeAccess { get; private set; }

        [JsonProperty("stream")]
        public bool IsStream { get; private set; }

        /*
        [JsonProperty]
        public Dictionary<string, string> Translations { get; private set; }

        [JsonIgnore]
        public string PrimaryLanguage => Translations?.Keys.FirstOrDefault() ?? "xx";
        */
    }
}
