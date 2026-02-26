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

     public uint Score { get;  set; } = 0;
     GameWeapon.Weapon MyWeapon;
     //List<GameWeapon.Weapon> MyDefaultWeaponList;

     public List<GameWeapon.Weapon> DefaultWeaponList;

      // constructor
      public Player(){
        Name = "Player";
        GemCount = 0;
        Level = 0;
        GemLevelsList = [ 10, 25, 50, 100, 250, 500 ];

        DefaultWeaponList = new List<GameWeapon.Weapon>();

        SetXLoc(0);
        SetZLoc(0);

        MaxWeaponListSize = 5;

        // create a new weapon by default and add it to the player weapon stack

        /*
        Name { get; set;} // name of weapon
        Damage { get; set;} // damage delt
        StrikeNumber { get; set;} // individual items spawned
        Range { get; set;} // max range from player
        Durability { get; set;} // max hits per item
        Cooldown { get; set;} // cooldown before respawn in seconds
        CurrentLevel { get; set;}
        MaxLevel { get; set;}
        DamageType { Fire, Lightning, Water, Ice, Cut, Strike, Earth } // etc
        EffectType { GroundHit, VertHit, HorizHit, AoE, Chain, Location }
        */

        MyWeapon = new GameWeapon.Weapon( "DeathRing", 10, 0, 0, 0,
            0, 1, 0, GameWeapon.DamageEnum.Cut, GameWeapon.EffectEnum.HorizHit );

        EquippedWeaponList.Add(MyWeapon);
        DefaultWeaponList.Add(MyWeapon);

        Console.WriteLine("Weapon 0 {0}", DefaultWeaponList[0].Name);

        // generate a list of default weapons
        MyWeapon = new GameWeapon.Weapon( "Flying Axe", 10, 1, 0, 0,
                0, 1, 0,GameWeapon.DamageEnum.Cut, GameWeapon.EffectEnum.HorizHit);
        DefaultWeaponList.Add(MyWeapon);
        MyWeapon = new GameWeapon.Weapon( "Anvil", 10, 0, 0, 0,
                 0, 1, 0, GameWeapon.DamageEnum.Strike, GameWeapon.EffectEnum.VertHit );
        DefaultWeaponList.Add(MyWeapon);
        MyWeapon = new GameWeapon.Weapon( "AreaLightning", 10, 0, 0, 0,
                0, 1, 0 , GameWeapon.DamageEnum.Lightning, GameWeapon.EffectEnum.AoE );
        DefaultWeaponList.Add(MyWeapon);
        MyWeapon = new GameWeapon.Weapon( "ChainLightning", 10, 0, 0, 0,
                0, 1, 0 , GameWeapon.DamageEnum.Lightning, GameWeapon.EffectEnum.Chain );
        DefaultWeaponList.Add(MyWeapon);
        MyWeapon = new GameWeapon.Weapon( "AreaLightning 2", 10, 3, 0, 0,
                0, 1, 0 , GameWeapon.DamageEnum.Cut, GameWeapon.EffectEnum.AoE );
        DefaultWeaponList.Add(MyWeapon);

      }

      //add weapon to the weapon stack
      public void ReplaceWeaponOnList(GameWeapon.Weapon NewWeapon){
          // if the list length is > x then remove it from the list.
          if (DefaultWeaponList.Count < MaxWeaponListSize){
            // GameWeapon.Weapon OldWeapon
            // ask for the weapon to replace
            // replace it.
            // GameWeapon.Weapon replaceWeapon = GetWeaponToReplace();
            // loop through the list and

            int count = 0;
            foreach(GameWeapon.Weapon DefaultWeapon in DefaultWeaponList){
                Console.WriteLine(DefaultWeaponList[count].Name);
                count++;
                }
            }
          // just add the weapon.
          DefaultWeaponList.Add(NewWeapon);
        }

        /*
        private GameWeapon.Weapon GetWeaponToReplace(){
          // string to search for:
          string WeaponName =
          SearchForWeapon();

          return
        }*/

      // replace weapon

  }
}


/*
public virtual int TriggerWeaponUpgrade(int[] myGemLevelsList,int myLevel){
 if ( GemCount == myGemLevelsList[myLevel]){
           GemCount = 0;
           myLevel = myLevel + 1;
           Console.WriteLine("Set Level = {0}", myLevel);
           return myLevel;
          }
 return myLevel;
}
*/

/*
//add weapon to the weapon stack
public void UpgradeWeapons(){
    // get the list of weapons
    // get a random 3 weapons
    // check to see if the weapon is already in the player stack
    // if so, upgrade it (how does this work?).
    // range, hits, damage are separate?



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
  */

// movement keys
// player height
// head yRot,xRot,zRot, x,y,z
// leftHand x,y,z.xrot,yrot,zRot
// rightHand x,y,z.xrot,yrot,zRot
// Console.WriteLine("New player");
