namespace WorldState.Enums
{
    /// <summary>
    /// Available platforms to retrieve the worldstate for.
    /// </summary>
    public enum WorldStatePlatform
    {
        /// <summary>
        /// Potato Computer
        /// </summary>
        [EndpointPath("/pc")]
        PC,
        /// <summary>
        /// Sony PlayStation 4
        /// </summary>
        [EndpointPath("/ps4")]
        PlayStation4,
        /// <summary>
        /// Microsoft Xbox One
        /// </summary>
        [EndpointPath("/xb1")]
        XboxOne,
        /// <summary>
        /// Nintendo Switch
        /// </summary>
        [EndpointPath("/swi")]
        Switch,
    }
}