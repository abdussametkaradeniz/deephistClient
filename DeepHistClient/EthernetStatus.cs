using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace DeepHistClient
{
    class EthernetStatus
    {
        public bool ethernetStatus = false;

        public bool checkEthernetStatus()
        {
            if (System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable())
            {
                ethernetStatus = true;
            }
            else
            {
                ethernetStatus = false;
            }
            return ethernetStatus;
        }

        public static bool CheckForInternetConnection()
        {
            try
            {
                //Ping myPing = new Ping();
                //String host = "google.com";
                //byte[] buffer = new byte[32];
                //int timeout = 2000;
                //PingOptions pingOptions = new PingOptions();
                //PingReply reply = myPing.Send(host, timeout, buffer, pingOptions);
                //return (reply.Status == IPStatus.Success);
                var request = (HttpWebRequest)WebRequest.Create("https://www.google.com/?gws_rd=ssl");
                request.KeepAlive = false;
                request.Timeout = 3000;
                using (var response = (HttpWebResponse)request.GetResponse())
                    return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

    }
}
