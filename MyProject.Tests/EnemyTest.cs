using NUnit.Framework;

namespace EnemyTests
{
  public class EnemyTests
   {

     private GameEnemy.Enemy MyEntity;

     [SetUp]
     public void Setup()
     {
         MyEntity = new GameEnemy.Enemy("Grubber");
     }

     // create a new enemy instance
     [Test]
     [Ignore("Skipping this test for now")]
     public void createEnemyOrc(){
       GameEnemy.Enemy OrcEntity = new GameEnemy.Enemy("Orc");
       Console.WriteLine("Enemy Name:", OrcEntity.Name);
       Console.WriteLine("Enemy X location:", OrcEntity.XLoc);
       Console.WriteLine("Enemy Y location:", OrcEntity.ZLoc);
       // Console.WriteLine("Enemy Y location:", OrcEntity.WeaponList[0].Name);
     }

     // create a new enemy instance
     [Test]
     [Ignore("Skipping this test for now")]
     public void createEnemyMage(){
       GameEnemy.Enemy MageEnemy = new GameEnemy.Enemy("Mage");
       Console.WriteLine("Enemy Name:", MageEnemy.Name);
       Console.WriteLine("Enemy X location:", MageEnemy.XLoc);
       Console.WriteLine("Enemy Y location:", MageEnemy.ZLoc);
       //Console.WriteLine("Enemy Y location:", MageEnemy.WeaponList[0].Name);
     }

     // create a new enemy instance
     [Test]
     [Ignore("Skipping this test for now")]
     public void createEnemyGoblin(){
       GameEnemy.Enemy GobEnemy = new GameEnemy.Enemy("Goblin");
       Console.WriteLine("Enemy Name:", GobEnemy.Name);
       Console.WriteLine("Enemy X location:", GobEnemy.XLoc);
       Console.WriteLine("Enemy Y location:", GobEnemy.ZLoc);
       //Console.WriteLine("Enemy Y location:", GobEnemy.WeaponList[0].Name);
     }

     // create a new enemy instance
     [Test]
     [Ignore("Skipping this test for now")]
     public void createEnemyGrubber(){
       GameEnemy.Enemy GrubEnemy = new GameEnemy.Enemy("Grubber");
       Console.WriteLine("Enemy Name:", GrubEnemy.Name);
       Console.WriteLine("Enemy X location:", GrubEnemy.XLoc);
       Console.WriteLine("Enemy Y location:", GrubEnemy.ZLoc);
       //Console.WriteLine("Enemy Y location:", GrubEnemy.WeaponList[0].Name);
     }

     [Test]
     [Ignore("Skipping this test for now")]
     public void TriggerAWeaponUpgrade(){
         Console.WriteLine("Enemy - trigger weapon upgrade");
         Console.WriteLine("GemCount = {0}", MyEntity.GemCount);
         Console.WriteLine("Level = {0}", MyEntity.Level);

         // go through all of the levels for the entity:
         while(MyEntity.GemCount < MyEntity.GemLevelsList.Count() ){
             MyEntity.Level = MyEntity.TriggerWeaponUpgrade(MyEntity.GemLevelsList,MyEntity.Level);
             Console.WriteLine("Enemy GemCount = {0}", MyEntity.GemCount);
             MyEntity.GemCount++; //2
           }
     }




     /*
     [Test]
     public void TestCreateWeaponList(){
        MyEntity.CreateWeaponList();
     }
     */

   }
 }
