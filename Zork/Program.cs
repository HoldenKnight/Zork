using System;

namespace Zork
{
    class Program
    {
        static void Main(string[] args)
        {
            const string defaultgameFilename = "Zork.json";

            string gameFilename = (args.Length > 0 ? args[(int)CommandLineArguments.GameFilename] : defaultgameFilename);

            ConsoleInputService input = new ConsoleInputService();
            ConsoleOutputService output = new ConsoleOutputService();
            Game game = Game.Load(gameFilename, output);
            Console.WriteLine("Welcome to Zork!");

            game.Player.LocationChanged += Player_LocationChanged;

            game.Start(input, output);

            Room previousRoom = null;
            while (game.IsRunning)
            {
                
                output.WriteLine(game.Player.LocationName);
                if (previousRoom != game.Player.Location)
                {
                    output.WriteLine(game.Player.Location.Description);
                    previousRoom = game.Player.Location;
                }

                output.Write("> ");

                input.ProcessInput();
            }

            output.WriteLine("Thank you for playing");
        }

        private static void Player_LocationChanged(object sender, Room e)
        {
            Console.WriteLine($"You moved to, {e.Name}");
        }

        private enum CommandLineArguments
        {
            GameFilename = 0
        }
    }
}