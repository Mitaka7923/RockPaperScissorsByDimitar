using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    internal class Messages
    {
        internal static string Win = "You win.";
        internal static string Lose = "You lose.";
        internal static string Draw = "This game is a draw.";
        internal static string TryAgain = "\nPress any key to try again. . .";
        internal static string Exit = "Press any key to exit. . .";

        internal static void Print(string message) 
        {
            Console.Write(message);
        }
    }
}
