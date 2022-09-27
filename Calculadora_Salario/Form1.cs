using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercicio2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double ht, vh, desconto, sb, sl, totaldescontos;

            ht = Convert.ToDouble (textBox1.Text);
            vh = Convert.ToDouble (textBox2.Text);
            desconto = Convert.ToDouble (textBox3.Text);

            sb = ht * vh;
            totaldescontos = ((desconto / 100) * sb);
            sl = sb - totaldescontos;

            label7.Text = sl.ToString("C");
            label8.Text = totaldescontos.ToString();
            label10.Text = sb.ToString("C");

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            label7.Text = " ";
            label8.Text = " ";
            label10.Text = " ";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
