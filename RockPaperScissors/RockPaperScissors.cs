using System.Threading.Channels;

namespace RockPaperScissors
{
    internal class RockPaperScissors
    {
        internal static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();

                Console.Write("Choose [r]ock, [p]aper or [s]cissors: ");
                var playerMove = Moves.GetUserMove();
                if (playerMove is null) 
                {
                    Messages.Print(Messages.TryAgain);
                    continue;
                }
                
                var computerMove = Moves.GetComputerMove();
                Console.WriteLine($"The computer chose {computerMove}.");

                Battle(playerMove, computerMove);
                Messages.Print(Messages.TryAgain);

                Console.ReadKey();
            }
        }

        internal static void Battle(string playerMove, string computerMove)
        {
            if ((playerMove == Moves.Rock && computerMove == Moves.Scissors) ||
                (playerMove == Moves.Paper && computerMove == Moves.Rock) ||
                (playerMove == Moves.Scissors && computerMove == Moves.Paper))
            {
                Messages.Print(Messages.Win);
            }
            else if ((playerMove == Moves.Rock && computerMove == Moves.Paper) ||
                (playerMove == Moves.Scissors && computerMove == Moves.Rock) ||
                (playerMove == Moves.Paper && computerMove == Moves.Scissors))
            {
                Messages.Print(Messages.Lose);
            }
            else
            {
                Messages.Print(Messages.Draw);
            }
        }
    }
}
