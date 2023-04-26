using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB03_BAI04
{
    public partial class Cau4 : Form
    {
        public Cau4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Sever sever = new Sever();
            sever.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Client client = new Client();
            client.ShowDialog();
        }
    }
}
