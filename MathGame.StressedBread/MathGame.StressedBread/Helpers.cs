using MathGame.StressedBread.Models;

namespace MathGame.StressedBread
{
    class Helpers
    {
        internal static List<Game> games = new();
        
        internal static void PrintGames()
        {
            Console.Clear();
            Console.WriteLine("Games History");
            Console.WriteLine("---------------------");
            foreach (var game in games)
            {
                Console.WriteLine($"{game.Date} - {game.Type} - {game.Score} pts");
            }
            Console.WriteLine("---------------------\n");
            Console.WriteLine("Press any key to return to Main Menu");
            Console.ReadLine();
        }
        internal static void AddToHistory(int gameScore, GameType gameType)
        {
            games.Add(new Game
            {
                Date = DateTime.Now,
                Score = gameScore,
                Type = gameType
            });
        }
        internal static int[] GetRandomNumbers()
        {
            Random random = new Random();
            int firstNumber = random.Next(1, 9);
            int secondNumber = random.Next(1, 9);

            int[] result = [firstNumber, secondNumber];

            return result;
        }
        internal static int[] GetDivisionNumbers()
        {
            Random random = new Random();
            int firstNumber = random.Next(1, 99);
            int secondNumber = random.Next(1, 99);

            while (firstNumber % secondNumber != 0)
            {
                firstNumber = random.Next(1, 99);
                secondNumber = random.Next(1, 99);
            }

            int[] result = [firstNumber, secondNumber];

            return result;
        }

        internal static string? ValidateResult(string result)
        {
            while (string.IsNullOrEmpty(result) || !Int32.TryParse(result, out _))
            {
                Console.WriteLine("Your answer needs to be a whole number. Try again.");
                result = Console.ReadLine();
            }
            return result;
        }
    }
}
