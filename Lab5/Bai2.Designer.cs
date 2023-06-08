namespace Lab5
{
    partial class Bai2
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
            lblEmail = new Label();
            lblPass = new Label();
            lblRecent = new Label();
            lblRecentNum = new Label();
            lblTotal = new Label();
            lblTotalNum = new Label();
            txtEmail = new TextBox();
            txtPass = new TextBox();
            btnLogin = new Button();
            lv_Message = new ListView();
            cl_Email = new ColumnHeader();
            cl_From = new ColumnHeader();
            cl_Time = new ColumnHeader();
            SuspendLayout();
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(12, 9);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(49, 20);
            lblEmail.TabIndex = 0;
            lblEmail.Text = "Email:";
            // 
            // lblPass
            // 
            lblPass.AutoSize = true;
            lblPass.Location = new Point(12, 46);
            lblPass.Name = "lblPass";
            lblPass.Size = new Size(73, 20);
            lblPass.TabIndex = 1;
            lblPass.Text = "Password:";
            // 
            // lblRecent
            // 
            lblRecent.AutoSize = true;
            lblRecent.Location = new Point(293, 98);
            lblRecent.Name = "lblRecent";
            lblRecent.Size = new Size(57, 20);
            lblRecent.TabIndex = 2;
            lblRecent.Text = "Recent:";
            // 
            // lblRecentNum
            // 
            lblRecentNum.AutoSize = true;
            lblRecentNum.Location = new Point(372, 98);
            lblRecentNum.Name = "lblRecentNum";
            lblRecentNum.Size = new Size(0, 20);
            lblRecentNum.TabIndex = 3;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(12, 98);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(45, 20);
            lblTotal.TabIndex = 4;
            lblTotal.Text = "Total:";
            // 
            // lblTotalNum
            // 
            lblTotalNum.AutoSize = true;
            lblTotalNum.Location = new Point(91, 98);
            lblTotalNum.Name = "lblTotalNum";
            lblTotalNum.Size = new Size(0, 20);
            lblTotalNum.TabIndex = 5;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(91, 6);
            txtEmail.Name = "txtEmail";
            txtEmail.ReadOnly = true;
            txtEmail.Size = new Size(422, 27);
            txtEmail.TabIndex = 6;
            txtEmail.Text = "trungkiennguyen2003@gmail.com";
            // 
            // txtPass
            // 
            txtPass.Location = new Point(91, 39);
            txtPass.Name = "txtPass";
            txtPass.PasswordChar = '*';
            txtPass.Size = new Size(422, 27);
            txtPass.TabIndex = 7;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(623, 6);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(165, 60);
            btnLogin.TabIndex = 8;
            btnLogin.Text = "LOGIN";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // lv_Message
            // 
            lv_Message.Columns.AddRange(new ColumnHeader[] { cl_Email, cl_From, cl_Time });
            lv_Message.Location = new Point(12, 146);
            lv_Message.Name = "lv_Message";
            lv_Message.Size = new Size(776, 292);
            lv_Message.TabIndex = 9;
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
            // Bai2
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
            Name = "Bai2";
            Text = "Bai2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblEmail;
        private Label lblPass;
        private Label lblRecent;
        private Label lblRecentNum;
        private Label lblTotal;
        private Label lblTotalNum;
        private TextBox txtEmail;
        private TextBox txtPass;
        private Button btnLogin;
        private ListView lv_Message;
        private ColumnHeader cl_Email;
        private ColumnHeader cl_From;
        private ColumnHeader cl_Time;
    }
}