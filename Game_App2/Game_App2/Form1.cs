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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
          //  this.ForeColor = Color.Black;
            this.Text = "My Game";
            this.button1.Text = "START";
            this.button2.Text = "NEW GAME";
            this.button3.Text = "EXIT";

            this.label1.Text = "TIC ";
            this.label2.Text = " TAC ";
            this.label3.Text = "TOE";
            this.label1.Visible = false;

            this.label3.Visible = false;
            this.label2.Visible = false;
            this.button2.Visible = false;
            this.button3.Visible = false;
           // this.BackColor = Color.PeachPuff;
           // this.button1.BackColor = Color.Bisque;
            this.StartPosition = FormStartPosition.CenterScreen;
          //  this.ControlBox = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.BackColor = Color.Purple;
            this.label1.ForeColor = Color.LightGray;
            this.label2.ForeColor = Color.LightGray;
            this.label3.ForeColor = Color.LightGray;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.label1.Visible = true;
            this.label2.Visible = true;
            this.label3.Visible = true;
            this.button2.Visible = true;
            this.button3.Visible = true;


        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(this);
            f2.Show();
            this.Hide();

        }



    }
}
