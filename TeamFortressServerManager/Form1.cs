using System;
using System.Diagnostics;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

namespace TeamFortressServerManager
{
    public partial class Form1 : Form
    {
        #region Variables
        public static Thread[] refreshThreads = new Thread[4];
        #endregion

        #region Initialization
        public Form1()
        {
            InitializeComponent();

            MessageBox.Show("Welcome to the TF2 Server Manager made by GeiszlA!", "Welcome!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            isFirstCheck();

            if (MainProgram.Variable.isFirst == true)
            {
                MessageBox.Show("It seems that at least one required option is not set. Please do it now!", "Welcome!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                MainProgram.Forms.showForm2();
            }

            if (Context.IO.checkSettings())
            {
                MainProgram.Forms.showForm2();
            }
        }
        #endregion

        #region Events
        // Form Events
        private void Form1_Shown(object sender, EventArgs e)
        {
            refreshNetwork();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (Thread currThread in refreshThreads)
            {
                if (currThread != null)
                {
                    currThread.Abort();
                }
            }
        }

        // Main Events
        private void startButton_Click(object sender, EventArgs e)
        {
            MainProgram.Forms.showForm3();

            /*
            var updateProcess = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "C:\\Users\\Andris\\Downloads\\TF2Server\\srcds.exe",
                    Arguments = "-console -game tf -port 27015 +maxplayers 32 +map ph_island_a17",
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    CreateNoWindow = false
                }
            };

            updateProcess.Start();

            while (!updateProcess.StandardOutput.EndOfStream)
            {
                string currLine = updateProcess.StandardOutput.ReadLine();

                StreamWriter a = new StreamWriter("server.log", true);
                a.WriteLine(currLine);
                a.Close();
            }
             */
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (!Context.IO.checkSettings())
            {
                Thread updateServerThread = new Thread(new ThreadStart(updateServer));
                updateServerThread.Start();
            }
        }

        // Network Events
        private void networkRefreshButton_Click(object sender, EventArgs e)
        {
            refreshNetwork();
        }

        private void copyButtons_Click(object sender, EventArgs e)
        {
            Button currButton = (Button)sender;
            Regex regEx = new Regex("copy(.*)Button");
            string name = regEx.Match(currButton.Name).Groups[1].ToString().ToLower();

            Label currLabel = (Label)this.Controls.Find(name + "Label", true)[0];

            if (currLabel.Text != "N/A" && currLabel.Text != "Refreshing...")
            {
                Clipboard.SetText(currLabel.Text);
            }
        }


        private void testSpeedButton_Click(object sender, EventArgs e)
        {
            /*
            long beginValue = NetworkInterface.GetIPv4Statistics().BytesReceived;
            DateTime beginTime = DateTime.Now;

            // do something

            long endValue = NetworkInterface.GetIPv4Statistics().BytesReceived;
            DateTime endTime = DateTime.Now;

            long recievedBytes = endValue - beginValue;
            double totalSeconds = (endTime - beginTime).TotalSeconds;

            var bytesPerSecond = recievedBytes / totalSeconds;
             */
        }

        // Other Events
        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainProgram.Forms.showForm2();
        }
        #endregion

        #region Functions
        // Network Functions
        void refreshNetwork()
        {
            localIpLabel.Text = "Refreshing...";
            externalIpLabel.Text = "Refreshing...";
            portStatusLabel.Text = "Refreshing...";
            proxyLabel.Text = "Refreshing...";

            startThread(0, refreshLocalIp);

            if (MainProgram.Network.publicIp != null)
            {
                startThread(1, refreshPortStatus);
            }

            startThread(2, refreshProxy);
            startThread(3, refreshPublicIp);
        }

        void refreshLocalIp()
        {
            string localIp = MainProgram.Network.refreshLocalIp();
            this.Invoke(new Action(() => localIpLabel.Text = localIp));
        }

        void refreshPublicIp()
        {
            string publicIp = MainProgram.Network.refreshPublicIp();
            this.Invoke(new Action(() => externalIpLabel.Text = publicIp));
        }

        void refreshPortStatus()
        {
            string portStatus = MainProgram.Network.refreshPortStatus();
            this.Invoke(new Action(() => portStatusLabel.Text = portStatus));
        }

        void refreshProxy()
        {
            string proxy = MainProgram.Network.refreshProxy();
            this.Invoke(new Action(() => proxyLabel.Text = proxy));
        }

        // Threading Functions
        public delegate void MyFunction();

        public static void startThread(int i, MyFunction function)
        {
            if (refreshThreads[i] == null || !refreshThreads[i].IsAlive)
            {
                refreshThreads[i] = new Thread(new ThreadStart(function));
                refreshThreads[i].IsBackground = true;
                refreshThreads[i].Start();
            }
        }

        // Update Functions
        void updateUpdateStatus(int inputPercent)
        {
            updateProgressBar.Value = inputPercent;
        }

        void statusStripUpdate(string currStatus)
        {
            statusStripLabel.Text = currStatus;
            statusStrip.Refresh();
        }

        void updateServer()
        {
            string steamCMDDirectory = Context.IO.readOption("SteamCMDDirectory");
            string serverDirectory = Context.IO.readOption("ServerDirectory");
            string gameNumber = Context.IO.readOption("GameNumber");

            var updateProcess = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = steamCMDDirectory + "\\steamcmd.exe",
                    Arguments = "+login anonymous +force_install_dir " + serverDirectory + " +app_update " + gameNumber + " validate +quit",
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    CreateNoWindow = true
                }
            };

            updateProcess.Start();

            while (!updateProcess.StandardOutput.EndOfStream)
            {
                this.Invoke(new Action(() => statusStripUpdate("enter")));
                return;

                string currLine = updateProcess.StandardOutput.ReadLine();

                char[] splitChars = { ':', ' ' };
                string[] splittedLine = currLine.Split(splitChars, 2);

                this.Invoke(new Action(() => statusStripUpdate(currLine)));
                return;

                try
                {
                    double currState;
                    bool isNum = double.TryParse(splittedLine[splittedLine.Length - 4].Replace(".", ","), out currState);

                    if (isNum)
                    {
                        if (InvokeRequired)
                        {
                            this.Invoke(new Action(() => updateUpdateStatus(Convert.ToInt32(Math.Round(currState)))));
                            return;
                        }
                    }
                }

                catch
                {
                }

                StreamWriter a = new StreamWriter("update.log", true);
                a.WriteLine(currLine);
                a.Close();
            }

            statusStripUpdate("leave");
        }

        // Other Functions
        void isFirstCheck()
        {
            if (Context.IO.readOption("ServerDirectory") == "" || Context.IO.readOption("GameDirectory") == "" || Context.IO.readOption("SteamCMDDirectory") == "")
            {
                MainProgram.Variable.isFirst = true;
            }
        }
        #endregion
    }

    #region Classes
    public class Ip
    {
        int[] adress = new int[4];

        public override string ToString()
        {
            string returnValue = "";

            for (int i = 0; i < adress.Length; i++)
            {
                returnValue += adress[i].ToString();

                if (i != adress.Length - 1)
                {
                    returnValue += ".";
                }
            }

            return returnValue;
        }

        public Ip(string inputString)
        {
            adress = Array.ConvertAll(inputString.Split('.'), item => Convert.ToInt32(item));
        }

        public Ip(int[] inputArray)
        {
            adress = inputArray;
        }
    }
    #endregion
}
