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
    public int Damage { get; set;} // damage delt
    public int StrikeNumber { get; set;} // individual items spawned
    public int Range { get; set;} // max range from player
    public int Durability { get; set;} // max hits per item
    public int Cooldown { get; set;} // cooldown before respawn in seconds     // etc
    public int CurrentLevel { get; set;}
    public int MaxLevel { get; set;}

    public DamageEnum DamageType { get; set;}

    public EffectEnum EffectType { get; set;}

    public Weapon(string name = "Blank", int strikeNumber = 0, int damage = 0)
      {
        Name = name;
        Damage = damage;
        StrikeNumber = strikeNumber;
        Range = 0;
        Durability = 0;//?
        Cooldown = 0;
        DamageType = DamageEnum.Fire;
        CurrentLevel = 0;
        MaxLevel = 1;
        EffectType = EffectEnum.GroundHit;
        Console.WriteLine("New weapon {0}", Name);
     }

     // should be created by the entity
    // public Weapon createWeapon(string name, int strikeNumber, int damage) {
    /*
    public string createWeapon(string name, int strikeNumber, int damage)
      {
      // create the weapon
      Weapon myWeapon = new Weapon(name,strikeNumber,damage);
      // add to the list
      // return myWeapon;
      return name;
    }*/

	  // level up weapon
      // how do level ups work?
      // two types, strikenumber and damage.
      /*
      public void upgradeWeaponDamage() {
        find the wepon in the list and upgrade it (by name)
      }
      */
      /*
      public void upgradeWeaponStrike() {
        find the wepon in the list and upgrade it (by name)
      }      */
   //}

  // for testing

  /*
  public static void Main()
	{
		List<Weapon> playerWeaponList = new List<Weapon>();
		Weapon playerWeapons = new Weapon("Anvil",50,50);
	 }
   */

 } // class
} // namespace
