
namespace Zork_Builder
{
    partial class ZorkBuilder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.MenuStrip menuStrip1;
            System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
            System.Windows.Forms.ToolStripMenuItem createToolStripMenuItem;
            System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
            System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem1;
            System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
            System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
            System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem2;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label7;
            System.Windows.Forms.Label label8;
            System.Windows.Forms.Label label9;
            System.Windows.Forms.Label RoomListLabel;
            System.Windows.Forms.Label RoomInformation;
            System.Windows.Forms.Label StartingLocatinLabel;
            System.Windows.Forms.Label WelcomeTextLabel;
            this.RoomListBox = new System.Windows.Forms.ListBox();
            this.roomsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.richTextBox5 = new System.Windows.Forms.RichTextBox();
            this.richTextBox6 = new System.Windows.Forms.RichTextBox();
            this.richTextBox7 = new System.Windows.Forms.RichTextBox();
            this.AddRoom = new System.Windows.Forms.Button();
            this.DeleteRoom = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.richTextBox4 = new System.Windows.Forms.RichTextBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            createToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            saveToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            saveToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            RoomListLabel = new System.Windows.Forms.Label();
            RoomInformation = new System.Windows.Forms.Label();
            StartingLocatinLabel = new System.Windows.Forms.Label();
            WelcomeTextLabel = new System.Windows.Forms.Label();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = System.Drawing.SystemColors.Info;
            menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            fileToolStripMenuItem,
            saveToolStripMenuItem2});
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new System.Drawing.Size(728, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            createToolStripMenuItem,
            openToolStripMenuItem,
            saveToolStripMenuItem1,
            saveAsToolStripMenuItem,
            closeToolStripMenuItem});
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            fileToolStripMenuItem.Text = "File";
            // 
            // createToolStripMenuItem
            // 
            createToolStripMenuItem.Name = "createToolStripMenuItem";
            createToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            createToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            createToolStripMenuItem.Text = "&Create";
            createToolStripMenuItem.Click += new System.EventHandler(this.CreateToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            openToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            openToolStripMenuItem.Text = "&Open";
            openToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem1
            // 
            saveToolStripMenuItem1.Name = "saveToolStripMenuItem1";
            saveToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            saveToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            saveToolStripMenuItem1.Text = "&Save";
            saveToolStripMenuItem1.Click += new System.EventHandler(this.SaveToolStripMenuItem1_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            saveAsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.S)));
            saveAsToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            saveAsToolStripMenuItem.Text = "Save As";
            // 
            // closeToolStripMenuItem
            // 
            closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            closeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            closeToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            closeToolStripMenuItem.Text = "E&xit";
            closeToolStripMenuItem.Click += new System.EventHandler(this.CloseToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem2
            // 
            saveToolStripMenuItem2.Name = "saveToolStripMenuItem2";
            saveToolStripMenuItem2.Size = new System.Drawing.Size(54, 24);
            saveToolStripMenuItem2.Text = "Save";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.SystemColors.Control;
            label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tableLayoutPanel1.SetColumnSpan(label1, 2);
            label1.Dock = System.Windows.Forms.DockStyle.Fill;
            label1.Location = new System.Drawing.Point(3, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(182, 28);
            label1.TabIndex = 0;
            label1.Text = "Room Name";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tableLayoutPanel1.SetColumnSpan(label2, 2);
            label2.Dock = System.Windows.Forms.DockStyle.Fill;
            label2.Location = new System.Drawing.Point(3, 28);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(182, 61);
            label2.TabIndex = 2;
            label2.Text = "Room Description";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            label3.Dock = System.Windows.Forms.DockStyle.Fill;
            label3.Location = new System.Drawing.Point(3, 89);
            label3.Name = "label3";
            this.tableLayoutPanel1.SetRowSpan(label3, 4);
            label3.Size = new System.Drawing.Size(88, 116);
            label3.TabIndex = 4;
            label3.Text = "Neigbors";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            label6.Dock = System.Windows.Forms.DockStyle.Fill;
            label6.Location = new System.Drawing.Point(97, 89);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(88, 28);
            label6.TabIndex = 5;
            label6.Text = "North";
            label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            label7.Dock = System.Windows.Forms.DockStyle.Fill;
            label7.Location = new System.Drawing.Point(97, 117);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(88, 28);
            label7.TabIndex = 7;
            label7.Text = "South";
            label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            label8.Dock = System.Windows.Forms.DockStyle.Fill;
            label8.Location = new System.Drawing.Point(97, 145);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(88, 28);
            label8.TabIndex = 9;
            label8.Text = "East";
            label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            label9.Dock = System.Windows.Forms.DockStyle.Fill;
            label9.Location = new System.Drawing.Point(97, 173);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(88, 32);
            label9.TabIndex = 11;
            label9.Text = "West";
            label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RoomListLabel
            // 
            RoomListLabel.AutoSize = true;
            RoomListLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            RoomListLabel.Location = new System.Drawing.Point(40, 65);
            RoomListLabel.Name = "RoomListLabel";
            RoomListLabel.Size = new System.Drawing.Size(71, 17);
            RoomListLabel.TabIndex = 1;
            RoomListLabel.Text = "Room List";
            // 
            // RoomInformation
            // 
            RoomInformation.AutoSize = true;
            RoomInformation.BackColor = System.Drawing.SystemColors.ControlLight;
            RoomInformation.Location = new System.Drawing.Point(202, 65);
            RoomInformation.Name = "RoomInformation";
            RoomInformation.Size = new System.Drawing.Size(119, 17);
            RoomInformation.TabIndex = 5;
            RoomInformation.Text = "Room Information";
            // 
            // StartingLocatinLabel
            // 
            StartingLocatinLabel.AutoSize = true;
            StartingLocatinLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            StartingLocatinLabel.Location = new System.Drawing.Point(40, 317);
            StartingLocatinLabel.Name = "StartingLocatinLabel";
            StartingLocatinLabel.Size = new System.Drawing.Size(115, 17);
            StartingLocatinLabel.TabIndex = 6;
            StartingLocatinLabel.Text = "Starting Location";
            // 
            // WelcomeTextLabel
            // 
            WelcomeTextLabel.AutoSize = true;
            WelcomeTextLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            WelcomeTextLabel.Location = new System.Drawing.Point(205, 317);
            WelcomeTextLabel.Name = "WelcomeTextLabel";
            WelcomeTextLabel.Size = new System.Drawing.Size(97, 17);
            WelcomeTextLabel.TabIndex = 8;
            WelcomeTextLabel.Text = "Welcome Text";
            // 
            // RoomListBox
            // 
            this.RoomListBox.DataSource = this.roomsBindingSource;
            this.RoomListBox.DisplayMember = "Name";
            this.RoomListBox.FormattingEnabled = true;
            this.RoomListBox.ItemHeight = 16;
            this.RoomListBox.Location = new System.Drawing.Point(43, 85);
            this.RoomListBox.Name = "RoomListBox";
            this.RoomListBox.Size = new System.Drawing.Size(156, 164);
            this.RoomListBox.TabIndex = 2;
            this.RoomListBox.ValueMember = "Description";
            // 
            // roomsBindingSource
            // 
            this.roomsBindingSource.DataSource = typeof(Zork.Room);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.Controls.Add(label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.richTextBox1, 2, 1);
            this.tableLayoutPanel1.Controls.Add(label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.richTextBox2, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.richTextBox3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(label6, 1, 2);
            this.tableLayoutPanel1.Controls.Add(label7, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.richTextBox5, 2, 3);
            this.tableLayoutPanel1.Controls.Add(label8, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.richTextBox6, 2, 4);
            this.tableLayoutPanel1.Controls.Add(label9, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.richTextBox7, 2, 5);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(205, 85);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(474, 205);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // richTextBox1
            // 
            this.richTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.roomsBindingSource, "Description", true));
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(191, 31);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(280, 55);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox2.Location = new System.Drawing.Point(191, 92);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(280, 22);
            this.richTextBox2.TabIndex = 6;
            this.richTextBox2.Text = "";
            // 
            // richTextBox3
            // 
            this.richTextBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.roomsBindingSource, "Name", true));
            this.richTextBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox3.Location = new System.Drawing.Point(191, 3);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.Size = new System.Drawing.Size(280, 22);
            this.richTextBox3.TabIndex = 1;
            this.richTextBox3.Text = "";
            // 
            // richTextBox5
            // 
            this.richTextBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox5.Location = new System.Drawing.Point(191, 120);
            this.richTextBox5.Name = "richTextBox5";
            this.richTextBox5.Size = new System.Drawing.Size(280, 22);
            this.richTextBox5.TabIndex = 8;
            this.richTextBox5.Text = "";
            // 
            // richTextBox6
            // 
            this.richTextBox6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox6.Location = new System.Drawing.Point(191, 148);
            this.richTextBox6.Name = "richTextBox6";
            this.richTextBox6.Size = new System.Drawing.Size(280, 22);
            this.richTextBox6.TabIndex = 10;
            this.richTextBox6.Text = "";
            // 
            // richTextBox7
            // 
            this.richTextBox7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox7.Location = new System.Drawing.Point(191, 176);
            this.richTextBox7.Name = "richTextBox7";
            this.richTextBox7.Size = new System.Drawing.Size(280, 26);
            this.richTextBox7.TabIndex = 12;
            this.richTextBox7.Text = "";
            // 
            // AddRoom
            // 
            this.AddRoom.Location = new System.Drawing.Point(43, 256);
            this.AddRoom.Name = "AddRoom";
            this.AddRoom.Size = new System.Drawing.Size(75, 23);
            this.AddRoom.TabIndex = 3;
            this.AddRoom.Text = "Add";
            this.AddRoom.UseVisualStyleBackColor = true;
            this.AddRoom.Click += new System.EventHandler(this.AddRoom_Click);
            // 
            // DeleteRoom
            // 
            this.DeleteRoom.Location = new System.Drawing.Point(124, 256);
            this.DeleteRoom.Name = "DeleteRoom";
            this.DeleteRoom.Size = new System.Drawing.Size(75, 23);
            this.DeleteRoom.TabIndex = 4;
            this.DeleteRoom.Text = "Delete";
            this.DeleteRoom.UseVisualStyleBackColor = true;
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "WorldFiles(*json)|*.json";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "West of House",
            "North of House",
            "South of House",
            "Behind House"});
            this.comboBox1.Location = new System.Drawing.Point(43, 337);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 7;
            // 
            // richTextBox4
            // 
            this.richTextBox4.Location = new System.Drawing.Point(208, 337);
            this.richTextBox4.Name = "richTextBox4";
            this.richTextBox4.Size = new System.Drawing.Size(471, 24);
            this.richTextBox4.TabIndex = 9;
            this.richTextBox4.Text = "";
            // 
            // ZorkBuilder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 426);
            this.Controls.Add(this.richTextBox4);
            this.Controls.Add(WelcomeTextLabel);
            this.Controls.Add(StartingLocatinLabel);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(RoomInformation);
            this.Controls.Add(RoomListLabel);
            this.Controls.Add(this.DeleteRoom);
            this.Controls.Add(this.AddRoom);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.RoomListBox);
            this.Controls.Add(menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = menuStrip1;
            this.MaximizeBox = false;
            this.Name = "ZorkBuilder";
            this.Text = "Zork Builder";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox RoomListBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button AddRoom;
        private System.Windows.Forms.Button DeleteRoom;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.RichTextBox richTextBox4;
        private System.Windows.Forms.RichTextBox richTextBox5;
        private System.Windows.Forms.RichTextBox richTextBox6;
        private System.Windows.Forms.RichTextBox richTextBox7;
        private System.Windows.Forms.BindingSource roomsBindingSource;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}

