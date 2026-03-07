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

      //add weapon to the equipped weapon list
      public void AddWeapon(GameWeapon.Weapon NewWeapon){

          // if the count is too large, select one to remove:
          if (EquippedWeaponList.Count() > MaxWeaponListSize){
              int count = 0;

              foreach(GameWeapon.Weapon EquippedWeapon in EquippedWeaponList){
                  // list the weapons
                  ListWeapon(EquippedWeaponList[count],count);
                  count++;
                }

              // choose a weapon to replace
              GameWeapon.Weapon WeaponToReplace = ChooseWeaponToReplace();
              ReplaceThisWeapon(NewWeapon, WeaponToReplace);
              }

          // just add the weapon.
          EquippedWeaponList.Add(NewWeapon);
          Console.WriteLine("Adding weapon - {0}", EquippedWeaponList[EquippedWeaponList.Count() - 1].Name);
        }


        public GameWeapon.Weapon ReplaceThisWeapon(GameWeapon.Weapon NewWeapon, GameWeapon.Weapon WeaponToReplace){
          int index = EquippedWeaponList.IndexOf(WeaponToReplace);

          if (index > -1)
            EquippedWeaponList[index] = WeaponToReplace;
          else
            Console.WriteLine("Error");

          return WeaponToReplace;
        }


        // display a single weapon.
        public GameWeapon.Weapon ListWeapon(GameWeapon.Weapon showThisWeapon, int weaponIndex){
            Console.WriteLine("[{0}] Weapons list: {1}", weaponIndex, showThisWeapon.Name);
            return showThisWeapon;
        }

        public GameWeapon.Weapon ChooseWeaponToReplace(){
          // generate a random number between 0 and 5
          // lowest bound is nclusive, highest is not (wtf?)
          // return that weapon
          Random rnd = new Random();
          int MaxList = EquippedWeaponList.Count();
          return EquippedWeaponList[rnd.Next(0,MaxList + 1)];
        }

        public GameWeapon.Weapon ls(GameWeapon.Weapon orig, GameWeapon.Weapon swap){
            // look for the original weapon and then replace it.
            int index = EquippedWeaponList.IndexOf(orig);

            if(index != -1)
              EquippedWeaponList[index] = swap;

            return EquippedWeaponList[index];
        }

        /*
        private void upgradeWeapon(GameWeapon.Weapon NewWeapon){

        }*/

        /*
        public GameWeapon.Weapon GetThreeWeaponsFromUpgradeList(){
          //GameWeapon.Weapon myWeapon = new GameWeapon.Weapon();
          // myWeapon.DeathRing;
          // GameWeapon.Weapon NewWeapon = myWeapon.DeathRing;
          ///Console.WriteLine("{0}", myWeapon.Name);
          // GameWeapon.Weapon[] UpgradeWeaponList = [ GameWeapon.DeathRing ];

          // return UpgradeWeaponList;
        }*/

        public void SelectAttribute(){
          // select a random attribute
          // list of attributes that can be upgraded:
          // range, durability, instances, etc
          // return attribute;
        }

        public void UpgradeAttribute (){
            // upgrade said attribute
            // add a number to the attribute.
          }

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
