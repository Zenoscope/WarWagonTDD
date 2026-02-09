// track player location/orientation vs wagon
// gem collection
// score?
// where the hands are
// steering the wagon

using System;

namespace GameEnemy
{ //1
  // inherits from entity

  public class Enemy : GameEntity.Entity { //2

      const int MaxWeaponNum = 1;

      enum GemLevelsList {
        1, 2, 3
      };

      // constructor

      public Enemy(string EnemyType){ //heh 3
        Name = "Enemy";

        // set the variables
        Console.WriteLine("Entity Name (constructor) {0}:", Name);

        int GemDropAmount = 15;

        // range for spawning the enemy
        // it should also check that the
        int xMaxRange = 100;
        int zMaxRange = 100;

        int xMinRange = 10;
        int zMinRange = 10;

        Random rnd = new Random();
        int XPos = rnd.Next(xMinRange, xMaxRange);
        int YPos = rnd.Next(zMinRange, zMaxRange);

        // set spawn location
        SetSpawnLocation(XPos, YPos);

        // type - mesh etc

        /*
        switch(EnemyType)
          { // 4
          case "Orc":
            health = 50;
            maxHealth = 50;
            range = 5;
            mesh = "";
            break;
          case "Mage":
            health = 150;
            maxHealth = 150;
            range = 15;
            mesh = "";
            break
          case "Goblin":
            health = 20;
            maxHealth = 20;
            range = 5;
            mesh = "";
            break;
          case "Grubber":
            health = 10;
            maxHealth = 10;
            range = 5;
            mesh = "";
          default:
            health = 5;
            maxHealth = 5;
            range = 5;
            mesh = "";
            break;
          } // 4
          */

          Console.WriteLine("{0}", EnemyType);

      } //3


      public virtual void SetSpawnLocation(int XLoc,int ZLoc){
          // check to see if there is something there already
          SetXLoc(XLoc);
          SetZLoc(ZLoc);
        } //3

      public override void KillEntity(){
          Console.WriteLine("die!!");
          ClearWeaponStack();
          // delete the instance
          DropGem();
        } //3

      private void DropGem(){
        // drop a gem at the location\
        // int gem = GemDropAmount;
        Console.WriteLine("Gem dropped at {0} {1}",  XLoc,ZLoc);
      } //3

      // enemy attack, which checks range of the ememy and

  } //2
} //1
