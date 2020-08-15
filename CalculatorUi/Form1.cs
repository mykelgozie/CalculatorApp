using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class Form1 : Form
    {

        private Double num;
        private int count;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 1;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 2;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 3;
        }

        private void button25_Click(object sender, EventArgs e)
        {
            button1.Show();
            button25.Hide();
        }

        private void button20_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Hide();
            button25.Show();
        }

       
        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 4;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 5;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 6;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 7;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 5;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 9;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int textLen = textBox1.TextLength - 1;
            string text = textBox1.Text;
            textBox1.Clear();

            for (int i = 0; i < textLen; i++)
            {
                textBox1.Text = textBox1.Text + text[i];


            }

        }

        private void button22_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ".";
        }

        private void button4_Click(object sender, EventArgs e)
        {

            num = float.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            label3.Text = num.ToString()  + " +";
            count = 1;

        }

     
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {


            num = float.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            label1.Text = num.ToString() + " -";
            count = 2;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            num = float.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            label1.Text = num.ToString() + " *";
            count = 3;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            num = float.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            label1.Text = num.ToString() + " /";
            count = 3;
        }

        private void button23_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            double num = float.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            label3.Text = "Cos() " + num.ToString();
            count = 5;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            num = double.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            label3.Text = "Tan() " + num.ToString();
            count = 7;

        }

        private void button15_Click(object sender, EventArgs e)
        {
            num = double.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            label3.Text = "Sin() " + num.ToString();
            count = 6;
        }
    }
}
