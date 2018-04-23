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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // chosebtn
            // 
            this.chosebtn.Location = new System.Drawing.Point(22, 15);
            this.chosebtn.Name = "chosebtn";
            this.chosebtn.Size = new System.Drawing.Size(75, 23);
            this.chosebtn.TabIndex = 0;
            this.chosebtn.Text = "选择文件";
            this.chosebtn.UseVisualStyleBackColor = true;
            this.chosebtn.Click += new System.EventHandler(this.chosebtn_Click);
            // 
            // statisticsbtn
            // 
            this.statisticsbtn.Location = new System.Drawing.Point(250, 15);
            this.statisticsbtn.Name = "statisticsbtn";
            this.statisticsbtn.Size = new System.Drawing.Size(75, 23);
            this.statisticsbtn.TabIndex = 1;
            this.statisticsbtn.Text = "字频统计";
            this.statisticsbtn.UseVisualStyleBackColor = true;
            this.statisticsbtn.Click += new System.EventHandler(this.statisticsbtn_Click);
            // 
            // rulebtn
            // 
            this.rulebtn.Location = new System.Drawing.Point(490, 12);
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
            this.comboBox1.Location = new System.Drawing.Point(363, 15);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 20);
            this.comboBox1.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(240, 54);
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
            this.listBox1.Location = new System.Drawing.Point(22, 54);
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBox1.Size = new System.Drawing.Size(212, 328);
            this.listBox1.TabIndex = 7;
            // 
            // deletebtn
            // 
            this.deletebtn.Location = new System.Drawing.Point(22, 404);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(86, 23);
            this.deletebtn.TabIndex = 8;
            this.deletebtn.Text = "删除选定文件";
            this.deletebtn.UseVisualStyleBackColor = true;
            this.deletebtn.Click += new System.EventHandler(this.deletebtn_Click);
            // 
            // clearbtn
            // 
            this.clearbtn.Location = new System.Drawing.Point(130, 403);
            this.clearbtn.Name = "clearbtn";
            this.clearbtn.Size = new System.Drawing.Size(91, 23);
            this.clearbtn.TabIndex = 9;
            this.clearbtn.Text = "清空文件列表";
            this.clearbtn.UseVisualStyleBackColor = true;
            this.clearbtn.Click += new System.EventHandler(this.clearbtn_Click);
            // 
            // savebtn
            // 
            this.savebtn.Location = new System.Drawing.Point(739, 403);
            this.savebtn.Name = "savebtn";
            this.savebtn.Size = new System.Drawing.Size(87, 23);
            this.savebtn.TabIndex = 10;
            this.savebtn.Text = "保存统计结果";
            this.savebtn.UseVisualStyleBackColor = true;
            this.savebtn.Click += new System.EventHandler(this.savebtn_Click);
            // 
            // closebtn
            // 
            this.closebtn.Location = new System.Drawing.Point(857, 404);
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
            this.label1.Location = new System.Drawing.Point(317, 413);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 13;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(130, 19);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(84, 16);
            this.checkBox1.TabIndex = 14;
            this.checkBox1.Text = "只匹配汉字";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // addrulebtn
            // 
            this.addrulebtn.Location = new System.Drawing.Point(833, 15);
            this.addrulebtn.Name = "addrulebtn";
            this.addrulebtn.Size = new System.Drawing.Size(117, 23);
            this.addrulebtn.TabIndex = 4;
            this.addrulebtn.Text = "按正则表达式统计";
            this.addrulebtn.UseVisualStyleBackColor = true;
            this.addrulebtn.Click += new System.EventHandler(this.addrulebtn_Click);
            // 
            // regulartxb
            // 
            this.regulartxb.Location = new System.Drawing.Point(607, 14);
            this.regulartxb.Name = "regulartxb";
            this.regulartxb.Size = new System.Drawing.Size(220, 21);
            this.regulartxb.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 451);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.regulartxb);
            this.Controls.Add(this.closebtn);
            this.Controls.Add(this.savebtn);
            this.Controls.Add(this.clearbtn);
            this.Controls.Add(this.deletebtn);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.addrulebtn);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.rulebtn);
            this.Controls.Add(this.statisticsbtn);
            this.Controls.Add(this.chosebtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "文字统计工具";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}

