using System;

namespace _221StarterCode
{
    class Program
    {
        static void Main(string[] args)
        {
            int userChoice = GetUserChoice();
            int computerChoice = GetComputerChoice();
            // Calculate the winner
            string winner = CalculateWinner(userChoice, computerChoice);
            //Translate integer to Rock Paper or Scissors value
            string userRPS = TranslateResults(userChoice);
            string computerRPS = TranslateResults(computerChoice);
            DisplayResults(userRPS, computerRPS);
            DisplayWinner(winner);
        }
        static int GetUserChoice()
        {
            Console.WriteLine("Please choose one of the following options: ");
            Console.WriteLine("1) Rock");
            Console.WriteLine("2) Paper");
            Console.WriteLine("3) Scissors");
            Console.Write("Choice: ");
            int userInput = int.Parse(Console.ReadLine());
            if (userInput > 3)
            {
                Console.WriteLine("Invalid Input");
                Environment.Exit(0);
            }
            if (userInput < 1)
            {
                Console.WriteLine("Invalid Input");
                Environment.Exit(0);
            }
            return userInput;
        }
        static int GetComputerChoice()
        {
            Random randomNumber= new Random();
            int number;
            number = randomNumber.Next(3);
            number = number + 1;
            Console.WriteLine($"Computer number is {number}");
            return number;
        }
        static string CalculateWinner(int user, int computer)
        {
            string result = "null";
            if (user == 1)
            {
                if (computer == 1)
                {
                    result = "It's a Tie";
                }
                else if (computer == 2)
                {
                    result = "Computer Wins";
                }
                else if (computer == 3)
                {
                    result = "You Win";
                }
            }
            else if (user == 2)
            {
                if (computer == 1)
                {
                    result = "You Win";
                }
                else if (computer == 2)
                {
                    result = "It's a Tie";
                }
                else if (computer == 3)
                {
                    result = "Computer Wins";
                }
            }
            else if (user == 3)
            {
                if (computer == 1)
                {
                    result = "Computer Wins";
                }
                else if (computer == 2)
                {
                    result = "You Win";
                }
                else if (computer == 3)
                {
                    result = "It's a Tie";
                }
            }
            return result;

        }
        static string TranslateResults(int x)
        {
            string result = "null";
            if (x == 1)
            {
                result = "Rock";
            }
            else if (x == 2)
            {
                result = "Paper";
            }
            else if (x == 3)
            {
                result = "Scissors";
            }
            return result;
        }
        static void DisplayResults(string user, string computer)
        {
            Console.WriteLine($"You selected {user} and the computer randomly selected {computer}.");
        }
        static void DisplayWinner(string winner)
        {
            Console.WriteLine(winner);
        }
    }
}
