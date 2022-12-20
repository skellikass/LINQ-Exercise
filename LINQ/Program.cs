using System.Collections.Generic;
using System.Runtime.Intrinsics.X86;
using System.Xml.Linq;

namespace LINQ
{
    public class Program
    {
        static void Main()
        {
            //Create a list of video game names...
            //Order the list of games by length of the game name.
            //Use the lambda expression in this exercise as well.
            //use Method Syntax for this exercise

            List<string> videoGames = new List<string>
            { "Zelda: Breath of the Wild", "League of Legends", "Fortnite", "Super Smash Bros", "Call of Duty", "Rainbow 6", "Mario Kart", "Super Mario" };
            videoGames.OrderBy(game => game.Length).ToList().ForEach(game => Console.WriteLine(game));
        }
    }
}
