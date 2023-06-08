using MailKit.Net.Imap;
using MailKit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MailKit.Net.Pop3;

namespace Lab5
{
    public partial class Bai3 : Form
    {
        public Bai3()
        {
            InitializeComponent();

            lv_Message.Columns[0].Width = (int)(lv_Message.Width * 0.5);
            lv_Message.Columns[1].Width = (int)(lv_Message.Width * 0.25);
            lv_Message.Columns[2].Width = (int)(lv_Message.Width * 0.25);

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            lv_Message.FullRowSelect = true;

            DateTimeOffset dt = DateTime.Today;
            var client = new Pop3Client();
            client.Connect("pop.gmail.com", 995, true);
            client.Authenticate(txtEmail.Text, txtPass.Text);
            int countMail = 0;
            int countCurrentMail = 0;
            int count = client.GetMessageCount();
            for (int i = client.GetMessageCount() - 1; i >= client.GetMessageCount() - 20 ; i--)
            {
                var message = client.GetMessage(i);
                var subject = message.Subject;
                var from = message.From;
                var date = message.Date;
                ListViewItem item = new ListViewItem();
                item.Text = subject.ToString();
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = from.ToString() });
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = date.ToString() });
                lv_Message.Items.Add(item);
                if (date.Day == dt.Day && date.Month == dt.Month && date.Year == dt.Year)
                {
                    countCurrentMail += 1;
                }
                countMail++;
            }
            lblTotalNum.Text = countMail.ToString();
            lblRecentNum.Text = countCurrentMail.ToString();
        }
    }
}
