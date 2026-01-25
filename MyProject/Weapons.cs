using System;
using System.Data;

namespace Weapons
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
  }

  // should there be bounds checking tests or should the tests
   public class Weapons
    {
      // starter waepon?

      // list of Weapons
      // weapon name, damage,
      /*
      playerWeapons = [
      "Anvil", 3,50,
      "Axe", 3,50,
      "lightning", 3, 50,
      "Flying hammer", 3, 50,
      "Flying daggers", 3, 50
      "arrows",  // area of effect
      ];
      */
      List<Weapon> playerWeaponList = new List<Weapon>();

      // Weapons for wagon
      // set up a list of weapons, check it exists
      // check for attributes and if they are set up.

      public void addToWeaponList(string name, int strikeNumber, int damage){
        playerWeaponList.Add(new Weapon(name,strikeNumber,damage));
      }

      /*
      public void getWeaponList(){

      }
      */
      /*
      public void deleteFromWeaponList() {

      }
      */

      // level up weapon
      // how do level ups work?
      // two types, strikenumber and damage.
      /*
      public void upgradeWeaponDamage() {

      }
      */
      /*
      public void upgradeWeaponStrike() {

      }
      */

    }
}
