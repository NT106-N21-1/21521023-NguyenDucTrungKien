namespace Lab2
{
    partial class Bai4
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
            btnWrite = new Button();
            btnRead = new Button();
            btnAdd = new Button();
            btnBack = new Button();
            btnNext = new Button();
            rtbShow = new RichTextBox();
            lblName = new Label();
            lbl_id = new Label();
            lblPhone = new Label();
            lblCourse1 = new Label();
            lblCourse2 = new Label();
            lblCourse3 = new Label();
            lbl_rName = new Label();
            lbl_rID = new Label();
            lbl_rPhone = new Label();
            lbl_rCourse1 = new Label();
            lbl_rCourse2 = new Label();
            lbl_rCourse3 = new Label();
            lbl_Avg = new Label();
            txtName = new TextBox();
            txtID = new TextBox();
            txtPhone = new TextBox();
            txtCourse1 = new TextBox();
            txtCourse2 = new TextBox();
            txtCourse3 = new TextBox();
            txt_rName = new TextBox();
            txt_rID = new TextBox();
            txt_rPhone = new TextBox();
            txt_rCourse1 = new TextBox();
            txt_rCourse2 = new TextBox();
            txt_rCourse3 = new TextBox();
            txt_rAvg = new TextBox();
            lblPage = new Label();
            lblTemp = new Label();
            SuspendLayout();
            // 
            // btnWrite
            // 
            btnWrite.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnWrite.Location = new Point(12, 12);
            btnWrite.Name = "btnWrite";
            btnWrite.Size = new Size(273, 39);
            btnWrite.TabIndex = 0;
            btnWrite.Text = "Write to a file";
            btnWrite.UseVisualStyleBackColor = true;
            btnWrite.Click += btnWrite_Click;
            // 
            // btnRead
            // 
            btnRead.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnRead.Location = new Point(792, 12);
            btnRead.Name = "btnRead";
            btnRead.Size = new Size(273, 39);
            btnRead.TabIndex = 1;
            btnRead.Text = "Read a file";
            btnRead.UseVisualStyleBackColor = true;
            btnRead.Click += btnRead_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(193, 255);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(92, 29);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(792, 295);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 29);
            btnBack.TabIndex = 3;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnNext
            // 
            btnNext.Location = new Point(971, 295);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(94, 29);
            btnNext.TabIndex = 4;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // rtbShow
            // 
            rtbShow.ForeColor = SystemColors.WindowText;
            rtbShow.Location = new Point(291, 12);
            rtbShow.Name = "rtbShow";
            rtbShow.Size = new Size(495, 312);
            rtbShow.TabIndex = 5;
            rtbShow.Text = "";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(12, 60);
            lblName.Name = "lblName";
            lblName.Size = new Size(49, 20);
            lblName.TabIndex = 6;
            lblName.Text = "Name";
            // 
            // lbl_id
            // 
            lbl_id.AutoSize = true;
            lbl_id.Location = new Point(12, 93);
            lbl_id.Name = "lbl_id";
            lbl_id.Size = new Size(24, 20);
            lbl_id.TabIndex = 7;
            lbl_id.Text = "ID";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(12, 126);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(50, 20);
            lblPhone.TabIndex = 8;
            lblPhone.Text = "Phone";
            // 
            // lblCourse1
            // 
            lblCourse1.AutoSize = true;
            lblCourse1.Location = new Point(12, 159);
            lblCourse1.Name = "lblCourse1";
            lblCourse1.Size = new Size(66, 20);
            lblCourse1.TabIndex = 9;
            lblCourse1.Text = "Course 1";
            // 
            // lblCourse2
            // 
            lblCourse2.AutoSize = true;
            lblCourse2.Location = new Point(12, 192);
            lblCourse2.Name = "lblCourse2";
            lblCourse2.Size = new Size(66, 20);
            lblCourse2.TabIndex = 10;
            lblCourse2.Text = "Course 2";
            // 
            // lblCourse3
            // 
            lblCourse3.AutoSize = true;
            lblCourse3.Location = new Point(12, 225);
            lblCourse3.Name = "lblCourse3";
            lblCourse3.Size = new Size(66, 20);
            lblCourse3.TabIndex = 11;
            lblCourse3.Text = "Course 3";
            // 
            // lbl_rName
            // 
            lbl_rName.AutoSize = true;
            lbl_rName.Location = new Point(997, 60);
            lbl_rName.Name = "lbl_rName";
            lbl_rName.Size = new Size(49, 20);
            lbl_rName.TabIndex = 6;
            lbl_rName.Text = "Name";
            // 
            // lbl_rID
            // 
            lbl_rID.AutoSize = true;
            lbl_rID.Location = new Point(997, 93);
            lbl_rID.Name = "lbl_rID";
            lbl_rID.Size = new Size(24, 20);
            lbl_rID.TabIndex = 7;
            lbl_rID.Text = "ID";
            // 
            // lbl_rPhone
            // 
            lbl_rPhone.AutoSize = true;
            lbl_rPhone.Location = new Point(997, 126);
            lbl_rPhone.Name = "lbl_rPhone";
            lbl_rPhone.Size = new Size(50, 20);
            lbl_rPhone.TabIndex = 8;
            lbl_rPhone.Text = "Phone";
            // 
            // lbl_rCourse1
            // 
            lbl_rCourse1.AutoSize = true;
            lbl_rCourse1.Location = new Point(997, 159);
            lbl_rCourse1.Name = "lbl_rCourse1";
            lbl_rCourse1.Size = new Size(66, 20);
            lbl_rCourse1.TabIndex = 9;
            lbl_rCourse1.Text = "Course 1";
            // 
            // lbl_rCourse2
            // 
            lbl_rCourse2.AutoSize = true;
            lbl_rCourse2.Location = new Point(997, 192);
            lbl_rCourse2.Name = "lbl_rCourse2";
            lbl_rCourse2.Size = new Size(66, 20);
            lbl_rCourse2.TabIndex = 10;
            lbl_rCourse2.Text = "Course 2";
            // 
            // lbl_rCourse3
            // 
            lbl_rCourse3.AutoSize = true;
            lbl_rCourse3.Location = new Point(997, 225);
            lbl_rCourse3.Name = "lbl_rCourse3";
            lbl_rCourse3.Size = new Size(66, 20);
            lbl_rCourse3.TabIndex = 11;
            lbl_rCourse3.Text = "Course 3";
            // 
            // lbl_Avg
            // 
            lbl_Avg.AutoSize = true;
            lbl_Avg.Location = new Point(997, 258);
            lbl_Avg.Name = "lbl_Avg";
            lbl_Avg.Size = new Size(64, 20);
            lbl_Avg.TabIndex = 11;
            lbl_Avg.Text = "Average";
            // 
            // txtName
            // 
            txtName.Location = new Point(87, 57);
            txtName.Name = "txtName";
            txtName.Size = new Size(198, 27);
            txtName.TabIndex = 12;
            // 
            // txtID
            // 
            txtID.Location = new Point(87, 90);
            txtID.Name = "txtID";
            txtID.Size = new Size(198, 27);
            txtID.TabIndex = 13;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(87, 123);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(198, 27);
            txtPhone.TabIndex = 14;
            // 
            // txtCourse1
            // 
            txtCourse1.Location = new Point(87, 156);
            txtCourse1.Name = "txtCourse1";
            txtCourse1.Size = new Size(198, 27);
            txtCourse1.TabIndex = 15;
            // 
            // txtCourse2
            // 
            txtCourse2.Location = new Point(87, 189);
            txtCourse2.Name = "txtCourse2";
            txtCourse2.Size = new Size(198, 27);
            txtCourse2.TabIndex = 16;
            // 
            // txtCourse3
            // 
            txtCourse3.Location = new Point(87, 222);
            txtCourse3.Name = "txtCourse3";
            txtCourse3.Size = new Size(198, 27);
            txtCourse3.TabIndex = 17;
            // 
            // txt_rName
            // 
            txt_rName.Location = new Point(792, 57);
            txt_rName.Name = "txt_rName";
            txt_rName.ReadOnly = true;
            txt_rName.Size = new Size(199, 27);
            txt_rName.TabIndex = 18;
            // 
            // txt_rID
            // 
            txt_rID.Location = new Point(792, 90);
            txt_rID.Name = "txt_rID";
            txt_rID.ReadOnly = true;
            txt_rID.Size = new Size(199, 27);
            txt_rID.TabIndex = 19;
            // 
            // txt_rPhone
            // 
            txt_rPhone.Location = new Point(792, 123);
            txt_rPhone.Name = "txt_rPhone";
            txt_rPhone.ReadOnly = true;
            txt_rPhone.Size = new Size(199, 27);
            txt_rPhone.TabIndex = 20;
            // 
            // txt_rCourse1
            // 
            txt_rCourse1.Location = new Point(792, 156);
            txt_rCourse1.Name = "txt_rCourse1";
            txt_rCourse1.ReadOnly = true;
            txt_rCourse1.Size = new Size(199, 27);
            txt_rCourse1.TabIndex = 21;
            // 
            // txt_rCourse2
            // 
            txt_rCourse2.Location = new Point(792, 189);
            txt_rCourse2.Name = "txt_rCourse2";
            txt_rCourse2.ReadOnly = true;
            txt_rCourse2.Size = new Size(199, 27);
            txt_rCourse2.TabIndex = 22;
            // 
            // txt_rCourse3
            // 
            txt_rCourse3.Location = new Point(792, 222);
            txt_rCourse3.Name = "txt_rCourse3";
            txt_rCourse3.ReadOnly = true;
            txt_rCourse3.Size = new Size(199, 27);
            txt_rCourse3.TabIndex = 23;
            // 
            // txt_rAvg
            // 
            txt_rAvg.Location = new Point(792, 255);
            txt_rAvg.Name = "txt_rAvg";
            txt_rAvg.ReadOnly = true;
            txt_rAvg.Size = new Size(199, 27);
            txt_rAvg.TabIndex = 24;
            // 
            // lblPage
            // 
            lblPage.AutoSize = true;
            lblPage.Location = new Point(920, 299);
            lblPage.Name = "lblPage";
            lblPage.Size = new Size(17, 20);
            lblPage.TabIndex = 25;
            lblPage.Text = "1";
            lblPage.Visible = false;
            // 
            // lblTemp
            // 
            lblTemp.AutoSize = true;
            lblTemp.Location = new Point(960, 339);
            lblTemp.Name = "lblTemp";
            lblTemp.Size = new Size(0, 20);
            lblTemp.TabIndex = 27;
            lblTemp.Visible = false;
            // 
            // Bai4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1077, 374);
            Controls.Add(lblTemp);
            Controls.Add(lblPage);
            Controls.Add(txt_rAvg);
            Controls.Add(txt_rCourse3);
            Controls.Add(txt_rCourse2);
            Controls.Add(txt_rCourse1);
            Controls.Add(txt_rPhone);
            Controls.Add(txt_rID);
            Controls.Add(txt_rName);
            Controls.Add(txtCourse3);
            Controls.Add(txtCourse2);
            Controls.Add(txtCourse1);
            Controls.Add(txtPhone);
            Controls.Add(txtID);
            Controls.Add(txtName);
            Controls.Add(lbl_Avg);
            Controls.Add(lbl_rCourse3);
            Controls.Add(lblCourse3);
            Controls.Add(lbl_rCourse2);
            Controls.Add(lblCourse2);
            Controls.Add(lbl_rCourse1);
            Controls.Add(lblCourse1);
            Controls.Add(lbl_rPhone);
            Controls.Add(lblPhone);
            Controls.Add(lbl_rID);
            Controls.Add(lbl_id);
            Controls.Add(lbl_rName);
            Controls.Add(lblName);
            Controls.Add(rtbShow);
            Controls.Add(btnNext);
            Controls.Add(btnBack);
            Controls.Add(btnAdd);
            Controls.Add(btnRead);
            Controls.Add(btnWrite);
            Name = "Bai4";
            Text = "Bai4";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnWrite;
        private Button btnRead;
        private Button btnAdd;
        private Button btnBack;
        private Button btnNext;
        private RichTextBox rtbShow;
        private Label lblName;
        private Label lbl_id;
        private Label lblPhone;
        private Label lblCourse1;
        private Label lblCourse2;
        private Label lblCourse3;
        private Label lbl_rName;
        private Label lbl_rID;
        private Label lbl_rPhone;
        private Label lbl_rCourse1;
        private Label lbl_rCourse2;
        private Label lbl_rCourse3;
        private Label lbl_Avg;
        private TextBox txtName;
        private TextBox txtID;
        private TextBox txtPhone;
        private TextBox txtCourse1;
        private TextBox txtCourse2;
        private TextBox txtCourse3;
        private TextBox txt_rName;
        private TextBox txt_rID;
        private TextBox txt_rPhone;
        private TextBox txt_rCourse1;
        private TextBox txt_rCourse2;
        private TextBox txt_rCourse3;
        private TextBox txt_rAvg;
        private Label lblPage;
        private Label lblTemp;
    }
}