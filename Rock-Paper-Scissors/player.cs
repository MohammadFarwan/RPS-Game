using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Rock_Paper_Scissors
{
    public class player
    {

        public string name;
        public int score;

        public string ChooseMove()
        {
            //rock, paper, or scissors
            Console.WriteLine("Type the number that indecate to your choose");
            Console.WriteLine("1.rock");
            Console.WriteLine("2.paper");
            Console.WriteLine("3.scissors");

            string choose = Console.ReadLine();

            while (true)
            {
                if (choose == "1" || choose == "2" || choose == "3")
                {
                    switch (choose)
                    {
                        case "1":
                            return "rock";
                            break;
                        case "2":
                            return "paper";
                            break;
                        case "3":
                            return "scissors";
                            break;
                    }
                } else
                {
                    Console.WriteLine("Please Type the valid number that indecate to your choose");
                    Console.WriteLine("1.rock");
                    Console.WriteLine("2.paper");
                    Console.WriteLine("3.scissors");
                    choose = Console.ReadLine();
                }
            }
        }
    }
}
