using System;
using System.IO;
using System.Windows.Forms;

namespace TeamFortressServerManager.Context
{
    class IO
    {
        public static string[,] defaultOptions = new string[2, 2] { { "GameNumber", "232250" }, { "RunAsAdmin", "true" } };

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

        static string getProgramFilesPath()
        {
            if (8 == IntPtr.Size || (!String.IsNullOrEmpty(Environment.GetEnvironmentVariable("PROCESSOR_ARCHITEW6432"))))
            {
                return Environment.GetEnvironmentVariable("ProgramFiles(x86)");
            }

            return Environment.GetEnvironmentVariable("ProgramFiles");
        }
    }
}
