﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientGui
{
    public partial class ListViewDialog : Form
    {
        private List<string> itemList;
        public ListViewDialog(List<string> itemlist)
        {
            itemList = itemlist;
            InitializeComponent();
            listBox.DataSource = itemList;
        }
    }
}
