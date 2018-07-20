using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace stream_filling
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "STREAM";
            this.label1.Text = "File location";
            this.label2.Text = "File name";
            this.button1.Text = "File Stream Read";
            this.button2.Text = "File Stream Write";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = this.textBox1.Text + this.textBox2.Text;
            StreamReader sr = new StreamReader(s);
            this.textBox3.Text = sr.ReadToEnd();
            sr.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string s = this.textBox3.Text + this.textBox2.Text;
            StreamWriter sw = new StreamWriter(s);
            sw.Write(this.textBox1.Text);
            MessageBox.Show("File has Written");
            sw.Close();
        }
    }
}
