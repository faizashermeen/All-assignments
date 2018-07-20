using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Game_App2
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            this.Text = "QUIT";
                this.label1.Text="DO YOU WANT TO QUIT???";
            this.button1.Text="YES";
            this.button2.Text = "NO";
            this.StartPosition = FormStartPosition.CenterScreen;
           // this.ControlBox = false;
          
                  

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
