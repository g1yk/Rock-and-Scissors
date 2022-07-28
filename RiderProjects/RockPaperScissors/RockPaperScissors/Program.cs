using System;

namespace RockPaperScissors
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var gameStatus = true;
            string playersChoice;
            string computerAnswer = null;
            while (gameStatus)
            {
                playersChoice = "";
                while (playersChoice != "ROCK" && playersChoice != "PAPER" && playersChoice != "SCISSORS")
                {
                    Console.WriteLine("Please write ROCK, PAPER or SCISSORS: ");
                    playersChoice = Console.ReadLine()?.ToUpper();
                }

                computerAnswer = CreateComputerAnswer();
                DisplayAllAnswers(playersChoice, computerAnswer);
                CompareAndGetResult(playersChoice, computerAnswer);
                gameStatus = AskToPlayAgain();
            }
        }
        
        /// <summary>
        /// Asks user to play again
        /// </summary>
        /// <returns>true or false depending on the user answer</returns>
        private static bool AskToPlayAgain()
        {
            Console.WriteLine("Would you like to play again? Y/N ");
            var answer = Console.ReadLine()?.ToUpper();
            if (answer == "Y")
            {
                return true;
            }
            else
            {
                Console.WriteLine("Thanks for playing!");
                return false;
            }
        }
        
        /// <summary>
        /// Displays all answers
        /// </summary>
        /// <param name="playersChoice">Player answer</param>
        /// <param name="computerAnswer">Computer answer</param>
        private static void DisplayAllAnswers(string playersChoice, string computerAnswer)
        {
            Console.WriteLine($"Computers choice: {computerAnswer}");
            Console.WriteLine($"Your choice: {playersChoice}");
        }
        
        /// <summary>
        /// Comparing both answers and displaying result.
        /// </summary>
        /// <param name="playersChoice">Player answer</param>
        /// <param name="computerAnswer">Computer answer</param>
        private static void CompareAndGetResult(string playersChoice, string computerAnswer)
        {
            if (playersChoice == computerAnswer)
                Console.WriteLine("Draw!");
            else
                switch (playersChoice)
                {
                    case "ROCK":
                        if (computerAnswer == "PAPER")
                            Console.WriteLine("Computer wins.");
                        else
                            Console.WriteLine("Player wins");
                        break;
                    case "PAPER":
                        if (computerAnswer == "SCISSORS")
                            Console.WriteLine("Computer wins.");
                        else
                            Console.WriteLine("Player wins");
                        break;
                    case "SCISSORS":
                        if (computerAnswer == "ROCK")
                            Console.WriteLine("Computer wins.");
                        else
                            Console.WriteLine("Player wins");
                        break;
                }
        }
        
        /// <summary>
        /// Creates computer answer based on random number between 1 and 3
        /// </summary>
        /// <returns>Returns computer answer as a string</returns>
        private static string CreateComputerAnswer()
        {
            var random = new Random();
            string computersChoice = null;
            var randomNumber = random.Next(1, 4);
            switch (randomNumber)
            {
                case 1:
                    computersChoice = "ROCK";
                    break;
                case 2:
                    computersChoice = "PAPER";
                    break;
                case 3:
                    computersChoice = "SCISSORS";
                    break;
            }

            return computersChoice;
        }
    }
}