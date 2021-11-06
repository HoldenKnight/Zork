using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ComponentModel;
using Newtonsoft.Json;
using System;

namespace Zork
{
    public class World : INotifyPropertyChanged 
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public List<Room> Rooms { get; set; }

        [JsonIgnore]
        public Dictionary<string, Room> RoomsByName => mRoomsByName;

        public Player SpawnPlayer() => new Player(this, StartingLocation);

        [OnDeserialized]
        private void OnDeserialized(StreamingContext context)
        {
            //try
            //{
                mRoomsByName = Rooms.ToDictionary(room => room.Name, room => room);
            //}
            //catch (ArgumentNullException)
            //{
            //    return;
            //}

            foreach (Room room in Rooms)
            {
                room.UpdateNeighbors(this);
            }
        }

        [JsonProperty]
        private string StartingLocation { get; set; }

        private Dictionary<string, Room> mRoomsByName;
    }
}
