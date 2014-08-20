using System;
using System.IO;
using System.Windows.Forms;

namespace TeamFortressServerManager
{
    public partial class Form2 : Form
    {
        #region Initialization
        public Form2()
        {
            InitializeComponent();

            readSettings();
        }
        #endregion

        #region Events
        // Main Events
        private void Form2_Load(object sender, EventArgs e)
        {
            setToolTips();
        }

        private void form2Closed(object sender, FormClosedEventArgs e)
        {
            MainProgram.Variable.isFirst = false;
        }

        // Click Events
        private void settingsOpenServerDirectoryButton_Click(object sender, EventArgs e)
        {
            savableServerDirectory.Text = createFolderBrowserDialog(serverDirectoryFolderBrowserDialog, savableServerDirectory.Text);
        }

        private void settingsOpenGameDirectoryButton_Click(object sender, EventArgs e)
        {
            string startPath = "";

            if (savableGameDirectory.Text != "")
            {
                startPath = savableGameDirectory.Text;
            }

            else
            {
                startPath = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + "\\Steam\\SteamApps\\common\\Team Fortress 2";
            }

            savableGameDirectory.Text = createFolderBrowserDialog(gameDirectoryFolderBrowserDialog, startPath);
        }

        private void openSteamCMDDirectoryButton_Click(object sender, EventArgs e)
        {
            savableSteamCMDDirectory.Text = createFolderBrowserDialog(SteamCMDFolderBrowserDialog, savableSteamCMDDirectory.Text);
        }

        private void updateDefaultSettingsButton_Click(object sender, EventArgs e)
        {
            restoreDefaults();
        }

        private void ok_Click(object sender, EventArgs e)
        {
            if (savableGameDirectory.Text != "" && savableServerDirectory.Text != "" && savableGameNumber.Text != "" && savableSteamCMDDirectory.Text != "")
            {
                saveSettings();

                if (!Context.IO.checkSettings())
                {
                    if (MainProgram.Variable.isFirst == true)
                    {
                        MainProgram.Variable.isFirst = false;

                        MessageBox.Show("You can modify these settings later in the \"Settings\" menu.", "Settings saved", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }

                    Close();
                }
            }

            else if (savableGameDirectory.Text == "")
            {
                MessageBox.Show("Please set the game directory!", "Error: empty game path", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (savableServerDirectory.Text == "")
            {
                MessageBox.Show("Please set the server directory!", "Error: empty server path", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (savableSteamCMDDirectory.Text == "")
            {
                MessageBox.Show("Please set the SteamCMD directory!", "Error: empty SteamCMD path", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (savableGameNumber.Text == "")
            {
                MessageBox.Show("Please set the game number!", "Error: empty game number", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void apply_Click(object sender, EventArgs e)
        {
            updateApplyButton.Enabled = false;
            saveSettings();
            MainProgram.Variable.isFirst = false;
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            if (!MainProgram.Variable.isFirst && !Context.IO.checkSettings())
            {
                if (savableGameDirectory.Text != "" && savableServerDirectory.Text != "" && savableSteamCMDDirectory.Text != "")
                {
                    if (updateApplyButton.Enabled && MessageBox.Show("There are some unsaved changes. Do you want to close anyway?", "Discard Changes", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        Close();
                    }

                    else if (!updateApplyButton.Enabled)
                    {
                        Close();
                    }
                }

                else if (savableServerDirectory.Text == "")
                {
                    MessageBox.Show("Please set the game number!", "Error: empty game number", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else if (savableGameDirectory.Text == "")
                {
                    MessageBox.Show("Please set the game directory!", "Error: empty game path", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else if (savableSteamCMDDirectory.Text == "")
                {
                    MessageBox.Show("Please set the game number!", "Error: empty game number", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            else if (MainProgram.Variable.isFirst)
            {
                if (MessageBox.Show("At least one required option is not set. The server manager can't continue without setting these options. Do you want to exit?", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
        }

        // Drag and Drop Events
        private void dragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false))
                e.Effect = DragDropEffects.All;
            else
                e.Effect = DragDropEffects.None;
        }

        private void dragDrop(object sender, DragEventArgs e)
        {
            var currTextBox = (TextBox)sender;

            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

                if (Directory.Exists(files[0]))
                {
                    currTextBox.Text = files[0];
                }

                else
                {
                    MessageBox.Show("That does not seem to be a directory. Please drop a directory here!", "Error: Invalid directory", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //Other Events
        private void filterText(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void settingsChange(object sender, EventArgs e)
        {
            isSettingsChanged();
        }
        #endregion

        #region Functions
        // Main Functions
        private void readSettings()
        {
            for (int i = 0; i < this.Controls[2].Controls.Count; i++)
            {
                for (int j = 0; j < this.Controls[2].Controls[i].Controls.Count; j++)
                {
                    try
                    {
                        if (this.Controls[2].Controls[i].Controls[j].Name.Substring(0, 7) == "savable")
                        {
                            FileStream settings = new FileStream("server.settings", FileMode.OpenOrCreate);
                            settings.Close();

                            string currOption = this.Controls[2].Controls[i].Controls[j].Name.Replace("savable", "");
                            var currControl = this.Controls[2].Controls[i].Controls[j];

                            if (currControl.HasProperty("Checked"))
                            {
                                try
                                {
                                    ((CheckBox)currControl).Checked = Convert.ToBoolean(Context.IO.readOption(currOption));
                                }

                                catch
                                {
                                }
                            }

                            else if (!currControl.HasProperty("Checked") && currControl.HasProperty("Text"))
                            {
                                currControl.Text = Context.IO.readOption(currOption);
                            }
                        }
                    }

                    catch
                    {
                    }
                }
            }

            if (savableGameNumber.Text == "")
            {
                savableGameNumber.Text = "232250";
                updateApplyButton.Enabled = false;
            }

            isSettingsChanged();
        }

        private void isSettingsChanged()
        {
            bool isChanged = false;

            for (int i = 0; i < this.Controls[2].Controls.Count; i++)
            {
                for (int j = 0; j < this.Controls[2].Controls[i].Controls.Count; j++)
                {
                    try
                    {
                        if (this.Controls[2].Controls[i].Controls[j].Name.Substring(0, 7) == "savable")
                        {
                            var currControl = this.Controls[2].Controls[i].Controls[j];

                            if (currControl.HasProperty("Checked"))
                            {
                                if (Context.IO.readOption(currControl.Name.Replace("savable", "")) != Convert.ToString(((CheckBox)currControl).Checked))
                                {
                                    isChanged = true;
                                }
                            }

                            else if (!currControl.HasProperty("Checked") && currControl.HasProperty("Text"))
                            {
                                if (this.Controls[2].Controls[i].Controls[j].Text != "")
                                {
                                    if (Context.IO.readOption(currControl.Name.Replace("savable", "")) != currControl.Text)
                                    {
                                        isChanged = true;
                                    }
                                }
                            }
                        }
                    }

                    catch
                    {
                    }
                }
            }

            if (isChanged)
            {
                updateApplyButton.Enabled = true;

            }

            else
            {
                updateApplyButton.Enabled = false;
            }
        }

        private void saveSettings()
        {
            for (int i = 0; i < this.Controls[2].Controls.Count; i++)
            {
                for (int j = 0; j < this.Controls[2].Controls[i].Controls.Count; j++)
                {
                    try
                    {
                        if (this.Controls[2].Controls[i].Controls[j].Name.Substring(0, 7) == "savable")
                        {
                            FileStream settings = new FileStream("server.settings", FileMode.OpenOrCreate);
                            settings.Close();

                            var currControl = this.Controls[2].Controls[i].Controls[j];
                            string optionValue = "";

                            if (currControl.HasProperty("Checked"))
                            {
                                optionValue = Convert.ToString(((CheckBox)currControl).Checked);
                            }

                            else if (!currControl.HasProperty("Checked") && currControl.HasProperty("Text"))
                            {
                                optionValue = currControl.Text;
                            }

                            string settingsName = "server.settings";
                            string optionName = this.Controls[2].Controls[i].Controls[j].Name.Replace("savable", "");

                            string[] settingsContent = File.ReadAllLines(settingsName);
                            bool isFound = false;

                            for (int k = 0; k < settingsContent.Length; k++)
                            {
                                try
                                {
                                    if (settingsContent[k].Substring(0, optionName.Length) == optionName)
                                    {
                                        settingsContent[k] = optionName + "=" + optionValue;
                                        isFound = true;
                                    }
                                }

                                catch
                                {
                                }
                            }

                            if (isFound == false)
                            {
                                string[] newSettingsContent = new string[settingsContent.Length + 1];

                                for (var k = 0; k < settingsContent.Length; k++)
                                {
                                    newSettingsContent[k] = settingsContent[k];
                                }

                                newSettingsContent[settingsContent.Length] = optionName + "=" + optionValue;

                                File.WriteAllLines(settingsName, newSettingsContent);
                            }

                            else
                            {
                                File.WriteAllLines(settingsName, settingsContent);
                            }
                        }
                    }

                    catch
                    {
                    }
                }
            }
        }

        void setToolTips()
        {
            //General
            serverDirectoryPathToolTip.SetToolTip(serverDirectoryTitleLabel, "The directory of the downloaded TF2 server");
            serverDirectoryPathToolTip.SetToolTip(savableServerDirectory, "The directory of the downloaded TF2 server");
            serverDirectorySelectToolTip.SetToolTip(openServerDIrectoryButton, "Select server directory");
            gameDirectoryPathToolTip.SetToolTip(gameDirectoryTitleLabel, "The \"Team Fortress 2\" directory (usually in \"C:\\Program Files\\Steam\\SteamApps\\common\")");
            gameDirectoryPathToolTip.SetToolTip(savableGameDirectory, "The \"Team Fortress 2\" directory (usually in \"C:\\Program Files\\Steam\\SteamApps\\common\")");
            gameDirectorySelectToolTip.SetToolTip(openGameDirectoryButton, "Select game directory");
            steamCMDPathToolTip.SetToolTip(SteamCMDTitleLabel, "SteamCMD path");
            steamCMDPathToolTip.SetToolTip(savableSteamCMDDirectory, "SteamCMD path");
            steamCMDSelectToolTip.SetToolTip(openSteamCMDDirectoryButton, "Select steamCMD directory");


            //Update
            anonymousLoginToolTip.SetToolTip(loginAnonymouslyRadioButton, "Log into the server anonymously");
            gameNumberToolTip.SetToolTip(savableGameNumber, "Updatable game number (TF2: 232250)");
            gameNumberToolTip.SetToolTip(gameNumberTitleLabel, "Updatable game number (TF2: 232250)");
        }

        string createFolderBrowserDialog(FolderBrowserDialog dialog, string startPath)
        {
            dialog.SelectedPath = startPath;

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                return dialog.SelectedPath;
            }

            else
            {
                return "";
            }
        }

        void restoreDefaults()
        {
            if (MessageBox.Show("Do you want to restore the default settings? All of your settings will be lost (this will affect only the \"update\" tab).", "Restore default settings", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                for (int i = 0; i < Context.IO.defaultOptions.GetLength(1); i++)
                {
                    string currOptionName = Context.IO.defaultOptions[i, 0];
                    string currOptionValue = Context.IO.defaultOptions[i, 1];

                    for (int j = 0; j < settingsTabControl.SelectedTab.Controls.Count; j++)
                    {
                        var currControl = settingsTabControl.SelectedTab.Controls[j];

                        try
                        {
                            if (currControl.Name.Substring(0, 7) == "savable" && currControl.Name.Replace("savable", "") == currOptionName)
                            {
                                if (currControl.HasProperty("Checked"))
                                {
                                    ((CheckBox)currControl).Checked = Convert.ToBoolean(currOptionValue);
                                }

                                else if (!currControl.HasProperty("Checked") && currControl.HasProperty("Text"))
                                {
                                    currControl.Text = currOptionValue;
                                }
                            }
                        }

                        catch
                        {
                        }
                    }
                }
            }
        }

        #endregion
    }

    #region Classes
    static class customMethods
    {
        public static bool HasProperty(this object objectToCheck, string methodName)
        {
            var type = objectToCheck.GetType();
            return type.GetProperty(methodName) != null;
        }
    }
    #endregion
}
