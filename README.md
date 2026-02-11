
TDD scripting <br>
https://blog.coscreen.co/blog/tdd-in-c-guide/ <br>
<br>

testing: <br>
https://sentry.io/signup/?original_referrer=https%3A%2F%2Fblog.sentry.io%2F <br>
<br>

dotnet setup: <br>
install pulsar ide <br>
install dotnet - sudo apt instal dotnet-sdk-<version> <br>
<br>

then setting up a test environment: <br>
Solution for to organise tests and codes <br>
dotnet new sln -o MySolution <br>
<br>

create application: <br>
dotnet new classlib -o MyProject <br>
<br>

add a test frmework (Nunit, xunit etc) <br>
dotnet new nunit -o MyProject.Tests <br>
<br>

link it all together: <br>
<br>

dotnet sln MySolution add MyProject/MyProject.csproj <br>
dotnet sln MySolution add MyProject.Tests/MyProject.Tests.csproj <br>
dotnet add MyProject.Tests/MyProject.Tests.csproj reference MyProject/MyProject.csproj  <br>

tests go in the test directory, code in the project directory. <br>

list tests with: <br>
dotnet test MySolution/  -t <br>

run tests with:

dotnet MySolution/ <br>

You can also use the required modifier on a property and allow callers to use an object initializer to set the initial value of the property:

C#
public class Person
{
    public required string LastName { get; set; }
    public required string FirstName { get; set; }
}
The addition of the required keyword mandates that callers must set those properties as part of a new expression:

C#
var p1 = new Person(); // Error! Required properties not set
var p2 = new Person() { FirstName = "Grace", LastName = "Hopper" };

Reading a key (can emulate this)
https://www.dutton.me.uk/2009-02-24/non-blocking-keyboard-input-in-c/#:~:text=I%20quite%20frequently%20want%20to,//%20Do%20something%20more%20useful%20%7D


__ideas___

Weaponlist is from entity
Add/delete/upgrade as well

New weapon replaces old weapon
Check new weapon before offering it

Lightning weapon - fry
Cannon with balls (aoe) - fire
Secret kei truck wagon
Split in half - cytting

Each gets a location function, like a path, it should be part of the weapon's class though.
So weapons get a subclass with:

Type (fire, lightning, drown, cut etc) used for death animation as well as object..
Damage
Number of instances
Animation
Hit location/area of effect/chain/whatever
Weapon life (durability?)
Current level
Max levels
Flight path (actual path to follow)
Randomness value


_–-------- coding:

Weapon list will spawn weapons and then add them to the list.
The weapon class "should" handle the upgrades, but it may need to know where they are in the list.


// 

using System;

public class HelloWorld
{

  public static void Main(string[] args)
    {

     int[] GemLevelsList =  { 10, 25, 50, 100, 250, 500 };

     int Level = 0;
     int GemCount = 0;

     while (GemCount < 100 ){
         GemCount++;
         Console.WriteLine("GemCount = {0}", GemCount);
         if ( GemCount == GemLevelsList[Level] ){
             Level++;
             GemCount = 0;
             Console.WriteLine("Level = {0}", Level);
            }
        }
    }
}
