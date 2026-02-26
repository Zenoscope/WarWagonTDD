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
      Console.WriteLine("GemLevelsList = {0}", MyEntity.GemLevelsList[0]);
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
       GameWeapon.Weapon peekAt = MyEntity.EquippedWeaponList[MyEntity.EquippedWeaponList.Count()];
       Console.WriteLine(" Default Weapon Name:{0}", peekAt.Name);
       Assert.That(peekAt.Name,Is.EqualTo("DeathRing"));
     }

     [Test]
     public void TestAddToWeaponList() {
        GameWeapon.Weapon MyWeapon;

        MyWeapon = new GameWeapon.Weapon( "AreaLightning 2", 10, 3, 0, 0,
                0, 1, 0 , GameWeapon.DamageEnum.Cut, GameWeapon.EffectEnum.AoE );

        MyEntity.AddToWeaponList(MyWeapon);

        Console.WriteLine("EquippedWeaponList.Count = {0}" ,MyEntity.EquippedWeaponList.Count());
        // GameWeapon.Weapon peek = MyEntity.EquippedWeaponList[1];
        GameWeapon.Weapon peek = MyEntity.EquippedWeaponList[MyEntity.EquippedWeaponList.Count() - 1];

        Assert.That(peek.Name,Is.EqualTo(MyWeapon.Name));
     }

     [Test]
     public void getListOfAllWeapons(){
       // Console.WriteLine("Weapon 0 {0}", MyEntity.MyDefaultWeaponList[0].Name);
      GameWeapon.Weapon test = MyEntity.DefaultWeaponList[0];
      // string MyWeaponName = MyEntity.MyDefaultWeaponList[0].Name;
       //Assert.That(MyWeapon.Name,Is.EqualTo("DeathRing"));
     }

     [Test]
     public void TestReplaceWeaponOnList(){
       GameWeapon.Weapon MyWeapon;
       MyWeapon = new GameWeapon.Weapon( "Replacement Weapon 1", 0, 0, 0, 0,
               0, 0, 0 , GameWeapon.DamageEnum.Cut, GameWeapon.EffectEnum.AoE );
       MyEntity.DefaultWeaponList.Add(MyWeapon);
       MyWeapon = new GameWeapon.Weapon( "Replacement Weapon 2", 0, 0, 0, 0,
               0, 0, 0 , GameWeapon.DamageEnum.Cut, GameWeapon.EffectEnum.AoE );
       MyEntity.DefaultWeaponList.Add(MyWeapon);
       MyWeapon = new GameWeapon.Weapon( "Replacement Weapon 3", 0, 0, 0, 0,
               0, 0, 0 , GameWeapon.DamageEnum.Cut, GameWeapon.EffectEnum.AoE );
       MyEntity.DefaultWeaponList.Add(MyWeapon);
       MyWeapon = new GameWeapon.Weapon( "Replacement Weapon 4", 0, 0, 0, 0,
               0, 0, 0 , GameWeapon.DamageEnum.Cut, GameWeapon.EffectEnum.AoE );
       MyEntity.DefaultWeaponList.Add(MyWeapon);
       MyWeapon = new GameWeapon.Weapon( "Replacement Weapon 5", 0, 0, 0, 0,
               0, 0, 0 , GameWeapon.DamageEnum.Cut, GameWeapon.EffectEnum.AoE );
       MyEntity.DefaultWeaponList.Add(MyWeapon);

       MyWeapon = new GameWeapon.Weapon( "Replacement Weapon 5", 0, 0, 0, 0,
               0, 0, 0 , GameWeapon.DamageEnum.Cut, GameWeapon.EffectEnum.AoE );
       MyEntity.ReplaceWeaponOnList(MyWeapon);
     }

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
