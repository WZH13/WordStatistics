namespace WordStatistics
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.chosebtn = new System.Windows.Forms.Button();
            this.statisticsbtn = new System.Windows.Forms.Button();
            this.rulebtn = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.deletebtn = new System.Windows.Forms.Button();
            this.clearbtn = new System.Windows.Forms.Button();
            this.savebtn = new System.Windows.Forms.Button();
            this.closebtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.addrulebtn = new System.Windows.Forms.Button();
            this.regulartxb = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lab_result = new System.Windows.Forms.Label();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_spellCheck = new System.Windows.Forms.Button();
            this.txb_wordB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txb_wordA = new System.Windows.Forms.TextBox();
            this.lab_road = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // chosebtn
            // 
            this.chosebtn.Location = new System.Drawing.Point(32, 21);
            this.chosebtn.Name = "chosebtn";
            this.chosebtn.Size = new System.Drawing.Size(75, 23);
            this.chosebtn.TabIndex = 0;
            this.chosebtn.Text = "选择文件";
            this.chosebtn.UseVisualStyleBackColor = true;
            this.chosebtn.Click += new System.EventHandler(this.chosebtn_Click);
            // 
            // statisticsbtn
            // 
            this.statisticsbtn.Location = new System.Drawing.Point(260, 21);
            this.statisticsbtn.Name = "statisticsbtn";
            this.statisticsbtn.Size = new System.Drawing.Size(75, 23);
            this.statisticsbtn.TabIndex = 1;
            this.statisticsbtn.Text = "字频统计";
            this.statisticsbtn.UseVisualStyleBackColor = true;
            this.statisticsbtn.Click += new System.EventHandler(this.statisticsbtn_Click);
            // 
            // rulebtn
            // 
            this.rulebtn.Location = new System.Drawing.Point(500, 18);
            this.rulebtn.Name = "rulebtn";
            this.rulebtn.Size = new System.Drawing.Size(88, 23);
            this.rulebtn.TabIndex = 2;
            this.rulebtn.Text = "按规则统计";
            this.rulebtn.UseVisualStyleBackColor = true;
            this.rulebtn.Click += new System.EventHandler(this.rulebtn_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "叠词（型如AABB）",
            "回文（型如abccba）"});
            this.comboBox1.Location = new System.Drawing.Point(373, 21);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 20);
            this.comboBox1.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(257, 62);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(711, 328);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_ColumnHeaderMouseClick);
            this.dataGridView1.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.dataGridView1_RowStateChanged);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(39, 62);
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBox1.Size = new System.Drawing.Size(212, 328);
            this.listBox1.TabIndex = 7;
            // 
            // deletebtn
            // 
            this.deletebtn.Location = new System.Drawing.Point(43, 423);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(86, 23);
            this.deletebtn.TabIndex = 8;
            this.deletebtn.Text = "删除选定文件";
            this.deletebtn.UseVisualStyleBackColor = true;
            this.deletebtn.Click += new System.EventHandler(this.deletebtn_Click);
            // 
            // clearbtn
            // 
            this.clearbtn.Location = new System.Drawing.Point(151, 422);
            this.clearbtn.Name = "clearbtn";
            this.clearbtn.Size = new System.Drawing.Size(91, 23);
            this.clearbtn.TabIndex = 9;
            this.clearbtn.Text = "清空文件列表";
            this.clearbtn.UseVisualStyleBackColor = true;
            this.clearbtn.Click += new System.EventHandler(this.clearbtn_Click);
            // 
            // savebtn
            // 
            this.savebtn.Location = new System.Drawing.Point(760, 424);
            this.savebtn.Name = "savebtn";
            this.savebtn.Size = new System.Drawing.Size(87, 23);
            this.savebtn.TabIndex = 10;
            this.savebtn.Text = "保存统计结果";
            this.savebtn.UseVisualStyleBackColor = true;
            this.savebtn.Click += new System.EventHandler(this.savebtn_Click);
            // 
            // closebtn
            // 
            this.closebtn.Location = new System.Drawing.Point(878, 425);
            this.closebtn.Name = "closebtn";
            this.closebtn.Size = new System.Drawing.Size(82, 23);
            this.closebtn.TabIndex = 11;
            this.closebtn.Text = "退出系统";
            this.closebtn.UseVisualStyleBackColor = true;
            this.closebtn.Click += new System.EventHandler(this.closebtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(418, 430);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 13;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(140, 25);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(84, 16);
            this.checkBox1.TabIndex = 14;
            this.checkBox1.Text = "只匹配汉字";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // addrulebtn
            // 
            this.addrulebtn.Location = new System.Drawing.Point(843, 21);
            this.addrulebtn.Name = "addrulebtn";
            this.addrulebtn.Size = new System.Drawing.Size(117, 23);
            this.addrulebtn.TabIndex = 4;
            this.addrulebtn.Text = "按正则表达式统计";
            this.addrulebtn.UseVisualStyleBackColor = true;
            this.addrulebtn.Click += new System.EventHandler(this.addrulebtn_Click);
            // 
            // regulartxb
            // 
            this.regulartxb.Location = new System.Drawing.Point(617, 20);
            this.regulartxb.Name = "regulartxb";
            this.regulartxb.Size = new System.Drawing.Size(220, 21);
            this.regulartxb.TabIndex = 12;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(-2, -2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1001, 506);
            this.tabControl1.TabIndex = 15;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.addrulebtn);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.checkBox1);
            this.tabPage1.Controls.Add(this.closebtn);
            this.tabPage1.Controls.Add(this.savebtn);
            this.tabPage1.Controls.Add(this.chosebtn);
            this.tabPage1.Controls.Add(this.clearbtn);
            this.tabPage1.Controls.Add(this.statisticsbtn);
            this.tabPage1.Controls.Add(this.deletebtn);
            this.tabPage1.Controls.Add(this.regulartxb);
            this.tabPage1.Controls.Add(this.rulebtn);
            this.tabPage1.Controls.Add(this.listBox1);
            this.tabPage1.Controls.Add(this.comboBox1);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(993, 480);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "文字统计工具";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.btn_close);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(993, 480);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "英语单词拼写检查";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lab_result
            // 
            this.lab_result.AutoSize = true;
            this.lab_result.Location = new System.Drawing.Point(28, 49);
            this.lab_result.Name = "lab_result";
            this.lab_result.Size = new System.Drawing.Size(65, 12);
            this.lab_result.TabIndex = 6;
            this.lab_result.Text = "lab_result";
            this.lab_result.Visible = false;
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(890, 447);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(75, 23);
            this.btn_close.TabIndex = 5;
            this.btn_close.Text = "退出系统";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_spellCheck
            // 
            this.btn_spellCheck.Location = new System.Drawing.Point(114, 229);
            this.btn_spellCheck.Name = "btn_spellCheck";
            this.btn_spellCheck.Size = new System.Drawing.Size(75, 23);
            this.btn_spellCheck.TabIndex = 4;
            this.btn_spellCheck.Text = "拼写检查";
            this.btn_spellCheck.UseVisualStyleBackColor = true;
            this.btn_spellCheck.Click += new System.EventHandler(this.btn_spellCheck_Click);
            // 
            // txb_wordB
            // 
            this.txb_wordB.Location = new System.Drawing.Point(114, 153);
            this.txb_wordB.Name = "txb_wordB";
            this.txb_wordB.Size = new System.Drawing.Size(139, 21);
            this.txb_wordB.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "单词B";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "单词A";
            // 
            // txb_wordA
            // 
            this.txb_wordA.Location = new System.Drawing.Point(116, 69);
            this.txb_wordA.Name = "txb_wordA";
            this.txb_wordA.Size = new System.Drawing.Size(139, 21);
            this.txb_wordA.TabIndex = 0;
            // 
            // lab_road
            // 
            this.lab_road.AutoSize = true;
            this.lab_road.Location = new System.Drawing.Point(28, 90);
            this.lab_road.Name = "lab_road";
            this.lab_road.Size = new System.Drawing.Size(53, 12);
            this.lab_road.TabIndex = 7;
            this.lab_road.Text = "lab_road";
            this.lab_road.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txb_wordB);
            this.groupBox1.Controls.Add(this.btn_spellCheck);
            this.groupBox1.Controls.Add(this.txb_wordA);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(92, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(285, 287);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "单词输入";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lab_result);
            this.groupBox2.Controls.Add(this.lab_road);
            this.groupBox2.Location = new System.Drawing.Point(471, 61);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(413, 287);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "结果显示";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 502);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "自然语言处理";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button chosebtn;
        private System.Windows.Forms.Button statisticsbtn;
        private System.Windows.Forms.Button rulebtn;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button deletebtn;
        private System.Windows.Forms.Button clearbtn;
        private System.Windows.Forms.Button savebtn;
        private System.Windows.Forms.Button closebtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button addrulebtn;
        private System.Windows.Forms.TextBox regulartxb;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_spellCheck;
        private System.Windows.Forms.TextBox txb_wordB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txb_wordA;
        private System.Windows.Forms.Label lab_result;
        private System.Windows.Forms.Label lab_road;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

