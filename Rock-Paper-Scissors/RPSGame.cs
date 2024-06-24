using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock_Paper_Scissors
{
    public class RPSGame
    {
        public string name = "Ai";
        public int score;
        public void start()
        {
            Console.WriteLine("Let's start the game!");
            Console.WriteLine("Enter your name?");
            player p1 = new player();

            string namePlayer = Console.ReadLine();
            p1.name = namePlayer;

            string choose = p1.ChooseMove();

            Console.WriteLine($"Your choose is: {choose}");

            // Create an array containing three numbers
            
            string[] choosesAi  = { "rock", "paper", "scissors" };

            // Create a Random object
            Random random = new Random();

            // Generate a random index between 0 and 2 (inclusive)
            int randomIndex = random.Next(0, choosesAi.Length);

            // Store the randomly selected value from the array
            string randomValue = choosesAi[randomIndex];

            // Output the randomly selected value
            Console.WriteLine("Random choose is : " + randomValue);


            Console.WriteLine($"{choose} VS {randomValue}");




            //rock, paper, or scissors


            if(choose == randomValue)
            {
                Console.WriteLine($"Ai tied with {p1.name}");
            }
            else if (choose == "scissors" && randomValue == "paper")
            {
                p1.score++;
                Console.WriteLine($"{p1.name} is the winner and the score is {p1.score}");
            }else if (randomValue == "scissors" && choose == "paper")
            {
                score++;
                Console.WriteLine($"{name} is the winner and the score is {score}");
            }
            else if (choose == "scissors" && randomValue == "rock")
            {
                
                score++;
                Console.WriteLine($"{name} is the winner and the score is {score}");
            }
            else if (randomValue == "scissors" && choose == "rock")
            {
                p1.score++;
                Console.WriteLine($"{p1.name} is the winner and the score is {p1.score}");
            }
            else if (choose == "paper" && randomValue == "rock")
            {
                p1.score++;
                Console.WriteLine($"{p1.name} is the winner and the score is {p1.score}");
            }
            else if (choose == "rock" && randomValue == "paper")
            {
                score++;
                Console.WriteLine($"{name} is the winner and the score is {score}");
            }
        }

    }
}
