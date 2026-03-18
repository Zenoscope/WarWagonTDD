// defines a weapon

using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;

namespace GameWeapon
{

  public enum DamageEnum { Fire, Lightning, Water, Ice, Cut, Strike, Earth }
  public enum EffectEnum { GroundHit, VertHit, HorizHit, AoE, Chain, Location }

  public class Weapon {

    // do they need to be public?
    public string Name { get; set;} // name of weapon
    public uint Damage { get; set;} // damage delt
    public uint DamageMax { get; set;} // damage delt
    public uint StrikeNumber { get; set;} // individual items spawned
    public uint StrikeNumberMax { get; set;} // individual items spawned
    public uint Range { get; set;} // max range from player
    public uint RangeMax { get; set;} // max range from player
    public uint Durability { get; set;} // max hits per item
    public uint DurabilityMax { get; set;} // max hits per item
    public uint Cooldown { get; set;} // cooldown before respawn in seconds     // etc
    public uint CooldownMax { get; set;} // cooldown before respawn in seconds     // etc
    public DamageEnum DamageType { get; set;}
    public EffectEnum EffectType { get; set;}
    public uint CurrentLevel { get; set;}
    public uint MaxLevel { get; set;}

    public Weapon(

        string name = "Blank",
        uint strikeNumber = 0,
        uint strikeNumberMax = 0,
        uint damage = 0,
        uint damageMax = 0,
        uint range = 0,
        uint rangeMax = 0,
        uint durability = 0,
        uint durabilityMax = 0,
        uint cooldown = 0,
        uint cooldownMax = 0,
        uint currentLevel = 0, uint maxLevel = 0,
        DamageEnum damageType = DamageEnum.Strike , EffectEnum effectType = EffectEnum.GroundHit)

      {

        Name = name;
        Damage = damage;
        DamageMax = damageMax;
        StrikeNumber = strikeNumber;
        StrikeNumberMax = strikeNumberMax;
        Range = range;
        RangeMax = rangeMax;
        Durability = durability;//?
        DurabilityMax = durabilityMax;//?
        Cooldown = cooldown;
        CooldownMax = cooldownMax;
        CurrentLevel = currentLevel;
        MaxLevel = maxLevel;
        DamageType = damageType;
        EffectType = EffectType;
     }

 } // class
} // namespace
