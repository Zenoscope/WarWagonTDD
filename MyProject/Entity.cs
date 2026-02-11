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

      public int XLoc { get; private set; } // no underscore as they are public
      public int ZLoc { get; private set; }

      // fields
      public int Health { get; set; }
      public int MaxHealth { get; set; }

      public string Name { get; set; }

      public virtual int MaxWeaponStackSize { get; set; }

      // public virtual enum GemLevelsList;

      // public List<GameWeapon.Weapon> myWeaponList;
      public Stack<GameWeapon.Weapon> MyWeaponStack;// = new Stack<GameWeapon.Weapon>();

      public string Mesh = "";

      public int EntityDirection { get; set; }

      // track the gem level
      public int GemCount { get; set ; } = 0;
      public int Level { get; set ; } = 0;

      // list of upgrade levels for gem collection
      //public enum GemLevelsList { 10,25,50,100,250,500}

      // This is the gems which have been collected
      public int CurrentAccumulatedGems { get; set; }

      // public List<GameWeapon.Weapon> myWeaponList { get;  set; }

      // int[] GemLevelsList = new int[1];
      public int[] GemLevelsList;

      // constructor
      public Entity(){
        XLoc = 0;
        ZLoc = 0;
        Name = "";

        Health = 0;
        MaxHealth = 0;

        // aspawns at zero and then gets rotated.
        EntityDirection = 0;

        MyWeaponStack = new Stack<GameWeapon.Weapon>();
        //Console.WriteLine("ENT___Entity instanced");
      }

      // get location

      public int GetXLoc() {
          Console.WriteLine("get x: {0}", XLoc);
          return XLoc;
      }

      public int GetZLoc() {
          Console.WriteLine("get z: {0}", ZLoc);
          return ZLoc;
      }

      public int SetXLoc(int amount = 0) {
          // will also work with negative numbers, so moving that way...
          // what about rotation though? hmm.
          //x_loc = x_loc + amount;
          Console.WriteLine("set x: {0}", XLoc);
          return XLoc += amount;
      }

      public int SetZLoc(int amount) {
          //this.y_loc = this.y_loc + amount;
          Console.WriteLine("set z: {0}", ZLoc);
          return ZLoc += amount;
      }

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
          ClearWeaponStack();
          // delete the instance
          // this = null;
      }

      public Stack<GameWeapon.Weapon> GetWeaponStack(){
        return MyWeaponStack;
        }

      //add weapon to the weapon List
      public virtual void AddToWeaponStack(GameWeapon.Weapon myWeapon){
        MyWeaponStack.Push(myWeapon);
        }

      public void ClearWeaponStack(){
         // for some reason this doesn't work?
         MyWeaponStack.Clear();
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


    }
}
