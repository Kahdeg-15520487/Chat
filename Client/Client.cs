using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Net;
using System.Net.Sockets;

using SimpleTCP;
using Utility;
using Newtonsoft.Json;

namespace Client
{
    public class Client
    {
        SimpleTcpClient tcpclient;

        public Client(IPAddress ipaddress,int Port)
        {
            tcpclient.Connect(ipaddress.ToString(), Port);

            tcpclient.DelimiterDataReceived += Tcpclient_DelimiterDataReceived;    
        }

        public void SendMessage(string clientId,string data)
        {
            Package msg = new Utility.Package(Utility.Messages.Request, Utility.Commands.Message, clientId + "|" + data);
            SendPackageToServer(msg);
        }

        private void SendPackageToServer(Utility.Package msg)
        {
            string package = JsonConvert.SerializeObject(msg);
            tcpclient.WriteLine(package);
        }

        private void Tcpclient_DelimiterDataReceived(object sender, Message e)
        {
            Utility.Package msg = new Utility.Package(e.MessageString);
        }
    }
}
