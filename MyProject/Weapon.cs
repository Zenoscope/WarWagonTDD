// defines a weapon

using System;

namespace Weapon
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

  // for testing
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
