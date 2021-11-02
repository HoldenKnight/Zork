using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Newtonsoft.Json;
using Zork;
using Zork_Builder.Forms;

namespace Zork_Builder
{
    public partial class ZorkBuilder : Form
    {
        internal WorldViewModel ViewModel { get; private set; }
       
        public ZorkBuilder()
        {
            InitializeComponent();
            ViewModel = new WorldViewModel();
        }

        private void CreateToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string json = File.ReadAllText(openFileDialog.FileName);
                ViewModel.World = JsonConvert.DeserializeObject<World>(json);
            }
        }

        private void SaveToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not yet implemented");
        }

        private void CloseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddRoom_Click(object sender, EventArgs e)
        {
            using (AddRoomForm addRoomForm = new AddRoomForm())
            {
                if (addRoomForm.ShowDialog() == DialogResult.OK)
                {
                    Room existingRoom = ViewModel.Rooms.FirstOrDefault(Room => Room.Name.Equals(addRoomForm.RoomName, StringComparison.OrdinalIgnoreCase));
                    if (existingRoom != null)
                    {
                        MessageBox.Show("Room already exists", "ZorkBuilder", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    Room room = new Room(addRoomForm.RoomName);
                }
            }
        }
    }
}
