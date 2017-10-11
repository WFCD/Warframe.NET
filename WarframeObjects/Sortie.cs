using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace WarframeNET
{
    /// <summary>
    /// In-game sortie.
    /// </summary>
    public class Sortie
    {
        /// <summary>
        /// Id of the sortie.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Start time of the sortie.
        /// </summary>
        [JsonProperty("activation")]
        public DateTime StartTime { get; set; }

        /// <summary>
        /// End time of the sortie.
        /// </summary>
        [JsonProperty("expiry")]
        public DateTime EndTime { get; set; }

        /// <summary>
        /// Reeward pool of the sortie.
        /// </summary>
        public string RewardPool { get; set; }

        /// <summary>
        /// Variants of the sortie.
        /// </summary>
        public List<SortieVariant> Variants { get; set; }

        /// <summary>
        /// Boss of the sortie.
        /// </summary>
        public string Boss { get; set; }

        /// <summary>
        /// Faction of the sortie.
        /// </summary>
        public string Faction { get; set; }

        [JsonProperty("eta")]
        public string ETA { get; set; }

        internal Sortie() { }
    }

    /// <summary>
    /// A variant of a sortie.
    /// </summary>
    public class SortieVariant
    {
        /// <summary>
        /// Boss of the variant.
        /// </summary>
        [Obsolete("This property is deprecated. Please use Sorties.Boss instead.")]
        public string Boss { get; set; }

        /// <summary>
        /// Planet of the variant.
        /// </summary>
        [Obsolete("This property is deprecated. Please use SortieVariant.Node instead.")]
        public string Planet { get; set; }

        /// <summary>
        /// Mission type of the variant.
        /// </summary>
        public string MissionType { get; set; }

        /// <summary>
        /// Modifier of the variant.
        /// </summary>
        public string Modifier { get; set; }

        /// <summary>
        /// Modifier of the variant.
        /// </summary>
        [JsonProperty("modifierDescription")]
        public string ModifierDescription { get; set; }

        /// <summary>
        /// Node of the variant.
        /// </summary>
        public string Node { get; set; }

        internal SortieVariant() { }
    }
}

