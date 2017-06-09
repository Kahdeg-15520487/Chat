using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    public class Room
    {
        public readonly string roomID;
        public List<Client> clients { get; private set; }

        public Room()
        {
            roomID = Convert.ToBase64String(Guid.NewGuid().ToByteArray());
            clients = new List<Client>();
        }

        public void AddClient(Client c)
        {
            if (!clients.Contains(c))
            {
                clients.Add(c);
            }
        }

        public void RemoveClient(string clientid)
        {
            clients.RemoveAll(c => string.Compare(c.clientID, clientid) == 0);
        }

        public void RemoveClient(TcpClient tcpclient)
        {
            clients.RemoveAll(c => c.tcpclient == tcpclient);
        }
    }
}
