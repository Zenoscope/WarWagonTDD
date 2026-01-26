using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;

namespace Weapons
{

  public class Weapon {	  
    public string Name { get; set;}
    public int Damage { get; set;}
    public int StrikeNumber { get; set;}

	
    public Weapon(string name, int damage, int strikeNumber)
      {
        Name = name;
        Damage = damage;
        StrikeNumber = strikeNumber;
    }
   }

  // should there be bounds checking tests or should the tests
  public class Weapons {
      // starter waepon?

      // list of Weapons
      // weapon name, damage,
      /*
      playerWeapons = [
      "Anvil", 3,50,
      "Axe", 3,50,
      "lightning", 3, 50,
      "Flying hammer", 3, 50,
      "Flying daggers", 3, 50
      "arrows",  // area of effect
      ];
      */  

      // Weapons for wagon
      // set up a list of weapons, check it exists
      // check for attributes and if they are set up.

      public void AddToWeaponList(List<Weapon> List, string name, int strikeNumber, int damage){
        List.Add(new Weapon(name,strikeNumber,damage));
		Console.WriteLine("List length = {0}", List.Count);
		Console.Write(List.ElementAt(List.Count - 1).Name);
		Console.Write(" ", List.ElementAt(List.Count - 1).StrikeNumber);
		Console.WriteLine(" ", List.ElementAt(List.Count - 1).Damage);
        }	

      /*
      public void GetWeaponList(List<Weapon> List){
	  	for (i = 0; i++ ; i < List.Count) {
			Console.WriteLine(List.ElementAt(i).Name);
			Console.WriteLine(List.ElementAt(i).StrikeNumber);
			Console.WriteLine(List.ElementAt(i).Damage);
			}	  			
      }
      */
      /*
      public void deleteFromWeaponList(List<Weapon> List, index) {
	  		// delete the weapon at the index
			// or delete by name (which should be unique)?
			List.RemoveAt(index);
      }
      */
	
	  // replace by name
	  /*
	  List<string> listOfStrings = new List<string> { "abc", "123", "ghi" };
	  int index = listOfStrings.FindIndex(s => s == "123");
	  if (index != -1)
    	listOfStrings[index] =  "def";
	  */
	  
      // level up weapon
	  
      // how do level ups work?
	  
      // two types, strikenumber and damage.
      /*
      public void upgradeWeaponDamage() {

      }
      */
      /*
      public void upgradeWeaponStrike() {

      }      */
   }
	
  class main {
	public static void Main()
	{
		Console.WriteLine("Hello World");
		
		List<Weapon> playerWeaponList = new List<Weapon>();
		
		Weapons playerWeapons = new Weapons();	
		
		playerWeapons.AddToWeaponList(playerWeaponList,"Anvil",50,103);
		playerWeapons.AddToWeaponList(playerWeaponList,"Anvil",50,103);
	}	
   } // class
} // namespace
