
namespace RiotAPIAplication
{
    partial class LeagueOfLegendAPIForm
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
            System.Windows.Forms.Label summonerNameInputLabel;
            System.Windows.Forms.Label aPISummonerNameResultsLabel;
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aPICodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.summonerInputsTabControl = new System.Windows.Forms.TabControl();
            this.summonersNameTabPage = new System.Windows.Forms.TabPage();
            this.summonersNameInputButton = new System.Windows.Forms.Button();
            this.aPISummonerNameResultsRichTextBox = new System.Windows.Forms.RichTextBox();
            this.summonersNameInputTextBox = new System.Windows.Forms.TextBox();
            this.puuidInputTabPage = new System.Windows.Forms.TabPage();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.accountDetailsLabel = new System.Windows.Forms.Label();
            this.puuidAccountInputLabel = new System.Windows.Forms.Label();
            this.puuidAccountInputTextBox = new System.Windows.Forms.TextBox();
            this.matchInformationGroupBox = new System.Windows.Forms.GroupBox();
            this.matchinformationTabControl = new System.Windows.Forms.TabControl();
            this.puuidMatchTabPage = new System.Windows.Forms.TabPage();
            this.matchListRichTextBox = new System.Windows.Forms.RichTextBox();
            this.puuidSummonerInputLabel = new System.Windows.Forms.Label();
            this.matchListLabel = new System.Windows.Forms.Label();
            this.puuidMatchInputTextBox1 = new System.Windows.Forms.TextBox();
            this.matchDetailTabPage = new System.Windows.Forms.TabPage();
            this.matchDetailRichTextBox = new System.Windows.Forms.RichTextBox();
            this.matchInputTextBox = new System.Windows.Forms.TextBox();
            this.matchDetailslabel = new System.Windows.Forms.Label();
            this.matchInputLabel = new System.Windows.Forms.Label();
            this.accountInputGroupBox = new System.Windows.Forms.GroupBox();
            this.puuidAccountInputButton = new System.Windows.Forms.Button();
            this.puuidMatchInputButton = new System.Windows.Forms.Button();
            this.matchInputButton = new System.Windows.Forms.Button();
            this.aPICodeTextBox = new System.Windows.Forms.ToolStripTextBox();
            summonerNameInputLabel = new System.Windows.Forms.Label();
            aPISummonerNameResultsLabel = new System.Windows.Forms.Label();
            this.menuStrip.SuspendLayout();
            this.summonerInputsTabControl.SuspendLayout();
            this.summonersNameTabPage.SuspendLayout();
            this.puuidInputTabPage.SuspendLayout();
            this.matchInformationGroupBox.SuspendLayout();
            this.matchinformationTabControl.SuspendLayout();
            this.puuidMatchTabPage.SuspendLayout();
            this.matchDetailTabPage.SuspendLayout();
            this.accountInputGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // summonerNameInputLabel
            // 
            summonerNameInputLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            summonerNameInputLabel.AutoSize = true;
            summonerNameInputLabel.Location = new System.Drawing.Point(6, 3);
            summonerNameInputLabel.Name = "summonerNameInputLabel";
            summonerNameInputLabel.Size = new System.Drawing.Size(152, 17);
            summonerNameInputLabel.TabIndex = 3;
            summonerNameInputLabel.Text = "Summoner Name Input";
            // 
            // aPISummonerNameResultsLabel
            // 
            aPISummonerNameResultsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            aPISummonerNameResultsLabel.AutoSize = true;
            aPISummonerNameResultsLabel.Location = new System.Drawing.Point(6, 59);
            aPISummonerNameResultsLabel.Name = "aPISummonerNameResultsLabel";
            aPISummonerNameResultsLabel.Size = new System.Drawing.Size(106, 17);
            aPISummonerNameResultsLabel.TabIndex = 4;
            aPISummonerNameResultsLabel.Text = "Account Details";
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(800, 28);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aPICodeToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(76, 24);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // aPICodeToolStripMenuItem
            // 
            this.aPICodeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aPICodeTextBox});
            this.aPICodeToolStripMenuItem.Name = "aPICodeToolStripMenuItem";
            this.aPICodeToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.aPICodeToolStripMenuItem.Text = "API Key";
            // 
            // summonerInputsTabControl
            // 
            this.summonerInputsTabControl.Controls.Add(this.summonersNameTabPage);
            this.summonerInputsTabControl.Controls.Add(this.puuidInputTabPage);
            this.summonerInputsTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.summonerInputsTabControl.Location = new System.Drawing.Point(3, 18);
            this.summonerInputsTabControl.Name = "summonerInputsTabControl";
            this.summonerInputsTabControl.SelectedIndex = 0;
            this.summonerInputsTabControl.Size = new System.Drawing.Size(322, 412);
            this.summonerInputsTabControl.TabIndex = 1;
            // 
            // summonersNameTabPage
            // 
            this.summonersNameTabPage.Controls.Add(this.summonersNameInputButton);
            this.summonersNameTabPage.Controls.Add(aPISummonerNameResultsLabel);
            this.summonersNameTabPage.Controls.Add(summonerNameInputLabel);
            this.summonersNameTabPage.Controls.Add(this.aPISummonerNameResultsRichTextBox);
            this.summonersNameTabPage.Controls.Add(this.summonersNameInputTextBox);
            this.summonersNameTabPage.Location = new System.Drawing.Point(4, 25);
            this.summonersNameTabPage.Name = "summonersNameTabPage";
            this.summonersNameTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.summonersNameTabPage.Size = new System.Drawing.Size(314, 383);
            this.summonersNameTabPage.TabIndex = 0;
            this.summonersNameTabPage.Text = "Summoner\'s Name";
            this.summonersNameTabPage.UseVisualStyleBackColor = true;
            // 
            // summonersNameInputButton
            // 
            this.summonersNameInputButton.Location = new System.Drawing.Point(217, 23);
            this.summonersNameInputButton.Name = "summonersNameInputButton";
            this.summonersNameInputButton.Size = new System.Drawing.Size(75, 23);
            this.summonersNameInputButton.TabIndex = 7;
            this.summonersNameInputButton.Text = "Submit";
            this.summonersNameInputButton.UseVisualStyleBackColor = true;
            this.summonersNameInputButton.Click += new System.EventHandler(this.summonersNameInputButton_Click);
            // 
            // aPISummonerNameResultsRichTextBox
            // 
            this.aPISummonerNameResultsRichTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.aPISummonerNameResultsRichTextBox.Location = new System.Drawing.Point(9, 79);
            this.aPISummonerNameResultsRichTextBox.Name = "aPISummonerNameResultsRichTextBox";
            this.aPISummonerNameResultsRichTextBox.Size = new System.Drawing.Size(288, 294);
            this.aPISummonerNameResultsRichTextBox.TabIndex = 2;
            this.aPISummonerNameResultsRichTextBox.Text = "";
            // 
            // summonersNameInputTextBox
            // 
            this.summonersNameInputTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.summonersNameInputTextBox.Location = new System.Drawing.Point(9, 23);
            this.summonersNameInputTextBox.Name = "summonersNameInputTextBox";
            this.summonersNameInputTextBox.Size = new System.Drawing.Size(180, 22);
            this.summonersNameInputTextBox.TabIndex = 0;
            this.summonersNameInputTextBox.TextChanged += new System.EventHandler(this.summonersNameInputTextBox_TextChanged);
            // 
            // puuidInputTabPage
            // 
            this.puuidInputTabPage.Controls.Add(this.puuidAccountInputButton);
            this.puuidInputTabPage.Controls.Add(this.richTextBox2);
            this.puuidInputTabPage.Controls.Add(this.accountDetailsLabel);
            this.puuidInputTabPage.Controls.Add(this.puuidAccountInputLabel);
            this.puuidInputTabPage.Controls.Add(this.puuidAccountInputTextBox);
            this.puuidInputTabPage.Location = new System.Drawing.Point(4, 25);
            this.puuidInputTabPage.Name = "puuidInputTabPage";
            this.puuidInputTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.puuidInputTabPage.Size = new System.Drawing.Size(314, 383);
            this.puuidInputTabPage.TabIndex = 1;
            this.puuidInputTabPage.Text = "puuid Input";
            this.puuidInputTabPage.UseVisualStyleBackColor = true;
            // 
            // richTextBox2
            // 
            this.richTextBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox2.Location = new System.Drawing.Point(9, 79);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(288, 294);
            this.richTextBox2.TabIndex = 3;
            this.richTextBox2.Text = "";
            // 
            // accountDetailsLabel
            // 
            this.accountDetailsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.accountDetailsLabel.AutoSize = true;
            this.accountDetailsLabel.Location = new System.Drawing.Point(6, 59);
            this.accountDetailsLabel.Name = "accountDetailsLabel";
            this.accountDetailsLabel.Size = new System.Drawing.Size(106, 17);
            this.accountDetailsLabel.TabIndex = 2;
            this.accountDetailsLabel.Text = "Account Details";
            // 
            // puuidAccountInputLabel
            // 
            this.puuidAccountInputLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.puuidAccountInputLabel.AutoSize = true;
            this.puuidAccountInputLabel.Location = new System.Drawing.Point(6, 3);
            this.puuidAccountInputLabel.Name = "puuidAccountInputLabel";
            this.puuidAccountInputLabel.Size = new System.Drawing.Size(78, 17);
            this.puuidAccountInputLabel.TabIndex = 1;
            this.puuidAccountInputLabel.Text = "puuid Input";
            // 
            // puuidAccountInputTextBox
            // 
            this.puuidAccountInputTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.puuidAccountInputTextBox.Location = new System.Drawing.Point(9, 23);
            this.puuidAccountInputTextBox.Name = "puuidAccountInputTextBox";
            this.puuidAccountInputTextBox.Size = new System.Drawing.Size(180, 22);
            this.puuidAccountInputTextBox.TabIndex = 0;
            this.puuidAccountInputTextBox.TextChanged += new System.EventHandler(this.puuidAccountInputTextBox_TextChanged);
            // 
            // matchInformationGroupBox
            // 
            this.matchInformationGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.matchInformationGroupBox.AutoSize = true;
            this.matchInformationGroupBox.Controls.Add(this.matchinformationTabControl);
            this.matchInformationGroupBox.Location = new System.Drawing.Point(373, 41);
            this.matchInformationGroupBox.Name = "matchInformationGroupBox";
            this.matchInformationGroupBox.Size = new System.Drawing.Size(415, 433);
            this.matchInformationGroupBox.TabIndex = 5;
            this.matchInformationGroupBox.TabStop = false;
            this.matchInformationGroupBox.Text = "Match Information";
            // 
            // matchinformationTabControl
            // 
            this.matchinformationTabControl.Controls.Add(this.puuidMatchTabPage);
            this.matchinformationTabControl.Controls.Add(this.matchDetailTabPage);
            this.matchinformationTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.matchinformationTabControl.Location = new System.Drawing.Point(3, 18);
            this.matchinformationTabControl.Name = "matchinformationTabControl";
            this.matchinformationTabControl.SelectedIndex = 0;
            this.matchinformationTabControl.Size = new System.Drawing.Size(409, 412);
            this.matchinformationTabControl.TabIndex = 3;
            // 
            // puuidMatchTabPage
            // 
            this.puuidMatchTabPage.Controls.Add(this.puuidMatchInputButton);
            this.puuidMatchTabPage.Controls.Add(this.matchListRichTextBox);
            this.puuidMatchTabPage.Controls.Add(this.puuidSummonerInputLabel);
            this.puuidMatchTabPage.Controls.Add(this.matchListLabel);
            this.puuidMatchTabPage.Controls.Add(this.puuidMatchInputTextBox1);
            this.puuidMatchTabPage.Location = new System.Drawing.Point(4, 25);
            this.puuidMatchTabPage.Name = "puuidMatchTabPage";
            this.puuidMatchTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.puuidMatchTabPage.Size = new System.Drawing.Size(401, 383);
            this.puuidMatchTabPage.TabIndex = 0;
            this.puuidMatchTabPage.Text = "puuid Input";
            this.puuidMatchTabPage.UseVisualStyleBackColor = true;
            // 
            // matchListRichTextBox
            // 
            this.matchListRichTextBox.Location = new System.Drawing.Point(9, 79);
            this.matchListRichTextBox.Name = "matchListRichTextBox";
            this.matchListRichTextBox.Size = new System.Drawing.Size(387, 294);
            this.matchListRichTextBox.TabIndex = 3;
            this.matchListRichTextBox.Text = "";
            // 
            // puuidSummonerInputLabel
            // 
            this.puuidSummonerInputLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.puuidSummonerInputLabel.AutoSize = true;
            this.puuidSummonerInputLabel.Location = new System.Drawing.Point(6, 3);
            this.puuidSummonerInputLabel.Name = "puuidSummonerInputLabel";
            this.puuidSummonerInputLabel.Size = new System.Drawing.Size(150, 17);
            this.puuidSummonerInputLabel.TabIndex = 0;
            this.puuidSummonerInputLabel.Text = "puuid Summoner Input";
            // 
            // matchListLabel
            // 
            this.matchListLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.matchListLabel.AutoSize = true;
            this.matchListLabel.Location = new System.Drawing.Point(6, 59);
            this.matchListLabel.Name = "matchListLabel";
            this.matchListLabel.Size = new System.Drawing.Size(72, 17);
            this.matchListLabel.TabIndex = 1;
            this.matchListLabel.Text = "Match List";
            // 
            // puuidMatchInputTextBox1
            // 
            this.puuidMatchInputTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.puuidMatchInputTextBox1.Location = new System.Drawing.Point(9, 23);
            this.puuidMatchInputTextBox1.Name = "puuidMatchInputTextBox1";
            this.puuidMatchInputTextBox1.Size = new System.Drawing.Size(180, 22);
            this.puuidMatchInputTextBox1.TabIndex = 2;
            this.puuidMatchInputTextBox1.TextChanged += new System.EventHandler(this.puuidMatchInputTextBox1_TextChanged);
            // 
            // matchDetailTabPage
            // 
            this.matchDetailTabPage.Controls.Add(this.matchInputButton);
            this.matchDetailTabPage.Controls.Add(this.matchDetailRichTextBox);
            this.matchDetailTabPage.Controls.Add(this.matchInputTextBox);
            this.matchDetailTabPage.Controls.Add(this.matchDetailslabel);
            this.matchDetailTabPage.Controls.Add(this.matchInputLabel);
            this.matchDetailTabPage.Location = new System.Drawing.Point(4, 25);
            this.matchDetailTabPage.Name = "matchDetailTabPage";
            this.matchDetailTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.matchDetailTabPage.Size = new System.Drawing.Size(401, 383);
            this.matchDetailTabPage.TabIndex = 1;
            this.matchDetailTabPage.Text = "Match Details";
            this.matchDetailTabPage.UseVisualStyleBackColor = true;
            // 
            // matchDetailRichTextBox
            // 
            this.matchDetailRichTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.matchDetailRichTextBox.Location = new System.Drawing.Point(9, 79);
            this.matchDetailRichTextBox.Name = "matchDetailRichTextBox";
            this.matchDetailRichTextBox.Size = new System.Drawing.Size(387, 304);
            this.matchDetailRichTextBox.TabIndex = 3;
            this.matchDetailRichTextBox.Text = "";
            // 
            // matchInputTextBox
            // 
            this.matchInputTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.matchInputTextBox.Location = new System.Drawing.Point(9, 23);
            this.matchInputTextBox.Name = "matchInputTextBox";
            this.matchInputTextBox.Size = new System.Drawing.Size(180, 22);
            this.matchInputTextBox.TabIndex = 2;
            this.matchInputTextBox.TextChanged += new System.EventHandler(this.matchInputTextBox_TextChanged);
            // 
            // matchDetailslabel
            // 
            this.matchDetailslabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.matchDetailslabel.AutoSize = true;
            this.matchDetailslabel.Location = new System.Drawing.Point(6, 55);
            this.matchDetailslabel.Name = "matchDetailslabel";
            this.matchDetailslabel.Size = new System.Drawing.Size(93, 17);
            this.matchDetailslabel.TabIndex = 1;
            this.matchDetailslabel.Text = "Match Details";
            // 
            // matchInputLabel
            // 
            this.matchInputLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.matchInputLabel.AutoSize = true;
            this.matchInputLabel.Location = new System.Drawing.Point(6, 3);
            this.matchInputLabel.Name = "matchInputLabel";
            this.matchInputLabel.Size = new System.Drawing.Size(81, 17);
            this.matchInputLabel.TabIndex = 0;
            this.matchInputLabel.Text = "Match Input";
            // 
            // accountInputGroupBox
            // 
            this.accountInputGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.accountInputGroupBox.AutoSize = true;
            this.accountInputGroupBox.Controls.Add(this.summonerInputsTabControl);
            this.accountInputGroupBox.Location = new System.Drawing.Point(39, 41);
            this.accountInputGroupBox.Name = "accountInputGroupBox";
            this.accountInputGroupBox.Size = new System.Drawing.Size(328, 433);
            this.accountInputGroupBox.TabIndex = 6;
            this.accountInputGroupBox.TabStop = false;
            this.accountInputGroupBox.Text = "Account Input";
            // 
            // puuidAccountInputButton
            // 
            this.puuidAccountInputButton.Location = new System.Drawing.Point(217, 23);
            this.puuidAccountInputButton.Name = "puuidAccountInputButton";
            this.puuidAccountInputButton.Size = new System.Drawing.Size(75, 23);
            this.puuidAccountInputButton.TabIndex = 6;
            this.puuidAccountInputButton.Text = "Submit";
            this.puuidAccountInputButton.UseVisualStyleBackColor = true;
            this.puuidAccountInputButton.Click += new System.EventHandler(this.puuidAccountInputButton_Click);
            // 
            // puuidMatchInputButton
            // 
            this.puuidMatchInputButton.Location = new System.Drawing.Point(217, 23);
            this.puuidMatchInputButton.Name = "puuidMatchInputButton";
            this.puuidMatchInputButton.Size = new System.Drawing.Size(75, 23);
            this.puuidMatchInputButton.TabIndex = 4;
            this.puuidMatchInputButton.Text = "Submit";
            this.puuidMatchInputButton.UseVisualStyleBackColor = true;
            this.puuidMatchInputButton.Click += new System.EventHandler(this.puuidMatchInputButton_Click);
            // 
            // matchInputButton
            // 
            this.matchInputButton.Location = new System.Drawing.Point(217, 23);
            this.matchInputButton.Name = "matchInputButton";
            this.matchInputButton.Size = new System.Drawing.Size(75, 23);
            this.matchInputButton.TabIndex = 4;
            this.matchInputButton.Text = "Submit";
            this.matchInputButton.UseVisualStyleBackColor = true;
            this.matchInputButton.Click += new System.EventHandler(this.matchInputButton_Click);
            // 
            // aPICodeTextBox
            // 
            this.aPICodeTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.aPICodeTextBox.Name = "aPICodeTextBox";
            this.aPICodeTextBox.Size = new System.Drawing.Size(100, 27);
            this.aPICodeTextBox.Click += new System.EventHandler(this.aPICodeTextBox_Click);
            // 
            // LeagueOfLegendAPIForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 486);
            this.Controls.Add(this.accountInputGroupBox);
            this.Controls.Add(this.matchInformationGroupBox);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "LeagueOfLegendAPIForm";
            this.Text = "LeagueOfLegendAPIForm";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.summonerInputsTabControl.ResumeLayout(false);
            this.summonersNameTabPage.ResumeLayout(false);
            this.summonersNameTabPage.PerformLayout();
            this.puuidInputTabPage.ResumeLayout(false);
            this.puuidInputTabPage.PerformLayout();
            this.matchInformationGroupBox.ResumeLayout(false);
            this.matchinformationTabControl.ResumeLayout(false);
            this.puuidMatchTabPage.ResumeLayout(false);
            this.puuidMatchTabPage.PerformLayout();
            this.matchDetailTabPage.ResumeLayout(false);
            this.matchDetailTabPage.PerformLayout();
            this.accountInputGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aPICodeToolStripMenuItem;
        private System.Windows.Forms.TabControl summonerInputsTabControl;
        private System.Windows.Forms.TabPage summonersNameTabPage;
        private System.Windows.Forms.RichTextBox aPISummonerNameResultsRichTextBox;
        private System.Windows.Forms.TextBox summonersNameInputTextBox;
        private System.Windows.Forms.TabPage puuidInputTabPage;
        private System.Windows.Forms.TextBox puuidAccountInputTextBox;
        private System.Windows.Forms.GroupBox matchInformationGroupBox;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Label accountDetailsLabel;
        private System.Windows.Forms.Label puuidAccountInputLabel;
        private System.Windows.Forms.TabControl matchinformationTabControl;
        private System.Windows.Forms.TabPage puuidMatchTabPage;
        private System.Windows.Forms.RichTextBox matchListRichTextBox;
        private System.Windows.Forms.Label puuidSummonerInputLabel;
        private System.Windows.Forms.Label matchListLabel;
        private System.Windows.Forms.TextBox puuidMatchInputTextBox1;
        private System.Windows.Forms.TabPage matchDetailTabPage;
        private System.Windows.Forms.RichTextBox matchDetailRichTextBox;
        private System.Windows.Forms.TextBox matchInputTextBox;
        private System.Windows.Forms.Label matchDetailslabel;
        private System.Windows.Forms.Label matchInputLabel;
        private System.Windows.Forms.GroupBox accountInputGroupBox;
        private System.Windows.Forms.Button summonersNameInputButton;
        private System.Windows.Forms.Button puuidAccountInputButton;
        private System.Windows.Forms.Button puuidMatchInputButton;
        private System.Windows.Forms.Button matchInputButton;
        private System.Windows.Forms.ToolStripTextBox aPICodeTextBox;
    }
}

