using System;
using Newtonsoft.Json.Serialization;

namespace WarframeNet.WorldState
{
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
    public class QueryLanguageAttribute : Attribute
    {
        /// <summary>
        /// The Accept-Language header to use for this language.
        /// </summary>
        public string Language { get; private set; }

        public QueryLanguageAttribute(string language)
        {
            Language = language;
        }
    }
}