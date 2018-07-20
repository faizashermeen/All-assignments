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
    public partial class grninvoice : Form
    {
        connection conn = new connection();

        public grninvoice()
        {
            InitializeComponent();
        }

        private void grninvoice_Load(object sender, EventArgs e)
        {




            conn.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand("select grnid from grn", conn.oleDbConnection1);
            OleDbDataReader dr2 = cmd.ExecuteReader();
            while (dr2.Read())
            {
                comboBox1.Items.Add(dr2["grnid"].ToString());

            }
            conn.oleDbConnection1.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            conn.oleDbConnection1.Open();

            OleDbCommand cmd = new OleDbCommand(@"select * from GRN where GRNID='" + comboBox1.Text + "';", conn.oleDbConnection1);
            OleDbDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                this.textBox1.Text = dr["POID"].ToString();

                this.textBox2.Text = dr["DDate"].ToString();
                this.textBox3.Text = dr["GRDate"].ToString();
                //this.textBox4.Text = dr["VID"].ToString();
                this.textBox5.Text = dr["VName"].ToString();
            }
            conn.oleDbConnection1.Close();


            conn.oleDbConnection1.Open();
            OleDbCommand cmd1 = new OleDbCommand(@"select * from GRNProducts where GRNID='" + comboBox1.Text + "';", conn.oleDbConnection1);
            OleDbDataReader dr1 = cmd1.ExecuteReader();
            while (dr1.Read())
            {
                textBox6.Text = (dr1["PModel"]).ToString();
                textBox8.Text = (dr1["PQty"]).ToString();

            }
            conn.oleDbConnection1.Close();
            conn.oleDbConnection1.Open();
            OleDbCommand cmdd = new OleDbCommand(@"select InvoiceID from Invoice ", conn.oleDbConnection1);
            OleDbDataReader drr = cmdd.ExecuteReader();
            int c = 0;
            while (drr.Read())
            {
                c++;
            }

            conn.oleDbConnection1.Close();
            textBox4.Text = "00" + (c + 1).ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand("insert into Invoice(GRNID,DCDate,GRNDate,VendorName,InvoiceID)values(@GRNID,@DCDate,@GRNDate,@VendorName,@InvoiceID);", conn.oleDbConnection1);
            cmd.Parameters.AddWithValue("@GRNID", comboBox1.Text);
          
            cmd.Parameters.AddWithValue("@DCDate", textBox2.Text);
            cmd.Parameters.AddWithValue("@GRNDate", textBox3.Text);
           
       
            cmd.Parameters.AddWithValue("@VendorName", textBox5.Text);
            cmd.Parameters.AddWithValue("@InvoiceID", textBox4.Text);
        
           // cmd.Parameters.AddWithValue("@POID", textBox1.Text);
          


            cmd.ExecuteNonQuery();
            conn.oleDbConnection1.Close();


           conn.oleDbConnection1.Open();
            OleDbCommand cmd1 = new OleDbCommand("UPDATE GRN SET  [Status]='Close'  WHERE GRNID ='" + comboBox1.Text + "' ",conn.oleDbConnection1);
            cmd1.ExecuteReader();
            conn.oleDbConnection1.Close();
            MessageBox.Show("Invoice has been Created..!!");
  
      
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
