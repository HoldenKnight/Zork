using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Zork;

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

        }

        private void CloseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
