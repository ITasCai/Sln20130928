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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //按钮的单击事件，当点击按钮的时候弹出窗体2
        private void button1_Click(object sender, EventArgs e)
        {

            string content = textBox1.Text.Trim();
            //创建一个窗体2的对象，即创建Form2的对象
            Form2 f2 = new Form2(content, UpdateTextbox);
            //f2.Show();
            //        f2.f1 = this;
            f2.ShowDialog();
            //...

        }

        private void UpdateTextbox(string s)
        {
            this.textBox1.Text = s;
        }
    }
}
