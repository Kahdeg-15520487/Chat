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
using WartornNetworking.Utility;

namespace ClientGui
{
    public partial class createjoinroom : Form
    {
        private Client client;

        public string RoomID { get; private set; }

        public createjoinroom(Client client)
        {
            this.client = client;
            InitializeComponent();
        }

        private void button_join_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBox_roomid.Text))
            {
                return;
            }

            bool reply = client.JoinRoom(txtBox_roomid.Text);
                 
            if (reply)
            {
                MessageBox.Show("Joined room successfully!");
                RoomID = client.GetRoomID();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Room does not exist!");
            }
        }

        private void button_create_Click(object sender, EventArgs e)
        {
            RoomID = client.CreateRoom();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
