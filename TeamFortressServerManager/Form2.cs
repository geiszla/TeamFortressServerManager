using System;
using System.IO;
using System.Windows.Forms;

namespace TeamFortressServerManager
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            readSettings();
        }


        // Main Functions

        private void Form2_Load(object sender, EventArgs e)
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
                                    ((CheckBox)currControl).Checked = Convert.ToBoolean(globalClass2.readOption(currOption));
                                }

                                catch
                                {
                                }
                            }

                            else if (!currControl.HasProperty("Checked") && currControl.HasProperty("Text"))
                            {
                                currControl.Text = globalClass2.readOption(currOption);
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

        private void settingsOpenServerDirectoryButton_Click(object sender, EventArgs e)
        {
            serverDirectoryFolderBrowserDialog.SelectedPath = savableServerDirectory.Text;

            if (serverDirectoryFolderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                string serverDirectoryPath = serverDirectoryFolderBrowserDialog.SelectedPath;
                savableServerDirectory.Text = serverDirectoryPath;
            }
        }

        private void settingsOpenGameDirectoryButton_Click(object sender, EventArgs e)
        {
            if (savableGameDirectory.Text != "")
            {
                gameDirectoryFolderBrowserDialog.SelectedPath = savableGameDirectory.Text;
            }

            else
            {
                gameDirectoryFolderBrowserDialog.SelectedPath = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + "\\Steam\\SteamApps\\common\\Team Fortress 2";
            }

            if (gameDirectoryFolderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                string gameDirectoryPath = gameDirectoryFolderBrowserDialog.SelectedPath;
                savableGameDirectory.Text = gameDirectoryPath;
            }
        }

        private void openSteamCMDDirectoryButton_Click(object sender, EventArgs e)
        {
            SteamCMDFolderBrowserDialog.SelectedPath = savableSteamCMDDirectory.Text;

            if (SteamCMDFolderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                string steamCMDPath = SteamCMDFolderBrowserDialog.SelectedPath;
                savableSteamCMDDirectory.Text = steamCMDPath;
            }
        }

        private void updateDefaultSettingsButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to restore the default settings? All of your settings will be lost (this will affect only the \"update\" tab).", "Restore default settings", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                for (int i = 0; i < globalClass2.defaultOptions.GetLength(1); i++)
                {
                    string currOptionName = globalClass2.defaultOptions[i, 0];
                    string currOptionValue = globalClass2.defaultOptions[i, 1];

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

        private void ok_Click(object sender, EventArgs e)
        {

            if (savableGameDirectory.Text != "" && savableServerDirectory.Text != "" && savableGameNumber.Text != "" && savableSteamCMDDirectory.Text != "")
            {
                if (globalClass1.isFirst == true)
                {
                    globalClass1.isFirst = false;

                    MessageBox.Show("You can modify these settings later in the \"Settings\" menu.", "Settings saved", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }

                saveSettings();

                if (!globalClass2.checkSettings())
                {
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
            globalClass1.isFirst = false;
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            if (!globalClass1.isFirst  && !globalClass2.checkSettings())
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

            else if (globalClass1.isFirst)
            {
                if (MessageBox.Show("At least one required option is not set. The server manager can't continue without setting these options. Do you want to exit?", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
        }

        private void form2Closed(object sender, FormClosedEventArgs e)
        {
            globalClass1.isFirst = false;
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


        // Sub Functions

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
                                if (globalClass2.readOption(currControl.Name.Replace("savable", "")) != Convert.ToString(((CheckBox)currControl).Checked))
                                {
                                    isChanged = true;
                                }
                            }

                            else if (!currControl.HasProperty("Checked") && currControl.HasProperty("Text"))
                            {
                                if (this.Controls[2].Controls[i].Controls[j].Text != "")
                                {
                                    if (globalClass2.readOption(currControl.Name.Replace("savable", "")) != currControl.Text)
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

        static string getProgramFilesPath()
        {
            if (8 == IntPtr.Size || (!String.IsNullOrEmpty(Environment.GetEnvironmentVariable("PROCESSOR_ARCHITEW6432"))))
            {
                return Environment.GetEnvironmentVariable("ProgramFiles(x86)");
            }

            return Environment.GetEnvironmentVariable("ProgramFiles");
        }

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
    }


    //Global variables and functions

    public static class globalClass2
    {
        public static bool checkSettings()
        {
            bool isNotValid = false;

            if (!File.Exists(readOption("GameDirectory") + "\\hl2.exe"))
            {
                MessageBox.Show("The game directory does not have \"hl2.exe\" in it. Please revise the path!", "Error: invalid game path", MessageBoxButtons.OK, MessageBoxIcon.Error);
                isNotValid = true;
            }

            else if (!File.Exists(readOption("ServerDirectory") + "\\srcds.exe"))
            {
                MessageBox.Show("The server directory does not have \"srcds.exe\" in it. Please revise the path!", "Error: invalid server path", MessageBoxButtons.OK, MessageBoxIcon.Error);
                isNotValid = true;
            }

            else if (!File.Exists(readOption("SteamCMDDirectory") + "\\steamcmd.exe"))
            {
                MessageBox.Show("The SteamCMD directory does not have \"steamcmd.exe\" in it. Please revise the path!", "Error: invalid SteamCMD path", MessageBoxButtons.OK, MessageBoxIcon.Error);
                isNotValid = true;
            }

            try
            {
                Convert.ToInt32(readOption("GameNumber"));
            }

            catch
            {
                MessageBox.Show("The game number is not in a correct format. It may only contains numbers.", "Error: invalid game number", MessageBoxButtons.OK, MessageBoxIcon.Error);
                isNotValid = true;
            }

            try
            {
                Convert.ToBoolean(readOption("RunAsAdmin"));
            }

            catch
            {
                MessageBox.Show("Some settings may not be saved. Please save them again!", "Settings error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                isNotValid = true;
            }

            return isNotValid;
        }

        public static string readOption(string inputOption)
        {
            FileStream settings = new FileStream("server.settings", FileMode.OpenOrCreate);
            settings.Close();

            StreamReader settingsFile = new StreamReader("server.settings");

            string outputValue = "";

            while (settingsFile.Peek() > -1)
            {
                string currLine = settingsFile.ReadLine();

                char[] splitChar = { '=' };

                if (currLine.Split(splitChar, 2)[0] == inputOption)
                {
                    outputValue = currLine.Split(splitChar, 2)[1];
                }
            }

            settingsFile.Close();

            return outputValue;
        }

        public static bool HasProperty(this object objectToCheck, string methodName)
        {
            var type = objectToCheck.GetType();
            return type.GetProperty(methodName) != null;
        }

        public static string[,] defaultOptions = new string[2, 2] { { "GameNumber", "232250" }, { "RunAsAdmin", "true" } };
    }
}
