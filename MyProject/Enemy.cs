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

    //int[] GemLevelsList =  { 1, 2, 3 };

    int GemDropAmount;

    const int MaxWeaponNum = 1;
    string EnemyType;

      // constructor
      public Enemy(string EnemyType){ //heh 3
        Name = "Enemy";

        // set the variables
        Console.WriteLine("Entity Name (constructor) {0}:", Name);

        GemDropAmount = 15;
        GemCount = 0;
        GemLevelsList = [ 1,2,3 ];

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

        int WeaponRange;

        // Enemy type - mesh etc
        switch(EnemyType)
          { // 4
          case "Orc":
            Health = 50;
            MaxHealth = 50;
            WeaponRange = 5;
            Mesh = "";
            break;
          case "Mage":
            Health = 150;
            MaxHealth = 150;
            WeaponRange = 15;
            Mesh = "";
            break;
          case "Goblin":
            Health = 20;
            MaxHealth = 20;
            WeaponRange = 5;
            Mesh = "";
            break;
          case "Grubber":
            Health = 10;
            MaxHealth = 10;
            WeaponRange = 5;
            Mesh = "";
            break;
          default:
            Health = 5;
            MaxHealth = 5;
            WeaponRange = 5;
            Mesh = "";
            break;
          } // 4

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
        int gem = GemDropAmount;
        Console.WriteLine("Gem dropped at {0} {1}",  XLoc,ZLoc);
      } //3

      // enemy attack, which checks range of the ememy and

  } //2
} //1
