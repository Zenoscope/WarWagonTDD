// defines a weapon

using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;

namespace Weapon
{
  public class Weapon {
    public string Name { get; set;}
    public int Damage { get; set;}
    public int StrikeNumber { get; set;}

    public Weapon(string name, int damage, int strikeNumber)
      {
        Name = name;
        Damage = damage;
        StrikeNumber = strikeNumber;
     }

    public void createWeapon() {
      // create the weapon
      Weapon myWeapon = new Weapon("Anvil",50,50);
      // add to the list

    }

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

  public static void Main()
	{
		List<Weapon> playerWeaponList = new List<Weapon>();
		Weapon playerWeapons = new Weapon("Anvil",50,50);
	 }

 } // class
} // namespace
