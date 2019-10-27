using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace Warframe.World.Models
{
    public class News
    {
        [JsonProperty]
        public string Id { get; private set; }

        [JsonProperty]
        public string Message { get; private set; }

        [JsonProperty]
        public string Link { get; private set; }

        [JsonProperty]
        public string ImageLink { get; private set; }

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

        [JsonProperty]
        public Dictionary<string, string> Translations { get; private set; }
        
        [JsonProperty("eta")]
        public string TimeRemaining { get; private set; }
        
        /// <summary>
        /// Returns the supposed language of this news instance.
        /// This is not accurate as it relies on the fact that the first language in the Translations property is the one used.
        /// </summary>
        [JsonIgnore]
        public string PrimaryLanguage { get { return Translations.Keys.First() ?? "Unknown";  } }
    }
}