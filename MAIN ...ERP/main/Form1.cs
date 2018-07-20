using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace main
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text == "" && this.textBox2.Text == "")
            {
                main f2 = new main();
                f2.Show();

                this.Hide();

            }
            else
            {
                MessageBox.Show("user name and password is incorrect");
            }
        
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
