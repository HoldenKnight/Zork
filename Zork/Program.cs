using System;

namespace Zork
{
    class Program
    {
        static void Main(string[] args)
        {
            const string defaultgameFilename = "Zork.json";

            string gameFilename = (args.Length > 0 ? args[(int)CommandLineArguments.GameFilename] : defaultgameFilename);

            Game game = Game.Load(gameFilename);
            Console.WriteLine("Welcome to Zork!");
            game.Run();
        }

        private enum CommandLineArguments
        {
            GameFilename = 0
        }
    }
}