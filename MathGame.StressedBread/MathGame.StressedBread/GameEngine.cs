using MathGame.StressedBread.Models;

namespace MathGame.StressedBread
{
    class GameEngine
    {

        internal void GameLogic(string message, string mathOperator)
        {
            int[] randomNumbers;
            int firstNumber;
            int secondNumber;
            int calculation = 0;
            int score = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.Clear();
                Console.WriteLine(message);

                switch (mathOperator)
                {
                    case "/":
                        randomNumbers = Helpers.GetDivisionNumbers();
                        break;
                    default:
                        randomNumbers = Helpers.GetRandomNumbers();
                        break;
                }

                firstNumber = randomNumbers[0];
                secondNumber = randomNumbers[1];

                Console.WriteLine($"{firstNumber} {mathOperator} {secondNumber}");

                string result = Console.ReadLine();

                result = Helpers.ValidateResult(result);

                switch (mathOperator)
                {
                    case "+":
                        calculation = firstNumber + secondNumber;
                        break;
                    case "-":
                        calculation = firstNumber - secondNumber;
                        break;
                    case "/":
                        calculation = firstNumber / secondNumber;
                        break;
                    case "*":
                        calculation = firstNumber * secondNumber;
                        break;
                }

                if (int.Parse(result) == calculation)
                {
                    Console.WriteLine("Correct! Press any key to get next question.");
                    score++;
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine($"Incorrect. Correct answer was {calculation}. Press any key to get next question.");
                    Console.ReadLine();
                }
            }
            Console.WriteLine($"Your score is: {score}. Press any key to return to menu.");
            Console.ReadLine();

            switch (mathOperator)
            {
                case "+":
                    Helpers.AddToHistory(score, GameType.Addition);
                    break;
                case "-":
                    Helpers.AddToHistory(score, GameType.Subtraction);
                    break;
                case "/":
                    Helpers.AddToHistory(score, GameType.Division);
                    break;
                case "*":
                    Helpers.AddToHistory(score, GameType.Multiplication);
                    break;
            }
        }
    }
}
