using System;

namespace WorldState.Entities
{
    /// <summary>
    /// Wrapper for data returned by the API. Handles cases where an error was returned by the API.
    /// </summary>
    /// <typeparam name="T"> The type of data expected from the API on success. </typeparam>
    public class ApiResult<T> where T : new()
    {
        /// <summary>
        /// The result returned by the API if the call was successful.
        /// </summary>
        public T Result { get; private set; }
        
        /// <summary>
        /// The error returned by the API if the call failed.
        /// </summary>
        public ApiError Error { get; private set; }

        /// <summary>
        /// Whether or not the call to the API was successful and no error was returned.
        /// This does not mean the result cannot be null as the API can return null.
        /// </summary>
        public bool IsSuccessful()
        {
            return Error == null;
        }

        /// <summary>
        /// Create a new ApiResult for a successful API call.
        /// </summary>
        /// <param name="result"> The result of the API call. </param>
        public static ApiResult<T> FromSuccess(T result)
        {
            return new ApiResult<T>
            {
                Result = result,
                Error = null
            };
        }

        /// <summary>
        /// Create a new ApiResult for a failed API call.
        /// </summary>
        /// <param name="error"> The error returned by the API. </param>
        public static ApiResult<T> FromError(ApiError error)
        {
            return new ApiResult<T>
            {
                Result = default,
                Error = error
            };
        }
    }
}