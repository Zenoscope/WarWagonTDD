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
     public void GetPlayerGemLevels(){
      Console.WriteLine("GemLevelsList = {0}" , MyEntity.GemLevelsList[0]);
      // Assert.That(MyEntity.GemLevelsList.1,Is.EqualTo(10));
     }

     // create a new player instance
     [Test]
     public void CreatePlayer(){
       //GamePlayer.Player myPlayer = new GamePlayer.Player();
       Console.WriteLine("Ply _PlayerTest");
       Console.WriteLine(" Entity Name:{0}", MyEntity.Name);
       Console.WriteLine(" Entity X location:{0}", MyEntity.XLoc);
       Console.WriteLine(" Entity Y location:{0}", MyEntity.ZLoc);
       Console.WriteLine(" Entity Y location:{0}", MyEntity.Score);
     }


     [Test]
     public void TriggerPlayerUpgrade(){
       MyEntity.TriggerPlayerUpgrade();
       Assert.That(MyEntity.,Is.EqualTo(10));
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
