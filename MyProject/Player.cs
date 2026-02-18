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
     GameWeapon.Weapon MyWeapon;

      // constructor
      public Player(){
        Name = "Player";
        GemCount = 0;
        Level = 0;
        GemLevelsList = [ 10, 25, 50, 100, 250, 500 ];

        SetXLoc(0);
        SetZLoc(0);

        MaxWeaponStackSize = 5;

        // Stack<GameWeapon.Weapon> MyUpgradedWeaponStack = new Stack<GameWeapon.Weapon>();

        /*

        Name { get; set;} // name of weapon
        Damage { get; set;} // damage delt
        StrikeNumber { get; set;} // individual items spawned
        Range { get; set;} // max range from player
        Durability { get; set;} // max hits per item
        Cooldown { get; set;} // cooldown before respawn in seconds
        DamageType { Fire, Lightning, Water, Ice, Cut, Strike, Earth,  } // etc
        CurrentLevel { get; set;}
        MaxLevel { get; set;}
        EffectType { GroundHit, VertHit, HorizHit, AoE, Chain, Location }

        */

        // create a new weapon by default and add it to the player weapon stack
        MyWeapon = new GameWeapon.Weapon("DeathRing",10,50);
        AddToWeaponStack(MyWeapon);

        var MyDefaultWeaponList = new List<GameWeapon.Weapon>
           {
               new (){ Name="DeathRing", Damage=10, StrikeNumber = 0, Range=0, Durability=0,
                Cooldown=0, DamageType = GameWeapon.DamageEnum.Cut, CurrentLevel = 1, MaxLevel = 0, EffectType = GameWeapon.EffectEnum.HorizHit },
               new (){ Name="Axe", Damage=10, StrikeNumber = 1, Range=0, Durability=0,
                Cooldown=0, DamageType = GameWeapon.DamageEnum.Cut, CurrentLevel = 1, MaxLevel = 0, EffectType = GameWeapon.EffectEnum.HorizHit },
               new (){ Name="Anvil", Damage=10, StrikeNumber=0, Range=0, Durability=0,
                 Cooldown=0, DamageType = GameWeapon.DamageEnum.Strike, CurrentLevel = 1, MaxLevel = 0, EffectType = GameWeapon.EffectEnum.VertHit },
               new (){ Name="AreaLightning", Damage=10, StrikeNumber=0, Range=0, Durability=0,
                Cooldown=0, DamageType = GameWeapon.DamageEnum.Lightning, CurrentLevel = 1, MaxLevel = 0 , EffectType = GameWeapon.EffectEnum.AoE },
               new (){ Name="ChainLightning", Damage=10, StrikeNumber=0, Range=0, Durability=0,
                Cooldown=0, DamageType = GameWeapon.DamageEnum.Lightning, CurrentLevel = 1, MaxLevel = 0 , EffectType = GameWeapon.EffectEnum.Chain },
               new (){ Name="AreaLighning", Damage=10, StrikeNumber = 3, Range=0, Durability=0,
                Cooldown=0, DamageType = GameWeapon.DamageEnum.Cut, CurrentLevel = 1, MaxLevel = 0 , EffectType = GameWeapon.EffectEnum.AoE}
                // etc etc
            };

      }

      //add weapon to the weapon stack
      public override void AddToWeaponStack(GameWeapon.Weapon thisWeapon){
          // if the list length is > 5 then remove it from the list.
          if (MyWeaponStack.Count < MaxWeaponStackSize){
                MyWeaponStack.Push(thisWeapon);
            }
          else {
            // delete the top item in the stack (first one added)
            MyWeaponStack.Pop();
            // add the one to add.
            MyWeaponStack.Push(thisWeapon);
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

  }
}
