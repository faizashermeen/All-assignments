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
    public partial class grn : Form
    {
        connection conn = new connection();
        public grn()
        {
            InitializeComponent();
        }

        private void grn_Load(object sender, EventArgs e)
        {

            // poid populate
            conn.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand("select POID from PO where status='close'", conn.oleDbConnection1);
            OleDbDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
 
                comboBox1.Items.Add(dr["POID"].ToString());

            }



            conn.oleDbConnection1.Close();


         
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int c = 0;
            conn.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand("select  count(grnid) from grn where poid='" + comboBox1.Text + "'", conn.oleDbConnection1);
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

            OleDbCommand cmd1 = new OleDbCommand("select * from PO where POID='" + comboBox1.Text + "'", conn.oleDbConnection1);


            OleDbDataReader dr1 = cmd1.ExecuteReader();

            if (dr1.Read())
            {
                textBox1.Text = dr1["VID"].ToString();
                textBox2.Text = dr1["Vname"].ToString();
                textBox3.Text = dr1["VDept"].ToString();

                textBox4.Text = dr1["totalamount"].ToString();
                textBox6.Text = dr1["DDate"].ToString();

            }



            conn.oleDbConnection1.Close();

            conn.oleDbConnection1.Open();
            OleDbCommand cmdd = new OleDbCommand("select * from products", conn.oleDbConnection1);
            OleDbDataReader drr = cmdd.ExecuteReader();
            if (drr.Read())
            {
                textBox5.Text = drr["producttype"].ToString();
                textBox9.Text = drr["baseprice"].ToString();
               

            }

            conn.oleDbConnection1.Close();

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand(" insert into GRN(GRNID,POID,Vname)values(@GRNID,@POID,@Vname)", conn.oleDbConnection1);
            cmd.Parameters.AddWithValue("@GRNID", textBox7.Text);
            cmd.Parameters.AddWithValue("@POID", comboBox1.Text);
            cmd.Parameters.AddWithValue("@Vname", textBox2.Text);
            cmd.Parameters.AddWithValue("@Ddate", textBox6.Text);
            cmd.Parameters.AddWithValue("@GRDate", dateTimePicker1.Text);
            cmd.ExecuteNonQuery();
            conn.oleDbConnection1.Close();
            MessageBox.Show("GRN created");

        }

        private void label11_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

    }
}
