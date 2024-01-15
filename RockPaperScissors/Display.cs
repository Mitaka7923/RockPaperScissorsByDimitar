using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    internal class Display
    {
        internal static void DisplayWinner(string winnerUsername)
        {
            switch (winnerUsername)
            {
                case null:
                    Console.WriteLine(Messages.Draw);
                    break;
                case "comptuer":
                    Console.WriteLine(Messages.Lose);
                    break;
                default:
                    Console.WriteLine(Messages.Win);
                    break;
            }
        }
    }
}
