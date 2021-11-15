using System;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using Newtonsoft.Json;
using Zork;
using Zork_Builder.Forms;

namespace Zork_Builder
{
    public partial class ZorkBuilder : Form
    {
        public static string AssemblyTitle = Assembly.GetExecutingAssembly().GetCustomAttribute<AssemblyTitleAttribute>().Title;

        private WorldViewModel ViewModel
        {
            get => _ViewModel;
            set 
            {
                if (_ViewModel != value)
                {
                    _ViewModel = value;
                }
            }
        }

        private bool IsWorldLoaded
        {
            get => _IsGameLoaded;
            set
            {
                _IsGameLoaded = value;
                foreach (var control in _WorldDependentControls)
                {
                    control.Enabled = _IsGameLoaded;
                }

                foreach (var MenuItem in _WorldDependentMenuItems)
                {
                    MenuItem.Enabled = _IsGameLoaded;
                }
            }
        }

        public ZorkBuilder()
        {
            InitializeComponent();
            ViewModel = new WorldViewModel();

            _WorldDependentControls = new Control[]
            {
                RoomListBox,
                //AddRoomButton,
                DeleteRoomButton,
                roomInformationLayoutPanel,
                startingLocationComboBox,
                welcomeTextTextBox
            };


            _WorldDependentMenuItems = new ToolStripMenuItem[]
            {
                saveToolStripMenuItem,
                saveAsToolStripMenuItem,
                menuSaveToolStripMenuItem
            };

            IsWorldLoaded = false;
        }

        #region File Controls

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string json = File.ReadAllText(openFileDialog.FileName);
                    ViewModel.Game = JsonConvert.DeserializeObject<Game>(json);
                    ViewModel.filename = openFileDialog.FileName;
                    _IsGameLoaded = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "ZorkBuilder", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e) => ViewModel.SaveWorld(ViewModel.filename);

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                ViewModel.filename = saveFileDialog.FileName;
                ViewModel.SaveWorld(ViewModel.filename);
            }
        }

        private void CloseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MenuSaveToolStripMenuItem_Click(object sender, EventArgs e) => ViewModel.SaveWorld(ViewModel.filename);
        #endregion

        #region Room List Controls
        private void RoomListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DeleteRoomButton.Enabled = RoomListBox.SelectedItem != null;
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

        private void DeleteRoomButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete the room?", AssemblyTitle, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ViewModel.Rooms.Remove((Room)RoomListBox.SelectedItem);
                RoomListBox.SelectedItem = ViewModel.Rooms.FirstOrDefault();
            }
        }
        #endregion

        private bool _IsGameLoaded;

        private WorldViewModel _ViewModel;

        private Control[] _WorldDependentControls;
        
        private ToolStripMenuItem[] _WorldDependentMenuItems;
    }
}
