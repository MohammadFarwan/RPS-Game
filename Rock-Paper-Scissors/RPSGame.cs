using System;

namespace Rock_Paper_Scissors
{
    public class RPSGame
    {
        private string[] _choices = { "Rock", "Paper", "Scissors" };
        private Random _random = new Random();

        public void StartGame()
        {
            Player player = new Player();
            Console.WriteLine("Let's start the game!");
            Console.WriteLine("Enter your name:");
            player.Name = Console.ReadLine();
            player.Score = 0;
            int aiScore = 0;

            PlayUntilScoreThree(player, aiScore);
        }

        public void PlayUntilScoreThree(Player player, int aiScore)
        {
            while (player.Score < 3 && aiScore < 3)
            {
                PlayRound(player, aiScore);
            }

            if (player.Score == 3)
                Console.WriteLine($"{player.Name} wins the game!");
            else
                Console.WriteLine("AI wins the game!");
        }

        public void PlayRound(Player player, int aiScore)
        {
            string playerMove = player.ChooseMove();
            string aiMove = GetAiMove();
            Console.WriteLine($"Your choice: {playerMove}");
            Console.WriteLine($"AI choice: {aiMove}");

            DetermineWinner(playerMove, aiMove, player);
        }

        public string GetAiMove()
        {
            int randomIndex = _random.Next(0, _choices.Length);
            return _choices[randomIndex];
        }

        public void DetermineWinner(string playerMove, string aiMove, Player player)
        {
            if (playerMove == aiMove)
            {
                Console.WriteLine("It's a tie!");
            }
            else if ((playerMove == "Scissors" && aiMove == "Paper") ||
                     (playerMove == "Rock" && aiMove == "Scissors") ||
                     (playerMove == "Paper" && aiMove == "Rock"))
            {
                player.Score++;
                Console.WriteLine($"{player.Name} wins this round! Score: {player.Score}");
            }
            else
            {
                Console.WriteLine($"AI wins this round!");
            }
        }
    }
}
