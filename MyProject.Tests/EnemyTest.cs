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


     // create a new player instance
     [Test]
     public void createEnemyOrc(){
       GameEnemy.Enemy myEnemy = new GameEnemy.Enemy("Orc");
       Console.WriteLine("Enemy Name:", myEnemy.Name);
       Console.WriteLine("Enemy X location:", myEnemy.XLoc);
       Console.WriteLine("Enemy Y location:", myEnemy.ZLoc);
     }

     /*
     // create a new player instance
     [Test]
     public void createEnemyOrc(){
       GameEnemy.Enemy myEnemy = new GameEnemy.Enemy("Mage");
       Console.WriteLine("Enemy Name:", myEnemy.Name);
       Console.WriteLine("Enemy X location:", myEnemy.XLoc);
       Console.WriteLine("Enemy Y location:", myEnemy.ZLoc);
     }

     // create a new player instance
     [Test]
     public void createEnemyOrc(){
       GameEnemy.Enemy myEnemy = new GameEnemy.Enemy("Goblin");
       Console.WriteLine("Enemy Name:", ZLlmyEnemy.Name);
       Console.WriteLine("Enemy X location:", myEnemy.XLoc);
       Console.WriteLine("Enemy Y location:", myEnemy.ZLoc);
     }

     // create a new player instance
     [Test]
     public void createEnemyOrc(){
       GameEnemy.Enemy myEnemy = new GameEnemy.Enemy("Grubber");
       Console.WriteLine("Enemy Name:", myEnemy.Name);
       Console.WriteLine("Enemy X location:", myEnemy.XLoc);
       Console.WriteLine("Enemy Y location:", myEnemy.ZLoc);
     }
     */

   }
 }
