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
using Microsoft.Office.Interop.Word;
using System.Text.RegularExpressions;
using Excel = Microsoft.Office.Interop.Excel;

namespace WordStatistics
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 要进行统计的文件列表
        /// </summary>
        List<string> selectFilePaths;

        /// <summary>
        /// 选择文件
        /// </summary>
        private void chosebtn_Click(object sender, EventArgs e)
        {
            try
            {
                //创建OpenFileDialog
                OpenFileDialog opnDlg = new OpenFileDialog();
                //为图像选择一个筛选器
                opnDlg.Filter = "所有文档(*.doc,*.docx,*.txt)|*.doc;*.docx;*.txt|文本文件(*.txt)|*.txt|Doc文件(*.doc,*.docx)|*.doc;*.docx";
                //设置对话框标题
                opnDlg.Title = "选择需要进行统计的文件";
                //启用“帮助”按钮
                opnDlg.ShowHelp = true;
                //可多选
                opnDlg.Multiselect = true;
                //如果结果为“打开”，选定文件
                if (opnDlg.ShowDialog() == DialogResult.OK)
                {
                    if (selectFilePaths == null)
                    {//第一次点击选择文件
                        selectFilePaths = opnDlg.FileNames.ToList();
                    }
                    else
                    {//不是第一次点击选择文件
                        selectFilePaths.AddRange(opnDlg.FileNames.ToList());
                    }
                    distinct(selectFilePaths);//去除List中重复项
                    string fileName = "";
                    listBox1.Items.Clear();//清空listbox
                    for (int i = 0; i < selectFilePaths.Count; i++)
                    {
                        //截取文件名
                        //fileName = fileNames[i].Substring(fileNames[i].LastIndexOf("\\") + 1);
                        fileName = System.IO.Path.GetFileName(selectFilePaths[i]);//文件名 “Default.aspx”
                                                                                  //显示已选文件名
                        listBox1.Items.Add(fileName);
                    }
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }


        /// <summary>
        /// 去除list重复项
        /// </summary>
        public void distinct(List<string> selectFilePaths)
        {
            for (int i = 0; i < selectFilePaths.Count; i++)  //外循环是循环的次数
            {
                for (int j = selectFilePaths.Count - 1; j > i; j--)  //内循环是 外循环一次比较的次数
                {

                    if (selectFilePaths[i] == selectFilePaths[j])
                    {
                        selectFilePaths.RemoveAt(j);
                    }
                }
            }
        }


        /// <summary>
        /// 删除选定文件
        /// </summary>
        private void deletebtn_Click(object sender, EventArgs e)
        {
            //选中的要删除文件列表
            List<string> selectList = new List<string>();
            string tempstr = "";
            for (int i = 0; i < listBox1.SelectedItems.Count; i++)
            {
                tempstr = listBox1.SelectedItems[i].ToString();
                selectList.Add(tempstr);
                for (int j = 0; j < selectFilePaths.Count; j++)
                {
                    if (tempstr == System.IO.Path.GetFileName(selectFilePaths[j]))
                    {
                        //从要统计的文件列表中删除当前遍历到的文件
                        selectFilePaths.Remove(selectFilePaths[j]);
                        //要进行统计的文件列表中删除当前遍历到的文件
                        listBox1.Items.Remove(listBox1.SelectedItems[i]);
                    }
                }
            }


        }


        /// <summary>
        /// 清空已选文件列表
        /// </summary>
        private void clearbtn_Click(object sender, EventArgs e)
        {
            if (listBox1.Items!=null&& selectFilePaths!=null)
            {
                listBox1.Items.Clear();
                selectFilePaths.Clear();
            }
            
        }


        /// <summary>
        /// 退出系统
        /// </summary>
        private void closebtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        /// <summary>
        /// 文档中的汉字字符串
        /// </summary>
        string fullTxetStr = "";
        /// <summary>
        /// 字频统计结果
        /// </summary>
        Dictionary<char, int> wordFrequencyDic = new Dictionary<char, int>();
        /// <summary>
        /// 字频统计
        /// </summary>
        private void statisticsbtn_Click(object sender, EventArgs e)
        {
            if (selectFilePaths == null)
            {
                MessageBox.Show("请选择文件");
            }
            else
            {

                //if (fullTxetStr == "")        //如果是第一次点击才进行统计。之后点击不做任何操作
                //{
                fullTxetStr = openFile(selectFilePaths);
                wordFrequencyDic = wordFrequencyStatistics(fullTxetStr);
                dataGridView1.DataSource = wordFrequencyDic.ToArray();
                dataGridView1.Columns[0].HeaderText = "字符"; //改列名称
                dataGridView1.Columns[1].HeaderText = "频次";
                dataGridView1.Columns[1].SortMode = DataGridViewColumnSortMode.Programmatic;
                //dataGridView1.Sort(dataGridView1.Columns[1], ListSortDirection.Ascending);
                //}
                //else//如果是第一次点击才进行统计。之后点击不做任何操作
                //{
                //    dataGridView1.DataSource = wordFrequencyDic.ToArray();
                //    dataGridView1.Columns[0].HeaderText = "字符"; //改列名称
                //    dataGridView1.Columns[1].HeaderText = "频次";
                //}

            }
        }


        /// <summary>
        /// 打开文件读取字符串
        /// </summary>
        /// <param name="filePaths">文件路径</param>
        /// <returns>文件中的字符串</returns>
        private string openFile(List<string> filePaths)
        {
            string txtStr = "";
            string docTxt = "";
            int cnt1 = 0, cnt2 = 0, cnt3 = 0, cnt4 = 0;
            string extensionName = "";
            //string fullTxetStr = "";
            if (filePaths != null)
            {
                foreach (var filePath in filePaths)
                {
                    //判断文件类型
                    extensionName = filePath.Substring(filePath.LastIndexOf(".") + 1);
                    if (extensionName.ToLower().Equals("txt"))
                    {
                        FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
                        StreamReader sr = new StreamReader(fs, EncodingType.GetType(filePath));
                        string sLine;
                        while ((sLine = sr.ReadLine()) != null)
                        {
                            sLine = sLine.Replace("\n", "").Replace("\r", "").Replace(" ?", "").Replace(" ", "").Replace("\t", "");
                            cnt1 += getWordLength(sLine);//字数
                            cnt2 += getByteLength(sLine);//字节数
                            cnt4++;//行数
                            txtStr += sLine;
                        }
                        sr.Close();
                        fs.Close();
                    }

                    else if (extensionName.ToLower().Equals("doc") || extensionName.ToLower().Equals("docx"))
                    {
                        docTxt = readDoc(filePath);

                        //行数
                        char[] ch = docTxt.ToCharArray();
                        for (int i = 0; i < ch.Length; i++)
                        {
                            if ((int)ch[i] == 13)//回车键
                            {
                                cnt4++;
                            }
                        }
                        if (docTxt != null)
                        {
                            docTxt = docTxt.Replace("\n", "").Replace("\r", "").Replace(" ?", "").Replace(" ", "").Replace("\t", "");
                            cnt1 += getWordLength(docTxt);//字数
                            cnt2 += getByteLength(docTxt);//字节数
                            txtStr += docTxt;
                        }
                    }
                    else
                    {
                        MessageBox.Show("暂时只支持文本文件(*.txt)和Doc文件(*.doc,*.docx),请重新选择文件");
                    }
                    cnt3 = cnt2 - cnt1;
                }
                //统计结果
                string labText = "经统计，此文件内容共有" + cnt4 + "行，共" + cnt1 + "字（" + cnt3 + "汉字）";
                label1.Visible = true;
                label1.Text = labText;
                //string strChinese = "";

                if (checkBox1.Checked)
                {
                    txtStr = Regex.Replace(txtStr, @"[^\u4e00-\u9fa5]", "");//只保留汉字
                }

                return txtStr;
            }
            else
            {
                return "";
            }

        }


        /// <summary>
        /// 返回字数
        /// </summary>
        /// <param name="fn"></param>
        /// <returns></returns>
        private string readDoc(string fn)
        {
            try
            {
                object readOnly = true;
                object missing = System.Reflection.Missing.Value;
                object fileName = fn;
                //初始化Word程序
                Microsoft.Office.Interop.Word.Application wordapp = new Microsoft.Office.Interop.Word.Application();
                //打开指定的doc文件
                Document doc = wordapp.Documents.Open(ref fileName,
                    ref missing, ref readOnly, ref missing, ref missing, ref missing,
                    ref missing, ref missing, ref missing, ref missing, ref missing,
                    ref missing, ref missing, ref missing, ref missing, ref missing);
                //读取指定的doc文件的文本
                string txt = doc.Content.Text;
                //关闭doc文件
                doc.Close(ref missing, ref missing, ref missing);
                //退出word程序
                wordapp.Quit(ref missing, ref missing, ref missing);
                return txt;
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
            return "";
        }


        /// <summary>
        /// 返回字数
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        private int getWordLength(string s)
        {
            if (s != null)
            {
                return s.Length;
            }
            else
            {
                return 0;
            }
        }


        /// <summary>
        /// 返回字节数
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        private int getByteLength(string s)
        {
            int byteLength = 0;
            char[] q = s.ToCharArray();
            for (int i = 0; i < q.Length; i++)
            {
                if ((int)q[i] >= 0x4E00 && (int)q[i] <= 0x9FA5)//汉字
                {
                    byteLength += 2;
                }
                else
                {
                    byteLength += 1;
                }
            }
            return byteLength;
        }


        /// <summary>
        /// 统计字频返回字典
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        private Dictionary<char, int> wordFrequencyStatistics(string str)
        {
            Dictionary<char, int> dic = new Dictionary<char, int>();
            foreach (char ch in str)
            {
                if (dic.Keys.Contains(ch))
                {
                    dic[ch]++;
                }
                else
                {
                    dic.Add(ch, 1);
                }
            }
            return dic;
        }


        /// <summary>
        /// 按选定的规则统计
        /// </summary>
        private void rulebtn_Click(object sender, EventArgs e)
        {
            if (selectFilePaths == null)
            {
                MessageBox.Show("请选择文件");
            }
            else
            {
                fullTxetStr = openFile(selectFilePaths);
                string rePattern = "";
                if (comboBox1.SelectedIndex == 0)//叠词
                {
                    rePattern = "(.)\\1((?!\\1).)\\2";
                    ruleMatch(fullTxetStr, rePattern);
                }
                else if (comboBox1.SelectedIndex == 1)//回文
                {
                    getPalindromeDic(fullTxetStr);
                }
                else
                {
                    MessageBox.Show("请选择匹配规则");
                }

            }

        }


        /// <summary>
        /// 查找字符串中所有的回文，并统计频次
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public void getPalindromeDic(String str)
        {
            if (selectFilePaths == null)
            {
                MessageBox.Show("请选择文件");
            }
            else
            {
                Dictionary<string, int> palindromeDic = new Dictionary<string, int>();// 回文统计结果
                String subs = "";
                for (int i = 0; i < str.Length; i++)
                {
                    for (int j = 3; j <= str.Length - i; j++)
                    {
                        subs = str.Substring(i, j);//截取连续子串  
                        if (isPalindrome(subs))// 判断字符串是否为回文字符串 
                        {
                            if (palindromeDic.Keys.Contains(subs))
                            {
                                palindromeDic[subs]++;
                            }
                            else
                            {
                                palindromeDic.Add(subs, 1);
                            }
                        }
                    }
                }
                if (palindromeDic != null)
                {
                    dataGridView1.DataSource = palindromeDic.ToArray();
                    dataGridView1.Columns[0].HeaderText = "字符"; //改列名称
                    dataGridView1.Columns[1].HeaderText = "频次";
                }
                else
                {
                    MessageBox.Show("无匹配结果");
                }
            }
        }


        /// <summary>
        /// 判断字符串是否为回文字符串  
        /// </summary>
        private static bool isPalindrome(String subs)
        {
            for (int i = 0; i < subs.Length; i++)
                if (subs[i] != subs[subs.Length - 1 - i])
                    return false;
            return true;
        }


        /// <summary>
        /// 匹配字符串中所有符合规则的词，并统计频次。并绑定DataGridView数据
        /// </summary>
        /// <param name="str"></param>
        /// <param name="rePattern"></param>
        /// <returns></returns>
        private void ruleMatch(string str, string rePattern)
        {
            if (selectFilePaths == null)
            {
                MessageBox.Show("请选择文件");
            }
            else
            {
                if (rePattern.Trim() == "")
                {
                    MessageBox.Show("请输入正则表达式");
                }
                else
                {
                    MatchCollection reMatches = null;
                    Dictionary<string, int> resultDic = new Dictionary<string, int>();
                    reMatches = Regex.Matches(str, rePattern);
                    bool re = Regex.IsMatch(str, rePattern);
                    if (reMatches.Count != 0)
                    {
                        foreach (var reMatche in reMatches)
                        {
                            if (resultDic.Keys.Contains(reMatche.ToString()))
                            {
                                resultDic[reMatche.ToString()]++;
                            }
                            else
                            {
                                resultDic.Add(reMatche.ToString(), 1);
                            }
                        }
                        dataGridView1.DataSource = resultDic.ToArray();
                        dataGridView1.Columns[0].HeaderText = "字符"; //改列名称
                        dataGridView1.Columns[1].HeaderText = "频次";
                    }
                    else
                    {
                        MessageBox.Show("无匹配结果");
                    }
                }
            }
        }


        /// <summary>
        /// 按textbox中的正则表达式统计
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addrulebtn_Click(object sender, EventArgs e)
        {
            fullTxetStr = openFile(selectFilePaths);
            string newPattern = regulartxb.Text;
            ruleMatch(fullTxetStr, newPattern);
        }


        /// <summary>
        /// 保存统计结果
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void savebtn_Click(object sender, EventArgs e)
        {
            setExcel(dataGridView1);
        }


        /// <summary>
        /// 将DataGridView的数据导入到Excel中
        /// </summary>
        /// <param name="dgv"></param>
        public void setExcel(DataGridView dgv)
        {
            //总可见列数，总可见行数
            int colCount = dgv.Columns.GetColumnCount(DataGridViewElementStates.Visible);
            int rowCount = dgv.Rows.GetRowCount(DataGridViewElementStates.Visible);

            //dataGridView 没有数据提示
            if (dgv.Rows.Count == 0 || rowCount == 0)
            {
                MessageBox.Show("表中没有数据", "提示");
            }
            else
            {
                string fileName = "";
                string saveFileName = "";
                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.DefaultExt = "xls";
                saveDialog.Filter = "Excel文件|*.xls";
                saveDialog.FileName = fileName;
                saveDialog.ShowDialog();
                saveFileName = saveDialog.FileName;

                if (saveFileName.IndexOf(":") < 0) return; //被点了取消

                Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();

                if (xlApp == null)
                {
                    MessageBox.Show("无法创建Excel对象，您的电脑可能未安装Excel");
                    return;
                }

                Microsoft.Office.Interop.Excel.Workbooks workbooks = xlApp.Workbooks;

                Microsoft.Office.Interop.Excel.Workbook workbook = workbooks.Add(Microsoft.Office.Interop.Excel.XlWBATemplate.xlWBATWorksheet);

                Microsoft.Office.Interop.Excel.Worksheet worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Worksheets[1];//取得sheet1 

                //写入标题             

                for (int i = 0; i < dataGridView1.ColumnCount; i++)
                {
                    worksheet.Cells[1, i + 1] = dataGridView1.Columns[i].HeaderText;
                }
                //写入数值

                for (int r = 0; r < dataGridView1.Rows.Count; r++)
                {
                    for (int i = 0; i < dataGridView1.ColumnCount; i++)
                    {
                        worksheet.Cells[r + 2, i + 1] = dataGridView1.Rows[r].Cells[i].Value;
                    }
                    System.Windows.Forms.Application.DoEvents();
                }
                worksheet.Columns.EntireColumn.AutoFit();//列宽自适应
                MessageBox.Show(fileName + "统计结果保存成功", "提示", MessageBoxButtons.OK);
                if (saveFileName != "")
                {
                    try
                    {
                        workbook.Saved = true;
                        workbook.SaveCopyAs(saveFileName);  //fileSaved = true;                 
                    }
                    catch (Exception ex)
                    {//fileSaved = false;                      
                        MessageBox.Show("导出文件时出错,文件可能正被打开！\n" + ex.Message);
                    }
                }
                xlApp.Quit();
                GC.Collect();//强行销毁          
            }
        }


        /// <summary>
        /// 建立DataTable将当前dataGridView中的数据读进DataTable中
        /// </summary>
        /// <param name="dv"></param>
        /// <returns></returns>
        public System.Data.DataTable dvtodt(DataGridView dv)
        {
            System.Data.DataTable dt = new System.Data.DataTable();
            DataColumn dc;
            for (int i = 0; i < dv.Columns.Count; i++)
            {
                dc = new DataColumn();
                dc.ColumnName = dv.Columns[i].HeaderText.ToString();
                dt.Columns.Add(dc);
            }
            for (int j = 0; j < dv.Rows.Count; j++)
            {
                DataRow dr = dt.NewRow();
                for (int x = 0; x < dv.Columns.Count; x++)
                {
                    dr[x] = dv.Rows[j].Cells[x].Value;
                }
                dt.Rows.Add(dr);
            }
            return dt;
        }


        private int SortOrder_ = 0;
        /// <summary>
        /// 点击列头实现排序
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //取得点击列的索引
            int nColumnIndex = e.ColumnIndex;
            if (nColumnIndex==1)
            {
                System.Data.DataTable d = dvtodt(dataGridView1);
                if (SortOrder_ == 0)
                {
                    d.DefaultView.Sort = this.dataGridView1.Columns[nColumnIndex].HeaderText + " ASC";    //指定升序排列
                    SortOrder_ = 1;
                }
                else
                {
                    d.DefaultView.Sort = this.dataGridView1.Columns[nColumnIndex].HeaderText + " desc";   //再次点击变为降序排列
                    SortOrder_ = 0;
                }
                dataGridView1.Columns.Clear();
                dataGridView1.DataSource = d;
            }
            
        }


        /// <summary>
        /// DataGridView显示行号
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            ////显示在HeaderCell上
            //for (int i = 0; i < this.dataGridView1.Rows.Count; i++)
            //{
            //    DataGridViewRow r = this.dataGridView1.Rows[i];
            //    r.HeaderCell.Value = string.Format("{0}", i + 1);
            //}
            //this.dataGridView1.Refresh();
            e.Row.HeaderCell.Value = (e.Row.Index + 1).ToString();
            
        }

        private void btn_spellCheck_Click(object sender, EventArgs e)
        {
            string wordA = txb_wordA.Text;
            string wordB = txb_wordB.Text;
            char[] word1 = wordA.ToCharArray();
            char[] word2 = wordB.ToCharArray();
            int[,] ed = new int[word1.Length,word2.Length];//编辑距离数组
            for (int i = 0; i < word1.Length; i++)
            {
                for (int j = 0; j < word2.Length; j++)
                {
                    
                    if (word1[i]!=word2[j])
                    {//当前字符不相等
                        //边界处理：对于A[j]≠B[k]若j = 1且k≠1则f[j, k] = f[j, k - 1] + 1若k = 1且j≠1则f[j, k] = f[j - 1, k] + 1若j = 1且k = 1则f[1, 1] = 1
                        if (i == 0 && j != 0)
                        {
                            ed[i, j] = ed[i, j - 1] + 1;
                        }
                        else if (i!=0&&j==0)
                        {
                            ed[i, j] = ed[i - 1, j] + 1;
                        }
                        else if (i == 0 && j == 0)
                        {
                            ed[0, 0] = 1;
                        }
                        else
                        {
                            //若A[j]≠B[k]则f[j, k]为f[j - 1, k - 1]、f[j - 1, k]、f[j, k - 1]三个数中最小数 + 1
                            if (ed[i-1,j-1]<=ed[i-1,j]&& ed[i - 1, j - 1] <= ed[i, j - 1])
                            {
                                ed[i, j] = ed[i - 1, j - 1] + 1;
                            }
                            if (ed[i - 1, j] <= ed[i - 1, j - 1] && ed[i - 1, j] <= ed[i, j - 1])
                            {
                                ed[i, j] = ed[i - 1, j] + 1;
                            }
                            if (ed[i, j - 1] <= ed[i - 1, j-1] && ed[i, j - 1] <= ed[i - 1, j])
                            {
                                ed[i, j] = ed[i, j - 1] + 1;
                            }
                        }
                    }
                    else
                    {
                        //边界处理：对于A[j] = B[k]若j = 1且k≠1则f[j, k] = f[j, k - 1]若k = 1且j≠1则f[j, k] = f[j - 1, k]若k = 1且j = 1则f[1, 1] = 0
                        if (i == 0&&j!=0)
                        {
                            ed[i, j] = ed[i, j-1];
                        }
                        else if (i != 0 && j == 0)
                        {
                            ed[i, j] = ed[i-1, j];
                        }
                        else if (i == 0 && j == 0)
                        {
                            ed[0, 0] = 0;
                        }
                        else
                        {
                            //若A[j] = B[k]则f[j, k] = f[j - 1, k - 1]
                            ed[i, j] = ed[i - 1, j - 1];
                        }
                    }
                }
            }
            lab_result.Visible = true;
            if (ed[word1.Length-1, word2.Length-1]==0)
            {
                lab_result.Text = "这两个单词的编辑距离为0,是相同的单词";
            }
            else
            {
                lab_result.Text = "这两个单词是不同的单词，其编辑距离为" + ed[word1.Length-1, word2.Length-1];
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

 