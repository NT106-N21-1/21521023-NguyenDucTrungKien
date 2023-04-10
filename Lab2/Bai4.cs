using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Runtime.Serialization.Formatters;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Bai4 : Form
    {
        public Bai4()
        {
            InitializeComponent();
        }
        [Serializable]
        public class Student
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Phone { get; set; }
            public double Course1 { get; set; }
            public double Course2 { get; set; }
            public double Course3 { get; set; }
            public double avg { get; set; }
            public override string ToString()
            {
                return Name + '\n' + Id + '\n' + Phone + '\n' + Course1 + '\n' + Course2 + '\n' + Course3;
            }
        }
        private void _Show()
        {
            rtbShow.Clear();
            int i = 0;
            foreach (var student in students)
            {
                student.Name = students[i].Name;
                student.Id = students[i].Id;
                student.Phone = students[i].Phone;
                student.Course1 = students[i].Course1;
                student.Course2 = students[i].Course2;
                student.Course3 = students[i].Course3;
                rtbShow.Text = rtbShow.Text + student + '\n';
                i++;
            }
        }

        List<Student> students = new List<Student>();
        private void btnAdd_Click(object sender, EventArgs e)
        {
            int check = 0, check1 = 0;
            int count = 0, count1 = 0;
            for(int j = 0; j < txtPhone.Text.Length; j++)
            {
                count++;
                if (txtPhone.Text[0] != 48 || txtPhone.Text[j] < 48 || txtPhone.Text[j] > 57)
                { 
                    check++;
                }
            }
            for(int j = 0; j<txtID.Text.Length; j++)
            {
                count1++;
                if (txtID.Text[j] < 48 || txtID.Text[j] > 57)
                {
                    check1++;
                }
            }
            if(int.Parse(txtCourse1.Text) < 0 || int.Parse(txtCourse1.Text) > 10 || int.Parse(txtCourse2.Text) < 0 || int.Parse(txtCourse2.Text) > 10 || int.Parse(txtCourse3.Text) < 0 || int.Parse(txtCourse3.Text) > 10)
            {
                MessageBox.Show("Điểm bạn nhập không đúng. Vui lòng nhập lại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(count != 10 || check != 0)
            {
                MessageBox.Show("Số điện thoại bạn nhập không đúng. Vui lòng nhập lại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(count1 != 8 || check1 != 0)
            {
                MessageBox.Show("Mã số sinh viên bạn nhập không đúng. Vui lòng nhập lại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Student stu = new Student();
                stu.Id = int.Parse(txtID.Text);
                stu.Name = txtName.Text;
                stu.Phone = txtPhone.Text;
                stu.Course1 = double.Parse(txtCourse1.Text);
                stu.Course2 = double.Parse(txtCourse2.Text);
                stu.Course3 = double.Parse(txtCourse3.Text);
                stu.avg = Math.Round(((stu.Course1 + stu.Course2 + stu.Course3) / 3), 2);
                students.Add(stu);
                _Show();
                txtName.Text = "";
                txtID.Text = "";
                txtPhone.Text = "";
                txtCourse1.Text = "";
                txtCourse2.Text = "";
                txtCourse3.Text = "";
            }
        }
        private void btnRead_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Text file|*.txt";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string filePath = ofd.FileName;
                BinaryFormatter bf = new BinaryFormatter();
                FileStream fs = File.OpenRead(filePath);
                List<Student> students = bf.Deserialize(fs) as List<Student>;
                lblTemp.Text = ofd.FileName;
                rtbShow.Clear();
                int i = 0;
                int page = 1;
                lblPage.Text = "1";
                foreach (var student in students)
                {
                    student.Name = students[i].Name;
                    txt_rName.Text = students[page - 1].Name;
                    student.Id = students[i].Id;
                    txt_rID.Text = students[page - 1].Id.ToString();
                    student.Phone = students[i].Phone;
                    txt_rPhone.Text = students[page - 1].Phone;
                    student.Course1 = students[i].Course1;
                    txt_rCourse1.Text = students[page - 1].Course1.ToString();
                    student.Course2 = students[i].Course2;
                    txt_rCourse2.Text = students[page - 1].Course2.ToString();
                    student.Course3 = students[i].Course3;
                    txt_rCourse3.Text = students[page - 1].Course3.ToString();
                    student.avg = students[i].avg;
                    txt_rAvg.Text = students[page - 1].avg.ToString();
                    rtbShow.Text = rtbShow.Text + student + '\n' + students[i].avg + '\n';
                    i++;
                }
                lblPage.Visible = true;
                fs.Close();
            }
        }
        private void btnWrite_Click(object sender, EventArgs e)
        {
            rtbShow.Clear();
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Text file|*.txt";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                string filePath = sfd.FileName;
                BinaryFormatter bf = new BinaryFormatter();
                FileStream fs = File.Create(filePath);

                bf.Serialize(fs, students);
                fs.Close();
            }
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            string filePath = lblTemp.Text;
            BinaryFormatter bf = new BinaryFormatter();
            FileStream fs = File.OpenRead(filePath);
            List<Student> students = bf.Deserialize(fs) as List<Student>;
            int count = students.Count;
            int page = int.Parse(lblPage.Text);
            if (page < count)
            {
                txt_rName.Text = students[page].Name;
                txt_rID.Text = students[page].Id.ToString();
                txt_rPhone.Text = students[page].Phone;
                txt_rCourse1.Text = students[page].Course1.ToString();
                txt_rCourse2.Text = students[page].Course2.ToString();
                txt_rCourse3.Text = students[page - 1].Course3.ToString();
                txt_rAvg.Text = students[page].avg.ToString();
                page++;
                lblPage.Text = page.ToString();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            string filePath = lblTemp.Text;
            BinaryFormatter bf = new BinaryFormatter();
            FileStream fs = File.OpenRead(filePath);
            List<Student> students = bf.Deserialize(fs) as List<Student>;
            int page = int.Parse(lblPage.Text);
            if (page > 1)
            {
                txt_rName.Text = students[page - 2].Name;
                txt_rID.Text = students[page - 2].Id.ToString();
                txt_rPhone.Text = students[page - 2].Phone;
                txt_rCourse1.Text = students[page - 2].Course1.ToString();
                txt_rCourse2.Text = students[page - 2].Course2.ToString();
                txt_rCourse3.Text = students[page - 2].Course3.ToString();
                txt_rAvg.Text = students[page - 2].avg.ToString();
                page--;
                lblPage.Text = page.ToString();
            }
        }
    }
}

