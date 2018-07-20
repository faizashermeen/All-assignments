using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace main
{
    public partial class vendor : Form
    {
        connection conn = new connection();

        public vendor()
        {
            InitializeComponent();
        }

        private void vendor_Load(object sender, EventArgs e)
        {

           
            
            // this.textBox1.ReadOnly = true;

            //city populate
            string[] Vcity = { "karachi", "lahore", "islamabad", "peshawer", "quetta" };
            this.comboBox1.Items.AddRange(Vcity);

            //vendor group
            string[] VGroup = { "HR", "CONSUMER", "SALES" };
            this.comboBox2.Items.AddRange(VGroup);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand("insert into vendor (vid, vname ,vcode,vcity,ph1,ph2,vaddress,cpname,cpph, vemail,vgroup)values(@vid, @vname ,@vcode,@vcity,@ph1,@ph2,@vaddress,@cpname,@cpph,@vemail,vgroup) ", conn.oleDbConnection1);
            cmd.Parameters.AddWithValue("@vid", textBox1.Text);
            cmd.Parameters.AddWithValue("@vname", textBox2.Text);
            cmd.Parameters.AddWithValue("@vcode", textBox3.Text);
            cmd.Parameters.AddWithValue("@vcity", comboBox1.Text);
            cmd.Parameters.AddWithValue("@ph1", int.Parse(textBox5.Text));
            cmd.Parameters.AddWithValue("@ph2", int.Parse(textBox6.Text));
            cmd.Parameters.AddWithValue("@vAdderess", textBox4.Text);
            cmd.Parameters.AddWithValue("@cpname", textBox7.Text);

            cmd.Parameters.AddWithValue("@cpph", int.Parse(textBox8.Text));
            cmd.Parameters.AddWithValue("@vemail", textBox9.Text);
           
           
            cmd.Parameters.AddWithValue("@vgroup", comboBox2.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data Inserted");
            conn.oleDbConnection1.Close();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            search sea = new search();
            sea.Show();

        }

        private void label12_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       
       
        }
    }

