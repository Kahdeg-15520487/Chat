using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Net;
using System.Net.Sockets;

using SimpleTCP;
using Newtonsoft.Json;

namespace Server
{
    public class Server
    {
        SimpleTcpServer server;

        //list of client that is not in any room
        List<Client> hall;
        //list of room
        List<Room> rooms;

        public Server(int Port)
        {
            server = new SimpleTcpServer();
            server.Start(Port);

            server.ClientConnected += Server_ClientConnected;
            server.ClientDisconnected += Server_ClientDisconnected;
            server.DelimiterDataReceived += Server_DelimiterDataReceived;

            hall = new List<Client>();
            rooms = new List<Room>();
        }

        private void Server_ClientConnected(object sender, TcpClient e)
        {
            Client client = new Client(e);
            hall.Add(client);
        }

        private void Server_DelimiterDataReceived(object sender, Message e)
        {
            Utility.Package msg = new Utility.Package(e.MessageString);
            if (msg.messages == Utility.Messages.Request)
            {
                switch (msg.commands)
                {
                    //only possible if the client is in a room
                    case Utility.Commands.Message:
                        //parse clientid...
                        //return Accept if in a room and Deny if not
                        //return Inform
                        //return data empty
                        break;

                    case Utility.Commands.Broadcast:
                        //send the data to everyone in the same roomid
                        //return Accept if in a room and Deny if not
                        //return Inform
                        //return data empty
                        break;

                    case Utility.Commands.GetRoom:
                        //send the roomid to the client if the client is already in a room
                        //or create a room, add the client in the room, remove client from the hall 
                        //and send that roomid to the client
                        //return Accept
                        //return Inform
                        //return data = roomId
                        break;

                    //only possible if the client is not in a room
                    case Utility.Commands.JoinRoom:
                        //add the client into a room
                        //if the room can add the client
                        //return Accept
                        //return Inform
                        //return data empty
                        //else
                        //return Fail
                        //return Inform
                        //return data = roomId
                        break;

                    default:
                        break;
                }
            }
        }

        private void Server_ClientDisconnected(object sender, TcpClient e)
        {
            foreach (Room room in rooms)
            {
                room.RemoveClient(e);
                return;
            }
        }
    }
}
