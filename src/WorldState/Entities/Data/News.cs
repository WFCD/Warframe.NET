using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;

namespace WarframeNet.WorldState
{
    /// <summary>
    /// An element in the news display of the Orbiter.
    /// </summary>
    public class News
    {
        /// <summary>
        /// Unique identifier for this news article.
        /// </summary>
        [JsonProperty]
        public string Id { get; private set; }

        /// <summary>
        /// Message displayed for this article.
        /// </summary>
        [JsonProperty]
        public string Message { get; private set; }

        /// <summary>
        /// External link for the article.
        /// </summary>
        [JsonProperty]
        public string Link { get; private set; }

        /// <summary>
        /// External link for the displayed image.
        /// </summary>
        [JsonProperty]
        public string ImageLink { get; private set; }

        /// <summary>
        /// Whether or not this article has priority over others (will be displayed above them).
        /// </summary>
        [JsonProperty("priority")]
        public bool HasPriority { get; private set; }

        /// <summary>
        /// Date at which this article was created.
        /// </summary>
        [JsonProperty]
        public DateTimeOffset Date { get; private set; }

        /// <summary>
        /// Whether or not this article is about a game update.
        /// </summary>
        [JsonProperty("update")]
        public bool IsUpdate { get; private set; }

        /// <summary>
        /// Whether or not this article is about Prime Access.
        /// </summary>
        [JsonProperty("primeAccess")]
        public bool IsPrimeAccess { get; private set; }

        /// <summary>
        /// Whether or not this article is about a DE livestream.
        /// </summary>
        [JsonProperty("stream")]
        public bool IsStream { get; private set; }

        [JsonProperty("translations")]
        private Dictionary<string, string> _translations;

        /// <summary>
        /// Available translations for this article's message.
        /// </summary>
        [JsonIgnore]
        public IReadOnlyDictionary<string, string> Translations => _translations;
        
        [JsonProperty("eta")]
        public string TimeRemaining { get; private set; }
        
        /// <summary>
        /// Returns the supposed language of this news instance.
        /// This is not accurate as it relies on the fact that the first language in the Translations property is the one used.
        /// </summary>
        [JsonIgnore]
        public string PrimaryLanguage => Translations.Keys.FirstOrDefault() ?? "en";
    }
}