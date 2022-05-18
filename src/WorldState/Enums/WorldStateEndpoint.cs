using System;

namespace WorldState.Enums
{
    /// <summary>
    /// List of available endpoints to retrieve data from.
    /// </summary>
    // TODO: Add doc link to endpoint entity class for every field below.
    public enum WorldStateEndpoint
    {
        /// <summary>
        /// The root endpoint, returns the entire world state data. 
        /// </summary>
        [EndpointPath("/")]
        Root,
        /// <summary>
        /// Retrieves the last update time of the world state. 
        /// </summary>
        [EndpointPath("/timestamp")]
        Timestamp,
        /// <summary>
        /// Currently available in-game Warframe news.
        /// </summary>
        [EndpointPath("/news")]
        News,
        /// <summary>
        /// Ongoing in-game events.
        /// </summary>
        [EndpointPath("/events")]
        Events,
        /// <summary>
        /// Ongoing and upcoming in-game alerts.
        /// </summary>
        [EndpointPath("/alerts")]
        Alerts,
        /// <summary>
        /// Information about the current world sortie.
        /// </summary>
        [EndpointPath("/sortie")]
        Sortie,
        /// <summary>
        /// Currently available syndicate missions.
        /// </summary>
        [EndpointPath("/syndicateMissions")]
        SyndicateMissions,
        /// <summary>
        /// Currently available fissures
        /// </summary>
        [EndpointPath("/fissures")]
        Fissures,
        /// <summary>
        /// Represents an upgrade that applies to all players.
        /// </summary>
        [EndpointPath("/globalUpgrades")]
        GlobalUpgrades,
        /// <summary>
        /// Represents a flash sale.
        /// </summary>
        [EndpointPath("/flashSales")]
        FlashSales,
        /// <summary>
        /// Represents an invasion with attacking and defending factions.
        /// </summary>
        [EndpointPath("/invasions")]
        Invasion,
        /// <summary>
        /// Used to represent dark sectors clans could fight to gain control over.
        /// </summary>
        [Obsolete("Dark sectors are under permanent armistice, as such the result will always be empty. Please don't hit against the API for no reason.", true)]
        [EndpointPath("/darkSectors")]
        DarkSectors,
        /// <summary>
        /// Current information about the void trader's time and place of arrival, as well as inventory if available.
        /// </summary>
        [EndpointPath("/voidTrader")]
        VoidTrader,
        /// <summary>
        /// Represents a daily deal, which generally brings discounts to specific items.
        /// </summary>
        [EndpointPath("/dailyDeals")]
        DailyDeals,
        /// <summary>
        /// Contains information about sanctuary targets.
        /// </summary>
        [EndpointPath("/simaris")]
        Simaris,
        /// <summary>
        /// Represents a Conclave challenge.
        /// </summary>
        [EndpointPath("/conclaveChallenges")]
        ConclaveChallenges,
        /// <summary>
        /// @todo: document this
        /// </summary>
        [EndpointPath("/persistentEnemies")]
        PersistentEnemies,
        /// <summary>
        /// Current information about the day/night cycle of Earth.
        /// </summary>
        [EndpointPath("/earthCycle")]
        EarthCycle,
        /// <summary>
        /// Current information about the day/night cycle of Cetus.
        /// </summary>
        [EndpointPath("/cetusCycle")]
        CetusCycle,
        /// <summary>
        /// Current information about the Fass/Vome cycle of the Cambion Drift.
        /// </summary>
        [EndpointPath("/cambionCycle")]
        CambionCycle,
        /// <summary>
        /// Current information about the warm/cold cycle of the Orb Vallis.
        /// </summary>
        [EndpointPath("/vallisCycle")]
        VallisCycle,
        [Obsolete("This endpoint seemed to have been used for the Void Trader at one point, and is no longer in use.", true)]
        [EndpointPath("/weeklyChallenges")]
        WeeklyChallenges,
        /// <summary>
        /// Current information about the construction of Fomorians and Razorbacks. 
        /// </summary>
        [EndpointPath("/constructionProgress")]
        ConstructionProgress,
        /// <summary>
        /// Current information about ongoing Nightwave challenges and rewards.
        /// </summary>
        [EndpointPath("/nightwave")]
        Nightwave,
        /// <summary>
        /// Currently active Kuva missions.
        /// </summary>
        [EndpointPath("/kuva")]
        Kuva,
        /// <summary>
        /// Retrieves information about the current Arbitration.
        /// </summary>
        [EndpointPath("/arbitration")]
        Arbitration,
        /// <summary>
        /// Represents a set of sentient outposts that are present
        /// </summary>
        [EndpointPath("/sentientOutposts")]
        SentientOutposts,
        /// <summary>
        /// Current information about Steel Path rotation, incursion and rewards.
        /// </summary>
        [EndpointPath("/steelPath")]
        SteelPath,
        /// <summary>
        /// Information about currently sold vaulted items at Maroo's Bazaar.
        /// </summary>
        [EndpointPath("/vaultTrader")]
        VaultTrader,
    }
}