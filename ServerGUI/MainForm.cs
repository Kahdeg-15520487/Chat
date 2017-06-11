using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Net;
using System.Net.Sockets;
using WartornNetworking.Utility;
using WartornNetworking.Server;

namespace ServerGUI
{
    public partial class MainForm : Form
    {
        Server server;
        public delegate void MainThreadOperation(string sender,ServerEventArgs e);

        public MainForm()
        {
            Server.Init();
            InitializeComponent();
        }

        private void button_startserver_Click(object sender, EventArgs e)
        {
            int port = 0;
            if (!int.TryParse(txtBox_port.Text,out port))
            {
                return;
            }

            button_startserver.Enabled = false;
            txtBox_port.Enabled = false;

            txtBox_broadcast.Enabled = true;
            button_broadcast.Enabled = true;

            server = new Server(port);
            server.ClientConnected += Server_ClientConnected;
            server.ClientDisconnected += Server_ClientDisconnected;
            server.PackageDataReceived += Server_PackageDataReceived;
        }

        private void Server_ClientConnected(object sender, ServerEventArgs e)
        {
            MainThreadOperation temp = MainThreadListViewLog;
            this.Invoke(temp, "Connected", e);
        }

        private void Server_PackageDataReceived(object sender, ServerEventArgs e)
        {
            MainThreadOperation temp = MainThreadListViewLog;
            this.Invoke(temp, "DataReceived", e);
        }

        private void Server_ClientDisconnected(object sender, ServerEventArgs e)
        {
            MainThreadOperation temp = MainThreadListViewLog;
            this.Invoke(temp, "Disconected", e);
        }

        private void MainThreadListViewLog(string sender, ServerEventArgs e)
        {
            ListViewItem lvi = new ListViewItem();
            int stt = listView_log.Items.Count;
            Client client = e.client;
            lvi.Text = stt.ToString();
            lvi.SubItems.Add(client.clientID);

            switch (sender)
            {
                case "Connected":
                    lvi.SubItems.Add(sender+" : " + (IPEndPoint)(client.tcpclient.Client.RemoteEndPoint));
                    break;
                case "Disconected":
                    lvi.SubItems.Add(sender + " : " + (IPEndPoint)(client.tcpclient.Client.RemoteEndPoint));
                    break;
                case "DataReceived":                    
                    lvi.SubItems.Add(ProcessPackage(client,e.package));
                    break;
                default:
                    break;
            }

            listView_log.Items.Add(lvi);
            listView_log.Items[stt].EnsureVisible();
        }

        private string ProcessPackage(Client client,Package package)
        {
            string result = string.Empty;
            if (package.messages == Messages.Request)
            {
                switch (package.commands)
                {
                    //send a private message to another client
                    case Commands.Message:
                        var datas = package.data.Split('|');
                        result = string.Format("{0} sent {1} : {2}", client.clientID, datas[0], datas[1]);
                        break;

                    //send a broadcast message to everyone who are in the same room as client
                    case Commands.Broadcast:
                        result = string.Format("{0} broadcasted : {1}", client.clientID, package.data);
                        break;

                    //get the roomid of the client
                    case Commands.GetRoom:
                        result = string.Format("{0} request his roomID : {1}", client.clientID, client.roomID);
                        break;

                    //create a new room and move into it
                    case Commands.CreateRoom:
                        result = string.Format("{0} request a new room : {1}",client.clientID,client.roomID);
                        break;

                    //join an existing room
                    case Commands.JoinRoom:
                        result = string.Format("{0} join a room : {1}", client.clientID, client.roomID);
                        break;

                    case Commands.GetClientID:
                        result = string.Format("{0} request his clientID", client.clientID);
                        break;

                    default:
                        break;
                }
            }
            return result;
        }

        private void txtBox_port_TextChanged(object sender, EventArgs e)
        {
            int port = 9090;
            if (!int.TryParse(txtBox_port.Text,out port))
            {
                txtBox_port.Text = "9090";
                return;
            }

            if (port == 0)
            {
                txtBox_port.Text = "9090";
            }
        }

        private void button_refresh_Click(object sender, EventArgs e)
        {
            if (listView_rooms.Items.Count>0)
            {
                listView_rooms.Items.Clear();
            }

            ListViewItem lvi;
            foreach (var kvp in server.rooms)
            {
                lvi = new ListViewItem();
                lvi.Text = kvp.Key;
                lvi.SubItems.Add(kvp.Value.ClientsCount.ToString());
                listView_rooms.Items.Add(lvi);
            }

            if (listView_clients.Items.Count>0)
            {
                listView_clients.Items.Clear();
            }

            foreach (var kvp in server.clients)
            {
                lvi = new ListViewItem();
                lvi.Text = kvp.Key;
                lvi.SubItems.Add(kvp.Value.IP.Address + ":" + kvp.Value.IP.Port);
                lvi.SubItems.Add(kvp.Value.State.ToString());
                listView_clients.Items.Add(lvi);
            }
        }

        private void button_broadcast_Click(object sender, EventArgs e)
        {
            server.BroadcastMessage(txtBox_broadcast.Text);
        }
    }
}
