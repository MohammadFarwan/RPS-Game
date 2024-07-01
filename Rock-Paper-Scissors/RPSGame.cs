using System;

namespace Rock_Paper_Scissors
{
    public class RPSGame
    {
        private Player player;
        private Player ai;

        public RPSGame(Player player, Player ai)
        {
            this.player = player;
            this.ai = ai;
        }

        public void StartGame()
        {
            int rounds = 0;

            while (rounds < 3 && player.Score < 3 && ai.Score < 3)
            {
                PlayRound();
                rounds++;
            }

            DisplayFinalScores();
            DeclareWinner();
        }

        private void PlayRound()
        {
            string playerMove = player.ChooseMove();
            string aiMove = ai.RandomMove();

            Console.WriteLine($"{player.Name} chose {playerMove}");
            Console.WriteLine($"{ai.Name} chose {aiMove}");

            string result = DetermineWinner(playerMove, aiMove);
            Console.WriteLine(result);

            DisplayScores();
        }

        public string DetermineWinner(string playerMove, string aiMove)
        {
            if (playerMove == aiMove)
            {
                return "It's a tie!";
            }
            else if ((playerMove == "rock" && aiMove == "scissors") ||
                     (playerMove == "paper" && aiMove == "rock") ||
                     (playerMove == "scissors" && aiMove == "paper"))
            {
                player.Score++;
                return $"{player.Name} wins this round!";
            }
            else
            {
                ai.Score++;
                return $"{ai.Name} wins this round!";
            }
        }

        private void DisplayScores()
        {
            Console.WriteLine($"{player.Name}: {player.Score}");
            Console.WriteLine($"{ai.Name}: {ai.Score}");
        }

        private void DisplayFinalScores()
        {
            Console.WriteLine("Final Scores:");
            Console.WriteLine($"{player.Name}: {player.Score}");
            Console.WriteLine($"{ai.Name}: {ai.Score}");
        }

        private void DeclareWinner()
        {
            if (player.Score > ai.Score)
            {
                Console.WriteLine($"{player.Name} is the overall winner!");
            }
            else if (ai.Score > player.Score)
            {
                Console.WriteLine($"{ai.Name} is the overall winner!");
            }
            else
            {
                Console.WriteLine("The game is a tie!");
            }
        }
    }
}
