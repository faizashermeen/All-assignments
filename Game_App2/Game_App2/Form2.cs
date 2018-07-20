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
    public partial class Form2 : Form
    {
        Form1 f1;
        public Form2(Form1 ff1)
        {
            f1 = ff1;
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

            this.Text = "Tic Tac Toe";
            this.button10.Text = "Back";
            this.button11.Text = "Quit";
            this.label1.Text = "Enter";
            this.label2.Text = "Enter   X   for   player1   &   O   for   player2";
            this.button12.Text = "RESULT";
            this.button13.Text = "RESET";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.ControlBox = false;
            this.BackColor = Color.Purple;

          



        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();

        }

        private void button11_Click(object sender, EventArgs e)
        {
            Form3 F3 = new Form3();
            F3.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string i = textBox1.Text;
            if (i == "X")
            {
                this.button1.BackColor = Color.Gray;
                button1.Text = "X";
                MessageBox.Show("PLAYER 2");

            }
            else if (i == "O")
            {
                button1.Text = "O";
                MessageBox.Show("PLAYER 1");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //this.textBox1.Clear();
            this.button2.BackColor = Color.Gray;
            string i = textBox1.Text;
            if (i == "X")
            {
                button2.Text = "X";
                MessageBox.Show("PLAYER 2");
            }
            else if (i == "O")
            {
                button2.Text = "O";
                MessageBox.Show("PLAYER 1");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //this.textBox1.Clear();
            this.button3.BackColor = Color.Gray;
            string i = textBox1.Text;
            if (i == "X")
            {
                button3.Text = "X";
                MessageBox.Show("PLAYER 2");
            }
            else if (i == "O")
            {
                button3.Text = "O";
                MessageBox.Show("PLAYER 1");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //this.textBox1.Clear();
            this.button4.BackColor = Color.Gray;
            string i = textBox1.Text;
            if (i == "X")
            {
                button4.Text = "X";
                MessageBox.Show("PLAYER 2");
            }
            else if (i == "O")
            {
                button4.Text = "O";
                MessageBox.Show("PLAYER 1");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //this.textBox1.Clear();
            this.button5.BackColor = Color.Gray;
            string i = textBox1.Text;
            if (i == "X")
            {
                button5.Text = "X";
                MessageBox.Show("PLAYER 2");
            }
            else if (i == "O")
            {
                button5.Text = "O";
                MessageBox.Show("PLAYER 1");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //this.textBox1.Clear();
            this.button6.BackColor = Color.Gray;
            string i = textBox1.Text;
            if (i == "X")
            {
                button6.Text = "X";
                MessageBox.Show("PLAYER 2");
            }
            else if (i == "O")
            {
                button6.Text = "O";
                MessageBox.Show("PLAYER 1");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //this.textBox1.Clear();
            this.button7.BackColor = Color.Gray;
            string i = textBox1.Text;
            if (i == "X")
            {
                button7.Text = "X";
                MessageBox.Show("PLAYER 2");
            }
            else if (i == "O")
            {
                button7.Text = "O";
                MessageBox.Show("PLAYER 1");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            // this.textBox1.Clear();
            this.button8.BackColor = Color.Gray;
            string i = textBox1.Text;
            if (i == "X")
            {
                button8.Text = "X";
                MessageBox.Show("PLAYER 2");
            }
            else if (i == "O")
            {
                button8.Text = "O";
                MessageBox.Show("PLAYER 1");
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //this.textBox1.Clear();
            this.button9.BackColor = Color.Gray;
            string i = textBox1.Text;
            if (i == "X")
            {
                button9.Text = "X";
                MessageBox.Show("PLAYER 2");
            }
            else if (i == "O")
            {
                button9.Text = "O";
                MessageBox.Show("PLAYER 1");
            }
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            this.textBox1.Clear();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if ((button1.Text == button4.Text) && (button1.Text == button5.Text) && (button1.Text == button7.Text) && (button1.Text == button8.Text))
            {
                MessageBox.Show("Wrong player inputs");
                this.Close();

            }
            else if ((button2.Text == button1.Text) && (button2.Text == button3.Text) && (button2.Text == button4.Text) && (button2.Text == button5.Text) && (button2.Text == button6.Text) && (button2.Text == button7.Text) && (button2.Text == button8.Text) & (button2.Text == button9.Text))
            {
                MessageBox.Show("Wrong player inputs");
                this.Close();

            }
            else if ((button3.Text == button1.Text) && (button3.Text == button3.Text) && (button3.Text == button4.Text) && (button3.Text == button5.Text) && (button3.Text == button6.Text) && (button3.Text == button7.Text) && (button3.Text == button8.Text) & (button3.Text == button9.Text))
            {
                MessageBox.Show("Wrong player inputs");
                this.Close();

            }
            else if ((button4.Text == button1.Text) && (button4.Text == button3.Text) && (button4.Text == button4.Text) && (button4.Text == button5.Text) && (button4.Text == button6.Text) && (button4.Text == button7.Text) && (button4.Text == button8.Text) & (button4.Text == button9.Text))
            {
                MessageBox.Show("Wrong player inputs");
                this.Close();

            }
            else if ((button5.Text == button1.Text) && (button5.Text == button3.Text) && (button5.Text == button4.Text) && (button5.Text == button5.Text) && (button5.Text == button6.Text) && (button5.Text == button7.Text) && (button5.Text == button8.Text) & (button5.Text == button9.Text))
            {
                MessageBox.Show("Wrong player inputs");
                this.Close();

            }
            else if ((button6.Text == button1.Text) && (button6.Text == button3.Text) && (button6.Text == button4.Text) && (button6.Text == button5.Text) && (button6.Text == button6.Text) && (button6.Text == button7.Text) && (button6.Text == button8.Text) & (button6.Text == button9.Text))
            {
                MessageBox.Show("Wrong player inputs");
                this.Close();

            }
            else if ((button7.Text == button1.Text) && (button7.Text == button3.Text) && (button7.Text == button4.Text) && (button7.Text == button5.Text) && (button7.Text == button6.Text) && (button7.Text == button7.Text) && (button7.Text == button8.Text) & (button7.Text == button9.Text))
            {
                MessageBox.Show("Wrong player inputs");
                this.Close();

            }
            else if ((button3.Text == button1.Text) && (button3.Text == button3.Text) && (button3.Text == button4.Text) && (button3.Text == button5.Text) && (button3.Text == button6.Text) && (button3.Text == button7.Text) && (button3.Text == button8.Text) & (button3.Text == button9.Text))
            {
                MessageBox.Show("Wrong player inputs");
                this.Close();

            }
            
            //BUTTON1 HOR
            if ((button1.Text == button2.Text) && (button1.Text == button3.Text))
            {
                if ((button1.Text == "X") && (button2.Text == "X") && (button3.Text == "X"))
                {
                    MessageBox.Show("PLAYER 1 WINS");
                }
                else if ((button1.Text == "O") && (button2.Text == "O") && (button3.Text == "O"))
                {
                    MessageBox.Show("PLAYER 2 WINS");
                }
            }

                //BUTTON1 VER
            else if ((button1.Text == button4.Text) && (button1.Text == button7.Text))
            {

                if ((button1.Text == "X") && (button4.Text == "X") && (button7.Text == "X"))
                {
                    MessageBox.Show("PLAYER 1 WINS");
                }
                else
                    if ((button1.Text == "O") && (button4.Text == "O") && (button7.Text == "O"))
                    {
                        MessageBox.Show("PLAYER 2 WINS");

                    }
            }
            //BUTTON1 DAI
            else if ((button1.Text == button5.Text) && (button1.Text == button9.Text))
            {

                if ((button1.Text == "X") && (button5.Text == "X") && (button9.Text == "X"))
                {
                    MessageBox.Show("PLAYER 1 WINS");
                }
                else if ((button1.Text == "O") && (button5.Text == "O") && (button9.Text == "O"))
                {
                    MessageBox.Show("PLAYER 2 WINS");
                }
            }
            //BUTTON3 VER
            else if ((button3.Text == button6.Text) && (button3.Text == button9.Text))
            {

                if ((button3.Text == "X") && (button6.Text == "X") && (button9.Text == "X"))
                {
                    MessageBox.Show("PLAYER 1 WINS");
                }
                else if ((button3.Text == "O") && (button6.Text == "O") && (button9.Text == "O"))
                {
                    MessageBox.Show("PLAYER 2 WINS");
                }
            }
            //BUTTON3 DAI
            else if ((button3.Text == button5.Text) && (button3.Text == button7.Text))
            {

                if ((button3.Text == "X") && (button5.Text == "X") && (button7.Text == "X"))
                {
                    MessageBox.Show("PLAYER 1 WINS");
                }
                else if ((button3.Text == "O") && (button5.Text == "O") && (button7.Text == "O"))
                {
                    MessageBox.Show("PLAYER 2 WINS");
                }




            }
            //BUTTON2 
            else if ((button2.Text == button5.Text) && (button2.Text == button8.Text))
            {

                if ((button2.Text == "X") && (button5.Text == "X") && (button8.Text == "X"))
                {
                    MessageBox.Show("PLAYER 1 WINS");
                }
                else if ((button2.Text == "O") && (button5.Text == "O") && (button8.Text == "O"))
                {
                    MessageBox.Show("PLAYER 2 WINS");
                }
            }
            //BUTTON4
            else if ((button4.Text == button5.Text) && (button4.Text == button6.Text))
            {

                if ((button4.Text == "X") && (button5.Text == "X") && (button6.Text == "X"))
                {
                    MessageBox.Show("PLAYER 1 WINS");
                }
                else if ((button4.Text == "O") && (button5.Text == "O") && (button6.Text == "O"))
                {
                    MessageBox.Show("PLAYER 2 WINS");
                }
            }
            //BUTTON7
            else if ((button7.Text == button8.Text) && (button7.Text == button9.Text))
            {

                if ((button7.Text == "X") && (button8.Text == "X") && (button9.Text == "X"))
                {
                    MessageBox.Show("PLAYER 1 WINS");
                }
                else if ((button7.Text == "O") && (button8.Text == "O") && (button9.Text == "O"))
                {
                    MessageBox.Show("PLAYER 2 WINS");
                }
            }


            
                
           
            


        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.textBox1.Clear();
            this.button1.Text = "";
            this.button2.Text = "";
            this.button3.Text = "";
            this.button4.Text = "";
            this.button5.Text = "";
            this.button6.Text = "";
            this.button7.Text = "";
            this.button8.Text = "";
            this.button9.Text = "";

            this.button1.BackColor = Color.WhiteSmoke;
            this.button2.BackColor = Color.WhiteSmoke;
            this.button3.BackColor = Color.WhiteSmoke;
            this.button4.BackColor = Color.WhiteSmoke;
            this.button5.BackColor = Color.WhiteSmoke;
            this.button6.BackColor = Color.WhiteSmoke;
            this.button7.BackColor = Color.WhiteSmoke;
            this.button8.BackColor = Color.WhiteSmoke;
            this.button9.BackColor = Color.WhiteSmoke;
            
        }


    }
}