using NUnit.Framework;

namespace PlayerTests
{
  public class PlayerTests
   {

     [Test]
     public void GetPlayerGemLevels(){
      Console.WriteLine("GemLevelsList = {0}" , MyEntity.GemLevelsList.1 );
      // Assert.That(MyEntity.GemLevelsList.1,Is.EqualTo(10));
     }      

     // create a new player instance
     [Test]
     public void CreatePlayer(){
       GamePlayer.Player myPlayer = new GamePlayer.Player();
       Console.WriteLine("Ply _PlayerTest");
       Console.WriteLine(" Entity Name:{0}", myPlayer.Name);
       Console.WriteLine(" Entity X location:{0}", myPlayer.XLoc);
       Console.WriteLine(" Entity Y location:{0}", myPlayer.ZLoc);
       Console.WriteLine(" Entity Y location:{0}", myPlayer.Score);
     }

   }

   /*
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


 }
