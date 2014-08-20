using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace TeamFortressServerManager.MainProgram
{
    class Network
    {
        public static Ip localIp;
        public static Ip publicIp;
        public static Ip portStatus;
        public static string proxy;

        static string getWebpage(string url)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.UserAgent = "Mozilla/5.0 (Windows NT 6.1; WOW64; rv:12.0) Gecko/20100101 Firefox/12.0";

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            Stream receiveStream = response.GetResponseStream();
            StreamReader readStream = new StreamReader(receiveStream, Encoding.UTF8);
            string htmlContent = readStream.ReadToEnd();

            return htmlContent;
        }

        public static string refreshLocalIp()
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
            return newLocalIp;
        }

        public static string refreshPublicIp()
        {
            string newPublicIp = getWebpage("http://curlmyip.com/");

            if (publicIp == null)
            {
                publicIp = new Ip(newPublicIp);

                string newPortStatus = refreshPublicIp();

                Label portStatusLabel = (Label)Application.OpenForms[0].Controls.Find("portStatusLabel", true)[0];
                Application.OpenForms[0].Invoke(new Action(() => portStatusLabel.Text = newPortStatus));
            }

            else
            {
                publicIp = new Ip(newPublicIp);
            }

            return newPublicIp;
        }

        public static string refreshProxy()
        {
            string htmlContent = getWebpage("http://www.whatismyip.com/");

            Regex regEx = new Regex("class=\"the-proxy\">(.*)</");
            string newProxy = regEx.Match(htmlContent).Groups[1].ToString();

            proxy = newProxy;
            return proxy;
        }

        public static string refreshPortStatus()
        {
            string newPortStatus = "";

            if (publicIp != null)
            {
                IPAddress[] hostIPAddresses = Dns.GetHostAddresses(publicIp.ToString());
                IPAddress selectedIPAddress = null;

                if (hostIPAddresses == null || hostIPAddresses.Length == 0)
                {
                    newPortStatus = "Unknown";
                }

                for (int i = 0; i < hostIPAddresses.Length; i++)
                {
                    if (hostIPAddresses[i].AddressFamily == AddressFamily.InterNetwork)
                    {
                        selectedIPAddress = hostIPAddresses[i];
                        break;
                    }
                }

                if (selectedIPAddress == null)
                {
                    newPortStatus = "Unknown";
                }

                Socket socketInstance = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

                try
                {
                    socketInstance.Connect(selectedIPAddress, 25565);

                    if (socketInstance.Connected == true)
                    {
                        newPortStatus = "Open";
                    }

                    newPortStatus = "Closed";
                }

                catch (SocketException ex)
                {
                    if (ex.ErrorCode == 10061)
                    {
                        newPortStatus = "Closed";
                    }

                    else
                    {
                        newPortStatus = "Unknown";
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

            portStatus = new Ip(newPortStatus);
            return newPortStatus;
        }
    }
}