using System;
using System.Collections.Generic;
using System.Linq;
using WarframeNet.WorldState.Enums;

namespace WarframeNet.WorldState.Utilities
{
    /// <summary>
    /// Contains a collection of extension methods for the world state API.
    /// </summary>
    public static class WorldStateExtensions
    {
        private static readonly Dictionary<WorldStatePlatform, string> PlatformEndpointMap = new();
        private static readonly Dictionary<WorldStateLanguage, string> LanguageHeaderMap = new();
        private static readonly Dictionary<WorldStateEndpoint, string> EndpointPathMap = new();

        /// <summary>
        /// Retrieves the endpoint specifier for the given platform. 
        /// </summary>
        /// <param name="platform"> The platform to retrieve the endpoint for. </param>
        /// <exception cref="ArgumentOutOfRangeException"> Thrown when an invalid platform is given. </exception>
        /// <exception cref="ArgumentException"> Thrown when we fail to retrieve a valid endpoint for the platform. </exception>
        public static string GetPlatformEndpoint(this WorldStatePlatform platform)
        {
            if (PlatformEndpointMap.ContainsKey(platform))
            {
                return PlatformEndpointMap[platform];
            }
            
            var member = typeof(WorldStatePlatform)
                .GetMember(platform.ToString())
                .FirstOrDefault();

            if (member == null)
            {
                throw new ArgumentOutOfRangeException(nameof(platform), platform, "Invalid world state platform.");
            }

            var attribute = member.GetCustomAttributes(typeof(EndpointPathAttribute), false).FirstOrDefault();
            
            if (attribute == null)
            {
                throw new ArgumentException($"Platform '{Enum.GetName(platform)}' is missing EndpointPath attribute.");
            }

            var attr = (EndpointPathAttribute)attribute;
            if (string.IsNullOrWhiteSpace(attr.EndpointPath))
            {
                throw new ArgumentException($"Platform '{Enum.GetName(platform)}' has a null or whitespace endpoint path.");
            }
            
            PlatformEndpointMap.Add(platform, attr.EndpointPath);
            return attr.EndpointPath;
        }

        /// <summary>
        /// Retrieves the Accept-Language header parameter for the given worldstate language.
        /// </summary>
        /// <param name="language"> The language to retrieve the header parameter for. </param>
        /// <exception cref="ArgumentOutOfRangeException"> Thrown when an invalid language is given. </exception>
        /// <exception cref="ArgumentException"> Thrown when we fail to retrieve a valid identifier for the language. </exception>
        public static string GetLanguageIdentifier(this WorldStateLanguage language)
        {
            if (LanguageHeaderMap.ContainsKey(language))
            {
                return LanguageHeaderMap[language];
            }
            
            var member = typeof(WorldStateLanguage)
                .GetMember(language.ToString())
                .FirstOrDefault();

            if (member == null)
            {
                throw new ArgumentOutOfRangeException(nameof(language), language, "Invalid world state language.");
            }

            var attribute = member.GetCustomAttributes(typeof(QueryLanguageAttribute), false).FirstOrDefault();
            
            if (attribute == null)
            {
                throw new ArgumentException($"Language '{Enum.GetName(language)}' is missing AcceptLanguage attribute.");
            }

            var attr = (QueryLanguageAttribute)attribute;
            if (string.IsNullOrWhiteSpace(attr.Language))
            {
                throw new ArgumentException($"Platform '{Enum.GetName(language)}' has a null or whitespace language identifier.");
            }
            
            LanguageHeaderMap.Add(language, attr.Language);
            return attr.Language;
        }

        /// <summary>
        /// Retrieves the endpoint path for the specified endpoint.
        /// </summary>
        /// <param name="endpoint"> The endpoint to retrieve the path for. </param>
        /// <exception cref="ArgumentOutOfRangeException"> Thrown when an invalid endpoint is given. </exception>>
        /// <exception cref="ArgumentException"> Thrown when we fail to retrieve a valid path for the endpoint. </exception>
        public static string GetEndpointPath(this WorldStateEndpoint endpoint)
        {
            if (EndpointPathMap.ContainsKey(endpoint))
            {
                return EndpointPathMap[endpoint];
            }
            
            var member = typeof(WorldStateEndpoint)
                .GetMember(endpoint.ToString())
                .FirstOrDefault();

            if (member == null)
            {
                throw new ArgumentOutOfRangeException(nameof(endpoint), endpoint, "Invalid world state endpoint.");
            }

            var attribute = member.GetCustomAttributes(typeof(EndpointPathAttribute), false).FirstOrDefault();
            
            if (attribute == null)
            {
                throw new ArgumentException($"Endpoint '{Enum.GetName(endpoint)}' is missing EndpointPath attribute.");
            }

            var attr = (EndpointPathAttribute)attribute;
            if (string.IsNullOrWhiteSpace(attr.EndpointPath))
            {
                throw new ArgumentException($"Endpoint '{Enum.GetName(endpoint)}' has a null or whitespace endpoint path.");
            }
            
            EndpointPathMap.Add(endpoint, attr.EndpointPath);
            return attr.EndpointPath;
        }
    }
}