using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 委托案例3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public Form2(string msg, UpdateTextBoxDelegate method)
            : this()
        {
            //InitializeComponent();
            //设置窗体2的label显示窗体1传递过来的字符串。
            label1.Text = msg;
            this._update = method;

        }


        public Form1 f1;
        private UpdateTextBoxDelegate _update;

        private void button1_Click(object sender, EventArgs e)
        {
            string str = textBox1.Text.Trim();
            if (_update != null)
            {
                this._update(str);
            }
            //关闭当前窗体
            this.Close();

        }
    }
}
