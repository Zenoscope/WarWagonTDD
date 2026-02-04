// defines a weapon

using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;

namespace GameWeapon
{
  public class Weapon {

    public string Name { get; set;}
    public int Damage { get; set;}
    public int StrikeNumber { get; set;}

    public Weapon(string name = "Blank", int strikeNumber = 0, int damage = 0)
      {
        Name = name;
        Damage = damage;
        StrikeNumber = strikeNumber;
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
