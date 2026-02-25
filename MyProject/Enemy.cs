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
    GameWeapon.Weapon myWeapon;

      // constructor
      public Enemy(string EnemyType = ""){ //heh
        Name = "Enemy";

        // set the variables
        Console.WriteLine("Entity Name (constructor) {0}:", Name);

        GemDropAmount = 15;
        GemCount = 0;
        GemLevelsList = [ 1,2,3 ];

        // range for spawning the enemy
        // it should also check for collisions too.

        SetSpawnLocation( SetSpawnLoc(10,100) , SetSpawnLoc(10,100) );

        // Enemy type - mesh etc
        switch(EnemyType)
          { // 4
          case "Orc":
            Name = "Orc";
            Health = 50;
            MaxHealth = 50;
            Mesh = "";
            myWeapon = new GameWeapon.Weapon("Long_Sword",5,50);
            GemCount = 0;
            break;
          case "Mage":
            Name = "Mage";
            Health = 150;
            MaxHealth = 150;
            Mesh = "";
            myWeapon = new GameWeapon.Weapon("Staff",10,50);
            GemCount = 0;
            break;
          case "Goblin":
            Name = "Goblin";
            Health = 20;
            MaxHealth = 20;
            Mesh = "";
            myWeapon = new GameWeapon.Weapon("Short_sword",2,25);
            GemCount = 0;
            break;
          case "Grubber":
            Name = "Grubber";
            Health = 10;
            MaxHealth = 10;
            Mesh = "";
            myWeapon = new GameWeapon.Weapon("Teeth",1,5);
            GemCount = 0;
            break;
          default:
            Name = "";
            Health = 5;
            MaxHealth = 5;
            Mesh = "";
            myWeapon = new GameWeapon.Weapon("Blank",0,0);
            GemCount = 0;
            break;
          } // 4

          Console.WriteLine("{0}", EnemyType);

          // GameEntity.UpdateWeaponList();
          UpdateWeaponList();

      } //3

      public void SetSpawnLocation(int XLoc,int ZLoc){
          // check to see if there is something there already
          SetXLoc(XLoc);
          SetZLoc(ZLoc);
        } //3

      public override void KillEntity(){
          Console.WriteLine("die!!");
          ClearWeaponList();
          // delete the instance
          DropGem();
        } //3

      private void DropGem(){
        // drop a gem at the location\
        int gem = GemDropAmount;
        Console.WriteLine("Gem dropped at {0} {1}",  XLoc,ZLoc);
      } //3

      public void UpdateWeaponList(){
         Console.WriteLine("UpdatedWeaponList");
         EquippedWeaponList.Add(myWeapon);
        }

      private int SetSpawnLoc(int Min,int Max){
        int MaxRange = Max;
        int MinRange = Min;
        Random rnd = new Random();
        return rnd.Next(MinRange, MaxRange);
      }

      // enemy attack, which checks range of the ememy and

  } //2
} //1
