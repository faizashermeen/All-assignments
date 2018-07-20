using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NOTEPAD
{
    public partial class Form2 : Form
    {
        Form1 f1;
        public Form2(Form1 ff1)
        {
            f1 = ff1;
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.Text = "Replace";
            this.label1.Text = "Find";
            this.label2.Text = "Replace with";
            this.button1.Text = "Replace";
            this.button2.Text = "Close";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string st = f1.textBox1.Text.Replace(this.textBox1.Text, this.textBox2.Text);
            f1.textBox1.Text = st;
            
        }
    }
}
