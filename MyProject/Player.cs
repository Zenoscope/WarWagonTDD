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

      // constructor
      public Player(){
        Name = "Player";
        // set location is done in the entity loc
        // mesh
        int Score = 0;
        // player also gets a weaponlist. This is to store the upgrades.
        List<GameWeapon.Weapon> myUpgradedWeaponList = new List<GameWeapon.Weapon>();
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
