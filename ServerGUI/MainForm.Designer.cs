namespace ServerGUI
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
            this.button_startserver = new System.Windows.Forms.Button();
            this.label_trangthai = new System.Windows.Forms.Label();
            this.txtBox_broadcast = new System.Windows.Forms.TextBox();
            this.button_broadcast = new System.Windows.Forms.Button();
            this.listView_log = new System.Windows.Forms.ListView();
            this.STT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clientID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.package = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView_rooms = new System.Windows.Forms.ListView();
            this.roomID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clientsNum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button_refresh = new System.Windows.Forms.Button();
            this.listView_clients = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            this.ipAddressBox.ReadOnly = true;
            this.ipAddressBox.Size = new System.Drawing.Size(87, 20);
            this.ipAddressBox.TabIndex = 1;
            this.ipAddressBox.Text = "...";
            // 
            // txtBox_port
            // 
            this.txtBox_port.Location = new System.Drawing.Point(105, 12);
            this.txtBox_port.Name = "txtBox_port";
            this.txtBox_port.Size = new System.Drawing.Size(37, 20);
            this.txtBox_port.TabIndex = 2;
            this.txtBox_port.Text = "9090";
            this.txtBox_port.TextChanged += new System.EventHandler(this.txtBox_port_TextChanged);
            // 
            // button_startserver
            // 
            this.button_startserver.Location = new System.Drawing.Point(12, 71);
            this.button_startserver.Name = "button_startserver";
            this.button_startserver.Size = new System.Drawing.Size(130, 50);
            this.button_startserver.TabIndex = 3;
            this.button_startserver.Text = "Start Server";
            this.button_startserver.UseVisualStyleBackColor = true;
            this.button_startserver.Click += new System.EventHandler(this.button_startserver_Click);
            // 
            // label_trangthai
            // 
            this.label_trangthai.AutoSize = true;
            this.label_trangthai.Location = new System.Drawing.Point(12, 46);
            this.label_trangthai.Name = "label_trangthai";
            this.label_trangthai.Size = new System.Drawing.Size(47, 13);
            this.label_trangthai.TabIndex = 4;
            this.label_trangthai.Text = "Stopped";
            // 
            // txtBox_broadcast
            // 
            this.txtBox_broadcast.Enabled = false;
            this.txtBox_broadcast.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_broadcast.Location = new System.Drawing.Point(148, 301);
            this.txtBox_broadcast.Name = "txtBox_broadcast";
            this.txtBox_broadcast.Size = new System.Drawing.Size(553, 20);
            this.txtBox_broadcast.TabIndex = 6;
            // 
            // button_broadcast
            // 
            this.button_broadcast.Enabled = false;
            this.button_broadcast.Location = new System.Drawing.Point(707, 298);
            this.button_broadcast.Name = "button_broadcast";
            this.button_broadcast.Size = new System.Drawing.Size(75, 23);
            this.button_broadcast.TabIndex = 7;
            this.button_broadcast.Text = "Send";
            this.button_broadcast.UseVisualStyleBackColor = true;
            this.button_broadcast.Click += new System.EventHandler(this.button_broadcast_Click);
            // 
            // listView_log
            // 
            this.listView_log.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.STT,
            this.clientID,
            this.package});
            this.listView_log.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView_log.Location = new System.Drawing.Point(148, 12);
            this.listView_log.Name = "listView_log";
            this.listView_log.Size = new System.Drawing.Size(634, 280);
            this.listView_log.TabIndex = 8;
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
            this.package.Width = 450;
            // 
            // listView_rooms
            // 
            this.listView_rooms.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.roomID,
            this.clientsNum});
            this.listView_rooms.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView_rooms.Location = new System.Drawing.Point(788, 12);
            this.listView_rooms.Name = "listView_rooms";
            this.listView_rooms.Size = new System.Drawing.Size(218, 280);
            this.listView_rooms.TabIndex = 9;
            this.listView_rooms.UseCompatibleStateImageBehavior = false;
            this.listView_rooms.View = System.Windows.Forms.View.Details;
            // 
            // roomID
            // 
            this.roomID.Text = "RoomID";
            this.roomID.Width = 151;
            // 
            // clientsNum
            // 
            this.clientsNum.Text = "clients";
            // 
            // button_refresh
            // 
            this.button_refresh.Location = new System.Drawing.Point(788, 295);
            this.button_refresh.Name = "button_refresh";
            this.button_refresh.Size = new System.Drawing.Size(93, 23);
            this.button_refresh.TabIndex = 10;
            this.button_refresh.Text = "Refresh";
            this.button_refresh.UseVisualStyleBackColor = true;
            this.button_refresh.Click += new System.EventHandler(this.button_refresh_Click);
            // 
            // listView_clients
            // 
            this.listView_clients.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView_clients.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView_clients.Location = new System.Drawing.Point(1012, 12);
            this.listView_clients.Name = "listView_clients";
            this.listView_clients.Size = new System.Drawing.Size(239, 280);
            this.listView_clients.TabIndex = 11;
            this.listView_clients.UseCompatibleStateImageBehavior = false;
            this.listView_clients.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ClientID";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "IP";
            this.columnHeader2.Width = 106;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Status";
            this.columnHeader3.Width = 68;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1263, 330);
            this.Controls.Add(this.listView_clients);
            this.Controls.Add(this.button_refresh);
            this.Controls.Add(this.listView_rooms);
            this.Controls.Add(this.listView_log);
            this.Controls.Add(this.button_broadcast);
            this.Controls.Add(this.txtBox_broadcast);
            this.Controls.Add(this.label_trangthai);
            this.Controls.Add(this.button_startserver);
            this.Controls.Add(this.txtBox_port);
            this.Controls.Add(this.ipAddressBox);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private IPAddressControlLib.IPAddressControl ipAddressBox;
        private System.Windows.Forms.TextBox txtBox_port;
        private System.Windows.Forms.Label label_trangthai;
        private System.Windows.Forms.Button button_startserver;
        private System.Windows.Forms.TextBox txtBox_broadcast;
        private System.Windows.Forms.Button button_broadcast;
        private System.Windows.Forms.ListView listView_log;
        private System.Windows.Forms.ColumnHeader STT;
        private System.Windows.Forms.ColumnHeader clientID;
        private System.Windows.Forms.ColumnHeader package;
        private System.Windows.Forms.ListView listView_rooms;
        private System.Windows.Forms.ColumnHeader roomID;
        private System.Windows.Forms.ColumnHeader clientsNum;
        private System.Windows.Forms.Button button_refresh;
        private System.Windows.Forms.ListView listView_clients;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}

