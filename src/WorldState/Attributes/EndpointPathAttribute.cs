using System;
using Newtonsoft.Json.Serialization;

namespace WarframeNet.WorldState
{
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
    public class EndpointPathAttribute : Attribute
    {
        /// <summary>
        /// The API path to retrieve this endpoint information for.
        /// </summary>
        public string EndpointPath { get; private set; }

        public EndpointPathAttribute(string path)
        {
            EndpointPath = path;
        }
    }
}