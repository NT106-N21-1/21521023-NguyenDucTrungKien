﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Bai3 : Form
    {
        public Bai3()
        {
            InitializeComponent();
        }

        private void btn_Server_Click(object sender, EventArgs e)
        {
            Bai3_Server server = new Bai3_Server();
            server.Show();
        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            Bai3_Client client = new Bai3_Client();
            client.Show();
        }
    }
}
