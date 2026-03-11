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
     [Ignore("Skipping this test for now")]
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
     [Ignore("Skipping this test for now")]
     public void getListOfAllWeapons(){
      GameWeapon.Weapon test = MyEntity.DefaultWeaponList[0];
     }


      [Test]
      [Ignore("Skipping this test for now")]
      public void TestListWeapon() {
        GameWeapon.Weapon MyWeapon = MyEntity.ListWeapon(MyEntity.EquippedWeaponList[0],0);
        // should return a Weapon
        Assert.That(MyWeapon, Is.TypeOf(typeof(GameWeapon.Weapon)));
        }

      [Test]
      [Ignore("Skipping this test for now")]
      public void TestChooseWeaponToReplace() {

        GameWeapon.Weapon MyWeapon = new GameWeapon.Weapon( "AreaLightning", 10, 3, 0, 0,
                0, 1, 0 , GameWeapon.DamageEnum.Cut, GameWeapon.EffectEnum.AoE );
        MyEntity.AddToWeaponList(MyWeapon);

        MyWeapon = new GameWeapon.Weapon( "AreaLightning 2", 10, 3, 0, 0,
                0, 1, 0 , GameWeapon.DamageEnum.Cut, GameWeapon.EffectEnum.AoE );
        MyEntity.AddToWeaponList(MyWeapon);

        Console.WriteLine("!@ EquippedWeaponList length: {0}", MyEntity.EquippedWeaponList.Count());
        MyWeapon = MyEntity.ChooseWeaponToReplace();
        // should return a Weapon
        Console.WriteLine("!@ Replacing weapon: {0}", MyWeapon.Name);
        Assert.That(MyWeapon, Is.TypeOf(typeof(GameWeapon.Weapon)));
        }


      [Test]
      [Ignore("Skipping this test for now")]
      public void TestReplaceThisWeapon(){

        Console.WriteLine("!! ReplaceThisWeapon");

        GameWeapon.Weapon originalWeapon = new GameWeapon.Weapon( "Mob of Tiny Horses", 10, 3, 0, 0,
                0, 1, 0 , GameWeapon.DamageEnum.Cut, GameWeapon.EffectEnum.AoE );
        MyEntity.AddToWeaponList(originalWeapon);

        GameWeapon.Weapon swappedWeapon = new GameWeapon.Weapon( "Giant Killer Duck", 10, 3, 0, 0,
                0, 1, 0 , GameWeapon.DamageEnum.Cut, GameWeapon.EffectEnum.AoE );

        Console.WriteLine("EquippedWeaponList length: {0}", MyEntity.EquippedWeaponList.Count());

        int index = MyEntity.EquippedWeaponList.IndexOf(originalWeapon);
        Console.WriteLine("Original Weapon {0} ", originalWeapon.Name);
        GameWeapon.Weapon replacedWeapon = MyEntity.ReplaceThisWeapon(originalWeapon, swappedWeapon);
        Console.WriteLine("Replaced with = {0} " , replacedWeapon.Name);
        Assert.That(replacedWeapon.Name,Is.EqualTo(swappedWeapon.Name));
      }

      [Test]
      public void TestAddWeapon(){
        Console.WriteLine("EquippedWeaponList test Count:" , MyEntity.EquippedWeaponList.Count());

        GameWeapon.Weapon Weapon;
        Weapon = new GameWeapon.Weapon( "Single Axe Handle", 10, 3, 0, 0,
                0, 1, 0 , GameWeapon.DamageEnum.Cut, GameWeapon.EffectEnum.AoE );
        MyEntity.AddWeapon(Weapon);
        Assert.That(Weapon, Is.TypeOf(typeof(GameWeapon.Weapon)));
        Console.WriteLine("EquippedWeaponList test Count:" , MyEntity.EquippedWeaponList.Count());

        Weapon = new GameWeapon.Weapon( "Double Axe Handle", 10, 3, 0, 0,
                0, 1, 0 , GameWeapon.DamageEnum.Cut, GameWeapon.EffectEnum.AoE );
        MyEntity.AddWeapon(Weapon);
        Console.WriteLine("EquippedWeaponList test Count:" , MyEntity.EquippedWeaponList.Count());

        Weapon = new GameWeapon.Weapon( "Double Double Axe Handle", 10, 3, 0, 0,
                0, 1, 0 , GameWeapon.DamageEnum.Cut, GameWeapon.EffectEnum.AoE );
        MyEntity.AddWeapon(Weapon);
        Console.WriteLine("EquippedWeaponList test Count:" , MyEntity.EquippedWeaponList.Count());

        Weapon = new GameWeapon.Weapon( "Double Double Toil and Trouble", 10, 3, 0, 0,
                0, 1, 0 , GameWeapon.DamageEnum.Cut, GameWeapon.EffectEnum.AoE );
        MyEntity.AddWeapon(Weapon);
        Console.WriteLine("EquippedWeaponList test Count:" , MyEntity.EquippedWeaponList.Count());

        Weapon = new GameWeapon.Weapon( "Doubler and Doubler Toil and Trouble", 10, 3, 0, 0,
                0, 1, 0 , GameWeapon.DamageEnum.Cut, GameWeapon.EffectEnum.AoE );
        MyEntity.AddWeapon(Weapon);
        Console.WriteLine("EquippedWeaponList test Count:" , MyEntity.EquippedWeaponList.Count());

        int EquippedWeaponListCount =  MyEntity.EquippedWeaponList.Count() - 1;
        // Assert.That(MyEntity.EquippedWeaponList.Count(),Is.EqualTo(MyEntity.MaxWeaponListSize));
        Assert.That(Weapon.Name,Is.EqualTo(MyEntity.EquippedWeaponList[EquippedWeaponListCount].Name));

        Console.WriteLine("EquippedWeaponList test Count:" , MyEntity.EquippedWeaponList.Count());

      }

      /*
      private void upgradeWeapon(GameWeapon.Weapon NewWeapon){
        // get three random weapons
        getThreeWeaponsFromListUpgradeList()

        // upgrade all of the weapons.
          // figure out which attributres its possible to upgrade and choose one
        // display all of the possible options and choose one.
        // upgrade the weapon
        // put it in the players inventory
      }*/

      [Test]
      public void TestGetThreeWeaponsFromUpgradeList(){
        MyEntity.UpgradeWeaponList =  MyEntity.GetThreeWeaponsFromUpgradeList();
        foreach(GameWeapon.Weapon item in MyEntity.UpgradeWeaponList){
            Assert.That(item, Is.TypeOf(typeof(GameWeapon.Weapon)));
        }

      }

      /*
      [Test]
      public void TestSelectAttribute(){
        Weapon = new GameWeapon.Weapon( "Doubler and Doubler Toil and Trouble", 10, 3, 0, 0,
                0, 1, 0 , GameWeapon.DamageEnum.Cut, GameWeapon.EffectEnum.AoE );

        // select a random attribute
        int randomAttribute = MyEntity.SelectAttribute(Weapon);
        // check to see if an attribute has been updated.
          // check to see if the attribute has been maxed out, if it has, choose another
        // list of attributes that can be upgraded:
        // range, durability, instances, etc
        // return attribute;
      }
      */

      /*
      public void UpgradeAttribute (){
          // upgrade said attribute
          // add a number to the attribute.
        }
      */

   }
}
