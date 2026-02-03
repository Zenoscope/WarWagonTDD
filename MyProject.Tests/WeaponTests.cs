using NUnit.Framework;

namespace WeaponTests
{
  // should there be bounds checking tests or should the tests
   public class WeaponTests
    {

      // private GameWeapon.Weapon myWeapon;

      // starter weapon?
      /*
      [SetUp]
      public void Setup()
      {
        myWeapon = new GameWeapon.Weapon("Anvil",3,50);
        Console.WriteLine("!!!!!!!!!  new weapon {0}", myWeapon.Name);
      }
      */

      [Test]
      public void testCreateWeapon(){
        //
        GameWeapon.Weapon myWeapon1 = new GameWeapon.Weapon("Anvil",3,50);
        // myWeaponList.add(myWeapon);
        GameWeapon.Weapon myWeapon2 = new GameWeapon.Weapon("Sword",100,50);
        // myWeaponList.add(myWeapon);
        }

      // public void add to weaponList
      /*
      [Test]
      public void testAddToWeaponList(){
        Assert.That(myEntity.addToWeaponList("Anvil",3,50),Is.EqualTo(True));
      }
      */

      /*
       delete specified from weaponList

       // level up weapon
       // how do level ups work?
       // two types, strikenumber and damage.

       upgradeWeaponDamage

       upgradeWeaponStrike
       */

    }
}
