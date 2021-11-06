
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
            System.Windows.Forms.MenuStrip menuStrip;
            System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
            System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
            System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
            System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
            System.Windows.Forms.Label RoomNameLabel;
            System.Windows.Forms.Label RoomDescriptionLabel;
            System.Windows.Forms.Label NeighborsLabel;
            System.Windows.Forms.Label NorthLabel;
            System.Windows.Forms.Label SouthLabel;
            System.Windows.Forms.Label EastLabel;
            System.Windows.Forms.Label WestLabel;
            System.Windows.Forms.Label RoomListLabel;
            System.Windows.Forms.Label RoomInformation;
            System.Windows.Forms.Label StartingLocatinLabel;
            System.Windows.Forms.Label WelcomeTextLabel;
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RoomListBox = new System.Windows.Forms.ListBox();
            this.roomsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.roomInformationLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.roomDescriptionTextBox = new System.Windows.Forms.RichTextBox();
            this.northTextBox = new System.Windows.Forms.RichTextBox();
            this.roomNameTextBox = new System.Windows.Forms.RichTextBox();
            this.SouthTextBox = new System.Windows.Forms.RichTextBox();
            this.EastTextBox = new System.Windows.Forms.RichTextBox();
            this.westTextBox = new System.Windows.Forms.RichTextBox();
            this.AddRoomButton = new System.Windows.Forms.Button();
            this.DeleteRoomButton = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.startingLocationComboBox = new System.Windows.Forms.ComboBox();
            this.welcomeTextTextBox = new System.Windows.Forms.RichTextBox();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            menuStrip = new System.Windows.Forms.MenuStrip();
            fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            RoomNameLabel = new System.Windows.Forms.Label();
            RoomDescriptionLabel = new System.Windows.Forms.Label();
            NeighborsLabel = new System.Windows.Forms.Label();
            NorthLabel = new System.Windows.Forms.Label();
            SouthLabel = new System.Windows.Forms.Label();
            EastLabel = new System.Windows.Forms.Label();
            WestLabel = new System.Windows.Forms.Label();
            RoomListLabel = new System.Windows.Forms.Label();
            RoomInformation = new System.Windows.Forms.Label();
            StartingLocatinLabel = new System.Windows.Forms.Label();
            WelcomeTextLabel = new System.Windows.Forms.Label();
            menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).BeginInit();
            this.roomInformationLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.BackColor = System.Drawing.SystemColors.Info;
            menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            fileToolStripMenuItem,
            this.menuSaveToolStripMenuItem});
            menuStrip.Location = new System.Drawing.Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new System.Drawing.Size(728, 28);
            menuStrip.TabIndex = 0;
            menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            openToolStripMenuItem,
            toolStripMenuItem1,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            toolStripMenuItem2,
            this.closeToolStripMenuItem});
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            openToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            openToolStripMenuItem.Text = "&Open";
            openToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new System.Drawing.Size(221, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.saveToolStripMenuItem.Text = "&Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.S)));
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.saveAsToolStripMenuItem.Text = "Save As";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.SaveAsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new System.Drawing.Size(221, 6);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.closeToolStripMenuItem.Text = "E&xit";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.CloseToolStripMenuItem_Click);
            // 
            // menuSaveToolStripMenuItem
            // 
            this.menuSaveToolStripMenuItem.Name = "menuSaveToolStripMenuItem";
            this.menuSaveToolStripMenuItem.Size = new System.Drawing.Size(54, 24);
            this.menuSaveToolStripMenuItem.Text = "Save";
            this.menuSaveToolStripMenuItem.Click += new System.EventHandler(this.MenuSaveToolStripMenuItem_Click);
            // 
            // RoomNameLabel
            // 
            RoomNameLabel.AutoSize = true;
            RoomNameLabel.BackColor = System.Drawing.SystemColors.Control;
            RoomNameLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.roomInformationLayoutPanel.SetColumnSpan(RoomNameLabel, 2);
            RoomNameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            RoomNameLabel.Location = new System.Drawing.Point(3, 0);
            RoomNameLabel.Name = "RoomNameLabel";
            RoomNameLabel.Size = new System.Drawing.Size(182, 28);
            RoomNameLabel.TabIndex = 0;
            RoomNameLabel.Text = "Room Name";
            RoomNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RoomDescriptionLabel
            // 
            RoomDescriptionLabel.AutoSize = true;
            RoomDescriptionLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.roomInformationLayoutPanel.SetColumnSpan(RoomDescriptionLabel, 2);
            RoomDescriptionLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            RoomDescriptionLabel.Location = new System.Drawing.Point(3, 28);
            RoomDescriptionLabel.Name = "RoomDescriptionLabel";
            RoomDescriptionLabel.Size = new System.Drawing.Size(182, 61);
            RoomDescriptionLabel.TabIndex = 2;
            RoomDescriptionLabel.Text = "Room Description";
            RoomDescriptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NeighborsLabel
            // 
            NeighborsLabel.AutoSize = true;
            NeighborsLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            NeighborsLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            NeighborsLabel.Location = new System.Drawing.Point(3, 89);
            NeighborsLabel.Name = "NeighborsLabel";
            this.roomInformationLayoutPanel.SetRowSpan(NeighborsLabel, 4);
            NeighborsLabel.Size = new System.Drawing.Size(88, 116);
            NeighborsLabel.TabIndex = 4;
            NeighborsLabel.Text = "Neighbors";
            NeighborsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NorthLabel
            // 
            NorthLabel.AutoSize = true;
            NorthLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            NorthLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            NorthLabel.Location = new System.Drawing.Point(97, 89);
            NorthLabel.Name = "NorthLabel";
            NorthLabel.Size = new System.Drawing.Size(88, 28);
            NorthLabel.TabIndex = 5;
            NorthLabel.Text = "North";
            NorthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SouthLabel
            // 
            SouthLabel.AutoSize = true;
            SouthLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            SouthLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            SouthLabel.Location = new System.Drawing.Point(97, 117);
            SouthLabel.Name = "SouthLabel";
            SouthLabel.Size = new System.Drawing.Size(88, 28);
            SouthLabel.TabIndex = 7;
            SouthLabel.Text = "South";
            SouthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EastLabel
            // 
            EastLabel.AutoSize = true;
            EastLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            EastLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            EastLabel.Location = new System.Drawing.Point(97, 145);
            EastLabel.Name = "EastLabel";
            EastLabel.Size = new System.Drawing.Size(88, 28);
            EastLabel.TabIndex = 9;
            EastLabel.Text = "East";
            EastLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WestLabel
            // 
            WestLabel.AutoSize = true;
            WestLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            WestLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            WestLabel.Location = new System.Drawing.Point(97, 173);
            WestLabel.Name = "WestLabel";
            WestLabel.Size = new System.Drawing.Size(88, 32);
            WestLabel.TabIndex = 11;
            WestLabel.Text = "West";
            WestLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.RoomListBox.SelectedIndexChanged += new System.EventHandler(this.RoomListBox_SelectedIndexChanged);
            // 
            // roomsBindingSource
            // 
            this.roomsBindingSource.DataSource = typeof(Zork.Room);
            // 
            // roomInformationLayoutPanel
            // 
            this.roomInformationLayoutPanel.ColumnCount = 3;
            this.roomInformationLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.roomInformationLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.roomInformationLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.roomInformationLayoutPanel.Controls.Add(RoomNameLabel, 0, 0);
            this.roomInformationLayoutPanel.Controls.Add(RoomDescriptionLabel, 0, 1);
            this.roomInformationLayoutPanel.Controls.Add(this.roomDescriptionTextBox, 2, 1);
            this.roomInformationLayoutPanel.Controls.Add(NeighborsLabel, 0, 2);
            this.roomInformationLayoutPanel.Controls.Add(this.northTextBox, 2, 2);
            this.roomInformationLayoutPanel.Controls.Add(this.roomNameTextBox, 2, 0);
            this.roomInformationLayoutPanel.Controls.Add(NorthLabel, 1, 2);
            this.roomInformationLayoutPanel.Controls.Add(SouthLabel, 1, 3);
            this.roomInformationLayoutPanel.Controls.Add(this.SouthTextBox, 2, 3);
            this.roomInformationLayoutPanel.Controls.Add(EastLabel, 1, 4);
            this.roomInformationLayoutPanel.Controls.Add(this.EastTextBox, 2, 4);
            this.roomInformationLayoutPanel.Controls.Add(WestLabel, 1, 5);
            this.roomInformationLayoutPanel.Controls.Add(this.westTextBox, 2, 5);
            this.roomInformationLayoutPanel.Location = new System.Drawing.Point(205, 85);
            this.roomInformationLayoutPanel.Name = "roomInformationLayoutPanel";
            this.roomInformationLayoutPanel.RowCount = 6;
            this.roomInformationLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.roomInformationLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.roomInformationLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.roomInformationLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.roomInformationLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.roomInformationLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.roomInformationLayoutPanel.Size = new System.Drawing.Size(474, 205);
            this.roomInformationLayoutPanel.TabIndex = 2;
            // 
            // roomDescriptionTextBox
            // 
            this.roomDescriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.roomsBindingSource, "Description", true));
            this.roomDescriptionTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roomDescriptionTextBox.Location = new System.Drawing.Point(191, 31);
            this.roomDescriptionTextBox.Name = "roomDescriptionTextBox";
            this.roomDescriptionTextBox.Size = new System.Drawing.Size(280, 55);
            this.roomDescriptionTextBox.TabIndex = 3;
            this.roomDescriptionTextBox.Text = "";
            // 
            // northTextBox
            // 
            this.northTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.northTextBox.Location = new System.Drawing.Point(191, 92);
            this.northTextBox.Name = "northTextBox";
            this.northTextBox.Size = new System.Drawing.Size(280, 22);
            this.northTextBox.TabIndex = 6;
            this.northTextBox.Text = "";
            // 
            // roomNameTextBox
            // 
            this.roomNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.roomsBindingSource, "Name", true));
            this.roomNameTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roomNameTextBox.Location = new System.Drawing.Point(191, 3);
            this.roomNameTextBox.Name = "roomNameTextBox";
            this.roomNameTextBox.Size = new System.Drawing.Size(280, 22);
            this.roomNameTextBox.TabIndex = 1;
            this.roomNameTextBox.Text = "";
            // 
            // SouthTextBox
            // 
            this.SouthTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SouthTextBox.Location = new System.Drawing.Point(191, 120);
            this.SouthTextBox.Name = "SouthTextBox";
            this.SouthTextBox.Size = new System.Drawing.Size(280, 22);
            this.SouthTextBox.TabIndex = 8;
            this.SouthTextBox.Text = "";
            // 
            // EastTextBox
            // 
            this.EastTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EastTextBox.Location = new System.Drawing.Point(191, 148);
            this.EastTextBox.Name = "EastTextBox";
            this.EastTextBox.Size = new System.Drawing.Size(280, 22);
            this.EastTextBox.TabIndex = 10;
            this.EastTextBox.Text = "";
            // 
            // westTextBox
            // 
            this.westTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.westTextBox.Location = new System.Drawing.Point(191, 176);
            this.westTextBox.Name = "westTextBox";
            this.westTextBox.Size = new System.Drawing.Size(280, 26);
            this.westTextBox.TabIndex = 12;
            this.westTextBox.Text = "";
            // 
            // AddRoomButton
            // 
            this.AddRoomButton.Location = new System.Drawing.Point(43, 256);
            this.AddRoomButton.Name = "AddRoomButton";
            this.AddRoomButton.Size = new System.Drawing.Size(75, 23);
            this.AddRoomButton.TabIndex = 3;
            this.AddRoomButton.Text = "Add";
            this.AddRoomButton.UseVisualStyleBackColor = true;
            this.AddRoomButton.Click += new System.EventHandler(this.AddRoom_Click);
            // 
            // DeleteRoomButton
            // 
            this.DeleteRoomButton.Location = new System.Drawing.Point(124, 256);
            this.DeleteRoomButton.Name = "DeleteRoomButton";
            this.DeleteRoomButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteRoomButton.TabIndex = 4;
            this.DeleteRoomButton.Text = "Delete";
            this.DeleteRoomButton.UseVisualStyleBackColor = true;
            this.DeleteRoomButton.Click += new System.EventHandler(this.DeleteRoomButton_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "JSON Files|*.json";
            // 
            // startingLocationComboBox
            // 
            this.startingLocationComboBox.FormattingEnabled = true;
            this.startingLocationComboBox.Items.AddRange(new object[] {
            "West of House",
            "North of House",
            "South of House",
            "Behind House"});
            this.startingLocationComboBox.Location = new System.Drawing.Point(43, 337);
            this.startingLocationComboBox.Name = "startingLocationComboBox";
            this.startingLocationComboBox.Size = new System.Drawing.Size(121, 24);
            this.startingLocationComboBox.TabIndex = 7;
            // 
            // welcomeTextTextBox
            // 
            this.welcomeTextTextBox.Location = new System.Drawing.Point(208, 337);
            this.welcomeTextTextBox.Name = "welcomeTextTextBox";
            this.welcomeTextTextBox.Size = new System.Drawing.Size(471, 24);
            this.welcomeTextTextBox.TabIndex = 9;
            this.welcomeTextTextBox.Text = "";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "JSON Files|*.json";
            // 
            // ZorkBuilder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 426);
            this.Controls.Add(this.welcomeTextTextBox);
            this.Controls.Add(WelcomeTextLabel);
            this.Controls.Add(StartingLocatinLabel);
            this.Controls.Add(this.startingLocationComboBox);
            this.Controls.Add(RoomInformation);
            this.Controls.Add(RoomListLabel);
            this.Controls.Add(this.DeleteRoomButton);
            this.Controls.Add(this.AddRoomButton);
            this.Controls.Add(this.roomInformationLayoutPanel);
            this.Controls.Add(this.RoomListBox);
            this.Controls.Add(menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = menuStrip;
            this.MaximizeBox = false;
            this.Name = "ZorkBuilder";
            this.Text = "Zork Builder";
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).EndInit();
            this.roomInformationLayoutPanel.ResumeLayout(false);
            this.roomInformationLayoutPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox RoomListBox;
        private System.Windows.Forms.TableLayoutPanel roomInformationLayoutPanel;
        private System.Windows.Forms.Button AddRoomButton;
        private System.Windows.Forms.Button DeleteRoomButton;
        private System.Windows.Forms.RichTextBox roomDescriptionTextBox;
        private System.Windows.Forms.RichTextBox northTextBox;
        private System.Windows.Forms.RichTextBox roomNameTextBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ComboBox startingLocationComboBox;
        private System.Windows.Forms.RichTextBox welcomeTextTextBox;
        private System.Windows.Forms.RichTextBox SouthTextBox;
        private System.Windows.Forms.RichTextBox EastTextBox;
        private System.Windows.Forms.RichTextBox westTextBox;
        private System.Windows.Forms.BindingSource roomsBindingSource;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuSaveToolStripMenuItem;
    }
}

