namespace Rock_Paper_Scissors
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Rock, Paper, Scissors!");
            Console.WriteLine("Enter your name: ");
            string playerName = Console.ReadLine();

            Player player = new Player(playerName);
            Player ai = new Player("AI");

            RPSGame game = new RPSGame(player, ai);
            game.StartGame();

            Console.WriteLine("Thank you for playing!");
        }
    }
}
