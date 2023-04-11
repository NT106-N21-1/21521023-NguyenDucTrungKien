using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Bai6 : Form
    {
        public Bai6()
        {
            InitializeComponent();
            foreach(var drive in DriveInfo.GetDrives())
            {
                TreeNode node = new TreeNode();
                node.Text = string.Format("{0} ({1})", drive.VolumeLabel, drive.Name);
                node.Name = drive.Name;
                treeView1.Nodes.Add(node);
            }    
            treeView1.SelectedNode = null;
            treeView1.TabStop = false;
            treeView1.AfterSelect += treeView1_AfterSelect;
        }
        private void ProcessFile(FileInfo fileInfo)
        {
            string[] imgExtension = { ".png", ".jpg" };
            string[] textExtension = { ".txt" };
            grb_Contents.Controls.Clear();
            if(imgExtension.Contains(fileInfo.Extension.ToLower()) )
            {
                PictureBox pictureBox = new PictureBox();
                pictureBox.ImageLocation = fileInfo.FullName;
                pictureBox.Dock = DockStyle.Fill;
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                grb_Contents.Controls.Add(pictureBox);
            }
            if(textExtension.Contains(fileInfo.Extension.ToLower()) )
            {
                FileStream fs = new FileStream(fileInfo.FullName, FileMode.Open);
                StreamReader sr = new StreamReader(fs);
                RichTextBox r_TextBox = new RichTextBox();
                r_TextBox.Text = sr.ReadToEnd();
                r_TextBox.Dock = DockStyle.Fill;
                grb_Contents.Controls.Add(r_TextBox);
                fs.Close();
            }    
        }

        private void AddFileToTreeview(bool directory = false)
        {
            TreeNode node = treeView1.SelectedNode;
            string[] filePaths;
            if(! directory)
            {
                filePaths = Directory.GetFiles(node.Name);
            }
            else
            {
                filePaths = Directory.GetDirectories(node.Name);
            }
            foreach(string filePath in filePaths)
            {
                bool nodeExisted = false;
                foreach(TreeNode sn in node.Nodes)
                {
                    if(string.Equals(sn.Name, filePath))
                    {
                        nodeExisted = true;
                    }    
                }
                if(! nodeExisted)
                {
                    TreeNode subNode = new TreeNode();
                    subNode.Text = filePath.Replace(node.Name, "");
                    subNode.Text = subNode.Text.Replace("\\", "");
                    subNode.Name = filePath;
                    node.Nodes.Add(subNode);
                }
            }
            node.Expand();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode node = treeView1.SelectedNode;
            FileInfo fileInfo = new FileInfo(node.Name);
            if (fileInfo.Exists)
            {
                ProcessFile(fileInfo);
                return;
            }
            AddFileToTreeview(true);
            AddFileToTreeview();
        }
    }
}
