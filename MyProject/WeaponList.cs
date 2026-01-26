using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;

namespace WeaponList
{
  // should there be bounds checking tests or should the tests
  public class WeaponList {

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
