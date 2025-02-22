using MathGame.StressedBread.Models;

namespace MathGame.StressedBread
{
    class GameEngine
    {
        internal void AdditionGame(string message)
        {
            Random random = new Random();
            int firstNumber;
            int secondNumber;
            int score = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.Clear();
                Console.WriteLine(message);

                firstNumber = random.Next(1, 9);
                secondNumber = random.Next(1, 9);

                Console.WriteLine($"{firstNumber} + {secondNumber}");

                string result = Console.ReadLine();

                result = Helpers.ValidateResult(result);

                if (int.Parse(result) == firstNumber + secondNumber)
                {
                    Console.WriteLine("Correct! Press any key to get next question.");
                    score++;
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine($"Incorrect. Correct answer was {firstNumber + secondNumber}. Press any key to get next question.");
                    Console.ReadLine();
                }
            }
            Console.WriteLine($"Your score is: {score}. Press any key to return to menu.");
            Console.ReadLine();

            Helpers.AddToHistory(score, GameType.Addition);
        }
        internal void SubtractionGame(string message)
        {
            Random random = new Random();
            int firstNumber;
            int secondNumber;
            int score = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.Clear();
                Console.WriteLine(message);

                firstNumber = random.Next(1, 9);
                secondNumber = random.Next(1, 9);

                Console.WriteLine($"{firstNumber} - {secondNumber}");

                string result = Console.ReadLine();

                result = Helpers.ValidateResult(result);

                if (int.Parse(result) == firstNumber - secondNumber)
                {
                    Console.WriteLine("Correct! Press any key to get next question.");
                    score++;
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine($"Incorrect. Correct answer was {firstNumber - secondNumber}. Press any key to get next question.");
                    Console.ReadLine();
                }
            }
            Console.WriteLine($"Your score is: {score}. Press any key to return to menu.");
            Console.ReadLine();

            Helpers.AddToHistory(score, GameType.Subtraction);
        }
        internal void MultiplicationGame(string message)
        {
            Random random = new Random();
            int firstNumber;
            int secondNumber;
            int score = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.Clear();
                Console.WriteLine(message);

                firstNumber = random.Next(1, 9);
                secondNumber = random.Next(1, 9);

                Console.WriteLine($"{firstNumber} * {secondNumber}");

                string result = Console.ReadLine();

                result = Helpers.ValidateResult(result);

                if (int.Parse(result) == firstNumber * secondNumber)
                {
                    Console.WriteLine("Correct! Press any key to get next question.");
                    score++;
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine($"Incorrect. Correct answer was {firstNumber * secondNumber}. Press any key to get next question.");
                    Console.ReadLine();
                }
            }
            Console.WriteLine($"Your score is: {score}. Press any key to return to menu.");
            Console.ReadLine();

            Helpers.AddToHistory(score, GameType.Multiplication);
        }
        internal void DivisionGame(string message)
        {
            int score = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.Clear();
                Console.WriteLine(message);

                int[] divisionNumbers = Helpers.GetDivisionNumbers();
                int firstNumber = divisionNumbers[0];
                int secondNumber = divisionNumbers[1];

                Console.WriteLine($"{firstNumber} / {secondNumber}");

                string result = Console.ReadLine();

                result = Helpers.ValidateResult(result);

                if (int.Parse(result) == firstNumber / secondNumber)
                {
                    Console.WriteLine("Correct! Press any key to get next question.");
                    score++;
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine($"Incorrect. Correct answer was {firstNumber / secondNumber}. Press any key to get next question.");
                    Console.ReadLine();
                }
            }
            Console.WriteLine($"Your score is: {score}. Press any key to return to menu.");
            Console.ReadLine();

            Helpers.AddToHistory(score, GameType.Division);
        }

    }
}
