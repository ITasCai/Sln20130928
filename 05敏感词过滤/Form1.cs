using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace _05敏感词过滤
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //获取用户输入
            string userInput = txtWords.Text.Trim();

            //用来存储 “严禁发帖”的词汇
            StringBuilder sbBanned = new StringBuilder();

            //用来存储 “需要人工审核的词汇”
            StringBuilder sbMode = new StringBuilder();


            string[] lines = File.ReadAllLines("网站过滤词（部分）.txt", Encoding.Default);
            for (int i = 0; i < lines.Length; i++)
            {
                string[] parts = lines[i].Split('=');
                if (parts[1] == "{MOD}")
                {
                    sbMode.Append(parts[0] + "|");
                }
                else if (parts[1] == "{BANNED}")
                {
                    sbBanned.Append(parts[0] + "|");
                }
            }
            sbMode.Remove(sbMode.Length - 1, 1);
            sbBanned.Remove(sbBanned.Length - 1, 1);



            //1.检查是否包含严禁发帖的词汇
            if (Regex.IsMatch(userInput, sbBanned.ToString()))
            {
                MessageBox.Show("包含禁止发帖词汇！");
            }
            else if (Regex.IsMatch(userInput, sbMode.ToString()))
            {
                MessageBox.Show("需要人工审核");
            }
            else
            {
                MessageBox.Show("可以发帖1！！");
            }

            //2.检查是否包含需要人工审核的词汇
        }
    }
}
