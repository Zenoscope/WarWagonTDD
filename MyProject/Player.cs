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

     public List<GameWeapon.Weapon> DefaultWeaponList; // list of weapons a player can get
     public List<GameWeapon.Weapon> UpgradeWeaponList; // tewmporaty list of weapons which a player can upgrade

     private int[] numbers = [];

     public int MaxUpgradeListSize;

      // constructor
      public Player(){
        Name = "Player";
        GemCount = 0;
        Level = 0;
        GemLevelsList = [ 10, 25, 50, 100, 250, 500 ];

        DefaultWeaponList = new List<GameWeapon.Weapon>();
        UpgradeWeaponList = new List<GameWeapon.Weapon>();

        SetXLoc(0);
        SetZLoc(0);

        MaxWeaponListSize = 5; // max number of weapons a player can have
        MaxUpgradeListSize = 3; // number of weapons which can be upgraded at once.

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
        AddWeapon(MyWeapon);
        MyWeapon = new GameWeapon.Weapon( "Anvil", 10, 0, 0, 0,
                 0, 1, 0, GameWeapon.DamageEnum.Strike, GameWeapon.EffectEnum.VertHit );
        AddWeapon(MyWeapon);
        MyWeapon = new GameWeapon.Weapon( "AreaLightning", 10, 0, 0, 0,
                0, 1, 0 , GameWeapon.DamageEnum.Lightning, GameWeapon.EffectEnum.AoE );
        AddWeapon(MyWeapon);
        MyWeapon = new GameWeapon.Weapon( "ChainLightning", 10, 0, 0, 0,
                0, 1, 0 , GameWeapon.DamageEnum.Lightning, GameWeapon.EffectEnum.Chain );
        AddWeapon(MyWeapon);
        MyWeapon = new GameWeapon.Weapon( "AreaLightning 2", 10, 3, 0, 0,
                0, 1, 0 , GameWeapon.DamageEnum.Cut, GameWeapon.EffectEnum.AoE );
        AddWeapon(MyWeapon);

      }

      //add weapon to the equipped weapon list
      public void AddWeapon(GameWeapon.Weapon NewWeapon){

          // if the count is too large, select one to remove:
          if (EquippedWeaponList.Count() > MaxWeaponListSize){
              int count = 0;
              Console.WriteLine("EquippedWeaponList greater than allowed");

              // this can be skipped if not testing
              foreach(GameWeapon.Weapon EquippedWeapon in EquippedWeaponList){
                  // list the weapons
                  ListWeapon(EquippedWeaponList[count],count);
                  count++;
                }

              // choose a weapon to replace
              GameWeapon.Weapon WeaponToReplace = ChooseWeaponToReplace();
              Console.WriteLine("replacing weapon {0}" , WeaponToReplace);
              ReplaceThisWeapon(NewWeapon, WeaponToReplace);
              }

          // just add the weapon.
          EquippedWeaponList.Add(NewWeapon);
          Console.WriteLine("Adding weapon - {0}", EquippedWeaponList[EquippedWeaponList.Count() - 1].Name);
          Console.WriteLine("EquippedWeaponList count {0}", EquippedWeaponList.Count());
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
          // lowest bound is inclusive, highest is not (wtf?)
          // return that weapon
          if ( EquippedWeaponList.Count() > MaxWeaponListSize) {
            Random rnd = new Random();
            int MaxList = EquippedWeaponList.Count();
            return EquippedWeaponList[rnd.Next(0,MaxList + 1)];
          }
          else return EquippedWeaponList[0];
        }

        //
        //
        //
        /*
        private void upgradeWeapon(GameWeapon.Weapon NewWeapon){
        // get three random weapons
        getThreeWeaponsFromListUpgradeList()

        // upgrade all of the weapons.
          // figure out which attributres its possible to upgrade and choose one
        // display all of the possible options and choose one.
        // upgrade the weapon
        // put it in the players inventory
        }*/

        // Online C# Editor for free // Write, Edit and Run your C# code using C# Online Compiler

        //public List<GameWeapon.Weapon> GetThreeWeaponsFromUpgradeList(List<GameWeapon.Weapon> DefaultWeaponList, int MaxUpgradeListSize){//2
        public void GetThreeWeaponsFromUpgradeList(List<GameWeapon.Weapon> DefaultWeaponList, int MaxUpgradeListSize){//2

            List<GameWeapon.Weapon> UpgradeWeaponList = new List<GameWeapon.Weapon>();
            List<int> RandomNumbersList = new List<int>();

            Random rnd = new Random();

            //generate some random numbers and check for duplicates
            while(RandomNumbersList.Count < 5){ //3
            // while(RandomNumbersList.Count < MaxUpgradeListSize){ //3
                int randomNumber = rnd.Next(0,DefaultWeaponList.Count - 1);
                if (!RandomNumbersList.Contains(randomNumber)) {
                    RandomNumbersList.Add(randomNumber);
                    }
                }//end while

          /*
            Console.WriteLine("RandomNumbersList count {0}", RandomNumbersList.Count);

           for(int i = 0; i < RandomNumbersList.Count; i++ ) {
             Console.WriteLine("RandomNumbersList {0}", RandomNumbersList[i]);
             UpgradeWeaponList.Add(DefaultWeaponList[RandomNumbersList[i]]);
            }

           // just for debugging
           for(int i = 0; i < UpgradeWeaponList.Count; i++ ) {
            Console.WriteLine("UpgradeWeaponList {0}", UpgradeWeaponList[i]);
            }
            */

            // return UpgradeWeaponList;
        }//2

        string SelectAttribute(GameWeapon.Weapon thisWeapon){
                  // select a random attribute
                  // Adding elements to Dictionary

              List<string> IsUpgradable = new List<string>();
              if (thisWeapon.Damage < thisWeapon.DamageMax)         IsUpgradable.Add("Damage");
              if (thisWeapon.StrikeNumber < thisWeapon.StrikeNumberMax) IsUpgradable.Add("StrikeNumber");
              if (thisWeapon.Range < thisWeapon.RangeMax)           IsUpgradable.Add("Range");
              if (MyWeapon.Durability < thisWeapon.DurabilityMax) IsUpgradable.Add("Durability");
              if (thisWeapon.Cooldown < thisWeapon.CooldownMax)     IsUpgradable.Add("Cooldown");

              // randomly choose from the dictionary
              Random rnd = new Random();
              int randomNumber = rnd.Next(0,IsUpgradable.Count);
              string attribute = IsUpgradable[randomNumber];

              return attribute;
              }

              // use the weapon set<attirbute> from the GameWeapon class

      void upgradeAttribute(GameWeapon.Weapon thisWeapon, String attribute){

        Console.WriteLine("Found attribute {0}", attribute);
        // just some game breaking numbers
        uint damageIncrement = 5; // maybe x the level?
        uint strikeNumberIncrement = 1;
        uint rangeIncrement = 10;
        uint durabilityIncremement = 1;
        float cooldownDecrement = 0.25f; // in seconds

        float currValue = 0;
        float newValue = 0;

        switch (attribute){
         case "Damage":
            currValue = thisWeapon.Damage;
            thisWeapon.Damage = (uint)currValue + damageIncrement;
            newValue = thisWeapon.Damage;
            break;
        case "StrikeNumber":
            currValue = thisWeapon.StrikeNumber;
            thisWeapon.StrikeNumber = (uint)currValue + strikeNumberIncrement;
            newValue = thisWeapon.StrikeNumber;
            break;
        case "Range":
            currValue = thisWeapon.Range;
            thisWeapon.Range = (uint)currValue + rangeIncrement;
            newValue = thisWeapon.Range;
            break;
        case "Durability":
            currValue = thisWeapon.Durability;
            thisWeapon.Durability = (uint)currValue + durabilityIncremement;
            newValue = thisWeapon.Durability;
            break;
        case "Cooldown":
            // float currValue = thisWeapon.Cooldown;
            currValue = thisWeapon.Cooldown;
            thisWeapon.Cooldown = (uint)currValue - cooldownDecrement;
            newValue = thisWeapon.Cooldown;
            break;
        default:
            Console.WriteLine("Weapon missing attribute {0}", attribute);
            break;
        }

        Console.WriteLine("Upgrading attribute {0}", attribute);
        Console.WriteLine("Upgrading attribute from {0} to {1}",
            currValue.ToString(), newValue.ToString() );

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
