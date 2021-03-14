using System;
namespace rock_paper_scissor
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputPlayer, inputCPU;
            int randomInt;

            Console.WriteLine("Choose between ROCK, PAPER, SCISSOR:  ");
            inputPlayer = Console.ReadLine();

            Random random = new Random();
            randomInt = random.Next(1, 4);

            switch (randomInt)
            {
                case 1:
                    inputCPU = "ROCK";
                    Console.WriteLine("Computer : Rock");
                    break;
                case 2:
                    inputCPU = "PAPER";
                    Console.WriteLine("Computer : Paper");
                    break;
                case 3:
                    inputCPU = "SCISSOR";
                    Console.WriteLine("Computer: Scissor");
                    break;
                default:
                    Console.WriteLine("Invalid entry!");
                    break;

            }
        }
    }
}
