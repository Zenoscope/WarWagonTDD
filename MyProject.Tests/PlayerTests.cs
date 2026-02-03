using NUnit.Framework;

namespace PlayerTests
{
  public class PlayerTests
   {

     // create a new player instance
     [Test]
     public void createPlayer(){
       GamePlayer.Player myPlayer = new GamePlayer.Player();
       Console.WriteLine("Entity Name:{0}", myPlayer.Name);
       Console.WriteLine("Entity X location:{0}", myPlayer._xloc);
       Console.WriteLine("Entity Y location:{0}", myPlayer._zloc);
       Console.WriteLine("Entity Y location:{0}", myPlayer.Score);
     }

   }
 }
