using NUnit.Framework;
using System;
using System.Linq;
using System.Collections.Generic;

namespace EntityTests
{

  // should there be bounds checking tests or should the tests

   public class EntityTests
    {

      private GameEntity.Entity MyEntity;

      int MoveAmount = 10;

      [SetUp]
      public void Setup()
      {
          MyEntity = new GameEntity.Entity();
          Console.WriteLine(MyEntity.GetHashCode());
      }

      [Test]
      [Ignore("This works")]
      //  not moved yet, just checking where we are.
      public void GetEntityXLocation() {
        Console.WriteLine("Ent___get X");
        Console.WriteLine(MyEntity.GetHashCode());
        Assert.That(MyEntity.GetXLoc(),Is.EqualTo(0));
      }

      [Test]
      [Ignore("This works")]
      public void GetEntityZLocation() {
        Console.WriteLine("Ent___get z");
        Console.WriteLine(MyEntity.GetHashCode());
        Assert.That(MyEntity.GetZLoc(),Is.EqualTo(0));
      }

      [Test]
      [Ignore("This works")]
      public void SetEntityXLocation() {
        Console.WriteLine("Ent___move X");
        Console.WriteLine(MyEntity.GetHashCode());
        // move in positive direction
        Assert.That(MyEntity.SetXLoc(MoveAmount),Is.EqualTo(MoveAmount));
        Assert.That(MyEntity.GetXLoc(),Is.EqualTo(MoveAmount));
        // move vack to zero
        Assert.That(MyEntity.SetXLoc(-MoveAmount),Is.EqualTo(0));
        Assert.That(MyEntity.GetXLoc(),Is.EqualTo(0));
      }

      [Test]
      [Ignore("This works")]
      public void SetEntityZLocation() {
        Console.WriteLine("Ent___move Z");
        Console.WriteLine(MyEntity.GetHashCode());
        // move in positive direction
        Assert.That(MyEntity.SetZLoc(MoveAmount),Is.EqualTo(MoveAmount));
        Assert.That(MyEntity.GetZLoc(),Is.EqualTo(MoveAmount));
        // move vack to zero
        Assert.That(MyEntity.SetZLoc(-MoveAmount),Is.EqualTo(0));
        Assert.That(MyEntity.GetZLoc(),Is.EqualTo(0));
      }


      // Health tests
      int MaxHealth = 100;

      [Test]
      [Ignore("This works")]
      public void SpawnSetEntityHealth() {
        // set max health and current health.
        Console.WriteLine("Ent___Setting health");
        Console.WriteLine(MyEntity.GetHashCode());
        Assert.That(MyEntity.SpawnSetHealth(MaxHealth),Is.EqualTo(MaxHealth));
      }

      [Test]
      [Ignore("This works")]
      public void GetEntityHealth() {
        Console.WriteLine("Ent___Getting health");
        Console.WriteLine(MyEntity.GetHashCode());
        Assert.That(MyEntity.SpawnSetHealth(MaxHealth),Is.EqualTo(MaxHealth));
        Assert.That(MyEntity.GetHealth(),Is.EqualTo(MaxHealth));
      }

      [Test]
      //[Ignore("This works")]
      public void InjureAndHealEntity() {
        Console.WriteLine("Ent___Injure/heal");
        int InjuryAmount = 25;
        int HealAmount = InjuryAmount;
        Assert.That(MyEntity.SpawnSetHealth(MaxHealth),Is.EqualTo(MaxHealth));
        Assert.That(MyEntity.SubtractFromHealth(InjuryAmount),Is.EqualTo(75));
        Console.WriteLine(" Getting health");
        Assert.That(MyEntity.GetHealth(),Is.EqualTo(75));
        Assert.That(MyEntity.AddToHealth(HealAmount),Is.EqualTo(100));
      }


      [Test]
      public void KillEntity() {
        int InjuryAmount = 25;
        Console.WriteLine("Ent___Killing entity");
        Assert.That(MyEntity.SpawnSetHealth(MaxHealth),Is.EqualTo(MaxHealth));
        Assert.That(MyEntity.SubtractFromHealth(InjuryAmount),Is.EqualTo(75));
        Assert.That(MyEntity.SubtractFromHealth(InjuryAmount),Is.EqualTo(50));
        Assert.That(MyEntity.SubtractFromHealth(InjuryAmount),Is.EqualTo(25));
        Assert.That(MyEntity.SubtractFromHealth(InjuryAmount),Is.EqualTo(0));
      }

      [Test]
      public void OverHealEntity() {
        Console.WriteLine("Ent___Overheal");
        int HealAmount = 25;
        Assert.That(MyEntity.SpawnSetHealth(MaxHealth),Is.EqualTo(MaxHealth));
        Assert.That(MyEntity.AddToHealth(HealAmount),Is.EqualTo(100));
      }

      /*
      *
      *
      [Test]
      public void getMyWeaponList(){
        List<GameWeapon.Weapon> myList = myEntity.GetWeaponList();
      }

      [Test]
      public void addAWeapon(){
        GameWeapon.Weapon myWeapon = new GameWeapon.Weapon();
        myWeapon.Name = "HammerFist";
        myWeapon.StrikeNumber = 100;
        myWeapon.Damage = 100;

        List<GameWeapon.Weapon> myList = myEntity.GetWeaponList();
        myEntity.AddToWeaponList(myWeapon);
        Console.WriteLine("New weapon: {0}", myEntity.myWeaponList[0].Name);
      }
      */

      [Test]
      public void GetMyWeaponStack(){
        Console.WriteLine("Ent___get Weapon stack");
        Stack<GameWeapon.Weapon> MyStack = MyEntity.GetWeaponStack();
      }

      [Test]
      public void AddAWeapon(){
        Console.WriteLine("Ent___Add Weapon");
        GameWeapon.Weapon MyWeapon = new GameWeapon.Weapon();
        MyWeapon.Name = "HammerFist";
        MyWeapon.StrikeNumber = 100;
        MyWeapon.Damage = 100;

        Stack<GameWeapon.Weapon> MyStack = MyEntity.GetWeaponStack();
        MyEntity.AddToWeaponStack(MyWeapon);
        // Console.WriteLine("New weapon: {0}", myEntity.myWeaponStack[0].Name);
        GameWeapon.Weapon StackWeapon  = MyEntity.MyWeaponStack.Peek();
        Console.WriteLine(" Added weapon: {0}", StackWeapon.Name);
      }

      [Test]
      public void ClearWeaponStack(){
        Console.WriteLine("WEA___clear weapon stack");
        GameWeapon.Weapon MyWeapon = new GameWeapon.Weapon();
        MyWeapon.Name = "Weapon To Be Cleared";
        MyWeapon.StrikeNumber = 100;
        MyWeapon.Damage = 100;

        MyEntity.AddToWeaponStack(MyWeapon);
        GameWeapon.Weapon StackWeapon  = MyEntity.MyWeaponStack.Peek();
        Console.WriteLine(" Added found: {0}", StackWeapon.Name);
        MyEntity.ClearWeaponStack();

        Assert.Throws<InvalidOperationException>(() =>  MyEntity.MyWeaponStack.Peek());

        /*
        try {
          stackWeapon = myEntity.myWeaponStack.Peek();
          Console.WriteLine(" Added found: {0}", stackWeapon.Name);
            }
        catch {
          Console.WriteLine(" Stack is empty.");
          }
          */
      }



      [Test]
      public void ReplaceAWeapon(){
        // the player can only have a certain number of weapons
        // before the existing ones are removed.

        Console.WriteLine("WEA__ Replace a weapon");

        // List<GameWeapon.Weapon> myList = myEntity.GetWeaponList();
        GameWeapon.Weapon MyWeapon = new GameWeapon.Weapon();

        MyWeapon.Name = "Number1";
        MyWeapon.StrikeNumber = 100;
        MyWeapon.Damage = 100;
        //MyEntity.AddToWeaponList(MyWeapon);
        MyEntity.AddToWeaponStack(MyWeapon);

        MyWeapon.Name = "Number2";
        MyWeapon.StrikeNumber = 100;
        MyWeapon.Damage = 100;
        MyEntity.AddToWeaponStack(MyWeapon);

        MyWeapon.Name = "Number3";
        MyWeapon.StrikeNumber = 100;
        MyWeapon.Damage = 100;
        MyEntity.AddToWeaponStack(MyWeapon);

        MyWeapon.Name = "Number4";
        MyWeapon.StrikeNumber = 100;
        MyWeapon.Damage = 100;
        MyEntity.AddToWeaponStack(MyWeapon);

        MyWeapon.Name = "Number5";
        MyWeapon.StrikeNumber = 100;
        MyWeapon.Damage = 100;
        MyEntity.AddToWeaponStack(MyWeapon);

        MyWeapon.Name = "Number6";
        MyWeapon.StrikeNumber = 100;
        MyWeapon.Damage = 100;
        MyEntity.AddToWeaponStack(MyWeapon);

        //List<GameWeapon.Weapon> MyList = MyEntity.GetWeaponStack();
        //Console.WriteLine("New weapon: {0}", MyEntity.MyWeaponStack[0].Name);
      }


      /*
      [Test]
      // Collect a gem
      public void CollectAGem(){
         String entityType = "Enemy";
         Assert.That(MyEntity.collectGem(),Is.EqualTo("Enemy"));

         String entityType = "Player";
         Assert.That(MyEntity.collectGem(),Is.EqualTo("Player"));

         // if the gem is collected by an enemy..
         // delete the gem mesh (also used by dieEntity)
         // add the gem value to the armour/health of the enemy entity, to a max value (%?)
         // add the gem to the GemCount
      }
      */

      [Test]
      public void EntityRotateLeft(){
        Console.WriteLine("Ent___RotateLeft");
        Assert.That(MyEntity.LeftRotate(),Is.EqualTo(10));
      }

      [Test]
      public void EntityRotateRight(){
        Console.WriteLine("Ent___RotateLeft");
        Assert.That(MyEntity.RightRotate(),Is.EqualTo(-10));
      }

      // This is the gems which have been collected

      [Test]
      public void GetGemLevel(){
        // check the current level, each gem level should have a level (number or percentage)
        // if the level reaches the threshold, then gems is 0 and level goes up.
        Console.WriteLine("ENT____GetGemLevel");
        Console.WriteLine("Current Gem Level = {0}", MyEntity.CurrentGemLevel);
        // Assert.That(MyEntity.CurrentGemLevel,Is.EqualTo("0"));
        }

      [Test]
      public void GetThenSetGemLevel(){
        // check the current level, each gem level should have a level (number or percentage)
        // if the level reaches the threshold, then gems is 0 and level goes up.
        Console.WriteLine("ENT____Get/SetGemLevel");
        MyEntity.CurrentGemLevel = 5;
        Console.WriteLine("Current Gem Level = {0}", MyEntity.CurrentGemLevel);
        //Assert.That(MyEntity.CurrentGemLevel,Is.EqualTo("0"));
        }

    }
}
