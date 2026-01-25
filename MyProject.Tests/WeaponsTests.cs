using NUnit.Framework;

namespace WeaponsTests
{
  // should there be bounds checking tests or should the tests
   public class WeaponsTests
    {
      // starter weapon?
      [SetUp]
      public void Setup()
      {
      //     List<Weapon> = new List<Weapon>();
      }

      // public void add to weaponList
      [Test]
      public void testAddToWeaponList(){
        Assert.That(myEntity.addToWeaponList("Anvil",3,50),Is.EqualTo(True));
      }

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
