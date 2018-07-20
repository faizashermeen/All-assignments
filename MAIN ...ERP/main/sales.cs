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
    public partial class sales : Form
    {
        connection conn = new connection();
        string[] pd = new string[50];
        int[] pqty = new int[50];
        int[] pprice = new int[50];

        int counter = 0;

        public sales()
        {
            InitializeComponent();
        }

        private void sales_Load(object sender, EventArgs e)
        {
            this.textBox2.ReadOnly = true;
            this.textBox3.ReadOnly = true;
            this.textBox4.ReadOnly = true;
            this.textBox5.ReadOnly = true;
            this.textBox1.ReadOnly = true;

            this.textBox6.ReadOnly = true;
            this.textBox7.ReadOnly = true;
            //  this.textBox8.ReadOnly = true;
            this.textBox9.ReadOnly = true;





            //department
            conn.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand("select CGroup from Customer", conn.oleDbConnection1);
            OleDbDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr["CGroup"].ToString());

            }
            conn.oleDbConnection1.Close();


            {
                //product id
                conn.oleDbConnection1.Open();
                OleDbCommand cmdd = new OleDbCommand("select pid from products", conn.oleDbConnection1);
                OleDbDataReader drr = cmdd.ExecuteReader();
                while (drr.Read())
                {
                    comboBox3.Items.Add(drr["pid"]);

                }

                conn.oleDbConnection1.Close();

            }



        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            conn.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand("select * from products where pid ='" + comboBox3.Text + "'", conn.oleDbConnection1);
            OleDbDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                textBox6.Text = dr["pname"].ToString();
                textBox7.Text = dr["BasePrice"].ToString();

            }
            conn.oleDbConnection1.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                conn.oleDbConnection1.Open();
                OleDbCommand cmd = new OleDbCommand("insert into SO(soid,Cdept,Cname,CCPPH,Cid,Ddate)values(@soid,@Cdept,@Cname,@CCPPH,@cid,@Ddate)", conn.oleDbConnection1);
                cmd.Parameters.AddWithValue("@soid", this.textBox1.Text);
                cmd.Parameters.AddWithValue("@Cdept", this.comboBox1.Text);
                cmd.Parameters.AddWithValue("@Cname", this.textBox2.Text);
                cmd.Parameters.AddWithValue("@Cid", this.comboBox2.Text);
                cmd.Parameters.AddWithValue("@CCPPH", this.textBox4.Text);
                cmd.Parameters.AddWithValue("@Ddate", this.dateTimePicker1);
                cmd.ExecuteNonQuery();
                conn.oleDbConnection1.Close();
                MessageBox.Show("transaction done!!");


                conn.oleDbConnection1.Close();
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pd[counter] = comboBox3.Text;
            pqty[counter] = Convert.ToInt32(textBox8.Text);
            pprice[counter] = Convert.ToInt32(textBox7.Text);
            counter++;
            MessageBox.Show("data is edited");   
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            {
                int c = 0;
                conn.oleDbConnection1.Open();

                OleDbCommand cmd = new OleDbCommand("select count(SOID) from SO where Cdept='" + comboBox1.Text + "'", conn.oleDbConnection1);

                OleDbDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    c = Convert.ToInt32(dr[0]);
                    c++;
                }
                if (comboBox1.Text == "Consumer")
                {
                    textBox1.Text = "Con-00" + c.ToString() + "-" + System.DateTime.Today.Year;
                }
                else if (comboBox1.Text == "marketing")
                {
                    textBox1.Text = "MR-00" + c.ToString() + "-" + System.DateTime.Today.Year;
                }
                else if (comboBox1.Text == "HR")
                {
                    textBox1.Text = "HR-00" + c.ToString() + "-" + System.DateTime.Today.Year;
                }
                else if (comboBox1.Text == "sales")
                {
                    textBox1.Text = "sales-00" + c.ToString() + "-" + System.DateTime.Today.Year;
                }
                conn.oleDbConnection1.Close();

                {
                    conn.oleDbConnection1.Open();
                    OleDbCommand cmd1= new OleDbCommand("select Cid from Customer where CGroup=@CGroup", conn.oleDbConnection1);
                    cmd1.Parameters.AddWithValue("@CGroup", comboBox1.Text);
                    OleDbDataReader dr1 = cmd1.ExecuteReader();
                    while (dr1.Read())
                    {
                        this.comboBox2.Items.Clear();
                        comboBox2.Items.Add(dr1["Cid"]).ToString();

                    }
                    conn.oleDbConnection1.Close();
                }

            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            conn.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand("select * from Customer where Cid='" + comboBox2.Text + "'", conn.oleDbConnection1);
            OleDbDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                textBox2.Text = dr["Cname"].ToString();


                textBox4.Text = dr["ph1"].ToString();
                textBox5.Text = dr["ph2"].ToString();
                textBox3.Text = dr["ContectPerson"].ToString();



            }

            conn.oleDbConnection1.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox7.Text);
            double b = Convert.ToDouble(textBox8.Text);
            textBox9.Text = (a * b).ToString();
        }

        private void label15_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
