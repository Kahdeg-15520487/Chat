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

        public event EventHandler<ClientEventArts> MessageReceived;
        public event EventHandler<ClientEventArts> Disconnected;

        public Client(IPAddress ipaddress,int Port)
        {
            tcpclient = new SimpleTcpClient();

            tcpclient.Connect(ipaddress.ToString(), Port);

            tcpclient.DelimiterDataReceived += Tcpclient_DelimiterDataReceived;    
        }

        public void SendMessage(string clientId,string message)
        {
            Package package = new Package(Messages.Request, Commands.Message, clientId + "|" + message);
            SendPackageToServer(package);
        }

        public void BroadcastMessage(string message)
        {
            Package package = new Package(Messages.Request, Commands.Broadcast,message);
            SendPackageToServer(package);
        }


        public string GetRoomId()
        {
            Package package = new Package(Messages.Request, Commands.GetRoom, "");
            Package reply = SendPackageToServer(package,isGetReply: true);
            string roomId = reply.data;
            //do something with the received roomId;
            return roomId;
        }

        /// <summary>
        /// join a room on the server with roomId
        /// </summary>
        /// <param name="roomId"></param>
        /// <returns>true if successfully join the room</returns>
        public bool JoinRoom(string roomId)
        {
            Package package = new Package(Messages.Request, Commands.JoinRoom, roomId);
            Package reply = SendPackageToServer(package, isGetReply: true);
            switch (reply.messages)
            {
                case Messages.Success:
                    //joined the room
                    break;
                case Messages.Fail:
                    //the room is not exist
                    break;
                default:
                    break;
            }
            return reply.messages == Messages.Accept;
        }

        private Package SendPackageToServer(Package package, bool isGetReply = false)
        {
            string packageConverted = JsonConvert.SerializeObject(package);
            if (isGetReply)
            {
                Message reply = tcpclient.WriteLineAndGetReply(packageConverted, TimeSpan.FromSeconds(Constants.MaxTimeOut));
                Package replyPackage = JsonConvert.DeserializeObject<Package>(reply.MessageString);
                return replyPackage;
            }
            else
            {
                tcpclient.WriteLine(packageConverted);
                return new Package(Messages.Accept, Commands.Inform, "");
            }
        }

        private void Tcpclient_DelimiterDataReceived(object sender, Message e)
        {
            Package package = JsonConvert.DeserializeObject<Package>(e.MessageString);
            switch (package.messages)
            {
                case Messages.Accept:
                    switch (package.commands)
                    {
                        case Commands.Message:
                            //receive a message from another clientId
                            OnMessageReceived(package);
                            break;
                        case Commands.Inform:
                            //get information from server
                            break;
                        default:
                            break;
                    }
                    break;
                default:
                    break;
            }
        }

        private void OnMessageReceived(Package package)
        {
            MessageReceived?.Invoke(this, new ClientEventArts(package));
        }
    }

    public class ClientEventArts: EventArgs
    {
        public Package package { get; private set; }
        public ClientEventArts(Package package)
        {
            this.package = package;
        }
    }
}
