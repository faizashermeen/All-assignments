using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace directory
{
    public partial class Form1 : Form
    {

        string[] c = { "*.exe", "*.txt", "*.doc" };
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.label1.Text = "Directory Address";
            this.label2.Text = "Directory Name";
            this.label3.Text = "Extention";
            this.label4.Text = "RESULT";
            this.button1.Text = "Get File";
            comboBox1.Items.AddRange(c);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DirectoryInfo dr = new DirectoryInfo(textBox1.Text + textBox2.Text);
            FileInfo[] fi = dr.GetFiles(comboBox1.Text);
            foreach (FileInfo f in fi)
            {
                this.textBox3.Text += f.Name + Environment.NewLine;
            }
            
        }
    }
}
