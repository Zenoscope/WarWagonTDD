using NUnit.Framework;

namespace PlayerTests
{
  public class PlayerTests
   {

     private GamePlayer.Player MyEntity;

     [SetUp]
     public void Setup()
     {
         MyEntity = new GamePlayer.Player();
     }

     [Test]
     [Ignore("Skipping this test for now")]
     public void GetPlayerGemLevels(){
      Console.WriteLine("GemLevelsList = {0}" , MyEntity.GemLevelsList[0]);
      // Assert.That(MyEntity.GemLevelsList.1,Is.EqualTo(10));
     }

     // create a new player instance
     [Test]
     [Ignore("Skipping this test for now")]
     public void CreatePlayer(){
       //GamePlayer.Player myPlayer = new GamePlayer.Player();
       Console.WriteLine("Ply _PlayerTest");
       Console.WriteLine(" Entity Name:{0}", MyEntity.Name);
       Console.WriteLine(" Entity X location:{0}", MyEntity.XLoc);
       Console.WriteLine(" Entity Y location:{0}", MyEntity.ZLoc);
       Console.WriteLine(" Entity Y location:{0}", MyEntity.Score);
       GameWeapon.Weapon peekAt = MyEntity.MyWeaponStack.Peek();
       Console.WriteLine(" Default Weapon Name:{0}", peekAt.Name);
       Assert.That(peekAt.Name,Is.EqualTo("DeathRing"));
     }

     [Test]
     public void TestAddToWeaponStack() {
        GameWeapon.Weapon MyWeapon;
        // MyEntity.MyWeapon = new GameWeapon.Weapon("Staff",10,50);
        MyWeapon = new GameWeapon.Weapon("Staff",10,50);
        MyEntity.AddToWeaponStack(MyWeapon);
        GameWeapon.Weapon peekAt = MyEntity.MyWeaponStack.Peek();
        Assert.That(peekAt.Name,Is.EqualTo("Staff"));
     }

     /*
     [Test]
     public void getListOfAllWeapons(){
       MyEntity.something();
     }
     */

     /*

       //Upgrade weapon
       public void UpgradeWeapons(){
           // Player has created a list of all weapons
           // Player also as a weapon stack.

           // get the list of all weapons


           // get a random 3 weapons
           // check to see if the weapon is already in the player stack
           // if so, upgrade it (how does this work?).
           // range, hits, damage are separate?

           MyEntity.MyWeaponStack.Count

             }
           else {
             // delete the top item in the stack (first one added)
             MyWeaponStack.Pop();
             // add the one to add.
             MyWeaponStack.Push(MyWeapon);
           }
         }
         */


   }



 }
