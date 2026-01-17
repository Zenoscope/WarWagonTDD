using System;

// entity stuff, like moving, spawning
// location, mesh etc.
// also set things like health, mesh etc

namespace Entity
{
    public class Entity
    {

     // these are properties, fields don’t have get/set
    // they can have default values set, but don’t get anything else.

      public int _xloc { get;  set; } // no underscore as they are public
      public int _zloc { get;  set; }

      // fields
      private int _health; //{ get; private set; }
      private int _maxHealth; //{ get; private set; }

    // a constructor could go here to run things when the instance is first created
    // e.g. checking a valid mesh exists, doing some other stuff.

      // spawn
      public int setXSpawn(int x = 0) {
          // xloc is optional, if not specified it's zero
          Console.WriteLine("spawn X: {0}", this._xloc);
          return this._xloc = x;
      }

      public int setZSpawn(int z = 0) {
          // zloc is optional, if not specified it's zero
          Console.WriteLine("spawn Z: {0}", this._zloc);
          return this._zloc = z;
      }

      // get location

      public int getXLoc() {
          Console.WriteLine("get x: {0}", this._xloc);
          return this._xloc;
      }

      public int getZLoc() {
          Console.WriteLine("get z: {0}", this._zloc);
          return this._zloc;
      }


      public int setXLoc(int amount = 0) {
          // will also work with negative numbers, so moving that way...
          // what about rotation though? hmm.
          //x_loc = x_loc + amount;
          Console.WriteLine("set x: {0}", this._xloc);
          return this._xloc += amount;
      }


      public int setZLoc(int amount) {
          //this.y_loc = this.y_loc + amount;
          Console.WriteLine("set z: {0}", this._zloc);
          return this._zloc += amount;
      }

      // Health

      public int spawnSetHealth(int amount = 15) {
          // set this when starting out
          // if there is an item which changes it, then it gets
          // done somewhere else
          this._maxHealth = amount;
          this._health = amount;
          Console.WriteLine("Max health {0}",this._maxHealth);
          Console.WriteLine("health {0}",this._health);
          return this._maxHealth;
      }

      public int getHealth() {
          Console.WriteLine("get health again: {0}",this._health);
          return this._health;
      }

      public int addToHealth(int amount){
        Console.WriteLine("get (add)health: {0}",this._health);
        Console.WriteLine("get (add)maxhealth : {0}",this._maxHealth);

        _health += amount;

        if (_health > _maxHealth ) {
            _health = _maxHealth;
        }

        return _health;
      }

      public int subtractFromHealth(int amount){
        _health -= amount;

        if (this._health <= 0) {
            killEntity();
            return 0;
          }
        else {
             Console.WriteLine("set injury: {0}",this._health - amount);
              return this._health;
            }
      }

      public void killEntity(){
          Console.WriteLine("die!!");
      }

      // set mesh
      // get mesh (not sure why though?)

      // set/get list of injury animations?
      // play movevement animations?
    }
}

/*
class TestClass
{
    static void Main(string[] args)
    {
        // force health, x,y loc, object type
        int EntXLoc;
        var myEntity = new Entity.Entity();
        myEntity._xloc = 0;
        myEntity._zloc = 0;
        myEntity.setXSpawn();
        myEntity.setYSpawn();
        Console.WriteLine("EntXLoc: {0}", myEntity._xloc);

        EntXLoc = myEntity.getXLoc();
        Console.WriteLine("EntXLoc1: {0}", EntXLoc);
        EntXLoc = myEntity.setXLoc(100);
        Console.WriteLine("EntXLoc2: {0}", EntXLoc);
        EntXLoc = myEntity.getXLoc();
        Console.WriteLine("EntXLoc1: {0}", myEntity._xloc);
        Console.WriteLine("EntXLoc3: {0}", EntXLoc);
        EntXLoc = myEntity.setXLoc(-100);
        Console.WriteLine("EntXLoc3: {0}", EntXLoc);


    }
}
*/
