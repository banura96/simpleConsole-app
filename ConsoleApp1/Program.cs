using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string appName = "Number guesser";
            string version = "1.0.0";
            string author = "Banura Hettiarachchi";

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("{0}: Version {1} by {2}", appName, version, author);
            Console.ResetColor();

            Console.WriteLine("What is your name: ");
            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}. Let's play a game...", inputName);

            //int correctNum = 7;
            while (true)
            {
                Random random = new Random();
                int correctNum = random.Next(1, 10);

                int gusss = 0;

                Console.WriteLine("Guess a number between 1 and 10");

                while (gusss != correctNum)
                {
                    string input = Console.ReadLine();
                    if (!int.TryParse(input, out gusss))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Please enter valid number");
                        Console.ResetColor();
                        continue;
                    }
                    gusss = Int32.Parse(input);

                    if (gusss != correctNum)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Number is Wrong. Try Again");
                        Console.ResetColor();
                    }
                }
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("your number is correct");
                Console.ResetColor();

                Console.WriteLine("Do you want to play again? [Y or N]");
                string answer = Console.ReadLine().ToUpper();
                if(answer == "Y")
                {
                    continue;
                }
                else if(answer == "N")
                {
                    return;
                }
                else
                {
                    return;
                }

            }
        }
    }
}
