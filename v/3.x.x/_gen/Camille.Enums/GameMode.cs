
// This file is automatically generated.
// Do not directly edit.
// Generated on 2020-07-31T03:12:11.102Z

using System.ComponentModel.DataAnnotations;

namespace Camille.Enums
{
    /// <summary>
    /// GameModes enum based on gameModes.json.
    /// </summary>
#if USE_NEWTONSOFT
    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
#elif USE_SYSTEXTJSON
    [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumConverter))]
#endif
    public enum GameMode
    {
        [Display(Name = "ARAM", Description = "ARAM games")]
        ARAM,
        [Display(Name = "ARSR", Description = "All Random Summoner's Rift games")]
        ARSR,
        [Display(Name = "ASCENSION", Description = "Ascension games")]
        ASCENSION,
        [Display(Name = "ASSASSINATE", Description = "Blood Hunt Assassin games")]
        ASSASSINATE,
        [Display(Name = "CLASSIC", Description = "Classic Summoner's Rift and Twisted Treeline games")]
        CLASSIC,
        [Display(Name = "DARKSTAR", Description = "Dark Star: Singularity games")]
        DARKSTAR,
        [Display(Name = "DOOMBOTSTEEMO", Description = "Doom Bot games")]
        DOOMBOTSTEEMO,
        [Display(Name = "FIRSTBLOOD", Description = "Snowdown Showdown games")]
        FIRSTBLOOD,
        [Display(Name = "GAMEMODEX", Description = "Nexus Blitz games, deprecated in patch 9.2 in favor of gameMode NEXUSBLITZ.")]
        GAMEMODEX,
        [Display(Name = "KINGPORO", Description = "Legend of the Poro King games")]
        KINGPORO,
        [Display(Name = "NEXUSBLITZ", Description = "Nexus Blitz games.")]
        NEXUSBLITZ,
        [Display(Name = "ODIN", Description = "Dominion/Crystal Scar games")]
        ODIN,
        [Display(Name = "ODYSSEY", Description = "Odyssey: Extraction games")]
        ODYSSEY,
        [Display(Name = "ONEFORALL", Description = "One for All games")]
        ONEFORALL,
        [Display(Name = "PROJECT", Description = "PROJECT: Hunters games")]
        PROJECT,
        [Display(Name = "SIEGE", Description = "Nexus Siege games")]
        SIEGE,
        [Display(Name = "STARGUARDIAN", Description = "Star Guardian Invasion games")]
        STARGUARDIAN,
        [Display(Name = "TUTORIAL", Description = "Tutorial games")]
        TUTORIAL,
        [Display(Name = "URF", Description = "URF games")]
        URF,
    }
}
