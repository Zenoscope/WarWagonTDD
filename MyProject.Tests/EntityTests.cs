using NUnit.Framework;
using System;
using System.Linq;
using System.Collections.Generic;

namespace EntityTests
{

  // should there be bounds checking tests or should the tests

   public class EntityTests
    {

      private GameEntity.Entity myEntity;

      int moveAmount = 10;

      [SetUp]
      public void Setup()
      {
          myEntity = new GameEntity.Entity();
          Console.WriteLine(myEntity.GetHashCode());
      }

      [Test]
      [Ignore("This works")]
      //  not moved yet, just checking where we are.
      public void getEntityXLocation() {
        Console.WriteLine("get X");
        Console.WriteLine(myEntity.GetHashCode());
        Assert.That(myEntity.getXLoc(),Is.EqualTo(0));
      }

      [Test]
      [Ignore("This works")]
      public void getEntityZLocation() {
        Console.WriteLine("get y");
        Console.WriteLine(myEntity.GetHashCode());
        Assert.That(myEntity.getZLoc(),Is.EqualTo(0));
      }

      [Test]
      [Ignore("This works")]
      public void setEntityXLocation() {
        Console.WriteLine("move X");
        Console.WriteLine(myEntity.GetHashCode());
        // move in positive direction
        Assert.That(myEntity.setXLoc(moveAmount),Is.EqualTo(moveAmount));
        Assert.That(myEntity.getXLoc(),Is.EqualTo(moveAmount));
        // move vack to zero
        Assert.That(myEntity.setXLoc(-moveAmount),Is.EqualTo(0));
        Assert.That(myEntity.getXLoc(),Is.EqualTo(0));
      }

      [Test]
      [Ignore("This works")]
      public void setEntityZLocation() {
        Console.WriteLine("move y");
        Console.WriteLine(myEntity.GetHashCode());
        // move in positive direction
        Assert.That(myEntity.setZLoc(moveAmount),Is.EqualTo(moveAmount));
        Assert.That(myEntity.getZLoc(),Is.EqualTo(moveAmount));
        // move vack to zero
        Assert.That(myEntity.setZLoc(-moveAmount),Is.EqualTo(0));
        Assert.That(myEntity.getZLoc(),Is.EqualTo(0));
      }


      // Health tests
      int maxHealth = 100;

      [Test]
      [Ignore("This works")]
      public void spawnSetEntityHealth() {
        // set max health and current health.
        Console.WriteLine("Set health");
        Console.WriteLine(myEntity.GetHashCode());
        Assert.That(myEntity.spawnSetHealth(maxHealth),Is.EqualTo(maxHealth));
      }

      [Test]
      [Ignore("This works")]
      public void getEntityHealth() {
        Console.WriteLine("Getting health");
        Console.WriteLine(myEntity.GetHashCode());
        Assert.That(myEntity.spawnSetHealth(maxHealth),Is.EqualTo(maxHealth));
        Assert.That(myEntity.getHealth(),Is.EqualTo(maxHealth));
      }

      [Test]
      //[Ignore("This works")]
      public void injureAndHealEntity() {
        int injuryAmount = 25;
        int healAmount = injuryAmount;
        Assert.That(myEntity.spawnSetHealth(maxHealth),Is.EqualTo(maxHealth));
        Assert.That(myEntity.subtractFromHealth(injuryAmount),Is.EqualTo(75));
        Console.WriteLine("Getting health");
        Assert.That(myEntity.getHealth(),Is.EqualTo(75));
        Assert.That(myEntity.addToHealth(healAmount),Is.EqualTo(100));
      }


      [Test]
      public void killEntity() {
        int injuryAmount = 25;
        Console.WriteLine("Killing entity");
        Assert.That(myEntity.spawnSetHealth(maxHealth),Is.EqualTo(maxHealth));
        Assert.That(myEntity.subtractFromHealth(injuryAmount),Is.EqualTo(75));
        Assert.That(myEntity.subtractFromHealth(injuryAmount),Is.EqualTo(50));
        Assert.That(myEntity.subtractFromHealth(injuryAmount),Is.EqualTo(25));
        Assert.That(myEntity.subtractFromHealth(injuryAmount),Is.EqualTo(0));
      }

      [Test]
      public void overHealEntity() {
        int healAmount = 25;
        Assert.That(myEntity.spawnSetHealth(maxHealth),Is.EqualTo(maxHealth));
        Assert.That(myEntity.addToHealth(healAmount),Is.EqualTo(100));
      }

      /*
      *
      *
      [Test]
      public void getMyWeaponList(){
        List<GameWeapon.Weapon> myList = myEntity.GetWeaponList();
      }
      */

      [Test]
      public void getMyWeaponStack(){
        Stack<GameWeapon.Weapon> myStack = myEntity.GetWeaponStack();
      }

      /*
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

      [Test]
      public void addAWeaponFourTimes(){
        // the player can only have a certain number of weapons
        // before the existing ones are removed.

        // List<GameWeapon.Weapon> myList = myEntity.GetWeaponList();
        GameWeapon.Weapon myWeapon = new GameWeapon.Weapon();

        myWeapon.Name = "HammerFist";
        myWeapon.StrikeNumber = 100;
        myWeapon.Damage = 100;
        myEntity.AddToWeaponList(myWeapon);

        myWeapon.Name = "Falling Anvil";
        myWeapon.StrikeNumber = 100;
        myWeapon.Damage = 100;
        myEntity.AddToWeaponList(myWeapon);

        myWeapon.Name = "Falling Anvil";
        myWeapon.StrikeNumber = 100;
        myWeapon.Damage = 100;
        myEntity.AddToWeaponList(myWeapon);

        myWeapon.Name = "Falling Anvil";
        myWeapon.StrikeNumber = 100;
        myWeapon.Damage = 100;
        myEntity.AddToWeaponList(myWeapon);

        List<GameWeapon.Weapon> myList = myEntity.GetWeaponList();
        Console.WriteLine("New weapon: {0}", myEntity.myWeaponList[0].Name);
      }

      [Test]
      public void addAWeaponTimes(){
        // the player can only have a certain number of weapons
        // before the existing ones are removed.
        // List<GameWeapon.Weapon> myList = myEntity.GetWeaponList();
        GameWeapon.Weapon myWeapon = new GameWeapon.Weapon();

        myWeapon.Name = "HammerFist";
        myWeapon.StrikeNumber = 100;
        myWeapon.Damage = 100;
        myEntity.AddToWeaponList(myWeapon);

        List<GameWeapon.Weapon> myList = myEntity.GetWeaponList();
        Console.WriteLine("New weapon: {0}", myEntity.myWeaponList[0].Name);
      }
      */
      /*
      [Test]
      public void replaceAWeapon(){
        // the player can only have a certain number of weapons
        // before the existing ones are removed.

        // List<GameWeapon.Weapon> myList = myEntity.GetWeaponList();
        GameWeapon.Weapon myWeapon = new GameWeapon.Weapon();

        myWeapon.Name = "Number1";
        myWeapon.StrikeNumber = 100;
        myWeapon.Damage = 100;
        myEntity.AddToWeaponList(myWeapon);

        myWeapon.Name = "Number2";
        myWeapon.StrikeNumber = 100;
        myWeapon.Damage = 100;
        myEntity.AddToWeaponList(myWeapon);

        myWeapon.Name = "Number3";
        myWeapon.StrikeNumber = 100;
        myWeapon.Damage = 100;
        myEntity.AddToWeaponList(myWeapon);

        myWeapon.Name = "Number4";
        myWeapon.StrikeNumber = 100;
        myWeapon.Damage = 100;
        myEntity.AddToWeaponList(myWeapon);

        myWeapon.Name = "Number5";
        myWeapon.StrikeNumber = 100;
        myWeapon.Damage = 100;
        myEntity.AddToWeaponList(myWeapon);

        myWeapon.Name = "Number6";
        myWeapon.StrikeNumber = 100;
        myWeapon.Damage = 100;
        myEntity.AddToWeaponList(myWeapon);

        List<GameWeapon.Weapon> myList = myEntity.GetWeaponList();
        Console.WriteLine("New weapon: {0}", myEntity.myWeaponList[0].Name);
      }
      */

      /*

      [Test]
      // Collect a gem
      public void collectAGem(){
         String entityType = "Enemy";
         Assert.That(myEntity.collectGem(),Is.EqualTo("Enemy"));

         String entityType = "Player";
         Assert.That(myEntity.collectGem(),Is.EqualTo("Player"));

         // if the gem is collected by an enemy..
         // delete the gem mesh (also used by dieEntity)
         // add the gem value to the armour/health of the enemy entity, to a max value (%?)
         // add the gem to the GemCount
      }
      */

      /*
      [Test]
      [Ignore("not written")]
      public void checkGemStage(){
         int currentGemLevel = 0;
        // check the current level, each gem level should have a level (number or percentage)
        // if the level reaches the threshold, then gems is 0 and level goes up.
        Assert.That(myEntity.checkGemLevel(currentGemLevel),Is.EqualTo("1"));
      */




    }
}
