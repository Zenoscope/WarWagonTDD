using System;

namespace Wagon {
  public class Wagon {

 wagonWeapons = [
      "Anvil", 3,50,
      "Axe", 3,50,
      "lightning", 3, 50,
      "Flying hammer", 3, 50,
      "Flying daggers", 3, 50
      "arrows",  // area of effect
      ];
 
 // attributes 
 int x { get; set;}
 int y { get; set;}
 int orientationAngle { get; set;} 
 string wagonCharacter; // (get gets the name, set is replacing the mesh and the name) 
 active weaponsList; // get, add remove 
 inactive weaponsList (list of weapons previously used, includes update status etc)
     // get add

 // just methods
 move wagon in direction of the angle
 rotate wagon/wagon direction orientationAngle 
 
  }
}
    
