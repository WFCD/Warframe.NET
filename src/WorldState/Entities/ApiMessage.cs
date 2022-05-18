using System.Net;
using Newtonsoft.Json;

namespace WorldState.Entities
{
    /// <summary>
    /// Generally returned by the warframestat.us API when no error or results need to be returned.
    /// </summary>
    public class ApiMessage
    {
        /// <summary>
        /// Message sent by the API.
        /// </summary>
        [JsonProperty("message")]
        public string Message { get; private set; }

        /// <summary>
        /// The HTTP status code that was returned alongside the message.
        /// </summary>
        [JsonProperty("code")]
        public HttpStatusCode Code { get; private set; }
    }
}