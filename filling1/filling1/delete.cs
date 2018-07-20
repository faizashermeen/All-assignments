using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace filling1
{
    public partial class delete : Form
    {
        public delete()
        {
            InitializeComponent();
        }

        private void delete_Load(object sender, EventArgs e)
        {
            this.label1.Text = "Address";
            this.label2.Text = "File name";
            this.button1.Text = "OK";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fn = this.textBox1.Text + this.textBox2.Text;
            if (File.Exists(fn))
            {
                File.Delete(fn);
                MessageBox.Show("File deleted");

            }
            else
            {
                MessageBox.Show("No file exist");

            }
        }
    }
}
