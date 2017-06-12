namespace ClientGui
{
    partial class CreateJoinRoomDialog
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button_canceljoin = new System.Windows.Forms.Button();
            this.button_join = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBox_roomid = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button_cancelcreate = new System.Windows.Forms.Button();
            this.button_create = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBox_roomidcreate = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, -2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(194, 128);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button_canceljoin);
            this.tabPage1.Controls.Add(this.button_join);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txtBox_roomid);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(186, 102);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Join Room";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button_canceljoin
            // 
            this.button_canceljoin.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_canceljoin.Location = new System.Drawing.Point(108, 62);
            this.button_canceljoin.Name = "button_canceljoin";
            this.button_canceljoin.Size = new System.Drawing.Size(75, 23);
            this.button_canceljoin.TabIndex = 3;
            this.button_canceljoin.Text = "Cancel";
            this.button_canceljoin.UseVisualStyleBackColor = true;
            // 
            // button_join
            // 
            this.button_join.Location = new System.Drawing.Point(3, 62);
            this.button_join.Name = "button_join";
            this.button_join.Size = new System.Drawing.Size(75, 23);
            this.button_join.TabIndex = 2;
            this.button_join.Text = "Join";
            this.button_join.UseVisualStyleBackColor = true;
            this.button_join.Click += new System.EventHandler(this.button_join_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "RoomID";
            // 
            // txtBox_roomid
            // 
            this.txtBox_roomid.Location = new System.Drawing.Point(77, 18);
            this.txtBox_roomid.Name = "txtBox_roomid";
            this.txtBox_roomid.Size = new System.Drawing.Size(100, 20);
            this.txtBox_roomid.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button_cancelcreate);
            this.tabPage2.Controls.Add(this.button_create);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.txtBox_roomidcreate);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(186, 102);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Create Room";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button_cancelcreate
            // 
            this.button_cancelcreate.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_cancelcreate.Location = new System.Drawing.Point(108, 62);
            this.button_cancelcreate.Name = "button_cancelcreate";
            this.button_cancelcreate.Size = new System.Drawing.Size(75, 23);
            this.button_cancelcreate.TabIndex = 7;
            this.button_cancelcreate.Text = "Cancel";
            this.button_cancelcreate.UseVisualStyleBackColor = true;
            // 
            // button_create
            // 
            this.button_create.Location = new System.Drawing.Point(3, 62);
            this.button_create.Name = "button_create";
            this.button_create.Size = new System.Drawing.Size(75, 23);
            this.button_create.TabIndex = 6;
            this.button_create.Text = "Create";
            this.button_create.UseVisualStyleBackColor = true;
            this.button_create.Click += new System.EventHandler(this.button_create_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "RoomID";
            // 
            // txtBox_roomidcreate
            // 
            this.txtBox_roomidcreate.Location = new System.Drawing.Point(77, 18);
            this.txtBox_roomidcreate.Name = "txtBox_roomidcreate";
            this.txtBox_roomidcreate.ReadOnly = true;
            this.txtBox_roomidcreate.Size = new System.Drawing.Size(100, 20);
            this.txtBox_roomidcreate.TabIndex = 4;
            // 
            // createjoinroom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(193, 124);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "createjoinroom";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Join/Create Room";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button_canceljoin;
        private System.Windows.Forms.Button button_join;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBox_roomid;
        private System.Windows.Forms.Button button_cancelcreate;
        private System.Windows.Forms.Button button_create;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBox_roomidcreate;
    }
}