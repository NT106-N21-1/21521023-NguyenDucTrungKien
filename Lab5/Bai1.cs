using MailKit.Net.Smtp;
using MimeKit;

namespace Lab5
{
    public partial class Bai1 : Form
    {
        public Bai1()
        {
            InitializeComponent();
        }

        private void btnSend_Click_1(object sender, EventArgs e)
        {
            int countA_From = 0;
            int countDot_From = 0;
            int countA_To = 0;
            int countDot_To = 0;

            var client = new SmtpClient();
            client.Connect("smtp.gmail.com", 465, true);
            client.Authenticate("trungkiennguyen2003@gmail.com", "bdjmomnrdwaaqptu");

            for(int i = 0; i < txtFrom.Text.Length; i++)
            {
                if (txtFrom.Text[i] == '@')
                    countA_From++;
                if (txtFrom.Text[i] == '.')
                    countDot_From++;
            }
            for (int i = 0; i < txtTo.Text.Length; i++)
            {
                if (txtTo.Text[i] == '@')
                    countA_To++;
                if (txtTo.Text[i] == '.')
                    countDot_To++;
            }

            if(txtFrom.Text == "" || countA_From == 0 || countDot_From == 0)
            {
                MessageBox.Show("Địa chỉ mail gửi không đúng. Vui lòng nhập lại!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtTo.Text == "" || countA_To == 0 || countDot_To == 0)
            {
                MessageBox.Show("Địa chỉ mail nhận không đúng. Vui lòng nhập lại!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(rtbBody.Text == "")
            {
                MessageBox.Show("Vui lòng nhập nội dung thư!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var message = new MimeMessage();
                message.From.Add(new MailboxAddress("Nguyễn Đức Trung Kiên", txtFrom.Text));
                message.To.Add(new MailboxAddress("", txtTo.Text));
                message.Subject = txtSubj.Text;
                message.Body = new TextPart("plain")
                {
                    Text = rtbBody.Text
                };

                client.Send(message);
                MessageBox.Show("Gửi mail thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}