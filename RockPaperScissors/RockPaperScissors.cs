namespace RockPaperScissors
{
    internal class RockPaperScissors
    {
        internal static void Main(string[] args)
        {
            var user = new Player("Gosho");
            var computer = new Player("computer");

            while (true)
            {
                Console.Clear();

                user.Move = Moves.GetUserMove();
                
                if (user.Move is null)
                {
                    Console.WriteLine(Messages.TryAgain);
                    continue;
                }

                computer.Move = Moves.GetComputerMove();
                Console.WriteLine($"The computer chose {computer.Move}.");

                var winner = Battle.ReturnWinner(user, computer);
                if (winner != null)
                {
                    Display.DisplayWinner(winner.Username);
                }
                else
                {
                    Console.WriteLine("TIE!");
                }

                Console.WriteLine(Messages.TryAgain);
                Console.ReadKey();
            }
        }
    }
}
