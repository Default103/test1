using System;
using System.Collections.Generic;
using System.Collections;
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
using Microsoft.Office.Interop.Excel;

namespace WindowsFormsApp1
{
    public struct task//定义结构体读入人员后储存姓名和所属部门
    {
        public string bumen;
        public string name;
        public int num_d;
        public int num_t;
    }
    
    public partial class Form1 : Form
    {
        public string fdic;
        public Form1()
        {
            InitializeComponent();
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();//结束程序
        }

        private void 新建任务ToolStripMenuItem_Click(object sender, EventArgs e)//调用form2新建任务
        {
            Form2 f2 = new Form2();
            f2.Owner = this;
            f2.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        int i = 0;//计人数
        task[] nt = new task[1000];//传递部门和姓名
        private void 打开任务ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            打开ToolStripMenuItem.Enabled = false;
            button2.Visible = true;
            button1.Visible = true;
            groupBox1.Visible = true;
            comboBox1.Visible = true;//显示选择人员和部门的下拉列表
            comboBox2.Visible = true;
            comboBox1.Text = "选择部门";
            comboBox2.Text = "选择人员";
            保存ToolStripMenuItem.Enabled = true;
            生成ToolStripMenuItem.Enabled = true;
            label1.Visible = false;//隐藏欢迎
            OpenFileDialog openFile = new OpenFileDialog();//实例化打开文件对话框
            openFile.InitialDirectory = "C:\\Users\\Administrator\\Desktop";//初始显示的路径
            openFile.Title = "选择任务";//对话框标题
            openFile.Filter = "任务文件|*.clw*";//文件类型筛选器
            openFile.ShowDialog();//显示对话框
            string[] str = new string[10000];//存储读入的每一行，便于随后分割
            string[] bumen = new string[10000];//储存去重后的部门
            fdic = openFile.FileName;
            StreamReader sReader = new StreamReader(openFile.FileName, Encoding.UTF8);//读入文件流
            string aline;//临时字符串辅助判断是否读到空行
            bool bool1 = true;
            while (true)//读入并分割信息
            {
                aline = sReader.ReadLine();
                if (aline == null) bool1 = false;//如果是空行就停止循环读入
                if (bool1)
                {
                    i++;
                    str[i] = aline;
                    string[] condition = { "," };
                    string[] result = str[i].Split(condition, StringSplitOptions.None);//分割部门和姓名
                    nt[i].bumen = result[0];
                    bumen[i] = result[0];
                    nt[i].name = result[1];
                    nt[i].num_d = int.Parse(result[2]);
                    nt[i].num_t = int.Parse(result[3]);
                }
                else
                {
                    break;
                }
            }
            sReader.Close();//文件流关闭
            string[] bumenp = bumen.Distinct().ToArray();//去重
            bumenp[0] = "请选择部门";
            foreach (string b in bumenp) comboBox1.Items.Add(b);
            comboBox1.Items.Remove("请选择部门");
        }

        private void 选项ToolStripMenuItem_Click(object sender, EventArgs e)//打开关于页面
        {
            Form4 f4 = new Form4();
            f4.Owner = this;
            f4.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)//下拉列表中选中的项改变时触发事件，实现两级列表的联动
        {
            comboBox2.Items.Clear();//初始化存放姓名的cBox
            for (int j=1;j<=i;j++)
            {
                if (comboBox1.Text == nt[j].bumen) comboBox2.Items.Add(nt[j].name);//遍历每条信息，判断当选中的部门与之相同时将姓名加入cBox
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //if(DateTime.Now.ToString()==;)
            int i = 0;
            while (true)
            {
                i++;
                 if (nt[i].name == comboBox2.Text)
                {
                    nt[i].num_d = nt[i].num_d + 1;
                    break;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int i = 0;
            while (true)
            {
                if (nt[i].name == comboBox2.Text)
                {
                    nt[i].num_t = nt[i].num_t + 1;
                    break;
                }
                i++;
            }
        }

        private void 保存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            保存ToolStripMenuItem.Enabled = false;
            生成ToolStripMenuItem.Enabled = false;
            打开ToolStripMenuItem.Enabled = true;
            int i = 0;
            File.Delete(fdic);
            StreamWriter sw = new StreamWriter(fdic,true);
            while (true)
            {
                i++; 
                if (nt[i].name == null)
                {
                    sw.Close();
                    break;
                }
                sw.Write(nt[i].bumen);
                sw.Write(",");
                sw.Write(nt[i].name);
                sw.Write(",");
                sw.Write(nt[i].num_d);
                sw.Write(",");
                sw.WriteLine(nt[i].num_t);
                nt[i].bumen = null;
                nt[i].name = null;
                nt[i].num_d = 0;
                nt[i].num_t = 0;
            }
            groupBox1.Visible = false;
            button1.Visible = false;
            button2.Visible = false;
            comboBox1.Visible = false;
            comboBox2.Visible = false;
            label1.Visible = true;
            comboBox1.Items.Clear();
            comboBox2.Items.Clear();
        }

        private void 生成ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int i = 1;
            //新建一个应用程序
            Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
            app.Visible = true;
            Workbooks wbks = app.Workbooks;
            Workbook _wbk = wbks.Add(@"C:\Users\admininstrator\Desktop\测试.xlsx");
            Worksheet WS1 = (Worksheet)_wbk.Worksheets[1];
            Microsoft.Office.Interop.Excel.Range range = null;
            WS1.Cells[1, 1] = "姓名";
            WS1.Cells[1, 2] = "所属部门"; 
            WS1.Cells[1, 3] = "签到次数";
            WS1.Cells[1, 4] = "签退次数";

            while (true)
            {
                if (nt[i].name == null)
                {
                    i = 1;
                    break;
                }
                WS1.Cells[i + 1, 1] = nt[i].name;
                WS1.Cells[i + 1, 2] = nt[i].bumen;
                WS1.Cells[i + 1, 3] = nt[i].num_d;
                WS1.Cells[i + 1, 4] = nt[i].num_t;
                i++;
            }
        
            range = WS1.UsedRange;
            range.Borders.LineStyle = 7;
            wbks.Close();//关闭文档

            app.Quit();//关闭EXCEL应用程序

            //释放EXCEL应用程序的进程
            System.Runtime.InteropServices.Marshal.ReleaseComObject(app);
        }
    }
}
