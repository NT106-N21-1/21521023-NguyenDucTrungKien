using MailKit;
using MailKit.Net.Imap;
using MailKit.Net.Smtp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5
{
    public partial class Bai2 : Form
    {
        public Bai2()
        {
            InitializeComponent();

            lv_Message.Columns[0].Width = (int)(lv_Message.Width * 0.5);
            lv_Message.Columns[1].Width = (int)(lv_Message.Width * 0.25);
            lv_Message.Columns[2].Width = (int)(lv_Message.Width * 0.25);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtPass.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                btnLogin.Enabled = false;
                MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lv_Message.FullRowSelect = true;

                DateTimeOffset dt = DateTime.Today;
                int countMail = 0;
                int countCurrentMail = 0;
                var client = new ImapClient();
                client.Connect("imap.gmail.com", 993, true);
                client.Authenticate(txtEmail.Text, txtPass.Text);
                var inbox = client.Inbox;
                inbox.Open(FolderAccess.ReadOnly);
                for (int i = inbox.Count - 1; i >= inbox.Count - 1 - 19; i--)
                {
                    var message = inbox.GetMessage(i);
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
}
