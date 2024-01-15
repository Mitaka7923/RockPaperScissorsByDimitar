using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    internal class Moves
    {
        internal const string Rock = "Rock";
        internal const string Paper = "Paper";
        internal const string Scissors = "Scissors";

        internal static string GetComputerMove()
        {
            var random = new Random();
            var computerMove = "";

            switch (random.Next(1, 4))
            {
                case 1: computerMove = Rock; break;
                case 2: computerMove = Paper; break;
                case 3: computerMove = Scissors; break;
            }
            
            return computerMove;
        }

        internal static string? GetUserMove()
        {
            Console.Write("Choose [r]ock, [p]aper or [s]cissors: ");
            var playerMove = Console.ReadLine().ToLower();

            if (playerMove == "r" || playerMove == "rock")
            {
                playerMove = Rock;
            }
            else if (playerMove == "p" || playerMove == "paper")
            {
                playerMove = Paper;
            }
            else if (playerMove == "s" || playerMove == "scissors")
            {
                playerMove = Scissors;
            }
            else
            {
                if (playerMove.Trim().ToLower().Equals("exit"))
                {
                    Console.WriteLine(Messages.Exit);
                    Environment.Exit(0);
                }

                Console.Write("Invalid Input. Press any key to try Again...");
                Console.ReadKey(true);
                return null;
            }

            return playerMove;
        }
    }
}
