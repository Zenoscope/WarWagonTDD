// track player location/orientation vs wagon
// gem collection
// score?
// where the hands are
// steering the wagon

using System;

namespace GameEnemy
{
  // inherits from entity
  public class Enemy : GameEntity.Entity {

      const int MaxWeaponNum = 1;

      // constructor
      public Enemy(){
        Name = "Enemy";
        // set the variables
        Console.WriteLine("Entity Name (constructor)):", Name);


        // type - mesh etc
        // spawn location
      }

      // movement keys

      //Console.WriteLine("New player");

  }
}
