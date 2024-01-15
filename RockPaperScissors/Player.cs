namespace RockPaperScissors
{
    internal class Player
    {
        public string Username { get; set; }

        public string Move { get; set; }

        public Player(string username)
        {
            this.Username = username;
        }
    }
}