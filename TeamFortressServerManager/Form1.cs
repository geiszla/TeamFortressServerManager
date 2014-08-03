using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

namespace TeamFortressServerManager
{
    public partial class Form1 : Form
    {
        public Thread[] refreshThreads = new Thread[4];

        public Ip localIp;
        public Ip publicIp;
        public Ip portStatus;
        public string proxy;

        public Form1()
        {
            InitializeComponent();

            MessageBox.Show("Welcome to the TF2 Server Manager made by GeiszlA!", "Welcome!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            isFirstCheck();

            if (globalClass1.isFirst == true)
            {
                MessageBox.Show("It seems that at least one required option is not set. Please do it now!", "Welcome!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                showForm2();
            }

            if (globalClass2.checkSettings())
            {
                showForm2();
            }
        }


        //Main functions

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showForm2();
        }


        //Sub Functions

        private void isFirstCheck()
        {
            if (globalClass2.readOption("ServerDirectory") == "" || globalClass2.readOption("GameDirectory") == "" || globalClass2.readOption("SteamCMDDirectory") == "")
            {
                TeamFortressServerManager.globalClass1.isFirst = true;
            }
        }

        private void showForm2()
        {
            Form2 settingsWindow = new Form2();
            settingsWindow.ShowDialog();
        }

        private void showForm3()
        {
            Form3 settingsWindow = new Form3();
            settingsWindow.ShowDialog();
        }

        void refreshLocalIp()
        {
            IPHostEntry host;
            string newLocalIp = "N/A";
            host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    newLocalIp = ip.ToString();
                }
            }

            localIp = new Ip(newLocalIp);
            this.Invoke(new Action(() => localIpLabel.Text = newLocalIp));
        }

        void refreshPublicIp()
        {
            string externalIP = getWebpage("http://curlmyip.com/");

            if (publicIp == null)
            {
                refreshThreads[3] = new Thread(new ThreadStart(refreshPortStatus));
                refreshThreads[3].IsBackground = true;
                refreshThreads[3].Start();
            }

            publicIp = new Ip(externalIP);
            this.Invoke(new Action(() => externalIpLabel.Text = externalIP));
        }

        void refreshPortStatus()
        {
            if (publicIp != null)
            {
                IPAddress[] hostIPAddresses = Dns.GetHostAddresses(publicIp.ToString());
                IPAddress selectedIPAddress = null;

                if (hostIPAddresses == null || hostIPAddresses.Length == 0) { this.Invoke(new Action(() => portStatusLabel.Text = "Unknown")); }

                for (int i = 0; i < hostIPAddresses.Length; i++)
                {
                    if (hostIPAddresses[i].AddressFamily == AddressFamily.InterNetwork)
                    {
                        selectedIPAddress = hostIPAddresses[i];
                        break;
                    }
                }

                if (selectedIPAddress == null) { this.Invoke(new Action(() => portStatusLabel.Text = "Unknown")); }

                Socket socketInstance = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

                try
                {
                    socketInstance.Connect(selectedIPAddress, 25565);

                    if (socketInstance.Connected == true)
                    {
                        //Port is in use and connection is successful           
                        this.Invoke(new Action(() => portStatusLabel.Text = "Open"));
                    }

                    this.Invoke(new Action(() => portStatusLabel.Text = "Closed"));
                }

                catch (SocketException ex)
                {
                    if (ex.ErrorCode == 10061)
                    {
                        //Port is unused and could not establish connection        
                        this.Invoke(new Action(() => portStatusLabel.Text = "Closed"));
                    }

                    else
                    {
                        this.Invoke(new Action(() => portStatusLabel.Text = "Unknown"));
                    }
                }

                finally
                {
                    if (socketInstance != null)
                    {
                        socketInstance.Close();
                    }
                }
            }
        }

        void refreshProxy()
        {
            string htmlContent = getWebpage("http://www.whatismyip.com/");

            Regex regEx = new Regex("class=\"the-proxy\">(.*)</");
            string newProxy = regEx.Match(htmlContent).Groups[1].ToString();

            proxy = newProxy;
            this.Invoke(new Action(() => proxyLabel.Text = proxy));
        }

        private void refreshNetwork()
        {
            localIpLabel.Text = "Refreshing...";
            externalIpLabel.Text = "Refreshing...";
            portStatusLabel.Text = "Refreshing...";
            proxyLabel.Text = "Refreshing...";

            startThread(0, refreshLocalIp);

            if (publicIp != null)
            {
                startThread(1, refreshPortStatus);
            }

            startThread(2, refreshProxy);
            startThread(3, refreshPublicIp);
        }

        string getWebpage(string url)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.UserAgent = "Mozilla/5.0 (Windows NT 6.1; WOW64; rv:12.0) Gecko/20100101 Firefox/12.0";

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            Stream receiveStream = response.GetResponseStream();
            StreamReader readStream = new StreamReader(receiveStream, Encoding.UTF8);
            string htmlContent = readStream.ReadToEnd();

            return htmlContent;
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            showForm3();

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
            if (!globalClass2.checkSettings())
            {
                Thread updateServerThread = new Thread(new ThreadStart(updateServer));
                updateServerThread.Start();
            }
        }

        private void updateUpdateStatus(int inputPercent)
        {
            updateProgressBar.Value = inputPercent;
        }

        private void statusStripUpdate(string currStatus)
        {
            statusStripLabel.Text = currStatus;
            statusStrip.Refresh();
        }

        public void updateServer()
        {
            string steamCMDDirectory = globalClass2.readOption("SteamCMDDirectory");
            string serverDirectory = globalClass2.readOption("ServerDirectory");
            string gameNumber = globalClass2.readOption("GameNumber");

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
                if (InvokeRequired)
                {
                    this.Invoke(new Action(() => statusStripUpdate("enter")));
                    return;
                }

                string currLine = updateProcess.StandardOutput.ReadLine();

                char[] splitChars = { ':', ' ' };
                string[] splittedLine = currLine.Split(splitChars, 2);

                if (InvokeRequired)
                {
                    this.Invoke(new Action(() => statusStripUpdate(currLine)));
                    return;
                }

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

        private void networkRefreshButton_Click(object sender, EventArgs e)
        {
            refreshNetwork();
        }

        private void formLoaded(object sender, EventArgs e)
        {
            refreshNetwork();
        }

        private void copyLabel(object sender, EventArgs e)
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

        public delegate void MyFunction();

        public void startThread(int i, MyFunction function)
        {
            if (refreshThreads[i] == null || !refreshThreads[i].IsAlive)
            {
                refreshThreads[i] = new Thread(new ThreadStart(function));
                refreshThreads[i].IsBackground = true;
                refreshThreads[i].Start();
            }
        }
    }


    //Global variables and functions
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

    public static class globalClass1
    {
        public static bool isFirst;
    }
}
