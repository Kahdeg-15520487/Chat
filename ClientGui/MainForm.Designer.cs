namespace ClientGui
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ipAddressBox = new IPAddressControlLib.IPAddressControl();
            this.txtBox_port = new System.Windows.Forms.TextBox();
            this.button_connect = new System.Windows.Forms.Button();
            this.listView_log = new System.Windows.Forms.ListView();
            this.STT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clientID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.package = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button_send = new System.Windows.Forms.Button();
            this.txtBox_send = new System.Windows.Forms.TextBox();
            this.txtBox_roomid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBox_clientid = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ipAddressBox
            // 
            this.ipAddressBox.AllowInternalTab = false;
            this.ipAddressBox.AutoHeight = true;
            this.ipAddressBox.BackColor = System.Drawing.SystemColors.Window;
            this.ipAddressBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ipAddressBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ipAddressBox.Location = new System.Drawing.Point(12, 12);
            this.ipAddressBox.MinimumSize = new System.Drawing.Size(87, 20);
            this.ipAddressBox.Name = "ipAddressBox";
            this.ipAddressBox.ReadOnly = false;
            this.ipAddressBox.Size = new System.Drawing.Size(87, 20);
            this.ipAddressBox.TabIndex = 0;
            this.ipAddressBox.Text = "52.187.31.71";
            // 
            // txtBox_port
            // 
            this.txtBox_port.Location = new System.Drawing.Point(105, 12);
            this.txtBox_port.Name = "txtBox_port";
            this.txtBox_port.Size = new System.Drawing.Size(39, 20);
            this.txtBox_port.TabIndex = 1;
            this.txtBox_port.Text = "9090";
            // 
            // button_connect
            // 
            this.button_connect.Location = new System.Drawing.Point(12, 38);
            this.button_connect.Name = "button_connect";
            this.button_connect.Size = new System.Drawing.Size(132, 45);
            this.button_connect.TabIndex = 2;
            this.button_connect.Text = "Connect";
            this.button_connect.UseVisualStyleBackColor = true;
            this.button_connect.Click += new System.EventHandler(this.button_connect_Click);
            // 
            // listView_log
            // 
            this.listView_log.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listView_log.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.STT,
            this.clientID,
            this.package});
            this.listView_log.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView_log.Location = new System.Drawing.Point(150, 12);
            this.listView_log.Name = "listView_log";
            this.listView_log.Size = new System.Drawing.Size(448, 212);
            this.listView_log.TabIndex = 3;
            this.listView_log.UseCompatibleStateImageBehavior = false;
            this.listView_log.View = System.Windows.Forms.View.Details;
            // 
            // STT
            // 
            this.STT.Text = "";
            this.STT.Width = 27;
            // 
            // clientID
            // 
            this.clientID.Text = "ClientID";
            this.clientID.Width = 150;
            // 
            // package
            // 
            this.package.Text = "Package";
            this.package.Width = 195;
            // 
            // button_send
            // 
            this.button_send.Enabled = false;
            this.button_send.Location = new System.Drawing.Point(523, 230);
            this.button_send.Name = "button_send";
            this.button_send.Size = new System.Drawing.Size(75, 23);
            this.button_send.TabIndex = 4;
            this.button_send.Text = "Send";
            this.button_send.UseVisualStyleBackColor = true;
            this.button_send.Click += new System.EventHandler(this.button_send_Click);
            // 
            // txtBox_send
            // 
            this.txtBox_send.Enabled = false;
            this.txtBox_send.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_send.Location = new System.Drawing.Point(150, 232);
            this.txtBox_send.Name = "txtBox_send";
            this.txtBox_send.Size = new System.Drawing.Size(367, 20);
            this.txtBox_send.TabIndex = 5;
            this.txtBox_send.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBox_send_KeyUp);
            // 
            // txtBox_roomid
            // 
            this.txtBox_roomid.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_roomid.Location = new System.Drawing.Point(12, 158);
            this.txtBox_roomid.Name = "txtBox_roomid";
            this.txtBox_roomid.ReadOnly = true;
            this.txtBox_roomid.Size = new System.Drawing.Size(132, 20);
            this.txtBox_roomid.TabIndex = 6;
            this.txtBox_roomid.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.txtBox_roomid_MouseDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "RoomID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "ClientID";
            // 
            // txtBox_clientid
            // 
            this.txtBox_clientid.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_clientid.Location = new System.Drawing.Point(12, 119);
            this.txtBox_clientid.Name = "txtBox_clientid";
            this.txtBox_clientid.ReadOnly = true;
            this.txtBox_clientid.Size = new System.Drawing.Size(132, 20);
            this.txtBox_clientid.TabIndex = 9;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 261);
            this.Controls.Add(this.txtBox_clientid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBox_roomid);
            this.Controls.Add(this.txtBox_send);
            this.Controls.Add(this.button_send);
            this.Controls.Add(this.listView_log);
            this.Controls.Add(this.button_connect);
            this.Controls.Add(this.txtBox_port);
            this.Controls.Add(this.ipAddressBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private IPAddressControlLib.IPAddressControl ipAddressBox;
        private System.Windows.Forms.TextBox txtBox_port;
        private System.Windows.Forms.Button button_connect;
        private System.Windows.Forms.ListView listView_log;
        private System.Windows.Forms.Button button_send;
        private System.Windows.Forms.TextBox txtBox_send;
        private System.Windows.Forms.ColumnHeader STT;
        private System.Windows.Forms.ColumnHeader clientID;
        private System.Windows.Forms.ColumnHeader package;
        private System.Windows.Forms.TextBox txtBox_roomid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBox_clientid;
    }
}

