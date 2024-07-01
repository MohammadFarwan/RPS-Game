using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Rock_Paper_Scissors
{
    public class Player
    {
        public string Name { get; private set; }
        public int Score { get; set; }

        public Player(string name)
        {
            Name = name;
            Score = 0;
        }

        public string ChooseMove()
        {
            Console.WriteLine($"{Name}, please choose your move (rock, paper, scissors): ");
            string move = Console.ReadLine().ToLower();

            while (move != "rock" && move != "paper" && move != "scissors")
            {
                Console.WriteLine("Invalid move. Please choose rock, paper, or scissors: ");
                move = Console.ReadLine().ToLower();
            }

            return move;
        }

        public string RandomMove()
        {
            string[] moves = { "rock", "paper", "scissors" };
            Random random = new Random();
            int index = random.Next(moves.Length);
            return moves[index];
        }
    }
}