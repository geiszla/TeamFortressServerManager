namespace TeamFortressServerManager
{
    partial class Form2
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
            this.settingsTabControl = new System.Windows.Forms.TabControl();
            this.generalTab = new System.Windows.Forms.TabPage();
            this.openSteamCMDDirectoryButton = new System.Windows.Forms.Button();
            this.savableSteamCMDDirectory = new System.Windows.Forms.TextBox();
            this.SteamCMDTitleLabel = new System.Windows.Forms.Label();
            this.openGameDirectoryButton = new System.Windows.Forms.Button();
            this.savableGameDirectory = new System.Windows.Forms.TextBox();
            this.gameDirectoryTitleLabel = new System.Windows.Forms.Label();
            this.serverDirectoryTitleLabel = new System.Windows.Forms.Label();
            this.savableServerDirectory = new System.Windows.Forms.TextBox();
            this.openServerDIrectoryButton = new System.Windows.Forms.Button();
            this.updateTab = new System.Windows.Forms.TabPage();
            this.savableRunAsAdmin = new System.Windows.Forms.CheckBox();
            this.updateDefaultSettingsButton = new System.Windows.Forms.Button();
            this.savableGameNumber = new System.Windows.Forms.TextBox();
            this.gameNumberTitleLabel = new System.Windows.Forms.Label();
            this.loginAnonymouslyRadioButton = new System.Windows.Forms.RadioButton();
            this.updateApplyButton = new System.Windows.Forms.Button();
            this.updateCancelButton = new System.Windows.Forms.Button();
            this.updateOkButton = new System.Windows.Forms.Button();
            this.serverDirectoryFolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.gameDirectoryFolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.serverDirectoryPathToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.serverDirectorySelectToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.gameDirectoryPathToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.gameDirectorySelectToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.anonymousLoginToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.gameNumberToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SteamCMDFolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.steamCMDSelectToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.steamCMDPathToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.settingsTabControl.SuspendLayout();
            this.generalTab.SuspendLayout();
            this.updateTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // settingsTabControl
            // 
            this.settingsTabControl.Controls.Add(this.generalTab);
            this.settingsTabControl.Controls.Add(this.updateTab);
            this.settingsTabControl.Location = new System.Drawing.Point(12, 12);
            this.settingsTabControl.Name = "settingsTabControl";
            this.settingsTabControl.SelectedIndex = 0;
            this.settingsTabControl.Size = new System.Drawing.Size(287, 205);
            this.settingsTabControl.TabIndex = 1;
            // 
            // generalTab
            // 
            this.generalTab.BackColor = System.Drawing.Color.WhiteSmoke;
            this.generalTab.Controls.Add(this.openSteamCMDDirectoryButton);
            this.generalTab.Controls.Add(this.savableSteamCMDDirectory);
            this.generalTab.Controls.Add(this.SteamCMDTitleLabel);
            this.generalTab.Controls.Add(this.openGameDirectoryButton);
            this.generalTab.Controls.Add(this.savableGameDirectory);
            this.generalTab.Controls.Add(this.gameDirectoryTitleLabel);
            this.generalTab.Controls.Add(this.serverDirectoryTitleLabel);
            this.generalTab.Controls.Add(this.savableServerDirectory);
            this.generalTab.Controls.Add(this.openServerDIrectoryButton);
            this.generalTab.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.generalTab.Location = new System.Drawing.Point(4, 22);
            this.generalTab.Name = "generalTab";
            this.generalTab.Padding = new System.Windows.Forms.Padding(3);
            this.generalTab.Size = new System.Drawing.Size(279, 179);
            this.generalTab.TabIndex = 0;
            this.generalTab.Text = "General";
            // 
            // openSteamCMDDirectoryButton
            // 
            this.openSteamCMDDirectoryButton.Location = new System.Drawing.Point(193, 143);
            this.openSteamCMDDirectoryButton.Name = "openSteamCMDDirectoryButton";
            this.openSteamCMDDirectoryButton.Size = new System.Drawing.Size(75, 23);
            this.openSteamCMDDirectoryButton.TabIndex = 10;
            this.openSteamCMDDirectoryButton.Text = "Select";
            this.openSteamCMDDirectoryButton.UseVisualStyleBackColor = true;
            this.openSteamCMDDirectoryButton.Click += new System.EventHandler(this.openSteamCMDDirectoryButton_Click);
            // 
            // savableSteamCMDDirectory
            // 
            this.savableSteamCMDDirectory.AllowDrop = true;
            this.savableSteamCMDDirectory.Location = new System.Drawing.Point(11, 145);
            this.savableSteamCMDDirectory.Name = "savableSteamCMDDirectory";
            this.savableSteamCMDDirectory.ReadOnly = true;
            this.savableSteamCMDDirectory.Size = new System.Drawing.Size(165, 20);
            this.savableSteamCMDDirectory.TabIndex = 9;
            this.savableSteamCMDDirectory.DragDrop += new System.Windows.Forms.DragEventHandler(this.dragDrop);
            this.savableSteamCMDDirectory.DragEnter += new System.Windows.Forms.DragEventHandler(this.dragEnter);
            // 
            // SteamCMDTitleLabel
            // 
            this.SteamCMDTitleLabel.AutoSize = true;
            this.SteamCMDTitleLabel.Location = new System.Drawing.Point(8, 124);
            this.SteamCMDTitleLabel.Name = "SteamCMDTitleLabel";
            this.SteamCMDTitleLabel.Size = new System.Drawing.Size(109, 13);
            this.SteamCMDTitleLabel.TabIndex = 8;
            this.SteamCMDTitleLabel.Text = "SteamCMD Directory:";
            // 
            // openGameDirectoryButton
            // 
            this.openGameDirectoryButton.Location = new System.Drawing.Point(193, 85);
            this.openGameDirectoryButton.Name = "openGameDirectoryButton";
            this.openGameDirectoryButton.Size = new System.Drawing.Size(75, 23);
            this.openGameDirectoryButton.TabIndex = 7;
            this.openGameDirectoryButton.Text = "Select";
            this.openGameDirectoryButton.UseVisualStyleBackColor = true;
            this.openGameDirectoryButton.Click += new System.EventHandler(this.settingsOpenGameDirectoryButton_Click);
            // 
            // savableGameDirectory
            // 
            this.savableGameDirectory.AllowDrop = true;
            this.savableGameDirectory.Location = new System.Drawing.Point(11, 87);
            this.savableGameDirectory.Name = "savableGameDirectory";
            this.savableGameDirectory.ReadOnly = true;
            this.savableGameDirectory.Size = new System.Drawing.Size(165, 20);
            this.savableGameDirectory.TabIndex = 6;
            this.savableGameDirectory.TextChanged += new System.EventHandler(this.settingsChange);
            this.savableGameDirectory.DragDrop += new System.Windows.Forms.DragEventHandler(this.dragDrop);
            this.savableGameDirectory.DragEnter += new System.Windows.Forms.DragEventHandler(this.dragEnter);
            // 
            // gameDirectoryTitleLabel
            // 
            this.gameDirectoryTitleLabel.AutoSize = true;
            this.gameDirectoryTitleLabel.Location = new System.Drawing.Point(8, 67);
            this.gameDirectoryTitleLabel.Name = "gameDirectoryTitleLabel";
            this.gameDirectoryTitleLabel.Size = new System.Drawing.Size(80, 13);
            this.gameDirectoryTitleLabel.TabIndex = 5;
            this.gameDirectoryTitleLabel.Text = "Game Directory";
            // 
            // serverDirectoryTitleLabel
            // 
            this.serverDirectoryTitleLabel.AutoSize = true;
            this.serverDirectoryTitleLabel.Location = new System.Drawing.Point(8, 11);
            this.serverDirectoryTitleLabel.Name = "serverDirectoryTitleLabel";
            this.serverDirectoryTitleLabel.Size = new System.Drawing.Size(83, 13);
            this.serverDirectoryTitleLabel.TabIndex = 2;
            this.serverDirectoryTitleLabel.Text = "Server Directory";
            // 
            // savableServerDirectory
            // 
            this.savableServerDirectory.AllowDrop = true;
            this.savableServerDirectory.Location = new System.Drawing.Point(11, 31);
            this.savableServerDirectory.Name = "savableServerDirectory";
            this.savableServerDirectory.ReadOnly = true;
            this.savableServerDirectory.Size = new System.Drawing.Size(165, 20);
            this.savableServerDirectory.TabIndex = 3;
            this.savableServerDirectory.TextChanged += new System.EventHandler(this.settingsChange);
            this.savableServerDirectory.DragDrop += new System.Windows.Forms.DragEventHandler(this.dragDrop);
            this.savableServerDirectory.DragEnter += new System.Windows.Forms.DragEventHandler(this.dragEnter);
            // 
            // openServerDIrectoryButton
            // 
            this.openServerDIrectoryButton.Location = new System.Drawing.Point(193, 29);
            this.openServerDIrectoryButton.Name = "openServerDIrectoryButton";
            this.openServerDIrectoryButton.Size = new System.Drawing.Size(75, 23);
            this.openServerDIrectoryButton.TabIndex = 4;
            this.openServerDIrectoryButton.Text = "Select";
            this.openServerDIrectoryButton.UseVisualStyleBackColor = true;
            this.openServerDIrectoryButton.Click += new System.EventHandler(this.settingsOpenServerDirectoryButton_Click);
            // 
            // updateTab
            // 
            this.updateTab.BackColor = System.Drawing.Color.WhiteSmoke;
            this.updateTab.Controls.Add(this.savableRunAsAdmin);
            this.updateTab.Controls.Add(this.updateDefaultSettingsButton);
            this.updateTab.Controls.Add(this.savableGameNumber);
            this.updateTab.Controls.Add(this.gameNumberTitleLabel);
            this.updateTab.Controls.Add(this.loginAnonymouslyRadioButton);
            this.updateTab.Location = new System.Drawing.Point(4, 22);
            this.updateTab.Name = "updateTab";
            this.updateTab.Padding = new System.Windows.Forms.Padding(3);
            this.updateTab.Size = new System.Drawing.Size(279, 179);
            this.updateTab.TabIndex = 1;
            this.updateTab.Text = "Update";
            // 
            // savableRunAsAdmin
            // 
            this.savableRunAsAdmin.AutoSize = true;
            this.savableRunAsAdmin.Checked = true;
            this.savableRunAsAdmin.CheckState = System.Windows.Forms.CheckState.Checked;
            this.savableRunAsAdmin.Location = new System.Drawing.Point(11, 74);
            this.savableRunAsAdmin.Name = "savableRunAsAdmin";
            this.savableRunAsAdmin.Size = new System.Drawing.Size(123, 17);
            this.savableRunAsAdmin.TabIndex = 15;
            this.savableRunAsAdmin.Text = "Run as Administrator";
            this.savableRunAsAdmin.UseVisualStyleBackColor = true;
            this.savableRunAsAdmin.CheckStateChanged += new System.EventHandler(this.settingsChange);
            // 
            // updateDefaultSettingsButton
            // 
            this.updateDefaultSettingsButton.Location = new System.Drawing.Point(80, 150);
            this.updateDefaultSettingsButton.Name = "updateDefaultSettingsButton";
            this.updateDefaultSettingsButton.Size = new System.Drawing.Size(120, 23);
            this.updateDefaultSettingsButton.TabIndex = 14;
            this.updateDefaultSettingsButton.Text = "Default Settings";
            this.updateDefaultSettingsButton.UseVisualStyleBackColor = true;
            this.updateDefaultSettingsButton.Click += new System.EventHandler(this.updateDefaultSettingsButton_Click);
            // 
            // savableGameNumber
            // 
            this.savableGameNumber.Location = new System.Drawing.Point(92, 23);
            this.savableGameNumber.Name = "savableGameNumber";
            this.savableGameNumber.Size = new System.Drawing.Size(54, 20);
            this.savableGameNumber.TabIndex = 13;
            this.savableGameNumber.Text = "232250";
            this.savableGameNumber.TextChanged += new System.EventHandler(this.settingsChange);
            this.savableGameNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.filterText);
            // 
            // gameNumberTitleLabel
            // 
            this.gameNumberTitleLabel.AutoSize = true;
            this.gameNumberTitleLabel.Location = new System.Drawing.Point(8, 26);
            this.gameNumberTitleLabel.Name = "gameNumberTitleLabel";
            this.gameNumberTitleLabel.Size = new System.Drawing.Size(78, 13);
            this.gameNumberTitleLabel.TabIndex = 12;
            this.gameNumberTitleLabel.Text = "Game Number:";
            // 
            // loginAnonymouslyRadioButton
            // 
            this.loginAnonymouslyRadioButton.AutoSize = true;
            this.loginAnonymouslyRadioButton.Checked = true;
            this.loginAnonymouslyRadioButton.Location = new System.Drawing.Point(11, 97);
            this.loginAnonymouslyRadioButton.Name = "loginAnonymouslyRadioButton";
            this.loginAnonymouslyRadioButton.Size = new System.Drawing.Size(115, 17);
            this.loginAnonymouslyRadioButton.TabIndex = 11;
            this.loginAnonymouslyRadioButton.TabStop = true;
            this.loginAnonymouslyRadioButton.Text = "Login anonymously";
            this.loginAnonymouslyRadioButton.UseVisualStyleBackColor = true;
            // 
            // updateApplyButton
            // 
            this.updateApplyButton.Enabled = false;
            this.updateApplyButton.Location = new System.Drawing.Point(117, 230);
            this.updateApplyButton.Name = "updateApplyButton";
            this.updateApplyButton.Size = new System.Drawing.Size(75, 23);
            this.updateApplyButton.TabIndex = 16;
            this.updateApplyButton.Text = "Apply";
            this.updateApplyButton.UseVisualStyleBackColor = true;
            this.updateApplyButton.Click += new System.EventHandler(this.apply_Click);
            // 
            // updateCancelButton
            // 
            this.updateCancelButton.Location = new System.Drawing.Point(224, 230);
            this.updateCancelButton.Name = "updateCancelButton";
            this.updateCancelButton.Size = new System.Drawing.Size(75, 23);
            this.updateCancelButton.TabIndex = 15;
            this.updateCancelButton.Text = "Cancel";
            this.updateCancelButton.UseVisualStyleBackColor = true;
            this.updateCancelButton.Click += new System.EventHandler(this.cancel_Click);
            // 
            // updateOkButton
            // 
            this.updateOkButton.Location = new System.Drawing.Point(12, 230);
            this.updateOkButton.Name = "updateOkButton";
            this.updateOkButton.Size = new System.Drawing.Size(75, 23);
            this.updateOkButton.TabIndex = 14;
            this.updateOkButton.Text = "OK";
            this.updateOkButton.UseVisualStyleBackColor = true;
            this.updateOkButton.Click += new System.EventHandler(this.ok_Click);
            // 
            // serverDirectoryPathToolTip
            // 
            this.serverDirectoryPathToolTip.AutoPopDelay = 5000;
            this.serverDirectoryPathToolTip.InitialDelay = 500;
            this.serverDirectoryPathToolTip.ReshowDelay = 100;
            // 
            // serverDirectorySelectToolTip
            // 
            this.serverDirectorySelectToolTip.AutoPopDelay = 5000;
            this.serverDirectorySelectToolTip.InitialDelay = 500;
            this.serverDirectorySelectToolTip.ReshowDelay = 100;
            // 
            // gameDirectoryPathToolTip
            // 
            this.gameDirectoryPathToolTip.AutoPopDelay = 5000;
            this.gameDirectoryPathToolTip.InitialDelay = 500;
            this.gameDirectoryPathToolTip.ReshowDelay = 100;
            // 
            // gameDirectorySelectToolTip
            // 
            this.gameDirectorySelectToolTip.AutoPopDelay = 5000;
            this.gameDirectorySelectToolTip.InitialDelay = 500;
            this.gameDirectorySelectToolTip.ReshowDelay = 100;
            // 
            // anonymousLoginToolTip
            // 
            this.anonymousLoginToolTip.AutoPopDelay = 5000;
            this.anonymousLoginToolTip.InitialDelay = 500;
            this.anonymousLoginToolTip.ReshowDelay = 100;
            // 
            // gameNumberToolTip
            // 
            this.gameNumberToolTip.AutoPopDelay = 5000;
            this.gameNumberToolTip.InitialDelay = 500;
            this.gameNumberToolTip.ReshowDelay = 100;
            // 
            // steamCMDSelectToolTip
            // 
            this.steamCMDSelectToolTip.AutoPopDelay = 5000;
            this.steamCMDSelectToolTip.InitialDelay = 500;
            this.steamCMDSelectToolTip.ReshowDelay = 100;
            // 
            // steamCMDPathToolTip
            // 
            this.steamCMDPathToolTip.AutoPopDelay = 5000;
            this.steamCMDPathToolTip.InitialDelay = 500;
            this.steamCMDPathToolTip.ReshowDelay = 100;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 265);
            this.ControlBox = false;
            this.Controls.Add(this.updateOkButton);
            this.Controls.Add(this.updateApplyButton);
            this.Controls.Add(this.settingsTabControl);
            this.Controls.Add(this.updateCancelButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Location = new System.Drawing.Point(500, 500);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Server Manager Settings";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.form2Closed);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.Enter += new System.EventHandler(this.settingsChange);
            this.settingsTabControl.ResumeLayout(false);
            this.generalTab.ResumeLayout(false);
            this.generalTab.PerformLayout();
            this.updateTab.ResumeLayout(false);
            this.updateTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl settingsTabControl;
        private System.Windows.Forms.TabPage generalTab;
        private System.Windows.Forms.TabPage updateTab;
        private System.Windows.Forms.Button openGameDirectoryButton;
        private System.Windows.Forms.TextBox savableGameDirectory;
        private System.Windows.Forms.Label gameDirectoryTitleLabel;
        private System.Windows.Forms.Label serverDirectoryTitleLabel;
        private System.Windows.Forms.Button openServerDIrectoryButton;
        private System.Windows.Forms.RadioButton loginAnonymouslyRadioButton;
        private System.Windows.Forms.Label gameNumberTitleLabel;
        private System.Windows.Forms.Button updateApplyButton;
        private System.Windows.Forms.Button updateCancelButton;
        private System.Windows.Forms.Button updateOkButton;
        private System.Windows.Forms.FolderBrowserDialog serverDirectoryFolderBrowserDialog;
        private System.Windows.Forms.FolderBrowserDialog gameDirectoryFolderBrowserDialog;
        private System.Windows.Forms.TextBox savableServerDirectory;
        private System.Windows.Forms.TextBox savableGameNumber;
        private System.Windows.Forms.ToolTip serverDirectoryPathToolTip;
        private System.Windows.Forms.ToolTip serverDirectorySelectToolTip;
        private System.Windows.Forms.ToolTip gameDirectoryPathToolTip;
        private System.Windows.Forms.ToolTip gameDirectorySelectToolTip;
        private System.Windows.Forms.ToolTip anonymousLoginToolTip;
        private System.Windows.Forms.ToolTip gameNumberToolTip;
        private System.Windows.Forms.Button updateDefaultSettingsButton;
        private System.Windows.Forms.CheckBox savableRunAsAdmin;
        private System.Windows.Forms.TextBox savableSteamCMDDirectory;
        private System.Windows.Forms.Label SteamCMDTitleLabel;
        private System.Windows.Forms.Button openSteamCMDDirectoryButton;
        private System.Windows.Forms.FolderBrowserDialog SteamCMDFolderBrowserDialog;
        private System.Windows.Forms.ToolTip steamCMDSelectToolTip;
        private System.Windows.Forms.ToolTip steamCMDPathToolTip;

    }
}