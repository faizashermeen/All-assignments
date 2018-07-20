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
    public partial class cus_search : Form
    {
        connection conn = new connection();
        public cus_search()
        {
            InitializeComponent();
        }

        private void cus_search_Load(object sender, EventArgs e)
        {

            this.textBox1.ReadOnly = true;
          //  this.textBox2.ReadOnly = true;
            this.textBox3.ReadOnly = true;
            this.textBox4.ReadOnly = true;
            this.textBox5.ReadOnly = true;
            this.textBox6.ReadOnly = true;
            this.textBox7.ReadOnly = true;
            this.textBox8.ReadOnly = true;
            this.textBox9.ReadOnly = true;
            this.textBox10.ReadOnly = true;


            //combo1
            conn.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand("select Cid  from Customer", conn.oleDbConnection1);
            OleDbDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr["Cid"]);
            }

            conn.oleDbConnection1.Close();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            conn.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand("select * from Customer where Cid='" + comboBox1.Text + "'", conn.oleDbConnection1);
            OleDbDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                textBox1.Text = dr["Cname"].ToString();
               // textBox2.Text = dr["vcode"].ToString();
                textBox3.Text = dr["City"].ToString();
                textBox4.Text = dr["CAddress"].ToString();
                textBox5.Text = dr["ph1"].ToString();
                textBox6.Text = dr["ph2"].ToString();
                textBox7.Text = dr["ContectPerson"].ToString();
                textBox8.Text = dr["CPPH"].ToString();
                textBox9.Text = dr["Cemail"].ToString();
                textBox10.Text = dr["Cgroup"].ToString();




            }

            conn.oleDbConnection1.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.textBox1.ReadOnly = false;
          //  this.textBox2.ReadOnly = false;
            this.textBox3.ReadOnly = false;
            this.textBox4.ReadOnly = false;
            this.textBox5.ReadOnly = false;
            this.textBox6.ReadOnly = false;
            this.textBox7.ReadOnly = false;
            this.textBox8.ReadOnly = false;
            this.textBox9.ReadOnly = false;
            this.textBox10.ReadOnly = false;
 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.textBox1.Clear();
          //  this.textBox2.Clear();
            this.textBox3.Clear();
            this.textBox4.Clear();
            this.textBox5.Clear();
            this.textBox6.Clear();
            this.textBox7.Clear();
            this.textBox8.Clear();
            this.textBox9.Clear();
            this.textBox10.Clear();


        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
