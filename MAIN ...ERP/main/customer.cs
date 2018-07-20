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
    public partial class customer : Form
    {
        connection conn=new connection();
        public customer()
        {
            InitializeComponent();
        }

        private void customer_Load(object sender, EventArgs e)
        {
              string[] Vcity = { "karachi", "lahore", "islamabad", "peshawer", "quetta" };
            this.comboBox1.Items.AddRange(Vcity);

            
            //vendor group
            string[] VGroup = { "HR", "CONSUMER", "SALES" };
            this.comboBox2.Items.AddRange(VGroup);

        }

        private void button1_Click(object sender, EventArgs e)
        {
               conn.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand("insert into Customer(Cid, Cname ,City,ph1,ph2,CAddress,ContectPerson,CPPH, Cemail,Cgroup)values(@Cid,@Cname,@City,@ph1,@ph2,@CAddress,@ContectPerson,@CPPH,@Cemail,@Cgroup)",conn.oleDbConnection1);

            cmd.Parameters.AddWithValue("@Cid", textBox1.Text);
            cmd.Parameters.AddWithValue("@Cname", textBox2.Text);
           // cmd.Parameters.AddWithValue("@Ccode", textBox3.Text);
            cmd.Parameters.AddWithValue("@City", comboBox1.Text);
            cmd.Parameters.AddWithValue("@ph1", int.Parse(textBox5.Text));
            cmd.Parameters.AddWithValue("@ph2", int.Parse(textBox6.Text));
            cmd.Parameters.AddWithValue("@CAdderess", textBox4.Text);
            cmd.Parameters.AddWithValue("@ContectPerson", textBox7.Text);

            cmd.Parameters.AddWithValue("@CPPH", int.Parse(textBox8.Text));
            cmd.Parameters.AddWithValue("@Cemail", textBox9.Text);
           
           
            cmd.Parameters.AddWithValue("@Cgroup", comboBox2.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data Inserted");
            conn.oleDbConnection1.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            cus_search cus = new cus_search();
            cus.Show();
        }

        private void label12_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        }
    }

