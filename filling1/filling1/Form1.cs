using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace filling1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "FILLING";
            this.radioButton1.Text = "COPY";
            this.radioButton2.Text = "DELETE";
            this.radioButton3.Text = "EXIST";
            this.button1.Text = "OK";
            this.groupBox1.Text = "SELECT";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                copy c = new copy();
                c.Show();
                this.Hide();
            }

            if (radioButton2.Checked)
            {
                delete del = new delete();
                del.Show();
                this.Hide();
            }
        }
    }
}
