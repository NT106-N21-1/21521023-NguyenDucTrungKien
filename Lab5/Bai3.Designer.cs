namespace Lab5
{
    partial class Bai3
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
            lv_Message = new ListView();
            cl_Email = new ColumnHeader();
            cl_From = new ColumnHeader();
            cl_Time = new ColumnHeader();
            btnLogin = new Button();
            txtPass = new TextBox();
            txtEmail = new TextBox();
            lblTotalNum = new Label();
            lblTotal = new Label();
            lblRecentNum = new Label();
            lblRecent = new Label();
            lblPass = new Label();
            lblEmail = new Label();
            SuspendLayout();
            // 
            // lv_Message
            // 
            lv_Message.Columns.AddRange(new ColumnHeader[] { cl_Email, cl_From, cl_Time });
            lv_Message.Location = new Point(12, 149);
            lv_Message.Name = "lv_Message";
            lv_Message.Size = new Size(776, 292);
            lv_Message.TabIndex = 19;
            lv_Message.UseCompatibleStateImageBehavior = false;
            lv_Message.View = View.Details;
            // 
            // cl_Email
            // 
            cl_Email.Text = "Email";
            // 
            // cl_From
            // 
            cl_From.Text = "From";
            // 
            // cl_Time
            // 
            cl_Time.Text = "Thời gian";
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(623, 9);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(165, 60);
            btnLogin.TabIndex = 18;
            btnLogin.Text = "LOGIN";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(91, 42);
            txtPass.Name = "txtPass";
            txtPass.PasswordChar = '*';
            txtPass.Size = new Size(422, 27);
            txtPass.TabIndex = 17;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(91, 9);
            txtEmail.Name = "txtEmail";
            txtEmail.ReadOnly = true;
            txtEmail.Size = new Size(422, 27);
            txtEmail.TabIndex = 16;
            txtEmail.Text = "trungkiennguyen2003@gmail.com";
            // 
            // lblTotalNum
            // 
            lblTotalNum.AutoSize = true;
            lblTotalNum.Location = new Point(91, 101);
            lblTotalNum.Name = "lblTotalNum";
            lblTotalNum.Size = new Size(0, 20);
            lblTotalNum.TabIndex = 15;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(12, 101);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(45, 20);
            lblTotal.TabIndex = 14;
            lblTotal.Text = "Total:";
            // 
            // lblRecentNum
            // 
            lblRecentNum.AutoSize = true;
            lblRecentNum.Location = new Point(372, 101);
            lblRecentNum.Name = "lblRecentNum";
            lblRecentNum.Size = new Size(0, 20);
            lblRecentNum.TabIndex = 13;
            // 
            // lblRecent
            // 
            lblRecent.AutoSize = true;
            lblRecent.Location = new Point(293, 101);
            lblRecent.Name = "lblRecent";
            lblRecent.Size = new Size(57, 20);
            lblRecent.TabIndex = 12;
            lblRecent.Text = "Recent:";
            // 
            // lblPass
            // 
            lblPass.AutoSize = true;
            lblPass.Location = new Point(12, 49);
            lblPass.Name = "lblPass";
            lblPass.Size = new Size(73, 20);
            lblPass.TabIndex = 11;
            lblPass.Text = "Password:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(12, 12);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(49, 20);
            lblEmail.TabIndex = 10;
            lblEmail.Text = "Email:";
            // 
            // Bai3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lv_Message);
            Controls.Add(btnLogin);
            Controls.Add(txtPass);
            Controls.Add(txtEmail);
            Controls.Add(lblTotalNum);
            Controls.Add(lblTotal);
            Controls.Add(lblRecentNum);
            Controls.Add(lblRecent);
            Controls.Add(lblPass);
            Controls.Add(lblEmail);
            Name = "Bai3";
            Text = "Bai3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView lv_Message;
        private ColumnHeader cl_Email;
        private ColumnHeader cl_From;
        private ColumnHeader cl_Time;
        private Button btnLogin;
        private TextBox txtPass;
        private TextBox txtEmail;
        private Label lblTotalNum;
        private Label lblTotal;
        private Label lblRecentNum;
        private Label lblRecent;
        private Label lblPass;
        private Label lblEmail;
    }
}