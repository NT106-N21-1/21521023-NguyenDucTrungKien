namespace Lab5
{
    partial class Bai1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblFrom = new Label();
            lblTo = new Label();
            lblSubj = new Label();
            lblBody = new Label();
            txtFrom = new TextBox();
            txtTo = new TextBox();
            txtSubj = new TextBox();
            rtbBody = new RichTextBox();
            btnSend = new Button();
            SuspendLayout();
            // 
            // lblFrom
            // 
            lblFrom.AutoSize = true;
            lblFrom.Location = new Point(12, 15);
            lblFrom.Name = "lblFrom";
            lblFrom.Size = new Size(46, 20);
            lblFrom.TabIndex = 0;
            lblFrom.Text = "From:";
            // 
            // lblTo
            // 
            lblTo.AutoSize = true;
            lblTo.Location = new Point(12, 48);
            lblTo.Name = "lblTo";
            lblTo.Size = new Size(28, 20);
            lblTo.TabIndex = 1;
            lblTo.Text = "To:";
            // 
            // lblSubj
            // 
            lblSubj.AutoSize = true;
            lblSubj.Location = new Point(12, 141);
            lblSubj.Name = "lblSubj";
            lblSubj.Size = new Size(61, 20);
            lblSubj.TabIndex = 2;
            lblSubj.Text = "Subject:";
            // 
            // lblBody
            // 
            lblBody.AutoSize = true;
            lblBody.Location = new Point(12, 171);
            lblBody.Name = "lblBody";
            lblBody.Size = new Size(46, 20);
            lblBody.TabIndex = 3;
            lblBody.Text = "Body:";
            // 
            // txtFrom
            // 
            txtFrom.Location = new Point(79, 12);
            txtFrom.Name = "txtFrom";
            txtFrom.Size = new Size(534, 27);
            txtFrom.TabIndex = 4;
            // 
            // txtTo
            // 
            txtTo.Location = new Point(79, 45);
            txtTo.Name = "txtTo";
            txtTo.Size = new Size(534, 27);
            txtTo.TabIndex = 5;
            // 
            // txtSubj
            // 
            txtSubj.Location = new Point(79, 138);
            txtSubj.Name = "txtSubj";
            txtSubj.Size = new Size(709, 27);
            txtSubj.TabIndex = 6;
            // 
            // rtbBody
            // 
            rtbBody.Location = new Point(79, 171);
            rtbBody.Name = "rtbBody";
            rtbBody.Size = new Size(709, 267);
            rtbBody.TabIndex = 7;
            rtbBody.Text = "";
            // 
            // btnSend
            // 
            btnSend.Location = new Point(619, 12);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(169, 60);
            btnSend.TabIndex = 8;
            btnSend.Text = "Send";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click_1;
            // 
            // Bai1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSend);
            Controls.Add(rtbBody);
            Controls.Add(txtSubj);
            Controls.Add(txtTo);
            Controls.Add(txtFrom);
            Controls.Add(lblBody);
            Controls.Add(lblSubj);
            Controls.Add(lblTo);
            Controls.Add(lblFrom);
            Name = "Bai1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFrom;
        private Label lblTo;
        private Label lblSubj;
        private Label lblBody;
        private TextBox txtFrom;
        private TextBox txtTo;
        private TextBox txtSubj;
        private RichTextBox rtbBody;
        private Button btnSend;
    }
}