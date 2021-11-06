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

        private bool IsWorldLoaded
        {
            get => _IsWorldLoaded;
            set
            {
                _IsWorldLoaded = value;
            }
        }

        public BindingList<Room> Rooms { get; set; }

        //public BindingList<StartingLocation> StartingLocations { get; set; }

        public World World
        {
            set
            {
                if (_World != value)
                {
                    _World = value;
                    if (_World != null)
                    {
                        Rooms = new BindingList<Room>(_World.Rooms);
                        //StartingLocations = new BindingList<StartingLocation>((IList<StartingLocation>)_World.StartingLocations);
                        _IsWorldLoaded = true;
                    }
                    else
                    {
                        Rooms = new BindingList<Room>(Array.Empty<Room>());
                        //StartingLocations = new BindingList<StartingLocation>(Array.Empty<StartingLocation>());
                        _IsWorldLoaded = false;
                    }
                }
            }
        }

        public void SaveWorld(string filename)
        {
            if (!_IsWorldLoaded)
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
                serializer.Serialize(jsonWriter, _World);
            }
        }

        private World _World;

        private bool _IsWorldLoaded;
    }
}
