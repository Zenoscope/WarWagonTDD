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

     public int Score { get;  set; } = 0;

      // constructor
      public Player(){
        Name = "Player";
        GemCount = 0;
        Level = 0;
        GemLevelsList = [ 10, 25, 50, 100, 250, 500 ];       

        MaxWeaponStackSize = 5;

        Stack<GameWeapon.Weapon> MyUpgradedWeaponStack = new Stack<GameWeapon.Weapon>();
      }

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
      // increase player score when gem is collected
      //Console.WriteLine("New player");

  }
}
