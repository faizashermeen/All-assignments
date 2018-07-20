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
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();

        }











        private void button7_Click(object sender, EventArgs e)
        {
            vendor ven = new vendor();
            ven.Show();


        }













        private void button8_Click(object sender, EventArgs e)
        {
            purchaseorder pur = new purchaseorder();
            pur.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            grn gr = new grn();
            gr.Show();

        }

        private void button10_Click(object sender, EventArgs e)
        {
            grninvoice grn = new grninvoice();
            grn.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            customer cus = new customer();
            cus.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sales sal = new sales();
            sal.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            challan cha = new challan();
            cha.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            ch_invoice ch=new ch_invoice();
            ch.Show();
        }

      




    }
}

