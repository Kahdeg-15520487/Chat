﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    public class Client : IEquatable<Client>
    {
        public readonly string clientID;
        public readonly TcpClient tcpclient;

        public Client(TcpClient c)
        {
            clientID = Convert.ToBase64String(Guid.NewGuid().ToByteArray());
            tcpclient = c;
        }

        public bool Equals(Client other)
        {
            return string.Compare(clientID, other.clientID) == 0 || tcpclient == other.tcpclient;
        }
    }
}