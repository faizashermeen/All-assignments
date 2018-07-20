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
    public partial class challan : Form
    {
        connection conn = new connection();

        public challan()
        {
            InitializeComponent();
        }

        private void challan_Load(object sender, EventArgs e)
        {

            // soid populate
            conn.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand("select SOID from SO where status='close'", conn.oleDbConnection1);
            OleDbDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {

                comboBox1.Items.Add(dr["SOID"].ToString());

            }



            conn.oleDbConnection1.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int c = 0;
            conn.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand("select  count(DCID) from Deliverychallan where SOID='" + comboBox1.Text + "'", conn.oleDbConnection1);
            OleDbDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {

                c = Convert.ToInt32(dr[0]);
                c++;

            }
            {
                textBox7.Text = "Con-00" + c.ToString() + "-" + System.DateTime.Today.Year;



            }
            conn.oleDbConnection1.Close();



            conn.oleDbConnection1.Open();

            OleDbCommand cmd1 = new OleDbCommand("select * from SO where SOID='" + comboBox1.Text + "'", conn.oleDbConnection1);


            OleDbDataReader dr1 = cmd1.ExecuteReader();

            if (dr1.Read())
            {
                textBox4.Text = dr1["CID"].ToString();
                textBox5.Text = dr1["Cname"].ToString();
                textBox6.Text = dr1["CDept"].ToString();

                textBox3.Text = dr1["totalamount"].ToString();
                textBox8.Text = dr1["DDate"].ToString();

            }



            conn.oleDbConnection1.Close();




            conn.oleDbConnection1.Open();
            OleDbCommand cmdd = new OleDbCommand("select * from products", conn.oleDbConnection1);
            OleDbDataReader drr = cmdd.ExecuteReader();
            if (drr.Read())
            {
                textBox1.Text = drr["producttype"].ToString();
                textBox2.Text = drr["baseprice"].ToString();


            }

            conn.oleDbConnection1.Close();




        }

        private void button1_Click(object sender, EventArgs e)
        {

            conn.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand(" insert into Deliverychallan(DCID,SOID,Cname)values(@DCID,@SOID,@Cname)", conn.oleDbConnection1);
            cmd.Parameters.AddWithValue("@DCID", textBox7.Text);
            cmd.Parameters.AddWithValue("@SOID", comboBox1.Text);
            cmd.Parameters.AddWithValue("@Cname", textBox2.Text);
            cmd.Parameters.AddWithValue("@Ddate", textBox6.Text);
            cmd.Parameters.AddWithValue("@DCDate", dateTimePicker1.Text);
            cmd.ExecuteNonQuery();
            conn.oleDbConnection1.Close();
            MessageBox.Show("DELIVERY CHALLAN has been created");
        }

        private void label11_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
