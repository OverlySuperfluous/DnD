using System;
using System.Net;
using SQLite;
using SQLite.Net.Attributes;
using SQLiteNetExtensions;
using SQLiteNetExtensions.Attributes;

[Table("Player")]
public class Player
{
    [PrimaryKey, AutoIncrement]
    public Int64 player_id { get; set; }
    public string firstName { get; set; }
    public string lastName { get; set; }
}

[Table("Spells")]
public class Spells
{
    [PrimaryKey, AutoIncrement]
    public Int64 SpellId { get; set; }
    public string SpellName { get; set; }
    public int Level { get; set; }
    public int School { get; set; }
    public Int64 CastingTime { get; set; }
    public Int64 CastingRange { get; set; }
    public byte Components { get; set; }
    public Int64 Duration { get; set; }
    public string Description { get; set; }
    public int Origination { get; set; }
    public Int64 AuthorId { get; set; }
    public Int64 EditionId { get; set; }
    public Int64 Ruleset { get; set; }
    public int Concentration { get; set; }
    public int SavingThrow { get; set; }
    public int DamageDice { get; set; }
    public int DamagePerLevel { get; set; }
    public int BaseTargets { get; set; }
    public int TargetsPerLevel { get; set; }
    public byte ConditionsApplied { get; set; }
    public int TargetMovement { get; set; }
}

[Table("Spells_By_Class")]
public class SpellsByClass
{
    [ForeignKey(typeof(Spells))]
    public Int64 SpellId { get; set; }

    [ForeignKey(typeof(CharacterClass))]
    public Int64 ClassId { get; set; }
}

[Table("CharacterClass")]
public class CharacterClass
{
    [PrimaryKey, AutoIncrement]
    public Int64 ClassId { get; set; }
    public string ClassName { get; set; }
    public Int64 RulesetId { get; set; }
    public Int64 AuthorId { get; set; }
}

[Table("Ruleset")]
public class Ruleset
{
    [PrimaryKey, AutoIncrement]
    public Int64 RulesetId { get; set; }
    public Int64 EditionId { get; set; }
}