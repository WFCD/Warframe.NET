﻿namespace WarframeNET
{
    /// <summary>
    /// List of correct Platforms.
    /// </summary>
    public struct Platform
    {
        /// <summary>
        /// PC Platform.
        /// </summary>
        public const string PC = "pc/";

        /// <summary>
        /// PS4 Platform.
        /// </summary>
        public const string PSFOUR = "ps4/";
        
        /// <summary>
        /// XBOX-ONE Platform.
        /// </summary>
        public const string XBOXONE = "xb1/";
        
        /// <summary>
        /// NINTENDO SWITCH Platform.
        /// </summary>
        public const string SWITCH = "swi/";

        /// <summary>
        /// List of correct platforms.
        /// </summary>
        public static string[] List { get; } = {PC, PSFOUR, XBOXONE, SWITCH};
    }
}