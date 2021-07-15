﻿
﻿
// This file is automatically generated.
// Do not directly edit.
// Generated on 2021-07-15T02:40:58.111Z

// http://www.mingweisamuel.com/lolgameapi-schema/tool/


using System.Collections.Generic;
using System.Linq;
using Camille.Enums;


#if USE_NEWTONSOFT
using JsonPropertyAttribute = Newtonsoft.Json.JsonPropertyAttribute;
using JsonExtensionDataAttribute = Newtonsoft.Json.JsonExtensionDataAttribute;
#elif USE_SYSTEXTJSON
using JsonPropertyAttribute = System.Text.Json.Serialization.JsonPropertyNameAttribute;
using JsonExtensionDataAttribute = System.Text.Json.Serialization.JsonExtensionDataAttribute;
#else
#error One of USE_NEWTONSOFT or USE_SYSTEXTJSON must be set.
#endif

// ReSharper disable InconsistentNaming

namespace Camille.LolGame.LiveClientData
{
    /// <summary>
    /// PlayerItem data object. This class is automatically generated.<para />
    /// 
    /// </summary>
    public class PlayerItem
    {

#nullable disable
        public PlayerItem() {}
#nullable restore

        [JsonProperty("canUse")]
        public bool CanUse { get; set; }
        [JsonProperty("consumable")]
        public bool Consumable { get; set; }
        [JsonProperty("count")]
        public int Count { get; set; }
        [JsonProperty("displayName")]
        public string DisplayName { get; set; }
        [JsonProperty("itemID")]
        public int ItemID { get; set; }
        [JsonProperty("price")]
        public int Price { get; set; }
        [JsonProperty("rawDescription")]
        public string RawDescription { get; set; }
        [JsonProperty("rawDisplayName")]
        public string RawDisplayName { get; set; }
        [JsonProperty("slot")]
        public int Slot { get; set; }

        /// <summary>Contains any extra JSON properties that did not map to fields.</summary>
        [JsonExtensionData]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE1006:Naming Styles")]
        public Dictionary<string, object> _AdditionalProperties { get; set; } = new Dictionary<string, object>();

        public override string ToString()
        {
            return "PlayerItem("
                + "CanUse: " + CanUse + ", "
                + "Consumable: " + Consumable + ", "
                + "Count: " + Count + ", "
                + "DisplayName: " + DisplayName + ", "
                + "ItemID: " + ItemID + ", "
                + "Price: " + Price + ", "
                + "RawDescription: " + RawDescription + ", "
                + "RawDisplayName: " + RawDisplayName + ", "
                + "Slot: " + Slot + ", "
                + "_AdditionalProperties: {" + string.Join(", ", _AdditionalProperties.Select(kv => $"\"{kv.Key}\": {kv.Value}")) + "})";
        }
    }
}

namespace Camille.LolGame.LiveClientData
{
    /// <summary>
    /// PlayerRune data object. This class is automatically generated.<para />
    /// 
    /// </summary>
    public class PlayerRune
    {

#nullable disable
        public PlayerRune() {}
#nullable restore

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("rawDescription")]
        public string RawDescription { get; set; }
        [JsonProperty("rawDisplayName")]
        public string RawDisplayName { get; set; }

        /// <summary>Contains any extra JSON properties that did not map to fields.</summary>
        [JsonExtensionData]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE1006:Naming Styles")]
        public Dictionary<string, object> _AdditionalProperties { get; set; } = new Dictionary<string, object>();

        public override string ToString()
        {
            return "PlayerRune("
                + "DisplayName: " + DisplayName + ", "
                + "Id: " + Id + ", "
                + "RawDescription: " + RawDescription + ", "
                + "RawDisplayName: " + RawDisplayName + ", "
                + "_AdditionalProperties: {" + string.Join(", ", _AdditionalProperties.Select(kv => $"\"{kv.Key}\": {kv.Value}")) + "})";
        }
    }
}

namespace Camille.LolGame.LiveClientData
{
    /// <summary>
    /// PlayerRunes data object. This class is automatically generated.<para />
    /// 
    /// </summary>
    public class PlayerRunes
    {

#nullable disable
        public PlayerRunes() {}
#nullable restore

        [JsonProperty("keystone")]
        public PlayerRune Keystone { get; set; }
        [JsonProperty("primaryRuneTree")]
        public PlayerRune PrimaryRuneTree { get; set; }
        [JsonProperty("secondaryRuneTree")]
        public PlayerRune SecondaryRuneTree { get; set; }

        /// <summary>Contains any extra JSON properties that did not map to fields.</summary>
        [JsonExtensionData]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE1006:Naming Styles")]
        public Dictionary<string, object> _AdditionalProperties { get; set; } = new Dictionary<string, object>();

        public override string ToString()
        {
            return "PlayerRunes("
                + "Keystone: " + Keystone + ", "
                + "PrimaryRuneTree: " + PrimaryRuneTree + ", "
                + "SecondaryRuneTree: " + SecondaryRuneTree + ", "
                + "_AdditionalProperties: {" + string.Join(", ", _AdditionalProperties.Select(kv => $"\"{kv.Key}\": {kv.Value}")) + "})";
        }
    }
}

namespace Camille.LolGame.LiveClientData
{
    /// <summary>
    /// PlayerScores data object. This class is automatically generated.<para />
    /// 
    /// </summary>
    public class PlayerScores
    {

#nullable disable
        public PlayerScores() {}
#nullable restore

        [JsonProperty("assists")]
        public int Assists { get; set; }
        [JsonProperty("creepScore")]
        public int CreepScore { get; set; }
        [JsonProperty("deaths")]
        public int Deaths { get; set; }
        [JsonProperty("kills")]
        public int Kills { get; set; }
        [JsonProperty("wardScore")]
        public double WardScore { get; set; }

        /// <summary>Contains any extra JSON properties that did not map to fields.</summary>
        [JsonExtensionData]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE1006:Naming Styles")]
        public Dictionary<string, object> _AdditionalProperties { get; set; } = new Dictionary<string, object>();

        public override string ToString()
        {
            return "PlayerScores("
                + "Assists: " + Assists + ", "
                + "CreepScore: " + CreepScore + ", "
                + "Deaths: " + Deaths + ", "
                + "Kills: " + Kills + ", "
                + "WardScore: " + WardScore + ", "
                + "_AdditionalProperties: {" + string.Join(", ", _AdditionalProperties.Select(kv => $"\"{kv.Key}\": {kv.Value}")) + "})";
        }
    }
}

namespace Camille.LolGame.LiveClientData
{
    /// <summary>
    /// PlayerSummonerSpell data object. This class is automatically generated.<para />
    /// 
    /// </summary>
    public class PlayerSummonerSpell
    {

#nullable disable
        public PlayerSummonerSpell() {}
#nullable restore

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }
        [JsonProperty("rawDescription")]
        public string RawDescription { get; set; }
        [JsonProperty("rawDisplayName")]
        public string RawDisplayName { get; set; }

        /// <summary>Contains any extra JSON properties that did not map to fields.</summary>
        [JsonExtensionData]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE1006:Naming Styles")]
        public Dictionary<string, object> _AdditionalProperties { get; set; } = new Dictionary<string, object>();

        public override string ToString()
        {
            return "PlayerSummonerSpell("
                + "DisplayName: " + DisplayName + ", "
                + "RawDescription: " + RawDescription + ", "
                + "RawDisplayName: " + RawDisplayName + ", "
                + "_AdditionalProperties: {" + string.Join(", ", _AdditionalProperties.Select(kv => $"\"{kv.Key}\": {kv.Value}")) + "})";
        }
    }
}

namespace Camille.LolGame.LiveClientData
{
    /// <summary>
    /// PlayerSummonerSpells data object. This class is automatically generated.<para />
    /// 
    /// </summary>
    public class PlayerSummonerSpells
    {

#nullable disable
        public PlayerSummonerSpells() {}
#nullable restore

        [JsonProperty("summonerSpellOne")]
        public PlayerSummonerSpell SummonerSpellOne { get; set; }
        [JsonProperty("summonerSpellTwo")]
        public PlayerSummonerSpell SummonerSpellTwo { get; set; }

        /// <summary>Contains any extra JSON properties that did not map to fields.</summary>
        [JsonExtensionData]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE1006:Naming Styles")]
        public Dictionary<string, object> _AdditionalProperties { get; set; } = new Dictionary<string, object>();

        public override string ToString()
        {
            return "PlayerSummonerSpells("
                + "SummonerSpellOne: " + SummonerSpellOne + ", "
                + "SummonerSpellTwo: " + SummonerSpellTwo + ", "
                + "_AdditionalProperties: {" + string.Join(", ", _AdditionalProperties.Select(kv => $"\"{kv.Key}\": {kv.Value}")) + "})";
        }
    }
}

namespace Camille.LolGame.LiveClientData
{
    /// <summary>
    /// Player data object. This class is automatically generated.<para />
    /// 
    /// </summary>
    public class Player
    {

#nullable disable
        public Player() {}
#nullable restore

        [JsonProperty("championName")]
        public string ChampionName { get; set; }
        [JsonProperty("isBot")]
        public bool IsBot { get; set; }
        [JsonProperty("isDead")]
        public bool IsDead { get; set; }
        [JsonProperty("items")]
        public PlayerItem[] Items { get; set; }
        [JsonProperty("level")]
        public int Level { get; set; }
        [JsonProperty("position")]
        public string Position { get; set; }
        [JsonProperty("rawChampionName")]
        public string RawChampionName { get; set; }
        [JsonProperty("rawSkinName")]
        public string? RawSkinName { get; set; }
        [JsonProperty("respawnTimer")]
        public double RespawnTimer { get; set; }
        [JsonProperty("runes")]
        public PlayerRunes Runes { get; set; }
        [JsonProperty("scores")]
        public PlayerScores Scores { get; set; }
        [JsonProperty("skinID")]
        public int SkinID { get; set; }
        [JsonProperty("skinName")]
        public string? SkinName { get; set; }
        [JsonProperty("summonerName")]
        public string SummonerName { get; set; }
        [JsonProperty("summonerSpells")]
        public PlayerSummonerSpells SummonerSpells { get; set; }
        [JsonProperty("team")]
        public string Team { get; set; }

        /// <summary>Contains any extra JSON properties that did not map to fields.</summary>
        [JsonExtensionData]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE1006:Naming Styles")]
        public Dictionary<string, object> _AdditionalProperties { get; set; } = new Dictionary<string, object>();

        public override string ToString()
        {
            return "Player("
                + "ChampionName: " + ChampionName + ", "
                + "IsBot: " + IsBot + ", "
                + "IsDead: " + IsDead + ", "
                + "Items: " + Items + ", "
                + "Level: " + Level + ", "
                + "Position: " + Position + ", "
                + "RawChampionName: " + RawChampionName + ", "
                + "RawSkinName: " + RawSkinName + ", "
                + "RespawnTimer: " + RespawnTimer + ", "
                + "Runes: " + Runes + ", "
                + "Scores: " + Scores + ", "
                + "SkinID: " + SkinID + ", "
                + "SkinName: " + SkinName + ", "
                + "SummonerName: " + SummonerName + ", "
                + "SummonerSpells: " + SummonerSpells + ", "
                + "Team: " + Team + ", "
                + "_AdditionalProperties: {" + string.Join(", ", _AdditionalProperties.Select(kv => $"\"{kv.Key}\": {kv.Value}")) + "})";
        }
    }
}

namespace Camille.LolGame.LiveClientData
{
    /// <summary>
    /// Event data object. This class is automatically generated.<para />
    /// 
    /// </summary>
    public class Event
    {

#nullable disable
        public Event() {}
#nullable restore

        [JsonProperty("Acer")]
        public string? Acer { get; set; }
        [JsonProperty("AcingTeam")]
        public string? AcingTeam { get; set; }
        [JsonProperty("Assisters")]
        public string[]? Assisters { get; set; }
        [JsonProperty("DragonType")]
        public string? DragonType { get; set; }
        [JsonProperty("EventID")]
        public int EventID { get; set; }
        [JsonProperty("EventName")]
        public string EventName { get; set; }
        [JsonProperty("EventTime")]
        public double EventTime { get; set; }
        [JsonProperty("InhibKilled")]
        public string? InhibKilled { get; set; }
        [JsonProperty("KillerName")]
        public string? KillerName { get; set; }
        [JsonProperty("KillStreak")]
        public int? KillStreak { get; set; }
        [JsonProperty("Result")]
        public string? Result { get; set; }
        [JsonProperty("Stolen")]
        public string? Stolen { get; set; }
        [JsonProperty("TurretKilled")]
        public string? TurretKilled { get; set; }
        [JsonProperty("VictimName")]
        public string? VictimName { get; set; }

        /// <summary>Contains any extra JSON properties that did not map to fields.</summary>
        [JsonExtensionData]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE1006:Naming Styles")]
        public Dictionary<string, object> _AdditionalProperties { get; set; } = new Dictionary<string, object>();

        public override string ToString()
        {
            return "Event("
                + "EventID: " + EventID + ", "
                + "EventName: " + EventName + ", "
                + "EventTime: " + EventTime + ", "
                + "KillerName: " + KillerName + ", "
                + "TurretKilled: " + TurretKilled + ", "
                + "Assisters: " + Assisters + ", "
                + "InhibKilled: " + InhibKilled + ", "
                + "DragonType: " + DragonType + ", "
                + "Stolen: " + Stolen + ", "
                + "VictimName: " + VictimName + ", "
                + "KillStreak: " + KillStreak + ", "
                + "Acer: " + Acer + ", "
                + "AcingTeam: " + AcingTeam + ", "
                + "Result: " + Result + ", "
                + "_AdditionalProperties: {" + string.Join(", ", _AdditionalProperties.Select(kv => $"\"{kv.Key}\": {kv.Value}")) + "})";
        }
    }
}

namespace Camille.LolGame.LiveClientData
{
    /// <summary>
    /// EventData data object. This class is automatically generated.<para />
    /// 
    /// </summary>
    public class EventData
    {

#nullable disable
        public EventData() {}
#nullable restore

        [JsonProperty("Events")]
        public Event[] Events { get; set; }

        /// <summary>Contains any extra JSON properties that did not map to fields.</summary>
        [JsonExtensionData]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE1006:Naming Styles")]
        public Dictionary<string, object> _AdditionalProperties { get; set; } = new Dictionary<string, object>();

        public override string ToString()
        {
            return "EventData("
                + "Events: " + Events + ", "
                + "_AdditionalProperties: {" + string.Join(", ", _AdditionalProperties.Select(kv => $"\"{kv.Key}\": {kv.Value}")) + "})";
        }
    }
}

namespace Camille.LolGame.LiveClientData
{
    /// <summary>
    /// GameStats data object. This class is automatically generated.<para />
    /// 
    /// </summary>
    public class GameStats
    {

#nullable disable
        public GameStats() {}
#nullable restore

        [JsonProperty("gameMode")]
        public string GameMode { get; set; }
        [JsonProperty("gameTime")]
        public double GameTime { get; set; }
        [JsonProperty("mapName")]
        public string MapName { get; set; }
        [JsonProperty("mapNumber")]
        public int MapNumber { get; set; }
        [JsonProperty("mapTerrain")]
        public string MapTerrain { get; set; }

        /// <summary>Contains any extra JSON properties that did not map to fields.</summary>
        [JsonExtensionData]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE1006:Naming Styles")]
        public Dictionary<string, object> _AdditionalProperties { get; set; } = new Dictionary<string, object>();

        public override string ToString()
        {
            return "GameStats("
                + "GameMode: " + GameMode + ", "
                + "GameTime: " + GameTime + ", "
                + "MapName: " + MapName + ", "
                + "MapNumber: " + MapNumber + ", "
                + "MapTerrain: " + MapTerrain + ", "
                + "_AdditionalProperties: {" + string.Join(", ", _AdditionalProperties.Select(kv => $"\"{kv.Key}\": {kv.Value}")) + "})";
        }
    }
}

namespace Camille.LolGame.LiveClientData
{
    /// <summary>
    /// ActivePlayerAbility data object. This class is automatically generated.<para />
    /// 
    /// </summary>
    public class ActivePlayerAbility
    {

#nullable disable
        public ActivePlayerAbility() {}
#nullable restore

        [JsonProperty("abilityLevel")]
        public int AbilityLevel { get; set; }
        [JsonProperty("displayName")]
        public string DisplayName { get; set; }
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("rawDescription")]
        public string RawDescription { get; set; }
        [JsonProperty("rawDisplayName")]
        public string RawDisplayName { get; set; }

        /// <summary>Contains any extra JSON properties that did not map to fields.</summary>
        [JsonExtensionData]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE1006:Naming Styles")]
        public Dictionary<string, object> _AdditionalProperties { get; set; } = new Dictionary<string, object>();

        public override string ToString()
        {
            return "ActivePlayerAbility("
                + "AbilityLevel: " + AbilityLevel + ", "
                + "DisplayName: " + DisplayName + ", "
                + "Id: " + Id + ", "
                + "RawDescription: " + RawDescription + ", "
                + "RawDisplayName: " + RawDisplayName + ", "
                + "_AdditionalProperties: {" + string.Join(", ", _AdditionalProperties.Select(kv => $"\"{kv.Key}\": {kv.Value}")) + "})";
        }
    }
}

namespace Camille.LolGame.LiveClientData
{
    /// <summary>
    /// ActivePlayerPassiveAbility data object. This class is automatically generated.<para />
    /// 
    /// </summary>
    public class ActivePlayerPassiveAbility
    {

#nullable disable
        public ActivePlayerPassiveAbility() {}
#nullable restore

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("rawDescription")]
        public string RawDescription { get; set; }
        [JsonProperty("rawDisplayName")]
        public string RawDisplayName { get; set; }

        /// <summary>Contains any extra JSON properties that did not map to fields.</summary>
        [JsonExtensionData]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE1006:Naming Styles")]
        public Dictionary<string, object> _AdditionalProperties { get; set; } = new Dictionary<string, object>();

        public override string ToString()
        {
            return "ActivePlayerPassiveAbility("
                + "DisplayName: " + DisplayName + ", "
                + "Id: " + Id + ", "
                + "RawDescription: " + RawDescription + ", "
                + "RawDisplayName: " + RawDisplayName + ", "
                + "_AdditionalProperties: {" + string.Join(", ", _AdditionalProperties.Select(kv => $"\"{kv.Key}\": {kv.Value}")) + "})";
        }
    }
}

namespace Camille.LolGame.LiveClientData
{
    /// <summary>
    /// ActivePlayerAbilities data object. This class is automatically generated.<para />
    /// 
    /// </summary>
    public class ActivePlayerAbilities
    {

#nullable disable
        public ActivePlayerAbilities() {}
#nullable restore

        [JsonProperty("E")]
        public ActivePlayerAbility E { get; set; }
        [JsonProperty("Passive")]
        public ActivePlayerPassiveAbility Passive { get; set; }
        [JsonProperty("Q")]
        public ActivePlayerAbility Q { get; set; }
        [JsonProperty("R")]
        public ActivePlayerAbility R { get; set; }
        [JsonProperty("W")]
        public ActivePlayerAbility W { get; set; }

        /// <summary>Contains any extra JSON properties that did not map to fields.</summary>
        [JsonExtensionData]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE1006:Naming Styles")]
        public Dictionary<string, object> _AdditionalProperties { get; set; } = new Dictionary<string, object>();

        public override string ToString()
        {
            return "ActivePlayerAbilities("
                + "Passive: " + Passive + ", "
                + "Q: " + Q + ", "
                + "W: " + W + ", "
                + "E: " + E + ", "
                + "R: " + R + ", "
                + "_AdditionalProperties: {" + string.Join(", ", _AdditionalProperties.Select(kv => $"\"{kv.Key}\": {kv.Value}")) + "})";
        }
    }
}

namespace Camille.LolGame.LiveClientData
{
    /// <summary>
    /// ActivePlayerChampionStats data object. This class is automatically generated.<para />
    /// 
    /// </summary>
    public class ActivePlayerChampionStats
    {

#nullable disable
        public ActivePlayerChampionStats() {}
#nullable restore

        [JsonProperty("abilityPower")]
        public int AbilityPower { get; set; }
        [JsonProperty("armor")]
        public int Armor { get; set; }
        [JsonProperty("armorPenetrationFlat")]
        public int ArmorPenetrationFlat { get; set; }
        [JsonProperty("armorPenetrationPercent")]
        public int ArmorPenetrationPercent { get; set; }
        [JsonProperty("attackDamage")]
        public double AttackDamage { get; set; }
        [JsonProperty("attackRange")]
        public int AttackRange { get; set; }
        [JsonProperty("attackSpeed")]
        public double AttackSpeed { get; set; }
        [JsonProperty("bonusArmorPenetrationPercent")]
        public int BonusArmorPenetrationPercent { get; set; }
        [JsonProperty("bonusMagicPenetrationPercent")]
        public int BonusMagicPenetrationPercent { get; set; }
        [JsonProperty("cooldownReduction")]
        public double CooldownReduction { get; set; }
        [JsonProperty("critChance")]
        public int CritChance { get; set; }
        [JsonProperty("critDamage")]
        public int CritDamage { get; set; }
        [JsonProperty("currentHealth")]
        public int CurrentHealth { get; set; }
        [JsonProperty("healthRegenRate")]
        public double HealthRegenRate { get; set; }
        [JsonProperty("lifeSteal")]
        public int LifeSteal { get; set; }
        [JsonProperty("magicLethality")]
        public int MagicLethality { get; set; }
        [JsonProperty("magicPenetrationFlat")]
        public int MagicPenetrationFlat { get; set; }
        [JsonProperty("magicPenetrationPercent")]
        public int MagicPenetrationPercent { get; set; }
        [JsonProperty("magicResist")]
        public int MagicResist { get; set; }
        [JsonProperty("maxHealth")]
        public int MaxHealth { get; set; }
        [JsonProperty("moveSpeed")]
        public int MoveSpeed { get; set; }
        [JsonProperty("physicalLethality")]
        public int PhysicalLethality { get; set; }
        [JsonProperty("resourceMax")]
        public int ResourceMax { get; set; }
        [JsonProperty("resourceRegenRate")]
        public double ResourceRegenRate { get; set; }
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }
        [JsonProperty("resourceValue")]
        public int ResourceValue { get; set; }
        [JsonProperty("spellVamp")]
        public int SpellVamp { get; set; }
        [JsonProperty("tenacity")]
        public int Tenacity { get; set; }

        /// <summary>Contains any extra JSON properties that did not map to fields.</summary>
        [JsonExtensionData]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE1006:Naming Styles")]
        public Dictionary<string, object> _AdditionalProperties { get; set; } = new Dictionary<string, object>();

        public override string ToString()
        {
            return "ActivePlayerChampionStats("
                + "AbilityPower: " + AbilityPower + ", "
                + "Armor: " + Armor + ", "
                + "ArmorPenetrationFlat: " + ArmorPenetrationFlat + ", "
                + "ArmorPenetrationPercent: " + ArmorPenetrationPercent + ", "
                + "AttackDamage: " + AttackDamage + ", "
                + "AttackRange: " + AttackRange + ", "
                + "AttackSpeed: " + AttackSpeed + ", "
                + "BonusArmorPenetrationPercent: " + BonusArmorPenetrationPercent + ", "
                + "BonusMagicPenetrationPercent: " + BonusMagicPenetrationPercent + ", "
                + "CooldownReduction: " + CooldownReduction + ", "
                + "CritChance: " + CritChance + ", "
                + "CritDamage: " + CritDamage + ", "
                + "CurrentHealth: " + CurrentHealth + ", "
                + "HealthRegenRate: " + HealthRegenRate + ", "
                + "LifeSteal: " + LifeSteal + ", "
                + "MagicLethality: " + MagicLethality + ", "
                + "MagicPenetrationFlat: " + MagicPenetrationFlat + ", "
                + "MagicPenetrationPercent: " + MagicPenetrationPercent + ", "
                + "MagicResist: " + MagicResist + ", "
                + "MaxHealth: " + MaxHealth + ", "
                + "MoveSpeed: " + MoveSpeed + ", "
                + "PhysicalLethality: " + PhysicalLethality + ", "
                + "ResourceMax: " + ResourceMax + ", "
                + "ResourceRegenRate: " + ResourceRegenRate + ", "
                + "ResourceType: " + ResourceType + ", "
                + "ResourceValue: " + ResourceValue + ", "
                + "SpellVamp: " + SpellVamp + ", "
                + "Tenacity: " + Tenacity + ", "
                + "_AdditionalProperties: {" + string.Join(", ", _AdditionalProperties.Select(kv => $"\"{kv.Key}\": {kv.Value}")) + "})";
        }
    }
}

namespace Camille.LolGame.LiveClientData
{
    /// <summary>
    /// ActivePlayerStatRune data object. This class is automatically generated.<para />
    /// 
    /// </summary>
    public class ActivePlayerStatRune
    {

#nullable disable
        public ActivePlayerStatRune() {}
#nullable restore

        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("rawDescription")]
        public string RawDescription { get; set; }

        /// <summary>Contains any extra JSON properties that did not map to fields.</summary>
        [JsonExtensionData]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE1006:Naming Styles")]
        public Dictionary<string, object> _AdditionalProperties { get; set; } = new Dictionary<string, object>();

        public override string ToString()
        {
            return "ActivePlayerStatRune("
                + "Id: " + Id + ", "
                + "RawDescription: " + RawDescription + ", "
                + "_AdditionalProperties: {" + string.Join(", ", _AdditionalProperties.Select(kv => $"\"{kv.Key}\": {kv.Value}")) + "})";
        }
    }
}

namespace Camille.LolGame.LiveClientData
{
    /// <summary>
    /// ActivePlayerRunes data object. This class is automatically generated.<para />
    /// 
    /// </summary>
    public class ActivePlayerRunes
    {

#nullable disable
        public ActivePlayerRunes() {}
#nullable restore

        [JsonProperty("generalRunes")]
        public PlayerRune[] GeneralRunes { get; set; }
        [JsonProperty("keystone")]
        public PlayerRune Keystone { get; set; }
        [JsonProperty("primaryRuneTree")]
        public PlayerRune PrimaryRuneTree { get; set; }
        [JsonProperty("secondaryRuneTree")]
        public PlayerRune SecondaryRuneTree { get; set; }
        [JsonProperty("statRunes")]
        public ActivePlayerStatRune[] StatRunes { get; set; }

        /// <summary>Contains any extra JSON properties that did not map to fields.</summary>
        [JsonExtensionData]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE1006:Naming Styles")]
        public Dictionary<string, object> _AdditionalProperties { get; set; } = new Dictionary<string, object>();

        public override string ToString()
        {
            return "ActivePlayerRunes("
                + "GeneralRunes: " + GeneralRunes + ", "
                + "Keystone: " + Keystone + ", "
                + "PrimaryRuneTree: " + PrimaryRuneTree + ", "
                + "SecondaryRuneTree: " + SecondaryRuneTree + ", "
                + "StatRunes: " + StatRunes + ", "
                + "_AdditionalProperties: {" + string.Join(", ", _AdditionalProperties.Select(kv => $"\"{kv.Key}\": {kv.Value}")) + "})";
        }
    }
}

namespace Camille.LolGame.LiveClientData
{
    /// <summary>
    /// ActivePlayer data object. This class is automatically generated.<para />
    /// 
    /// </summary>
    public class ActivePlayer
    {

#nullable disable
        public ActivePlayer() {}
#nullable restore

        [JsonProperty("abilities")]
        public ActivePlayerAbilities? Abilities { get; set; }
        [JsonProperty("championStats")]
        public ActivePlayerChampionStats? ChampionStats { get; set; }
        [JsonProperty("currentGold")]
        public int? CurrentGold { get; set; }
        /// <summary>
        /// If this field is set, it indicates the game client is spectating a game rather than playing a game, so there is no active player. If this field is NOT set, all other fields will be supplied.
        /// </summary>
        [JsonProperty("error")]
        public string? Error { get; set; }
        [JsonProperty("fullRunes")]
        public ActivePlayerRunes? FullRunes { get; set; }
        [JsonProperty("level")]
        public int? Level { get; set; }
        [JsonProperty("summonerName")]
        public string? SummonerName { get; set; }

        /// <summary>Contains any extra JSON properties that did not map to fields.</summary>
        [JsonExtensionData]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE1006:Naming Styles")]
        public Dictionary<string, object> _AdditionalProperties { get; set; } = new Dictionary<string, object>();

        public override string ToString()
        {
            return "ActivePlayer("
                + "Abilities: " + Abilities + ", "
                + "ChampionStats: " + ChampionStats + ", "
                + "CurrentGold: " + CurrentGold + ", "
                + "FullRunes: " + FullRunes + ", "
                + "Level: " + Level + ", "
                + "SummonerName: " + SummonerName + ", "
                + "Error: " + Error + ", "
                + "_AdditionalProperties: {" + string.Join(", ", _AdditionalProperties.Select(kv => $"\"{kv.Key}\": {kv.Value}")) + "})";
        }
    }
}

namespace Camille.LolGame.LiveClientData
{
    /// <summary>
    /// AllGameData data object. This class is automatically generated.<para />
    /// 
    /// </summary>
    public class AllGameData
    {

#nullable disable
        public AllGameData() {}
#nullable restore

        [JsonProperty("activePlayer")]
        public ActivePlayer ActivePlayer { get; set; }
        [JsonProperty("allPlayers")]
        public Player[] AllPlayers { get; set; }
        [JsonProperty("events")]
        public EventData Events { get; set; }
        [JsonProperty("gameData")]
        public GameStats GameData { get; set; }

        /// <summary>Contains any extra JSON properties that did not map to fields.</summary>
        [JsonExtensionData]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE1006:Naming Styles")]
        public Dictionary<string, object> _AdditionalProperties { get; set; } = new Dictionary<string, object>();

        public override string ToString()
        {
            return "AllGameData("
                + "ActivePlayer: " + ActivePlayer + ", "
                + "AllPlayers: " + AllPlayers + ", "
                + "Events: " + Events + ", "
                + "GameData: " + GameData + ", "
                + "_AdditionalProperties: {" + string.Join(", ", _AdditionalProperties.Select(kv => $"\"{kv.Key}\": {kv.Value}")) + "})";
        }
    }
}


