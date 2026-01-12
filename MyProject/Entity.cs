using System;

// entity stuff, like moving, spawning
// location, mesh etc.
// also set things like health, mesh etc

namespace Entity
{
    public class Entity
    {
      private int _health { get; private set; }
      private int _maxHealth { get; private set; }

      public int _x_loc { get; private set; }
      public int _y_loc { get; private set; }

      // spawn

      public int set_x_spawn(int x = 0) {
          // xloc is optional, if not specified it's zero
          return this.x_loc = x;
      }

      public int set_y_spawn(int y = 0) {
          // xloc is optional, if not specified it's zero
          return this.y_loc = y;
      }

      // get location
      /*
      public int get_x_loc() {
          Console.WriteLine("get x: {0}", x_loc);
          return x_loc;
      }*/
      /*
      public int get_y_loc() {
          Console.WriteLine("get y: {0}", y_loc);
          return y_loc;
      }
      */
      /*
      public int set_x_loc(int amount) {
          // will also work with negative numbers, so moving that way...
          // what about rotation though? hmm.
          //x_loc = x_loc + amount;
          Console.WriteLine("set x: {0}", x_loc);
          return x_loc += amount;
      }

      //
      public int set_y_loc(int amount) {
          //this.y_loc = this.y_loc + amount;
          Console.WriteLine("set y: {0}", y_loc);
          return y_loc += amount;
      }*/

      // Health
      public int setTotalHealth(int amount) {
          Health = amount;
          return Health;
      }


      public int getHealth() {
          return Health;
      }

      /*
      public int subtractFromHealth(int amount){
        return Health - amount;
      }*/

      // set health

      // set mesh
      // get mesh (not sure why though?)

      // set/get list of injury animations?
      // play movevement animations?


    }
}
