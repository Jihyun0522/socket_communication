﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace m3501
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Server_Click(object sender, EventArgs e)
        {
            server server = new server();
            server.Show();
        }

        private void Client_Click(object sender, EventArgs e)
        {
            client client = new client();
            client.Show();
        }
    }
}
