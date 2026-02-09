// track player location/orientation vs wagon
// gem collection
// score?
// where the hands are
// steering the wagon

using System;

namespace GamePlayer
{
  // inherits from entity
  public class Player : GameEntity.Entity {

     public int Score { get;  set; }

     const int MaxWeaponNum = 5;

     private enum GemLevelsList {
        10, 25, 50, 100, 250, 500
       }

      // constructor
      public Player(){
        Name = "Player";

        int MaxWeaponStackSize = 1;

        // set location is done in the entity loc
        // mesh
        // int Score = 0;
        // player also gets a weaponlist. This is to store the upgrades.
        //
        //*****
        Stack<GameWeapon.Weapon> MyUpgradedWeaponStack = new Stack<GameWeapon.Weapon>();
      }

      /*
      * List
      *
      //add weapon to the weapon List
      public override void AddToWeaponList(GameWeapon.Weapon myWeapon){
        myWeaponList.Add(myWeapon);
        Console.WriteLine("List length = {0}", myWeaponList.Count);
        Console.Write(myWeaponList.ElementAt(myWeaponList.Count - 1).Name);

        // if the list length is > 5 then remove it from the list.
        }
        */

      //add weapon to the weapon stack
      public override void AddToWeaponStack(GameWeapon.Weapon MyWeapon){
          // if the list length is > 5 then remove it from the list.
          if (MyWeaponStack.Count < MaxWeaponStackSize){
                MyWeaponStack.Push(MyWeapon);
            }
          else {
            // delete the top item in the stack (first one added)
            MyWeaponStack.Pop();
            // add the one to add.
            MyWeaponStack.Push(MyWeapon);
          }
        }

      // movement keys

      // player height
      // head yRot,xRot,zRot, x,y,z
      // leftHand x,y,z.xrot,yrot,zRot
      // rightHand x,y,z.xrot,yrot,zRot

      // increase player score when

      //Console.WriteLine("New player");

  }
}
