using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using WartornNetworking.Client;
using System.Net;
using System.Net.Sockets;
using WartornNetworking.Utility;

namespace ClientGui
{
    public partial class MainForm : Form
    {
        Client client;
        public delegate void MainThreadOperation(string sender, ClientEventArts e);

        public MainForm()
        {
            Client.Init();
            InitializeComponent();
        }

        private void button_connect_Click(object sender, EventArgs e)
        {
            int port = 0;
            if (!int.TryParse(txtBox_port.Text, out port))
            {
                return;
            }
            IPAddress ipAddress = IPAddress.Any;
            if (!IPAddress.TryParse(ipAddressBox.Text,out ipAddress))
            {
                return;
            }

            button_connect.Enabled = false;
            ipAddressBox.Enabled = false;
            txtBox_port.Enabled = false;

            button_send.Enabled = true;
            txtBox_send.Enabled = true;
            button_listrooms.Enabled = true;
            button_listclients.Enabled = true;

            client = new Client(ipAddress, port);
            client.MessageReceived += Client_MessageReceived;
            client.Disconnected += Client_Disconnected;

            txtBox_clientid.Text = client.GetClientID();
            txtBox_roomid.Text = client.GetRoomID();
        }

        private void Client_Disconnected(object sender, ClientEventArts e)
        {
            MainThreadOperation temp = MainThreadListViewLog;
            this.Invoke(temp, "Disconnected", e);
        }

        private void Client_MessageReceived(object sender, ClientEventArts e)
        {
            MainThreadOperation temp = MainThreadListViewLog;
            this.Invoke(temp, "MessageReceived", e);
        }

        private void MainThreadListViewLog(string sender,ClientEventArts e)
        {
            ListViewItem lvi = new ListViewItem();
            int stt = listView_log.Items.Count;
            lvi.Text = stt.ToString();
            var datas = e.package.data.Split('|');
            lvi.SubItems.Add(datas[0]);
            lvi.SubItems.Add(datas[1]);

            listView_log.Items.Add(lvi);
            listView_log.Items[stt].EnsureVisible();
        }

        private void button_send_Click(object sender, EventArgs e)
        {
            SendMessage();
        }

        private void txtBox_roomid_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            using (CreateJoinRoomDialog tempform = new CreateJoinRoomDialog(client))
            {
                DialogResult dialogReult = tempform.ShowDialog();
                if (dialogReult == DialogResult.OK)
                {
                    txtBox_roomid.Text = tempform.RoomID;
                }
            }
        }

        private void txtBox_send_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendMessage();
            }
        }

        private void SendMessage()
        {
            client.BroadcastMessage(txtBox_send.Text.Replace("|", string.Empty));
            txtBox_send.Text = "";
        }

        private void button_listrooms_Click(object sender, EventArgs e)
        {
            List<string> roomlist = client.GetRooms().ToList();
            using (ListViewDialog listviewdialog = new ListViewDialog(roomlist))
            {
                listviewdialog.ShowDialog();
            }
        }

        private void button_listclients_Click(object sender, EventArgs e)
        {
            List<string> clientlist = client.GetClients().ToList();
            using (ListViewDialog listviewdialog = new ListViewDialog(clientlist))
            {
                listviewdialog.ShowDialog();
            }
        }
    }
}
