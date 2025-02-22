namespace MathGame.StressedBread
{
    class Menu
    {
        GameEngine engine = new();
        internal void ShowMenu(DateTime date)
        {
            bool isGameOn = true;

            do
            {
                Console.Clear();
                Console.WriteLine($"It's {date}.\n");
                Console.WriteLine(@"Choose the game you want to play:
V - View previous games
A - Addition
S - Subtraction
M - Multiplication
D - Division
Q - Quit");

                string? gameSelected = Console.ReadLine();

                switch (gameSelected.Trim().ToLower())
                {
                    case "v":
                        Helpers.PrintGames();
                        break;
                    case "a":
                        engine.GameLogic("Addition game", "+");
                        break;
                    case "s":
                        engine.GameLogic("Subtraction game", "-");
                        break;
                    case "m":
                        engine.GameLogic("Multiplication game", "*");
                        break;
                    case "d":
                        engine.GameLogic("Division game", "/");
                        break;
                    case "q":
                        Console.WriteLine("Quitting the program.");
                        isGameOn = false;
                        break;
                    default:
                        Console.WriteLine("Invalid input. Press any key to reset.");
                        Console.ReadLine();
                        break;
                }
            } while (isGameOn);
        }
    }
}
