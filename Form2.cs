using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Microsoft.Office.Core;
using System.Reflection;
using MSword = Microsoft.Office.Interop.Excel;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public struct new_task
        {
           public string bumen;
           public string name;
        }
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Owner = this;
            f1.Show();
            f1.Hide();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dilog = new FolderBrowserDialog();//选择文件路径对话框
            dilog.Description = "请选择文件夹";//标题
            if (dilog.ShowDialog() == DialogResult.OK || dilog.ShowDialog() == DialogResult.Yes)
            {
                textBox2.Text = dilog.SelectedPath;
            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex=1;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex=2;//翻页
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox4.Text.Trim()))//提醒输入
                 {
                     MessageBox.Show("请输入部门名称！");
                     return;
                 }
            treeView2.Nodes.Add(textBox4.Text.Trim());//添加父节点
            textBox4.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox3.Text.Trim()))
                {
                    MessageBox.Show("请输入人员姓名！");
                    return;
                }
            if (treeView1.SelectedNode == null)
                {
                    MessageBox.Show("请选择一个部门！");
                    return;
                }
            treeView1.SelectedNode.Nodes.Add(textBox3.Text.Trim());//添加子节点
            textBox3.Text = "";
        }

        private void tabControl1_SelctedIndexChenged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 3)
            {
                for (int i = 0; i < treeView2.Nodes.Count;)
                {
                    treeView1.Nodes.Add((TreeNode)treeView2.Nodes[i].Clone());
                    i++;
                }
            }
            if(tabControl1.SelectedIndex==2)
            {
                treeView1.Nodes.Clear();
            }
        }

        private void button7_Click(object sender, EventArgs e)//创建树状列表
        {
            new_task[ ] nt = new new_task[1000];
            int i = 0;
            foreach (TreeNode tn in treeView1.Nodes)
            { 
                foreach (TreeNode stn in tn.Nodes)
                {
                    i++;
                    nt[i].bumen = tn.Text;
                    nt[i].name = stn.Text;
                }
            }
            
            StreamWriter sw = new StreamWriter(textBox2.Text+@"\"+textBox1.Text+".clw", true);//写入文件流
            sw.Write(numericUpDown1.Value);sw.Write(":");sw.Writeline(numericUpDown2.Value);
            sw.Write(numericUpDown3.Value);sw.Write(":");sw.WriteLine(numericUpDown4.Value);
            for (int j = 1; j<=i; j++)
            {
                sw.Write(nt[j].bumen);
                sw.Write(",");
                sw.Write(nt[j].name);
                sw.Write(",");
                sw.Write("0");
                sw.Write(",");
                sw.WriteLine("0");
            }
            sw.Close();
            MessageBox.Show("创建成功！");
            this.Hide();//返回主界面
        }
    }
}
