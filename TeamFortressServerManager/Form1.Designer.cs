namespace TeamFortressServerManager
{
    partial class Form1
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
            this.serverOptionsGroupBox = new System.Windows.Forms.GroupBox();
            this.startButton = new System.Windows.Forms.Button();
            this.pauseButton = new System.Windows.Forms.Button();
            this.shutdownButton = new System.Windows.Forms.Button();
            this.restartButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.systemGroupBox = new System.Windows.Forms.GroupBox();
            this.commandSubmitButton = new System.Windows.Forms.Button();
            this.commandInputTextBox = new System.Windows.Forms.TextBox();
            this.networkGroupBox = new System.Windows.Forms.GroupBox();
            this.proxyLabel = new System.Windows.Forms.Label();
            this.proxyTitleLabel = new System.Windows.Forms.Label();
            this.portStatusLabel = new System.Windows.Forms.Label();
            this.portStatusTitleLabel = new System.Windows.Forms.Label();
            this.copyClientPortButton = new System.Windows.Forms.Button();
            this.copyServerPortButton = new System.Windows.Forms.Button();
            this.copyExternalIPButton = new System.Windows.Forms.Button();
            this.copyLocalIPButton = new System.Windows.Forms.Button();
            this.testSpeedButton = new System.Windows.Forms.Button();
            this.pingLabel = new System.Windows.Forms.Label();
            this.uploadSpeedLabel = new System.Windows.Forms.Label();
            this.downloadSpeedLabel = new System.Windows.Forms.Label();
            this.pingTitleLabel = new System.Windows.Forms.Label();
            this.uploadSpeedTitleLabel = new System.Windows.Forms.Label();
            this.downloadSpeedTitleLabel = new System.Windows.Forms.Label();
            this.clientPortLabel = new System.Windows.Forms.Label();
            this.clientPortTitleLabel = new System.Windows.Forms.Label();
            this.networkRefreshButton = new System.Windows.Forms.Button();
            this.serverPortLabel = new System.Windows.Forms.Label();
            this.serverPortTitleLabel = new System.Windows.Forms.Label();
            this.externalIpLabel = new System.Windows.Forms.Label();
            this.localIpLabel = new System.Windows.Forms.Label();
            this.externalIpTitleLabel = new System.Windows.Forms.Label();
            this.localIpTitleLabel = new System.Windows.Forms.Label();
            this.gameDetailsGroupBox = new System.Windows.Forms.GroupBox();
            this.gameDetailsRefreshButton = new System.Windows.Forms.Button();
            this.serverDirectoryLabel = new System.Windows.Forms.Label();
            this.serverDirectoryTitleLabel = new System.Windows.Forms.Label();
            this.maxPlayersLabel = new System.Windows.Forms.Label();
            this.maxPlayersTitleLabel = new System.Windows.Forms.Label();
            this.currMapLabel = new System.Windows.Forms.Label();
            this.currMapTitleLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statusStripLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.updateGrupBox = new System.Windows.Forms.GroupBox();
            this.updateRemainingSizeLabel = new System.Windows.Forms.Label();
            this.updateSizeLabel = new System.Windows.Forms.Label();
            this.updateElapsedLabel = new System.Windows.Forms.Label();
            this.updateSpeedLabel = new System.Windows.Forms.Label();
            this.updateDoneLabel = new System.Windows.Forms.Label();
            this.updateRemainingTimeLabel = new System.Windows.Forms.Label();
            this.updateElapsedTitleLabel = new System.Windows.Forms.Label();
            this.updatePercentLabel = new System.Windows.Forms.Label();
            this.updateRemainingTimeTitleLabel = new System.Windows.Forms.Label();
            this.updateRemainingSizeTitleLabel = new System.Windows.Forms.Label();
            this.updateDoneTitleLabel = new System.Windows.Forms.Label();
            this.updateSizeTitleLabel = new System.Windows.Forms.Label();
            this.updateSeepTitleLabel = new System.Windows.Forms.Label();
            this.updateProgressBar = new System.Windows.Forms.ProgressBar();
            this.logTextBox = new System.Windows.Forms.TextBox();
            this.propertiesListBox = new System.Windows.Forms.ListBox();
            this.newPropertyTextBox = new System.Windows.Forms.TextBox();
            this.serverPropertiesGroupBox = new System.Windows.Forms.GroupBox();
            this.addPropertyButton = new System.Windows.Forms.Button();
            this.serverLogGroupBox = new System.Windows.Forms.GroupBox();
            this.serverOptionsGroupBox.SuspendLayout();
            this.networkGroupBox.SuspendLayout();
            this.gameDetailsGroupBox.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.updateGrupBox.SuspendLayout();
            this.serverPropertiesGroupBox.SuspendLayout();
            this.serverLogGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // serverOptionsGroupBox
            // 
            this.serverOptionsGroupBox.Controls.Add(this.startButton);
            this.serverOptionsGroupBox.Controls.Add(this.pauseButton);
            this.serverOptionsGroupBox.Controls.Add(this.shutdownButton);
            this.serverOptionsGroupBox.Controls.Add(this.restartButton);
            this.serverOptionsGroupBox.Location = new System.Drawing.Point(712, 204);
            this.serverOptionsGroupBox.Name = "serverOptionsGroupBox";
            this.serverOptionsGroupBox.Size = new System.Drawing.Size(394, 69);
            this.serverOptionsGroupBox.TabIndex = 17;
            this.serverOptionsGroupBox.TabStop = false;
            this.serverOptionsGroupBox.Text = "Server Options";
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(39, 29);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 18;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // pauseButton
            // 
            this.pauseButton.Location = new System.Drawing.Point(120, 29);
            this.pauseButton.Name = "pauseButton";
            this.pauseButton.Size = new System.Drawing.Size(75, 23);
            this.pauseButton.TabIndex = 21;
            this.pauseButton.Text = "Pause";
            this.pauseButton.UseVisualStyleBackColor = true;
            // 
            // shutdownButton
            // 
            this.shutdownButton.Location = new System.Drawing.Point(281, 29);
            this.shutdownButton.Name = "shutdownButton";
            this.shutdownButton.Size = new System.Drawing.Size(75, 23);
            this.shutdownButton.TabIndex = 19;
            this.shutdownButton.Text = "Shutdown";
            this.shutdownButton.UseVisualStyleBackColor = true;
            // 
            // restartButton
            // 
            this.restartButton.Location = new System.Drawing.Point(200, 29);
            this.restartButton.Name = "restartButton";
            this.restartButton.Size = new System.Drawing.Size(75, 23);
            this.restartButton.TabIndex = 20;
            this.restartButton.Text = "Restart";
            this.restartButton.UseVisualStyleBackColor = true;
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(164, 19);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(75, 23);
            this.updateButton.TabIndex = 2;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // systemGroupBox
            // 
            this.systemGroupBox.Location = new System.Drawing.Point(712, 279);
            this.systemGroupBox.Name = "systemGroupBox";
            this.systemGroupBox.Size = new System.Drawing.Size(394, 91);
            this.systemGroupBox.TabIndex = 22;
            this.systemGroupBox.TabStop = false;
            this.systemGroupBox.Text = "System";
            // 
            // commandSubmitButton
            // 
            this.commandSubmitButton.Location = new System.Drawing.Point(311, 375);
            this.commandSubmitButton.Name = "commandSubmitButton";
            this.commandSubmitButton.Size = new System.Drawing.Size(82, 23);
            this.commandSubmitButton.TabIndex = 25;
            this.commandSubmitButton.Text = "Submit";
            this.commandSubmitButton.UseVisualStyleBackColor = true;
            // 
            // commandInputTextBox
            // 
            this.commandInputTextBox.Location = new System.Drawing.Point(13, 377);
            this.commandInputTextBox.Name = "commandInputTextBox";
            this.commandInputTextBox.Size = new System.Drawing.Size(292, 20);
            this.commandInputTextBox.TabIndex = 24;
            // 
            // networkGroupBox
            // 
            this.networkGroupBox.Controls.Add(this.proxyLabel);
            this.networkGroupBox.Controls.Add(this.proxyTitleLabel);
            this.networkGroupBox.Controls.Add(this.portStatusLabel);
            this.networkGroupBox.Controls.Add(this.portStatusTitleLabel);
            this.networkGroupBox.Controls.Add(this.copyClientPortButton);
            this.networkGroupBox.Controls.Add(this.copyServerPortButton);
            this.networkGroupBox.Controls.Add(this.copyExternalIPButton);
            this.networkGroupBox.Controls.Add(this.copyLocalIPButton);
            this.networkGroupBox.Controls.Add(this.testSpeedButton);
            this.networkGroupBox.Controls.Add(this.pingLabel);
            this.networkGroupBox.Controls.Add(this.uploadSpeedLabel);
            this.networkGroupBox.Controls.Add(this.downloadSpeedLabel);
            this.networkGroupBox.Controls.Add(this.pingTitleLabel);
            this.networkGroupBox.Controls.Add(this.uploadSpeedTitleLabel);
            this.networkGroupBox.Controls.Add(this.downloadSpeedTitleLabel);
            this.networkGroupBox.Controls.Add(this.clientPortLabel);
            this.networkGroupBox.Controls.Add(this.clientPortTitleLabel);
            this.networkGroupBox.Controls.Add(this.networkRefreshButton);
            this.networkGroupBox.Controls.Add(this.serverPortLabel);
            this.networkGroupBox.Controls.Add(this.serverPortTitleLabel);
            this.networkGroupBox.Controls.Add(this.externalIpLabel);
            this.networkGroupBox.Controls.Add(this.localIpLabel);
            this.networkGroupBox.Controls.Add(this.externalIpTitleLabel);
            this.networkGroupBox.Controls.Add(this.localIpTitleLabel);
            this.networkGroupBox.Location = new System.Drawing.Point(712, 376);
            this.networkGroupBox.Name = "networkGroupBox";
            this.networkGroupBox.Size = new System.Drawing.Size(394, 240);
            this.networkGroupBox.TabIndex = 26;
            this.networkGroupBox.TabStop = false;
            this.networkGroupBox.Text = "Network";
            // 
            // proxyLabel
            // 
            this.proxyLabel.AutoEllipsis = true;
            this.proxyLabel.Location = new System.Drawing.Point(89, 74);
            this.proxyLabel.Name = "proxyLabel";
            this.proxyLabel.Size = new System.Drawing.Size(140, 13);
            this.proxyLabel.TabIndex = 52;
            this.proxyLabel.Text = "N/A";
            // 
            // proxyTitleLabel
            // 
            this.proxyTitleLabel.AutoSize = true;
            this.proxyTitleLabel.Location = new System.Drawing.Point(19, 74);
            this.proxyTitleLabel.Name = "proxyTitleLabel";
            this.proxyTitleLabel.Size = new System.Drawing.Size(36, 13);
            this.proxyTitleLabel.TabIndex = 51;
            this.proxyTitleLabel.Text = "Proxy:";
            // 
            // portStatusLabel
            // 
            this.portStatusLabel.AutoSize = true;
            this.portStatusLabel.Location = new System.Drawing.Point(89, 135);
            this.portStatusLabel.Name = "portStatusLabel";
            this.portStatusLabel.Size = new System.Drawing.Size(27, 13);
            this.portStatusLabel.TabIndex = 50;
            this.portStatusLabel.Text = "N/A";
            // 
            // portStatusTitleLabel
            // 
            this.portStatusTitleLabel.AutoSize = true;
            this.portStatusTitleLabel.Location = new System.Drawing.Point(19, 135);
            this.portStatusTitleLabel.Name = "portStatusTitleLabel";
            this.portStatusTitleLabel.Size = new System.Drawing.Size(60, 13);
            this.portStatusTitleLabel.TabIndex = 49;
            this.portStatusTitleLabel.Text = "Port status:";
            // 
            // copyClientPortButton
            // 
            this.copyClientPortButton.Location = new System.Drawing.Point(177, 154);
            this.copyClientPortButton.Name = "copyClientPortButton";
            this.copyClientPortButton.Size = new System.Drawing.Size(48, 23);
            this.copyClientPortButton.TabIndex = 48;
            this.copyClientPortButton.Text = "Copy";
            this.copyClientPortButton.UseVisualStyleBackColor = true;
            this.copyClientPortButton.Click += new System.EventHandler(this.copyLabel);
            // 
            // copyServerPortButton
            // 
            this.copyServerPortButton.Location = new System.Drawing.Point(177, 106);
            this.copyServerPortButton.Name = "copyServerPortButton";
            this.copyServerPortButton.Size = new System.Drawing.Size(48, 23);
            this.copyServerPortButton.TabIndex = 47;
            this.copyServerPortButton.Text = "Copy";
            this.copyServerPortButton.UseVisualStyleBackColor = true;
            this.copyServerPortButton.Click += new System.EventHandler(this.copyLabel);
            // 
            // copyExternalIPButton
            // 
            this.copyExternalIPButton.Location = new System.Drawing.Point(177, 46);
            this.copyExternalIPButton.Name = "copyExternalIPButton";
            this.copyExternalIPButton.Size = new System.Drawing.Size(48, 23);
            this.copyExternalIPButton.TabIndex = 46;
            this.copyExternalIPButton.Text = "Copy";
            this.copyExternalIPButton.UseVisualStyleBackColor = true;
            this.copyExternalIPButton.Click += new System.EventHandler(this.copyLabel);
            // 
            // copyLocalIPButton
            // 
            this.copyLocalIPButton.Location = new System.Drawing.Point(177, 23);
            this.copyLocalIPButton.Name = "copyLocalIPButton";
            this.copyLocalIPButton.Size = new System.Drawing.Size(48, 23);
            this.copyLocalIPButton.TabIndex = 45;
            this.copyLocalIPButton.Text = "Copy";
            this.copyLocalIPButton.UseVisualStyleBackColor = true;
            this.copyLocalIPButton.Click += new System.EventHandler(this.copyLabel);
            // 
            // testSpeedButton
            // 
            this.testSpeedButton.Location = new System.Drawing.Point(275, 130);
            this.testSpeedButton.Name = "testSpeedButton";
            this.testSpeedButton.Size = new System.Drawing.Size(75, 23);
            this.testSpeedButton.TabIndex = 42;
            this.testSpeedButton.Text = "Test speed";
            this.testSpeedButton.UseVisualStyleBackColor = true;
            // 
            // pingLabel
            // 
            this.pingLabel.AutoSize = true;
            this.pingLabel.Location = new System.Drawing.Point(349, 111);
            this.pingLabel.Name = "pingLabel";
            this.pingLabel.Size = new System.Drawing.Size(27, 13);
            this.pingLabel.TabIndex = 41;
            this.pingLabel.Text = "N/A";
            // 
            // uploadSpeedLabel
            // 
            this.uploadSpeedLabel.AutoSize = true;
            this.uploadSpeedLabel.Location = new System.Drawing.Point(349, 90);
            this.uploadSpeedLabel.Name = "uploadSpeedLabel";
            this.uploadSpeedLabel.Size = new System.Drawing.Size(27, 13);
            this.uploadSpeedLabel.TabIndex = 40;
            this.uploadSpeedLabel.Text = "N/A";
            // 
            // downloadSpeedLabel
            // 
            this.downloadSpeedLabel.AutoSize = true;
            this.downloadSpeedLabel.Location = new System.Drawing.Point(349, 67);
            this.downloadSpeedLabel.Name = "downloadSpeedLabel";
            this.downloadSpeedLabel.Size = new System.Drawing.Size(27, 13);
            this.downloadSpeedLabel.TabIndex = 39;
            this.downloadSpeedLabel.Text = "N/A";
            // 
            // pingTitleLabel
            // 
            this.pingTitleLabel.AutoSize = true;
            this.pingTitleLabel.Location = new System.Drawing.Point(240, 111);
            this.pingTitleLabel.Name = "pingTitleLabel";
            this.pingTitleLabel.Size = new System.Drawing.Size(31, 13);
            this.pingTitleLabel.TabIndex = 38;
            this.pingTitleLabel.Text = "Ping:";
            // 
            // uploadSpeedTitleLabel
            // 
            this.uploadSpeedTitleLabel.AutoSize = true;
            this.uploadSpeedTitleLabel.Location = new System.Drawing.Point(240, 90);
            this.uploadSpeedTitleLabel.Name = "uploadSpeedTitleLabel";
            this.uploadSpeedTitleLabel.Size = new System.Drawing.Size(76, 13);
            this.uploadSpeedTitleLabel.TabIndex = 37;
            this.uploadSpeedTitleLabel.Text = "Upload speed:";
            // 
            // downloadSpeedTitleLabel
            // 
            this.downloadSpeedTitleLabel.AutoSize = true;
            this.downloadSpeedTitleLabel.Location = new System.Drawing.Point(240, 67);
            this.downloadSpeedTitleLabel.Name = "downloadSpeedTitleLabel";
            this.downloadSpeedTitleLabel.Size = new System.Drawing.Size(90, 13);
            this.downloadSpeedTitleLabel.TabIndex = 36;
            this.downloadSpeedTitleLabel.Text = "Download speed:";
            // 
            // clientPortLabel
            // 
            this.clientPortLabel.AutoSize = true;
            this.clientPortLabel.Location = new System.Drawing.Point(89, 159);
            this.clientPortLabel.Name = "clientPortLabel";
            this.clientPortLabel.Size = new System.Drawing.Size(27, 13);
            this.clientPortLabel.TabIndex = 34;
            this.clientPortLabel.Text = "N/A";
            // 
            // clientPortTitleLabel
            // 
            this.clientPortTitleLabel.AutoSize = true;
            this.clientPortTitleLabel.Location = new System.Drawing.Point(19, 159);
            this.clientPortTitleLabel.Name = "clientPortTitleLabel";
            this.clientPortTitleLabel.Size = new System.Drawing.Size(58, 13);
            this.clientPortTitleLabel.TabIndex = 33;
            this.clientPortTitleLabel.Text = "Client Port:";
            // 
            // networkRefreshButton
            // 
            this.networkRefreshButton.Location = new System.Drawing.Point(132, 188);
            this.networkRefreshButton.Name = "networkRefreshButton";
            this.networkRefreshButton.Size = new System.Drawing.Size(143, 46);
            this.networkRefreshButton.TabIndex = 35;
            this.networkRefreshButton.Text = "Refresh";
            this.networkRefreshButton.UseVisualStyleBackColor = true;
            this.networkRefreshButton.Click += new System.EventHandler(this.networkRefreshButton_Click);
            // 
            // serverPortLabel
            // 
            this.serverPortLabel.AutoSize = true;
            this.serverPortLabel.Location = new System.Drawing.Point(89, 111);
            this.serverPortLabel.Name = "serverPortLabel";
            this.serverPortLabel.Size = new System.Drawing.Size(27, 13);
            this.serverPortLabel.TabIndex = 32;
            this.serverPortLabel.Text = "N/A";
            // 
            // serverPortTitleLabel
            // 
            this.serverPortTitleLabel.AutoSize = true;
            this.serverPortTitleLabel.Location = new System.Drawing.Point(19, 111);
            this.serverPortTitleLabel.Name = "serverPortTitleLabel";
            this.serverPortTitleLabel.Size = new System.Drawing.Size(63, 13);
            this.serverPortTitleLabel.TabIndex = 31;
            this.serverPortTitleLabel.Text = "Server Port:";
            // 
            // externalIpLabel
            // 
            this.externalIpLabel.AutoSize = true;
            this.externalIpLabel.Location = new System.Drawing.Point(89, 51);
            this.externalIpLabel.Name = "externalIpLabel";
            this.externalIpLabel.Size = new System.Drawing.Size(27, 13);
            this.externalIpLabel.TabIndex = 30;
            this.externalIpLabel.Text = "N/A";
            // 
            // localIpLabel
            // 
            this.localIpLabel.AutoSize = true;
            this.localIpLabel.Location = new System.Drawing.Point(89, 28);
            this.localIpLabel.Name = "localIpLabel";
            this.localIpLabel.Size = new System.Drawing.Size(27, 13);
            this.localIpLabel.TabIndex = 28;
            this.localIpLabel.Text = "N/A";
            // 
            // externalIpTitleLabel
            // 
            this.externalIpTitleLabel.AutoSize = true;
            this.externalIpTitleLabel.Location = new System.Drawing.Point(19, 51);
            this.externalIpTitleLabel.Name = "externalIpTitleLabel";
            this.externalIpTitleLabel.Size = new System.Drawing.Size(61, 13);
            this.externalIpTitleLabel.TabIndex = 29;
            this.externalIpTitleLabel.Text = "External IP:";
            // 
            // localIpTitleLabel
            // 
            this.localIpTitleLabel.AutoSize = true;
            this.localIpTitleLabel.Location = new System.Drawing.Point(19, 27);
            this.localIpTitleLabel.Name = "localIpTitleLabel";
            this.localIpTitleLabel.Size = new System.Drawing.Size(49, 13);
            this.localIpTitleLabel.TabIndex = 27;
            this.localIpTitleLabel.Text = "Local IP:";
            // 
            // gameDetailsGroupBox
            // 
            this.gameDetailsGroupBox.Controls.Add(this.gameDetailsRefreshButton);
            this.gameDetailsGroupBox.Controls.Add(this.serverDirectoryLabel);
            this.gameDetailsGroupBox.Controls.Add(this.serverDirectoryTitleLabel);
            this.gameDetailsGroupBox.Controls.Add(this.maxPlayersLabel);
            this.gameDetailsGroupBox.Controls.Add(this.maxPlayersTitleLabel);
            this.gameDetailsGroupBox.Controls.Add(this.currMapLabel);
            this.gameDetailsGroupBox.Controls.Add(this.currMapTitleLabel);
            this.gameDetailsGroupBox.Location = new System.Drawing.Point(302, 445);
            this.gameDetailsGroupBox.Name = "gameDetailsGroupBox";
            this.gameDetailsGroupBox.Size = new System.Drawing.Size(404, 171);
            this.gameDetailsGroupBox.TabIndex = 38;
            this.gameDetailsGroupBox.TabStop = false;
            this.gameDetailsGroupBox.Text = "Game Details";
            // 
            // gameDetailsRefreshButton
            // 
            this.gameDetailsRefreshButton.Location = new System.Drawing.Point(138, 108);
            this.gameDetailsRefreshButton.Name = "gameDetailsRefreshButton";
            this.gameDetailsRefreshButton.Size = new System.Drawing.Size(143, 46);
            this.gameDetailsRefreshButton.TabIndex = 45;
            this.gameDetailsRefreshButton.Text = "Refresh";
            this.gameDetailsRefreshButton.UseVisualStyleBackColor = true;
            // 
            // serverDirectoryLabel
            // 
            this.serverDirectoryLabel.AutoSize = true;
            this.serverDirectoryLabel.Location = new System.Drawing.Point(109, 74);
            this.serverDirectoryLabel.Name = "serverDirectoryLabel";
            this.serverDirectoryLabel.Size = new System.Drawing.Size(27, 13);
            this.serverDirectoryLabel.TabIndex = 44;
            this.serverDirectoryLabel.Text = "N/A";
            // 
            // serverDirectoryTitleLabel
            // 
            this.serverDirectoryTitleLabel.AutoSize = true;
            this.serverDirectoryTitleLabel.Location = new System.Drawing.Point(17, 74);
            this.serverDirectoryTitleLabel.Name = "serverDirectoryTitleLabel";
            this.serverDirectoryTitleLabel.Size = new System.Drawing.Size(86, 13);
            this.serverDirectoryTitleLabel.TabIndex = 43;
            this.serverDirectoryTitleLabel.Text = "Server Directory:";
            // 
            // maxPlayersLabel
            // 
            this.maxPlayersLabel.AutoSize = true;
            this.maxPlayersLabel.Location = new System.Drawing.Point(93, 54);
            this.maxPlayersLabel.Name = "maxPlayersLabel";
            this.maxPlayersLabel.Size = new System.Drawing.Size(27, 13);
            this.maxPlayersLabel.TabIndex = 42;
            this.maxPlayersLabel.Text = "N/A";
            // 
            // maxPlayersTitleLabel
            // 
            this.maxPlayersTitleLabel.AutoSize = true;
            this.maxPlayersTitleLabel.Location = new System.Drawing.Point(17, 54);
            this.maxPlayersTitleLabel.Name = "maxPlayersTitleLabel";
            this.maxPlayersTitleLabel.Size = new System.Drawing.Size(70, 13);
            this.maxPlayersTitleLabel.TabIndex = 41;
            this.maxPlayersTitleLabel.Text = "Max. Players:";
            // 
            // currMapLabel
            // 
            this.currMapLabel.AutoSize = true;
            this.currMapLabel.Location = new System.Drawing.Point(53, 34);
            this.currMapLabel.Name = "currMapLabel";
            this.currMapLabel.Size = new System.Drawing.Size(27, 13);
            this.currMapLabel.TabIndex = 40;
            this.currMapLabel.Text = "N/A";
            // 
            // currMapTitleLabel
            // 
            this.currMapTitleLabel.AutoSize = true;
            this.currMapTitleLabel.Location = new System.Drawing.Point(17, 34);
            this.currMapTitleLabel.Name = "currMapTitleLabel";
            this.currMapTitleLabel.Size = new System.Drawing.Size(31, 13);
            this.currMapTitleLabel.TabIndex = 39;
            this.currMapTitleLabel.Text = "Map:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1134, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusStripLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 629);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1134, 22);
            this.statusStrip.TabIndex = 7;
            this.statusStrip.Text = "statusStrip";
            // 
            // statusStripLabel
            // 
            this.statusStripLabel.Name = "statusStripLabel";
            this.statusStripLabel.Size = new System.Drawing.Size(90, 17);
            this.statusStripLabel.Text = "statusStripLabel";
            // 
            // updateGrupBox
            // 
            this.updateGrupBox.Controls.Add(this.updateRemainingSizeLabel);
            this.updateGrupBox.Controls.Add(this.updateSizeLabel);
            this.updateGrupBox.Controls.Add(this.updateElapsedLabel);
            this.updateGrupBox.Controls.Add(this.updateSpeedLabel);
            this.updateGrupBox.Controls.Add(this.updateDoneLabel);
            this.updateGrupBox.Controls.Add(this.updateRemainingTimeLabel);
            this.updateGrupBox.Controls.Add(this.updateElapsedTitleLabel);
            this.updateGrupBox.Controls.Add(this.updatePercentLabel);
            this.updateGrupBox.Controls.Add(this.updateRemainingTimeTitleLabel);
            this.updateGrupBox.Controls.Add(this.updateRemainingSizeTitleLabel);
            this.updateGrupBox.Controls.Add(this.updateDoneTitleLabel);
            this.updateGrupBox.Controls.Add(this.updateSizeTitleLabel);
            this.updateGrupBox.Controls.Add(this.updateSeepTitleLabel);
            this.updateGrupBox.Controls.Add(this.updateProgressBar);
            this.updateGrupBox.Controls.Add(this.updateButton);
            this.updateGrupBox.Location = new System.Drawing.Point(712, 28);
            this.updateGrupBox.Name = "updateGrupBox";
            this.updateGrupBox.Size = new System.Drawing.Size(394, 170);
            this.updateGrupBox.TabIndex = 1;
            this.updateGrupBox.TabStop = false;
            this.updateGrupBox.Text = "Update Server";
            // 
            // updateRemainingSizeLabel
            // 
            this.updateRemainingSizeLabel.AutoSize = true;
            this.updateRemainingSizeLabel.Location = new System.Drawing.Point(304, 64);
            this.updateRemainingSizeLabel.Name = "updateRemainingSizeLabel";
            this.updateRemainingSizeLabel.Size = new System.Drawing.Size(10, 13);
            this.updateRemainingSizeLabel.TabIndex = 8;
            this.updateRemainingSizeLabel.Text = "-";
            // 
            // updateSizeLabel
            // 
            this.updateSizeLabel.AutoSize = true;
            this.updateSizeLabel.Location = new System.Drawing.Point(77, 64);
            this.updateSizeLabel.Name = "updateSizeLabel";
            this.updateSizeLabel.Size = new System.Drawing.Size(10, 13);
            this.updateSizeLabel.TabIndex = 4;
            this.updateSizeLabel.Text = "-";
            // 
            // updateElapsedLabel
            // 
            this.updateElapsedLabel.AutoSize = true;
            this.updateElapsedLabel.Location = new System.Drawing.Point(188, 94);
            this.updateElapsedLabel.Name = "updateElapsedLabel";
            this.updateElapsedLabel.Size = new System.Drawing.Size(10, 13);
            this.updateElapsedLabel.TabIndex = 12;
            this.updateElapsedLabel.Text = "-";
            // 
            // updateSpeedLabel
            // 
            this.updateSpeedLabel.AutoSize = true;
            this.updateSpeedLabel.Location = new System.Drawing.Point(79, 94);
            this.updateSpeedLabel.Name = "updateSpeedLabel";
            this.updateSpeedLabel.Size = new System.Drawing.Size(10, 13);
            this.updateSpeedLabel.TabIndex = 10;
            this.updateSpeedLabel.Text = "-";
            // 
            // updateDoneLabel
            // 
            this.updateDoneLabel.AutoSize = true;
            this.updateDoneLabel.Location = new System.Drawing.Point(178, 64);
            this.updateDoneLabel.Name = "updateDoneLabel";
            this.updateDoneLabel.Size = new System.Drawing.Size(10, 13);
            this.updateDoneLabel.TabIndex = 6;
            this.updateDoneLabel.Text = "-";
            // 
            // updateRemainingTimeLabel
            // 
            this.updateRemainingTimeLabel.AutoSize = true;
            this.updateRemainingTimeLabel.Location = new System.Drawing.Point(309, 94);
            this.updateRemainingTimeLabel.Name = "updateRemainingTimeLabel";
            this.updateRemainingTimeLabel.Size = new System.Drawing.Size(10, 13);
            this.updateRemainingTimeLabel.TabIndex = 14;
            this.updateRemainingTimeLabel.Text = "-";
            // 
            // updateElapsedTitleLabel
            // 
            this.updateElapsedTitleLabel.AutoSize = true;
            this.updateElapsedTitleLabel.Location = new System.Drawing.Point(136, 94);
            this.updateElapsedTitleLabel.Name = "updateElapsedTitleLabel";
            this.updateElapsedTitleLabel.Size = new System.Drawing.Size(48, 13);
            this.updateElapsedTitleLabel.TabIndex = 11;
            this.updateElapsedTitleLabel.Text = "Elapsed:";
            // 
            // updatePercentLabel
            // 
            this.updatePercentLabel.AutoSize = true;
            this.updatePercentLabel.Location = new System.Drawing.Point(188, 147);
            this.updatePercentLabel.Name = "updatePercentLabel";
            this.updatePercentLabel.Size = new System.Drawing.Size(10, 13);
            this.updatePercentLabel.TabIndex = 16;
            this.updatePercentLabel.Text = "-";
            // 
            // updateRemainingTimeTitleLabel
            // 
            this.updateRemainingTimeTitleLabel.AutoSize = true;
            this.updateRemainingTimeTitleLabel.Location = new System.Drawing.Point(245, 94);
            this.updateRemainingTimeTitleLabel.Name = "updateRemainingTimeTitleLabel";
            this.updateRemainingTimeTitleLabel.Size = new System.Drawing.Size(60, 13);
            this.updateRemainingTimeTitleLabel.TabIndex = 13;
            this.updateRemainingTimeTitleLabel.Text = "Remaining:";
            // 
            // updateRemainingSizeTitleLabel
            // 
            this.updateRemainingSizeTitleLabel.AutoSize = true;
            this.updateRemainingSizeTitleLabel.Location = new System.Drawing.Point(238, 64);
            this.updateRemainingSizeTitleLabel.Name = "updateRemainingSizeTitleLabel";
            this.updateRemainingSizeTitleLabel.Size = new System.Drawing.Size(60, 13);
            this.updateRemainingSizeTitleLabel.TabIndex = 7;
            this.updateRemainingSizeTitleLabel.Text = "Remaining:";
            // 
            // updateDoneTitleLabel
            // 
            this.updateDoneTitleLabel.AutoSize = true;
            this.updateDoneTitleLabel.Location = new System.Drawing.Point(136, 64);
            this.updateDoneTitleLabel.Name = "updateDoneTitleLabel";
            this.updateDoneTitleLabel.Size = new System.Drawing.Size(36, 13);
            this.updateDoneTitleLabel.TabIndex = 5;
            this.updateDoneTitleLabel.Text = "Done:";
            // 
            // updateSizeTitleLabel
            // 
            this.updateSizeTitleLabel.AutoSize = true;
            this.updateSizeTitleLabel.Location = new System.Drawing.Point(41, 64);
            this.updateSizeTitleLabel.Name = "updateSizeTitleLabel";
            this.updateSizeTitleLabel.Size = new System.Drawing.Size(30, 13);
            this.updateSizeTitleLabel.TabIndex = 3;
            this.updateSizeTitleLabel.Text = "Size:";
            // 
            // updateSeepTitleLabel
            // 
            this.updateSeepTitleLabel.AutoSize = true;
            this.updateSeepTitleLabel.Location = new System.Drawing.Point(34, 94);
            this.updateSeepTitleLabel.Name = "updateSeepTitleLabel";
            this.updateSeepTitleLabel.Size = new System.Drawing.Size(41, 13);
            this.updateSeepTitleLabel.TabIndex = 9;
            this.updateSeepTitleLabel.Text = "Speed:";
            // 
            // updateProgressBar
            // 
            this.updateProgressBar.Location = new System.Drawing.Point(38, 121);
            this.updateProgressBar.Name = "updateProgressBar";
            this.updateProgressBar.Size = new System.Drawing.Size(318, 23);
            this.updateProgressBar.TabIndex = 15;
            // 
            // logTextBox
            // 
            this.logTextBox.Location = new System.Drawing.Point(13, 19);
            this.logTextBox.Multiline = true;
            this.logTextBox.Name = "logTextBox";
            this.logTextBox.ReadOnly = true;
            this.logTextBox.Size = new System.Drawing.Size(380, 350);
            this.logTextBox.TabIndex = 37;
            // 
            // propertiesListBox
            // 
            this.propertiesListBox.FormattingEnabled = true;
            this.propertiesListBox.Location = new System.Drawing.Point(6, 19);
            this.propertiesListBox.Name = "propertiesListBox";
            this.propertiesListBox.Size = new System.Drawing.Size(269, 537);
            this.propertiesListBox.TabIndex = 37;
            // 
            // newPropertyTextBox
            // 
            this.newPropertyTextBox.Location = new System.Drawing.Point(6, 562);
            this.newPropertyTextBox.Name = "newPropertyTextBox";
            this.newPropertyTextBox.Size = new System.Drawing.Size(203, 20);
            this.newPropertyTextBox.TabIndex = 38;
            // 
            // serverPropertiesGroupBox
            // 
            this.serverPropertiesGroupBox.Controls.Add(this.addPropertyButton);
            this.serverPropertiesGroupBox.Controls.Add(this.newPropertyTextBox);
            this.serverPropertiesGroupBox.Controls.Add(this.propertiesListBox);
            this.serverPropertiesGroupBox.Location = new System.Drawing.Point(12, 27);
            this.serverPropertiesGroupBox.Name = "serverPropertiesGroupBox";
            this.serverPropertiesGroupBox.Size = new System.Drawing.Size(284, 589);
            this.serverPropertiesGroupBox.TabIndex = 49;
            this.serverPropertiesGroupBox.TabStop = false;
            this.serverPropertiesGroupBox.Text = "Server Properties (server.cfg)";
            // 
            // addPropertyButton
            // 
            this.addPropertyButton.Location = new System.Drawing.Point(215, 560);
            this.addPropertyButton.Name = "addPropertyButton";
            this.addPropertyButton.Size = new System.Drawing.Size(60, 23);
            this.addPropertyButton.TabIndex = 39;
            this.addPropertyButton.Text = "Add";
            this.addPropertyButton.UseVisualStyleBackColor = true;
            // 
            // serverLogGroupBox
            // 
            this.serverLogGroupBox.Controls.Add(this.logTextBox);
            this.serverLogGroupBox.Controls.Add(this.commandInputTextBox);
            this.serverLogGroupBox.Controls.Add(this.commandSubmitButton);
            this.serverLogGroupBox.Location = new System.Drawing.Point(302, 28);
            this.serverLogGroupBox.Name = "serverLogGroupBox";
            this.serverLogGroupBox.Size = new System.Drawing.Size(404, 411);
            this.serverLogGroupBox.TabIndex = 50;
            this.serverLogGroupBox.TabStop = false;
            this.serverLogGroupBox.Text = "Server Log";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 651);
            this.Controls.Add(this.serverLogGroupBox);
            this.Controls.Add(this.serverPropertiesGroupBox);
            this.Controls.Add(this.updateGrupBox);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.gameDetailsGroupBox);
            this.Controls.Add(this.networkGroupBox);
            this.Controls.Add(this.systemGroupBox);
            this.Controls.Add(this.serverOptionsGroupBox);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Team Fortress 2 Server GUI";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Shown += new System.EventHandler(this.formLoaded);
            this.serverOptionsGroupBox.ResumeLayout(false);
            this.networkGroupBox.ResumeLayout(false);
            this.networkGroupBox.PerformLayout();
            this.gameDetailsGroupBox.ResumeLayout(false);
            this.gameDetailsGroupBox.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.updateGrupBox.ResumeLayout(false);
            this.updateGrupBox.PerformLayout();
            this.serverPropertiesGroupBox.ResumeLayout(false);
            this.serverPropertiesGroupBox.PerformLayout();
            this.serverLogGroupBox.ResumeLayout(false);
            this.serverLogGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox serverOptionsGroupBox;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button pauseButton;
        private System.Windows.Forms.Button shutdownButton;
        private System.Windows.Forms.Button restartButton;
        private System.Windows.Forms.GroupBox systemGroupBox;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.TextBox commandInputTextBox;
        private System.Windows.Forms.Button commandSubmitButton;
        private System.Windows.Forms.GroupBox networkGroupBox;
        private System.Windows.Forms.Button networkRefreshButton;
        private System.Windows.Forms.Label serverPortLabel;
        private System.Windows.Forms.Label serverPortTitleLabel;
        private System.Windows.Forms.Label externalIpLabel;
        private System.Windows.Forms.Label localIpLabel;
        private System.Windows.Forms.Label externalIpTitleLabel;
        private System.Windows.Forms.Label localIpTitleLabel;
        private System.Windows.Forms.GroupBox gameDetailsGroupBox;
        private System.Windows.Forms.Label maxPlayersLabel;
        private System.Windows.Forms.Label maxPlayersTitleLabel;
        private System.Windows.Forms.Label currMapLabel;
        private System.Windows.Forms.Label currMapTitleLabel;
        private System.Windows.Forms.Button gameDetailsRefreshButton;
        private System.Windows.Forms.Label serverDirectoryLabel;
        private System.Windows.Forms.Label serverDirectoryTitleLabel;
        private System.Windows.Forms.Label clientPortLabel;
        private System.Windows.Forms.Label clientPortTitleLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.GroupBox updateGrupBox;
        private System.Windows.Forms.Label updateRemainingSizeLabel;
        private System.Windows.Forms.Label updateSizeLabel;
        private System.Windows.Forms.Label updateElapsedLabel;
        private System.Windows.Forms.Label updateSpeedLabel;
        private System.Windows.Forms.Label updateDoneLabel;
        private System.Windows.Forms.Label updateRemainingTimeLabel;
        private System.Windows.Forms.Label updateElapsedTitleLabel;
        private System.Windows.Forms.Label updatePercentLabel;
        private System.Windows.Forms.Label updateRemainingTimeTitleLabel;
        private System.Windows.Forms.Label updateRemainingSizeTitleLabel;
        private System.Windows.Forms.Label updateDoneTitleLabel;
        private System.Windows.Forms.Label updateSizeTitleLabel;
        private System.Windows.Forms.Label updateSeepTitleLabel;
        private System.Windows.Forms.ProgressBar updateProgressBar;
        private System.Windows.Forms.ToolStripStatusLabel statusStripLabel;
        private System.Windows.Forms.TextBox logTextBox;
        private System.Windows.Forms.Button copyServerPortButton;
        private System.Windows.Forms.Button copyExternalIPButton;
        private System.Windows.Forms.Button copyLocalIPButton;
        private System.Windows.Forms.Button testSpeedButton;
        private System.Windows.Forms.Label pingLabel;
        private System.Windows.Forms.Label uploadSpeedLabel;
        private System.Windows.Forms.Label downloadSpeedLabel;
        private System.Windows.Forms.Label pingTitleLabel;
        private System.Windows.Forms.Label uploadSpeedTitleLabel;
        private System.Windows.Forms.Label downloadSpeedTitleLabel;
        private System.Windows.Forms.Button copyClientPortButton;
        private System.Windows.Forms.TextBox newPropertyTextBox;
        private System.Windows.Forms.ListBox propertiesListBox;
        private System.Windows.Forms.GroupBox serverPropertiesGroupBox;
        private System.Windows.Forms.GroupBox serverLogGroupBox;
        private System.Windows.Forms.Button addPropertyButton;
        private System.Windows.Forms.Label portStatusLabel;
        private System.Windows.Forms.Label portStatusTitleLabel;
        private System.Windows.Forms.Label proxyLabel;
        private System.Windows.Forms.Label proxyTitleLabel;
    }
}

