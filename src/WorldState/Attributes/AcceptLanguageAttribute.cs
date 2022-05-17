using System;
using Newtonsoft.Json.Serialization;

namespace WorldState
{
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
    public class AcceptLanguageAttribute : Attribute
    {
        /// <summary>
        /// The Accept-Language header to use for this language.
        /// </summary>
        public string Language { get; private set; }

        public AcceptLanguageAttribute(string language)
        {
            Language = language;
        }
    }
}