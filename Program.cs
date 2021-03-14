using System;
namespace rock_paper_scissor
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputPlayer, inputCPU;
            int randomInt;
            int playerScore = 0;
            int CpuScore = 0;
            string template = "Player: {0} - CPU: {1}";

            Console.WriteLine("Choose between ROCK, PAPER, SCISSOR:  ");
            inputPlayer = Console.ReadLine();
            inputPlayer = inputPlayer.ToUpper();

            Random random = new Random();
            randomInt = random.Next(1, 4);

            switch (randomInt)
            {
                case 1:
                    inputCPU = "ROCK";
                    Console.WriteLine("Computer : Rock");
                    if (inputPlayer == "ROCK")
                    {
                        Console.WriteLine("Draw!!\n");
                    }
                    else if (inputPlayer == "PAPER")
                    {
                        Console.WriteLine("You Won!!\n");
                        playerScore++;
                    }
                    else if (inputPlayer == "SCISSOR")
                    {
                        Console.WriteLine("You Lost!!\n");
                        CpuScore++;
                    }
                    break;
                case 2:
                    inputCPU = "PAPER";
                    Console.WriteLine("Computer : Paper");
                    if (inputPlayer == "PAPER")
                    {
                        Console.WriteLine("Draw!!\n");
                    }
                    else if (inputPlayer == "SCISSOR")
                    {
                        Console.WriteLine("You Won!!\n");
                        playerScore++;
                    }
                    else if (inputPlayer == "ROCK")
                    {
                        Console.WriteLine("You Lost!!\n");
                        CpuScore++;
                    }
                    break;
                case 3:
                    inputCPU = "SCISSOR";
                    Console.WriteLine("Computer: Scissor");
                    if (inputPlayer == "SCISSOR")
                    {
                        Console.WriteLine("Draw!!\n");
                    }
                    else if (inputPlayer == "ROCK")
                    {
                        Console.WriteLine("You Won!!\n");
                        playerScore++;
                    }
                    else if (inputPlayer == "PAPER")
                    {
                        Console.WriteLine("You Lost!!\n");
                        CpuScore++;
                    }
                    break;
                default:
                    Console.WriteLine("Invalid entry!");
                    break;
            }
            // Console.WriteLine(template, playerScore, CpuScore);
        }
    }
}
