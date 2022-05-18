using WorldState.Enums;

namespace WorldState.Entities
{
    /// <summary>
    /// Configuration options for the <see cref="WorldStateApiWrapper"/>
    /// </summary>
    public struct WorldStateApiConfiguration
    {
        /// <summary>
        /// The platform to retrieve world state data for.
        /// </summary>
        public WorldStatePlatform Platform { get; set; }
        
        /// <summary>
        /// The language to retrieve world state data in.
        /// </summary>
        public WorldStateLanguage Language { get; set; }
    }
}