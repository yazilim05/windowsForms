using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string harf1 = textBox1.Text;
            harf1 = "A";
            textBox1.Text =harf1;
        }

        private void button30_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            }
            timer1.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string harf2 = textBox1.Text;
            textBox1.Text =harf2;
        }
        private void btn_Click(object sender, EventArgs e)
        {

            Button b = (Button)sender;
            textBox1.Text = textBox1.Text + b.Text;
            timer1.Enabled = true;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
