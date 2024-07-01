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
        public string Name { get; set; }
        public int Score { get; set; }

        public string ChooseMove()
        {
            Console.WriteLine("Type the number that indicates your choice");
            Console.WriteLine("1. Rock");
            Console.WriteLine("2. Paper");
            Console.WriteLine("3. Scissors");
            Console.WriteLine();

            string choose = Console.ReadLine();

            while (true)
            {
                if (choose == "1" || choose == "2" || choose == "3")
                {
                    switch (choose)
                    {
                        case "1":
                            return "Rock";
                        case "2":
                            return "Paper";
                        case "3":
                            return "Scissors";
                    }
                }
                else
                {
                    Console.WriteLine("Please type a valid number that indicates your choice");
                    Console.WriteLine("1. Rock");
                    Console.WriteLine("2. Paper");
                    Console.WriteLine("3. Scissors");
                    choose = Console.ReadLine();
                }
            }
        }
    }
}