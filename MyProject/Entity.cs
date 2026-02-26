using System;

// entity stuff, like moving, spawning
// location, mesh etc.
// also set things like health, mesh etc

namespace GameEntity
{
    public class Entity
    {

     // these are properties, fields don’t have get/set
    // they can have default values set, but don’t get anything else.

      public float XLoc { get; private set; } // no underscore as they are public
      public float ZLoc { get; private set; }

      // fields
      public int Health { get; set; } // possibly byte, 255?
      public int MaxHealth { get; set; }

      public string Name { get; set; }

      public virtual byte MaxWeaponListSize { get; set; }


      public List<GameWeapon.Weapon> EquippedWeaponList;

      // public Stack<GameWeapon.Weapon> MyWeaponStack;// = new Stack<GameWeapon.Weapon>();

      public string Mesh = "";

      public int EntityDirection { get; set; } = 0;

      // track the gem level and entites level
      public uint GemCount { get; set ; } = 0;
      public uint Level { get; set ; } = 0;
      public uint CurrentAccumulatedGems { get; set; } = 0;
      public ushort[] GemLevelsList = [1];

      // constructor      // the list is populated by the player/enemy themselves,
      // this just creates the list.
      // public int WeaponRange;

      // public GameWeapon.Weapon[] WeaponList;
      public Entity(){
        XLoc = 0;
        ZLoc = 0;
        Name = "";

        Health = 0;
        MaxHealth = 0;

        // stores the current weapons
        EquippedWeaponList = new List<GameWeapon.Weapon>();
      }

      // get location

      public float GetXLoc() {
          Console.WriteLine("get x: {0}", XLoc);
          return XLoc;
      }

      public float GetZLoc() {
          Console.WriteLine("get z: {0}", ZLoc);
          return ZLoc;
      }

      public float SetXLoc(float amount = 0) {
          // will also work with negative numbers, so moving that way...
          // what about rotation though? hmm.
          //x_loc = x_loc + amount;
          Console.WriteLine("set x: {0}", XLoc);
          return XLoc += amount;
      }

      public float SetZLoc(float amount) {
          //this.y_loc = this.y_loc + amount;
          Console.WriteLine("set z: {0}", ZLoc);
          return ZLoc += amount;
      }

      /*
      public int SetSpawnLocation(int XLoc,int ZLoc){
          // check to see if there is something there already
          SetXLoc(XLoc);
          SetZLoc(ZLoc);
        } //3
      */

      // Health

      public int SpawnSetHealth(int amount = 15) {
          // set this when starting out
          // if there is an item which changes it, then it gets
          // done somewhere else
          MaxHealth = amount;
          Health = amount;
          Console.WriteLine("Max health {0}", MaxHealth);
          Console.WriteLine("health {0}", Health);
          return MaxHealth;
      }

      public int GetHealth() {
          Console.WriteLine("get health again: {0}", Health);
          return Health;
      }

      public int AddToHealth(int amount){
        Console.WriteLine("get (add)health: {0}", Health);
        Console.WriteLine("get (add)maxhealth : {0}", MaxHealth);

        Health += amount;

        if (Health > MaxHealth ) {
            Health = MaxHealth;
        }

        return Health;
      }

      public int SubtractFromHealth(int amount){
          Health -= amount;

        if (Health <= 0) {
            KillEntity();
            return 0;
          }
        else {
             Console.WriteLine("set injury: {0}",Health - amount);
              return Health;
            }
      }

      public virtual void KillEntity(){
          Console.WriteLine("die!!");
          ClearWeaponList();
          // delete the instance
          // this = null;
      }

      //add weapon to the weapon stack
      public virtual void AddToWeaponList(GameWeapon.Weapon myWeapon){
        EquippedWeaponList.Add(myWeapon);
        }

      public List<GameWeapon.Weapon> GetWeaponList(){
        return EquippedWeaponList;
        }

      public void ClearWeaponList(){
         // for some reason this doesn't work?
         EquippedWeaponList.Clear();
         }

       public int LeftRotate(int RotateAmount = 10){
         EntityDirection = EntityDirection + RotateAmount;
         return EntityDirection;
       }

       public int RightRotate(int RotateAmount = 10){
         EntityDirection = EntityDirection - RotateAmount;
         return EntityDirection;
       }

       public void CollectGem(){
          // collision detection etc
          GemCount++;
       }

       public virtual uint TriggerWeaponUpgrade(ushort[] myGemLevelsList,uint myLevel){
        if ( GemCount == myGemLevelsList[myLevel]){
                  GemCount = 0;
                  myLevel = myLevel + 1;
                  Console.WriteLine("Set Level = {0}", myLevel);
                  return myLevel;
                 }
        return myLevel;
       }


    }
}
