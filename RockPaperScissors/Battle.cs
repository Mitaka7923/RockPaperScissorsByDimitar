namespace RockPaperScissors
{
    internal class Battle
    {
        internal static Player? ReturnWinner(Player user, Player computer)
        {
            if ((user.Move == Moves.Rock && computer.Move == Moves.Scissors) ||
                (user.Move == Moves.Paper && computer.Move == Moves.Rock) ||
                (user.Move == Moves.Scissors && computer.Move == Moves.Paper))
            {
                return user;
            }
            else if ((user.Move == Moves.Rock && computer.Move == Moves.Paper) ||
                (user.Move == Moves.Scissors && computer.Move == Moves.Rock) ||
                (user.Move == Moves.Paper && computer.Move == Moves.Scissors))
            {
                return computer;
            }
            else
            {
                return null;
            }
        }
    }
}
