using Newtonsoft.Json;
using System;
using System.IO;
using System.ComponentModel;

namespace Zork
{
    public class Game : INotifyPropertyChanged
    {
#pragma warning disable CS0067
        public event PropertyChangedEventHandler PropertyChanged;
#pragma warning restore CS0067

        public event EventHandler<float> MovesIncreased;
        
        public event EventHandler<float> ScoreIncreased;

        public event EventHandler GameStopped;

        public World World { get; private set; }

        [JsonIgnore]
        public Player Player { get; private set; }

        public IInputService Input { get; set; }

        public IOutputService Output { get; set; }

        public float Moves { get; set; }

        public float Score { get; set; }

        [JsonIgnore]
        public bool IsRunning { get; set; }

        public Game(World world, Player player)
        {
            World = world;
            Player = player;
        }

        public void Start(IInputService input, IOutputService output)
        {
            if (input != null)
            {
                Input = input;
                Input.InputRecieved += InputRecievedHandler; ;
            }

            if (output != null)
            {
                Output = output;
            }

            IsRunning = true;
        }

        private void InputRecievedHandler(object sender, string commandString)
        {
            Commands command = ToCommand(Console.ReadLine().Trim());

            string outputString = "";
            switch (command)
            {
                case Commands.QUIT:
                    IsRunning = false;
                    GameStopped?.Invoke(this, EventArgs.Empty);
                    break;
                case Commands.LOOK:
                    outputString = $"{Player.Location.Description}";
                    Moves++;
                    MovesIncreased?.Invoke(this, Moves);
                    break;
                case Commands.NORTH:
                case Commands.SOUTH:
                case Commands.EAST:
                case Commands.WEST:
                    Directions direction = (Directions)command;
                    if (Player.Move(direction) == false)
                    {
                        outputString = "The way is shut!";
                    }
                    Moves++;
                    break;
                case Commands.REWARD:
                    Score = Score + 5;
                    Moves++;
                    ScoreIncreased?.Invoke(this, Score);
                    MovesIncreased?.Invoke(this, Moves);
                    break;
                case Commands.SCORE:
                    outputString = "${ Score}";
                    Moves++;
                    MovesIncreased?.Invoke(this, Moves);
                    break;
                default:
                    outputString = ("Unrecognized command.");
                    break;
            }

            Output.WriteLine(outputString);
        }

        public static Game Load(string filename, IOutputService output)
        {
            Game game = JsonConvert.DeserializeObject<Game>(File.ReadAllText(filename));
            game.Player = game.World.SpawnPlayer();
            game.Output = output;
            return game;
        }
        
        private static Commands ToCommand(string commandString)
        {
            return Enum.TryParse(commandString, true, out Commands result) ? result : Commands.UNKNOWN;
        }
    }
}