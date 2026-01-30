using NUnit.Framework;

namespace WeaponListTests
{
  public class WeaponListTests
   {

     [SetUp]
     public void Setup()
     {
       List<WeaponList.WeaponList> testWeaponList = new List<WeaponList.WeaponList>();
       WeaponList.createWeaponList();
     }

     [Test]
     public void testAddToWeaponList(){
       Assert.That(WeaponList.addToWeaponList("Anvil",3,50),Is.EqualTo(True));
     }

     /*
     [Test]
     public void testAddToWeaponList(){
       Assert.That(WeaponList.addToWeaponList("Anvil",3,50),Is.EqualTo(True));
     }
     */

   }
}
