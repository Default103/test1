namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.clwToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新建ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新建任务ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.管理人员ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打开ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打开任务ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.保存ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.选项ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.签到ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.签到ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.签退ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.生成ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.menuStrip1.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 9F);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clwToolStripMenuItem,
            this.签到ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(337, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // clwToolStripMenuItem
            // 
            this.clwToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.clwToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新建ToolStripMenuItem,
            this.打开ToolStripMenuItem,
            this.保存ToolStripMenuItem,
            this.选项ToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.clwToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.clwToolStripMenuItem.Name = "clwToolStripMenuItem";
            this.clwToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.clwToolStripMenuItem.Text = "文件";
            // 
            // 新建ToolStripMenuItem
            // 
            this.新建ToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.新建ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新建任务ToolStripMenuItem,
            this.管理人员ToolStripMenuItem});
            this.新建ToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.新建ToolStripMenuItem.Name = "新建ToolStripMenuItem";
            this.新建ToolStripMenuItem.Size = new System.Drawing.Size(122, 26);
            this.新建ToolStripMenuItem.Text = "新建";
            // 
            // 新建任务ToolStripMenuItem
            // 
            this.新建任务ToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.新建任务ToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.新建任务ToolStripMenuItem.Name = "新建任务ToolStripMenuItem";
            this.新建任务ToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.新建任务ToolStripMenuItem.Text = "新建任务";
            this.新建任务ToolStripMenuItem.Click += new System.EventHandler(this.新建任务ToolStripMenuItem_Click);
            // 
            // 管理人员ToolStripMenuItem
            // 
            this.管理人员ToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.管理人员ToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.管理人员ToolStripMenuItem.Name = "管理人员ToolStripMenuItem";
            this.管理人员ToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.管理人员ToolStripMenuItem.Text = "管理人员";
            // 
            // 打开ToolStripMenuItem
            // 
            this.打开ToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.打开ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.打开任务ToolStripMenuItem});
            this.打开ToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.打开ToolStripMenuItem.Name = "打开ToolStripMenuItem";
            this.打开ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.打开ToolStripMenuItem.Text = "打开";
            // 
            // 打开任务ToolStripMenuItem
            // 
            this.打开任务ToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.打开任务ToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.打开任务ToolStripMenuItem.Name = "打开任务ToolStripMenuItem";
            this.打开任务ToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.打开任务ToolStripMenuItem.Text = "打开任务";
            this.打开任务ToolStripMenuItem.Click += new System.EventHandler(this.打开任务ToolStripMenuItem_Click_1);
            // 
            // 保存ToolStripMenuItem
            // 
            this.保存ToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.保存ToolStripMenuItem.Enabled = false;
            this.保存ToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.保存ToolStripMenuItem.Name = "保存ToolStripMenuItem";
            this.保存ToolStripMenuItem.Size = new System.Drawing.Size(122, 26);
            this.保存ToolStripMenuItem.Text = "保存";
            this.保存ToolStripMenuItem.Click += new System.EventHandler(this.保存ToolStripMenuItem_Click);
            // 
            // 选项ToolStripMenuItem
            // 
            this.选项ToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.选项ToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.选项ToolStripMenuItem.Name = "选项ToolStripMenuItem";
            this.选项ToolStripMenuItem.Size = new System.Drawing.Size(122, 26);
            this.选项ToolStripMenuItem.Text = "选项";
            this.选项ToolStripMenuItem.Click += new System.EventHandler(this.选项ToolStripMenuItem_Click);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.退出ToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(122, 26);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // 签到ToolStripMenuItem
            // 
            this.签到ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.签到ToolStripMenuItem1,
            this.签退ToolStripMenuItem,
            this.生成ToolStripMenuItem});
            this.签到ToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.签到ToolStripMenuItem.Name = "签到ToolStripMenuItem";
            this.签到ToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.签到ToolStripMenuItem.Text = "任务";
            // 
            // 签到ToolStripMenuItem1
            // 
            this.签到ToolStripMenuItem1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.签到ToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.签到ToolStripMenuItem1.Name = "签到ToolStripMenuItem1";
            this.签到ToolStripMenuItem1.Size = new System.Drawing.Size(122, 26);
            this.签到ToolStripMenuItem1.Text = "签到";
            // 
            // 签退ToolStripMenuItem
            // 
            this.签退ToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.签退ToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.签退ToolStripMenuItem.Name = "签退ToolStripMenuItem";
            this.签退ToolStripMenuItem.Size = new System.Drawing.Size(122, 26);
            this.签退ToolStripMenuItem.Text = "签退";
            // 
            // 生成ToolStripMenuItem
            // 
            this.生成ToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.生成ToolStripMenuItem.Enabled = false;
            this.生成ToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.生成ToolStripMenuItem.Name = "生成ToolStripMenuItem";
            this.生成ToolStripMenuItem.Size = new System.Drawing.Size(122, 26);
            this.生成ToolStripMenuItem.Text = "生成";
            this.生成ToolStripMenuItem.Click += new System.EventHandler(this.生成ToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Beige;
            this.label1.Location = new System.Drawing.Point(172, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 104);
            this.label1.TabIndex = 1;
            this.label1.Text = "欢迎";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.SandyBrown;
            this.comboBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(6, 34);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(103, 38);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.Visible = false;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.BackColor = System.Drawing.Color.SandyBrown;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(6, 96);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(103, 38);
            this.comboBox2.TabIndex = 3;
            this.comboBox2.Visible = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("微软雅黑", 20F);
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(207, 108);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 62);
            this.button1.TabIndex = 4;
            this.button1.Text = "签到";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("微软雅黑", 20F);
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(210, 193);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 62);
            this.button2.TabIndex = 5;
            this.button2.Text = "签退";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Font = new System.Drawing.Font("微软雅黑", 13F);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(41, 53);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(126, 149);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "选择";
            this.groupBox1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(337, 304);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("微软雅黑", 6F);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem clwToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 新建ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打开ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 签到ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 签到ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 签退ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 管理人员ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打开任务ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 生成ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 选项ToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ToolStripMenuItem 保存ToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ToolStripMenuItem 新建任务ToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

