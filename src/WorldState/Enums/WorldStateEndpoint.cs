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
        /// Returns a <see cref="WarframeNet.WorldState.WorldStateData"/> object.
        [EndpointPath("/")]
        Root,
        /// <summary>
        /// Retrieves the last update time of the world state.
        /// Returns a <see cref="System.DateTimeOffset"/> object.
        /// </summary>
        [EndpointPath("/timestamp")]
        Timestamp,
        /// <summary>
        /// Currently available in-game Warframe news.
        /// Returns a list of <see cref="WarframeNet.WorldState.News"/> objects.
        /// </summary>
        [EndpointPath("/news")]
        News,
        /// <summary>
        /// Ongoing in-game events.
        /// Returns a list of <see cref="WarframeNet.WorldState.Event"/> objects.
        /// </summary>
        [EndpointPath("/events")]
        Events,
        /// <summary>
        /// Ongoing and upcoming in-game alerts.
        /// Returns a list of <see cref="WarframeNet.WorldState.Alert"/> objects.
        /// </summary>
        [EndpointPath("/alerts")]
        Alerts,
        /// <summary>
        /// Information about the current world sortie.
        /// </summary>
        /// Returns a <see cref="WarframeNet.WorldState.Sortie"/> object.
        [EndpointPath("/sortie")]
        Sortie,
        /// <summary>
        /// Currently available syndicate missions.
        /// </summary>
        /// Returns a list of <see cref="WarframeNet.WorldState.SyndicateMission"/> objects.
        [EndpointPath("/syndicateMissions")]
        SyndicateMissions,
        /// <summary>
        /// Currently available fissures
        /// </summary>
        /// Returns a list of <see cref="WarframeNet.WorldState.Fissure"/> objects.
        [EndpointPath("/fissures")]
        Fissures,
        /// <summary>
        /// Represents an upgrade that applies to all players.
        /// </summary>
        /// Returns a list of <see cref="WarframeNet.WorldState.GlobalUpgrade"/> objects.
        [EndpointPath("/globalUpgrades")]
        GlobalUpgrades,
        /// <summary>
        /// Represents a flash sale.
        /// </summary>
        /// Returns a list of <see cref="WarframeNet.WorldState.FlashSale"/> objects.
        [EndpointPath("/flashSales")]
        FlashSales,
        /// <summary>
        /// Represents an invasion with attacking and defending factions.
        /// </summary>
        /// Returns a list of <see cref="WarframeNet.WorldState.Invasion"/> objects.
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
        /// Returns a <see cref="WarframeNet.WorldState.VoidTrader"/> object.
        [EndpointPath("/voidTrader")]
        VoidTrader,
        /// <summary>
        /// Represents a daily deal, which generally brings discounts to specific items.
        /// </summary>
        /// Returns a list of <see cref="WarframeNet.WorldState.DailyDeal"/> objects.
        [EndpointPath("/dailyDeals")]
        DailyDeals,
        /// <summary>
        /// Contains information about sanctuary targets.
        /// </summary>
        /// Returns a <see cref="WarframeNet.WorldState.Simaris"/> object.
        [EndpointPath("/simaris")]
        Simaris,
        /// <summary>
        /// Represents a Conclave challenge.
        /// </summary>
        /// Returns a list of <see cref="WarframeNet.WorldState.ConclaveChallenge"/> objects.
        [EndpointPath("/conclaveChallenges")]
        ConclaveChallenges,
        /// <summary>
        /// @todo: document this
        /// </summary>
        /// Returns a list of <see cref="WarframeNet.WorldState.PersistentEnemy"/> objects.
        [EndpointPath("/persistentEnemies")]
        PersistentEnemies,
        /// <summary>
        /// Current information about the day/night cycle of Earth.
        /// </summary>
        /// Returns an <see cref="WarframeNet.WorldState.EarthCycle"/> object.
        [EndpointPath("/earthCycle")]
        EarthCycle,
        /// <summary>
        /// Current information about the day/night cycle of Cetus.
        /// </summary>
        /// Returns a <see cref="WarframeNet.WorldState.CetusCycle"/> object.
        [EndpointPath("/cetusCycle")]
        CetusCycle,
        /// <summary>
        /// Current information about the Fass/Vome cycle of the Cambion Drift.
        /// </summary>
        /// Returns a <see cref="WarframeNet.WorldState.CambionCycle"/> object.
        [EndpointPath("/cambionCycle")]
        CambionCycle,
        /// <summary>
        /// Current information about the warm/cold cycle of the Orb Vallis.
        /// </summary>
        /// Returns a <see cref="WarframeNet.WorldState.VallisCycle"/> object.
        [EndpointPath("/vallisCycle")]
        VallisCycle,
        [Obsolete("This endpoint seemed to have been used for the Void Trader at one point, and is no longer in use.", true)]
        [EndpointPath("/weeklyChallenges")]
        WeeklyChallenges,
        /// <summary>
        /// Current information about the construction of Fomorians and Razorbacks. 
        /// </summary>
        /// Returns a <see cref="WarframeNet.WorldState.ConstructionProgress"/> object.
        [EndpointPath("/constructionProgress")]
        ConstructionProgress,
        /// <summary>
        /// Current information about ongoing Nightwave challenges and rewards.
        /// </summary>
        /// Returns a <see cref="WarframeNet.WorldState.Nightwave"/> object.
        [EndpointPath("/nightwave")]
        Nightwave,
        /// <summary>
        /// Currently active Kuva missions.
        /// </summary>
        /// Returns a list of <see cref="WarframeNet.WorldState.Kuva"/> objects.
        [EndpointPath("/kuva")]
        Kuva,
        /// <summary>
        /// Retrieves information about the current Arbitration.
        /// </summary>
        /// Returns an <see cref="WarframeNet.WorldState.Arbitration"/> object.
        [EndpointPath("/arbitration")]
        Arbitration,
        /// <summary>
        /// Represents a set of sentient outposts that are present
        /// </summary>
        /// Returns a <see cref="WarframeNet.WorldState.SentientOutpost"/> object.
        [EndpointPath("/sentientOutposts")]
        SentientOutposts,
        /// <summary>
        /// Current information about Steel Path rotation, incursion and rewards.
        /// </summary>
        /// Returns a <see cref="WarframeNet.WorldState.SteelPath"/> object.
        [EndpointPath("/steelPath")]
        SteelPath,
        /// <summary>
        /// Information about currently sold vaulted items at Maroo's Bazaar.
        /// </summary>
        /// Returns a <see cref="WarframeNet.WorldState.VaultTrader"/> object.
        [EndpointPath("/vaultTrader")]
        VaultTrader,
    }
}