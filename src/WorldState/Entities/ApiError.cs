using System.Net;
using Newtonsoft.Json;

namespace WorldState.Entities
{
    /// <summary>
    /// Returned by the warframestat.us API when an error has occurred.
    /// </summary>
    public class ApiError
    {
        /// <summary>
        /// A short description of the error.
        /// </summary>
        [JsonProperty("error")]
        public string Error { get; init; }

        /// <summary>
        /// The HTTP status code that was returned alongside the error.
        /// </summary>
        [JsonProperty("code")]
        public HttpStatusCode Code { get; init; }
    }
}