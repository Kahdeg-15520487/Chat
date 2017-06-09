using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Net;
using System.Net.Sockets;

using SimpleTCP;
using Newtonsoft.Json;
using Utility;

namespace Server
{
    public class Server
    {
        SimpleTcpServer server;

        //list of client that is connected
        List<Client> clients;
        //list of client that is not in any room
        Room hall;
        //list of room
        List<Room> rooms;

        public Server(int Port)
        {
            server = new SimpleTcpServer();
            server.Start(Port);

            server.ClientConnected += Server_ClientConnected;
            server.ClientDisconnected += Server_ClientDisconnected;
            server.DelimiterDataReceived += Server_DelimiterDataReceived;

            clients = new List<Client>();
            hall = new Room();
            rooms = new List<Room>();
        }

        private void Server_ClientConnected(object sender, TcpClient e)
        {
            Client client = new Client(e);
            clients.Add(client);
            hall.AddClient(client);
        }

        private void SendPackageToClient(Client client,Package package)
        {
            server.WriteLine(client.tcpclient, JsonConvert.SerializeObject(package));
        }

        private Room FindRoomThatHaveClient(string clientId)
        {
            Room result = null;

            foreach (Room room in rooms)
            {
                foreach (Client client in room.clients)
                {
                    if (string.Compare(clientId,client.clientID)==0)
                    {
                        result = room;
                        return result;
                    }
                }
            }
            return result;
        }

        private Room FindRoom(string roomId)
        {
            Room result = null;

            rooms.ForEach(room =>
            {
                if (string.Compare(room.roomID,roomId)==0)
                {
                    result = room;
                }
            });
            return result;
        }

        private Client FindClient(string clientId)
        {
            Client result = null;

            clients.ForEach(client =>
            {
                if ( string.Compare(client.clientID,clientId)==0)
                {
                    result = client;
                    return;
                }
            });

            return result;
        }

        private void Server_DelimiterDataReceived(object sender, Message e)
        {
            Package msg = new Package(e.MessageString);
            Package reply;
            Client client = clients.Find(c => c.tcpclient == e.TcpClient);
            Room room = FindRoom(client.clientID);
            if (msg.messages == Utility.Messages.Request)
            {
                switch (msg.commands)
                {
                    //only possible if the client is in a room
                    case Utility.Commands.Message:
                        var datas = msg.data.Split('|');
                        //parse receiver clientid...
                        //string receiver = datas[0];
                        Client receiver = FindClient(datas[0]);
                        //check if receiver is connected
                        if (receiver != null)
                        {
                            //send success to the client
                            SendPackageToClient(client, new Package(Messages.Success, Commands.Inform, "Message sent."));
                            //send the message to the receiver
                            SendPackageToClient(receiver, new Package(Messages.Request, Commands.Message, client.clientID + "|" + datas[1]));
                        }
                        else
                        {
                            //send fail to the client
                            SendPackageToClient(client, new Package(Messages.Fail, Commands.Inform, "There is no such client"));
                        }
                        break;

                    case Utility.Commands.Broadcast:
                        reply = new Package(Messages.Request, Commands.Message, client.clientID + "|" + msg.data);
                        //check if the client is not in the hall
                        if (hall.ContainClient(client))
                        {
                            //send the message to everyone in the hall
                            foreach (Client rev in hall.clients)
                            {
                                SendPackageToClient(rev, reply);
                            }
                        }
                        else
                        {
                            //send the data to everyone in the same roomid
                            foreach (Client rev in room.clients)
                            {
                                SendPackageToClient(rev, reply);
                            }
                        }
                        //return Accept if in a room and Deny if not
                        //return Inform
                        //return data empty
                        SendPackageToClient(client, new Package(Messages.Success, Commands.Inform, "Message sent."));
                        break;

                    case Utility.Commands.GetRoom:
                        //send the roomid to the client if the client is already in a room
                        if ()
                        {
                            reply = new Package(Messages.Success,Commands.Inform,)
                        }
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
