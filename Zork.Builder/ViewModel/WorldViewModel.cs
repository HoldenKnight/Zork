using System;
using System.Collections.Generic;
using System.ComponentModel;
using Zork;

namespace Zork_Builder
{
    internal class WorldViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public BindingList<Room> Rooms { get; set; }

        public World World
        {
            set
            {
                if (_world != value)
                {
                    _world = value;
                    if (_world != null)
                    {
                        Rooms = new BindingList<Room>((IList<Room>)_world.Rooms);
                    }
                    else
                    {
                        Rooms = new BindingList<Room>(Array.Empty<Room>());
                    }
                }
            }
        }

        private World _world;
    }
}
