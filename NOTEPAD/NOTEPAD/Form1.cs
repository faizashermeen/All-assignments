using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace NOTEPAD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.Text = "FAIZA-notepad";
            this.newToolStripMenuItem.ShortcutKeys = (Keys.Control | Keys.N);
            this.openToolStripMenuItem.ShortcutKeys = (Keys.Control | Keys.O);
            this.saveToolStripMenuItem.ShortcutKeys = (Keys.Control | Keys.S);
            this.cutToolStripMenuItem.ShortcutKeys = (Keys.Control | Keys.X);
            this.copyToolStripMenuItem.ShortcutKeys = (Keys.Control | Keys.C);
            this.pasteToolStripMenuItem.ShortcutKeys = (Keys.Control | Keys.V);
            this.deleteToolStripMenuItem.ShortcutKeys = (Keys.Delete);
            
            this.undoToolStripMenuItem.ShortcutKeys = (Keys.Control | Keys.Z);
            this.selectAllToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.A;

            this.replaceToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.H;
            this.timeDateToolStripMenuItem.ShortcutKeys = Keys.F5;






            
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult ab = openFileDialog1.ShowDialog();
            openFileDialog1.Filter = "text(*.txt)|*.txt";
            if (ab == DialogResult.OK)
            
            {
                string fn = openFileDialog1.FileName;
                this.textBox1.Text = File.ReadAllText(fn);
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.textBox1.Clear();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult xy = saveFileDialog1.ShowDialog();
            saveFileDialog1.Filter = "text(*.txt)|*.txt";
            if (xy == DialogResult.OK)
            {
                string fn = saveFileDialog1.FileName;
                fn += fn + ".txt";
                File.WriteAllText(fn, this.textBox1.Text);

            }

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.textBox1.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Copy();

        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Paste();

        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }


        private void wordwrapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (wordwrapToolStripMenuItem.Checked == true)
            {
                this.wordwrapToolStripMenuItem.Checked = false;
                this.textBox1.WordWrap = false;

            }
            else
            {
                wordwrapToolStripMenuItem.Checked=true;
                this.textBox1.WordWrap = true;
            }
        }

        private void withColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowColor = true;
            DialogResult dr = this.fontDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {         
                  this.textBox1.ForeColor = fontDialog1.Color;
                   this.textBox1.Font = fontDialog1.Font;

 
            }
            

        }

        private void regularToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult ab = fontDialog2.ShowDialog();
            if (ab == DialogResult.OK)
            {
                this.textBox1.ForeColor = fontDialog1.Color;
 
            }
        }



        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = this.colorDialog1.ShowDialog();
            this.textBox1.ForeColor = this.colorDialog1.Color;
        }












        private void upperCaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
               this.textBox1.CharacterCasing = CharacterCasing.Upper;
            
        }

        private void lowerCaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.textBox1.CharacterCasing = CharacterCasing.Lower;
        }

        private void rosyBrownToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.textBox1.BackColor = Color.RosyBrown;
        }

        private void thistleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.textBox1.BackColor = Color.Thistle;
        }

        private void silverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.textBox1.BackColor = Color.Silver;
        }

        

        private void whiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.textBox1.BackColor = Color.White;
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.textBox1.SelectAll();
        }

        private void timeDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = System.DateTime.Today.ToString();
        }

        private void replaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(this);
            f2.Show();

        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

    }
}
