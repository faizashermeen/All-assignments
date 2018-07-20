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
    public partial class search : Form
    {
        connection conn= new connection();
    
        public search()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void search_Load(object sender, EventArgs e)
        {
            this.textBox1.ReadOnly = true;
            this.textBox2.ReadOnly = true;
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
            OleDbCommand cmd = new OleDbCommand("select vid  from vendor", conn.oleDbConnection1);
            OleDbDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr["vid"]);
            }

            conn.oleDbConnection1.Close();

        }












        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            conn.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand("select * from vendor where vid='" + comboBox1.Text + "'", conn.oleDbConnection1);
            OleDbDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                textBox1.Text = dr["vname"].ToString();
                textBox2.Text = dr["vcode"].ToString();
                textBox3.Text = dr["vcity"].ToString();
                textBox4.Text = dr["vaddress"].ToString();
                textBox5.Text = dr["ph1"].ToString();
                textBox6.Text = dr["ph2"].ToString();
                textBox7.Text = dr["cpname"].ToString();
                textBox8.Text = dr["cpph"].ToString();
                textBox9.Text = dr["vemail"].ToString();
                textBox10.Text = dr["vgroup"].ToString();




            }

            conn.oleDbConnection1.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.textBox1.ReadOnly = false;
            this.textBox2.ReadOnly = false;
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
            this.textBox2.Clear();
            this.textBox3.Clear();
            this.textBox4.Clear();
            this.textBox5.Clear();
            this.textBox6.Clear();
            this.textBox7.Clear();
            this.textBox8.Clear();
            this.textBox9.Clear();
            this.textBox10.Clear();








        }

        private void button5_Click(object sender, EventArgs e)
        {
            conn.oleDbConnection1.Open();
            
            OleDbCommand cmd = new OleDbCommand("UPDATE Vendor SET Vname = '" + textBox1.Text + "' ,VCode = '" + textBox2.Text + "',VCity = '" + textBox3.Text + "' ,VAddress = '" + textBox4.Text + "',PH1= '" + textBox5.Text + "',PH2='" + textBox6.Text + "',CPName= '" + textBox7.Text + "',CPPH = '" + textBox8.Text + "',VEmail= '" + textBox9.Text  +"',VGroup= '" + textBox10.Text + "' WHERE VID = @VID", conn.oleDbConnection1);

            cmd.Parameters.AddWithValue("@VID", comboBox1.Text);
            cmd.Parameters.AddWithValue("@Vname", textBox1.Text);
            cmd.Parameters.AddWithValue("@VCode", textBox2.Text);
            cmd.Parameters.AddWithValue("@VCity", textBox3.Text);
            cmd.Parameters.AddWithValue("@VAddress", textBox4.Text);
            cmd.Parameters.AddWithValue("@PH1", textBox5.Text);
            cmd.Parameters.AddWithValue("@PH2", textBox6.Text);
            cmd.Parameters.AddWithValue("@CPName", textBox7.Text);
            cmd.Parameters.AddWithValue("@CPPH", textBox8.Text);
            cmd.Parameters.AddWithValue("@VEmail", textBox9.Text);
            
            cmd.Parameters.AddWithValue("@VGroup", textBox10.Text);
           

            cmd.ExecuteNonQuery();
            MessageBox.Show("record has been updated");
            conn.oleDbConnection1.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
