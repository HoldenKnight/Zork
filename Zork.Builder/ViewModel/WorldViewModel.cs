using System;
using System.ComponentModel;
using System.IO;
using Zork;
using Newtonsoft.Json;

namespace Zork_Builder
{
    internal class WorldViewModel : INotifyPropertyChanged
    {
#pragma warning disable CS0067
        public event PropertyChangedEventHandler PropertyChanged;
#pragma warning restore CS0067

        public string filename { get; set; }

        private bool IsGameLoaded
        {
            get => _IsGameLoaded;
            set
            {
                _IsGameLoaded = value;
            }
        }

        public BindingList<Room> Rooms { get; set; }

        //public BindingList<StartingLocation> StartingLocations { get; set; }

        public Game Game
        {
            set
            {
                if (_Game != value)
                {
                    _Game = value;
                    if (_Game != null)
                    {
                        Rooms = new BindingList<Room>(_Game.World.Rooms);
                        //StartingLocations = new BindingList<StartingLocation>((IList<StartingLocation>)_World.StartingLocations);
                        _IsGameLoaded = true;
                    }
                    else
                    {
                        Rooms = new BindingList<Room>(Array.Empty<Room>());
                        //StartingLocations = new BindingList<StartingLocation>(Array.Empty<StartingLocation>());
                        _IsGameLoaded = false;
                    }
                }
            }
        }

        public void SaveWorld(string filename)
        {
            if (!_IsGameLoaded)
            {
                throw new InvalidOperationException("World isn't loaded.");
            }

            if (string.IsNullOrWhiteSpace(filename))
            {
                throw new InvalidOperationException("Invalid filename.");
            }

            JsonSerializer serializer = new JsonSerializer
            {
                Formatting = Formatting.Indented
            };
            using (StreamWriter streamWriter = new StreamWriter(filename))
            using (JsonWriter jsonWriter = new JsonTextWriter(streamWriter))
            {
                serializer.Serialize(jsonWriter, _Game);
            }
        }

        private Game _Game;

        private bool _IsGameLoaded;
    }
}
