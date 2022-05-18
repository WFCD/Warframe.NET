using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using WorldState.Entities;
using WorldState.Enums;
using WorldState.Utilities;

namespace WorldState
{
    /// <summary>
    /// Handles making API calls to the world state using the specific parameters.
    /// </summary>
    public class WorldStateApiWrapper
    {
        /// <summary>
        /// Base URL of the world state api.
        /// </summary>
        private readonly string _apiUrl = "https://api.warframestat.us";
        private HttpClient _httpClient;

        /// <summary>
        /// Initialises a new world state API wrapper. 
        /// </summary>
        public WorldStateApiWrapper()
        {
            _httpClient = new HttpClient();
        }

        /// <summary>
        /// Attempts to retrieve data from the world state API for the given platform and endpoint.
        /// </summary>
        /// <param name="platform"> The platform to retrieve the world state data for. </param>
        /// <param name="endpoint"> The endpoint to retrieve data from. </param>
        /// <typeparam name="T"> The entity class expected to return from the specified endpoint. </typeparam>
        public async Task<ApiResult<T>> GetWorldStateDataAsync<T>(WorldStatePlatform platform, WorldStateEndpoint endpoint) where T : new()
        {
            return await GetWorldStateDataAsync<T>(platform, WorldStateLanguage.English, endpoint).ConfigureAwait(false);
        }

        /// <summary>
        /// Attempts to retrieve data from the world state API for the given platform and endpoint.
        /// </summary>
        /// <param name="platform"> The platform to retrieve the world state data for. </param>
        /// <param name="language"> The language to retrieve the world state data in. </param>
        /// <param name="endpoint"> The endpoint to retrieve data from. </param>
        /// <typeparam name="T"> The entity class expected to return from the specified endpoint. </typeparam>
        public async Task<ApiResult<T>> GetWorldStateDataAsync<T>(WorldStatePlatform platform,
            WorldStateLanguage language, WorldStateEndpoint endpoint) where T : new()
        {
            var platformEndpoint = platform.GetPlatformEndpoint();
            var languageHeader = language.GetLanguageIdentifier();
            var endpointPath = endpoint.GetEndpointPath();

            // Get the correct path for this API call.
            var apiPath = $"{_apiUrl}{platformEndpoint}{endpointPath}";

            // Set the user agent and language headers. 
            using var request = new HttpRequestMessage(HttpMethod.Get, apiPath);
            request.Headers.AcceptLanguage.Clear();
            request.Headers.AcceptLanguage.ParseAdd(languageHeader);
            request.Headers.UserAgent.ParseAdd("Warframe.NET");

            var response = await _httpClient.SendAsync(request).ConfigureAwait(false);
            var result = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
            
            // If the response code isn't a successful one, we'll try to parse the result into an ApiResult.
            // Else, we'll make one ourselves and specify an unknown error happened.
            if (!response.IsSuccessStatusCode)
            {
                try
                {
                    var apiError = JsonConvert.DeserializeObject<ApiError>(result);
                    return ApiResult<T>.FromError(apiError);
                }
                catch (Exception)
                {
                    var apiError = new ApiError
                    {
                        Code = response.StatusCode,
                        Error = "Warframe.NET: the API returned an error, but without a valid ApiError result. Please try again later."
                    };

                    return ApiResult<T>.FromError(apiError);
                }
            }
            
            // Success! Let's try reading the data into the requested type.
            try
            {
                var data = JsonConvert.DeserializeObject<T>(result);
                return ApiResult<T>.FromSuccess(data);
            }
            catch (Exception ex)
            {
                return ApiResult<T>.FromError(new ApiError
                {
                    Error = $"Failed to parse data into the requested type: {ex.Message}.",
                    Code = HttpStatusCode.BadRequest
                });
            }
        }
    }
}