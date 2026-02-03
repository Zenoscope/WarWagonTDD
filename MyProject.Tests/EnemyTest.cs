using NUnit.Framework;

namespace EnemyTests
{
  public class EnemyTest
   {

     // create a new player instance
     [Test]
     public void createPlayer(){
       GameEnemy.Enemy myEnemy = new GameEnemy.Enemy();
       Console.WriteLine("Enemy Name:", myEnemy.Name);
       Console.WriteLine("Enemy X location:", myEnemy._xloc);
       Console.WriteLine("Enemy Y location:", myEnemy._zloc);
     }
   }
 }
