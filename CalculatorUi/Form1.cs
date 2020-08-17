using CalculatorApp.CalculatorLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class Form1 : Form
    {

        public OperatorCode Operation { get; set; }
        public double Result { get; set; }
        public double TextBoxNumber { get; set; }

        private IOperation calOperation;
       
        public Form1(IOperation process)
        {
            InitializeComponent();
            calOperation = process;       
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
        // insert number 1 to screen 
        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 1;
        }

        // insert number 2 to screen 
        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 2;
        }

        // insert number 3 to screen 
        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 3;
        }

        // Off button
        private void button25_Click(object sender, EventArgs e)
        {
            button1.Show();
            button25.Hide();
        }
        //power button 
        private void button20_Click(object sender, EventArgs e)
        {
            try
            {
                TextBoxNumber = ValidatorClass.ValidateEntryReturn(textBox1.Text);
                UitlityClass.ClearTextBox(textBox1);
                label3.Text = UitlityClass.AddTextToString(TextBoxNumber, " ^");
                Operation = OperatorCode.POWER;
            }
            catch (Exception)
            {

                Console.WriteLine("Invalid Opeartion");
            }
        }

        // On button
        private void button1_Click(object sender, EventArgs e)
        {
            button1.Hide();
            button25.Show();
        }

       //  button 4
        private void button11_Click(object sender, EventArgs e)
        {
            UitlityClass.AppendToTextBox(textBox1, 4);
            //textBox1.Text = textBox1.Text + 4;
        }

        // button 5
        private void button12_Click(object sender, EventArgs e)
        {
            UitlityClass.AppendToTextBox(textBox1, 5);
            //textBox1.Text = textBox1.Text + 5;
        }

        // button 6
        private void button13_Click(object sender, EventArgs e)
        {
            UitlityClass.AppendToTextBox(textBox1, 6);
            //textBox1.Text = textBox1.Text + 6;
        }

        // button 7
        private void button6_Click(object sender, EventArgs e)
        {
            UitlityClass.AppendToTextBox(textBox1, 7);
            //textBox1.Text = textBox1.Text + 7;
        }

        // button 5
        private void button7_Click(object sender, EventArgs e)
        {
            UitlityClass.AppendToTextBox(textBox1, 8);
            //textBox1.Text = textBox1.Text + 8;
        }

        // button 9
        private void button8_Click(object sender, EventArgs e)
        {
            UitlityClass.AppendToTextBox(textBox1, 9);
            //textBox1.Text = textBox1.Text + 9;
        }

        // button zero
        private void button21_Click(object sender, EventArgs e)
        {
            UitlityClass.AppendToTextBox(textBox1, 0);
            //textBox1.Text = textBox1.Text + 0;
        }

        //clear button
        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        //  backspace button
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = UitlityClass.RemoveLast(textBox1);
        }

        // dot button 
        private void button22_Click(object sender, EventArgs e)
        {

            if (!ValidatorClass.ValidateOperator(textBox1, "."))
            {
                textBox1.Text = textBox1.Text + ".";
            }
        
        }

        // addition button
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
               TextBoxNumber =   ValidatorClass.ValidateEntryReturn(textBox1.Text);
              UitlityClass.ClearTextBox(textBox1);
              label3.Text = UitlityClass.AddTextToString(TextBoxNumber, " +");
              Operation = OperatorCode.ADDITION;
              
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid Operation" );
             
            }

        }    
        // Display screen 
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        // upper screen button

        private void label3_Click(object sender, EventArgs e)
        {
        }

        // subtraction button 
        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                TextBoxNumber = ValidatorClass.ValidateEntryReturn(textBox1.Text);
                UitlityClass.ClearTextBox(textBox1);
                label3.Text = UitlityClass.AddTextToString(TextBoxNumber, " -");
                Operation = OperatorCode.SUBTRATION;
            }
            catch (Exception ex )
            {
                MessageBox.Show("Invalid Operation");
            }
          
        }

        // multiplication button
        private void button14_Click(object sender, EventArgs e)
        {
            try
            {
                TextBoxNumber = ValidatorClass.ValidateEntryReturn(textBox1.Text);
                UitlityClass.ClearTextBox(textBox1);
                label3.Text = UitlityClass.AddTextToString(TextBoxNumber, " *");
                Operation = OperatorCode.MULTIPLICATION;
            }
            catch (Exception)
            {

                MessageBox.Show("Invalid Operation");
            }
          
        }

        // division button
        private void button19_Click(object sender, EventArgs e)
        {
            try
            {
                TextBoxNumber = ValidatorClass.ValidateEntryReturn(textBox1.Text);
                UitlityClass.ClearTextBox(textBox1);
                label3.Text = UitlityClass.AddTextToString(TextBoxNumber, " /");
                Operation = OperatorCode.DIVISION;
            }
            catch (Exception)
            {
               MessageBox.Show("Invalid Operation");
            }
            
        }

        // +/- operator button 
        private void button23_Click(object sender, EventArgs e)
        {
            try
            {
                ValidatorClass.ValidateEntryReturn(textBox1.Text);
               textBox1.Text = UitlityClass.AppendPlusMinusOperator(textBox1.Text);
            }
            catch (Exception)
            {

                MessageBox.Show("Invalid Operation");
            }
           
        }

        // Cosine button 
        private void button5_Click(object sender, EventArgs e)
        {
            try
            {

                TextBoxNumber = ValidatorClass.ValidateEntryReturn(textBox1.Text);
                UitlityClass.ClearTextBox(textBox1);
                label3.Text = UitlityClass.AddTextToString("Cos() ", TextBoxNumber);
                Operation = OperatorCode.COSINE;
            }
            catch (Exception)
            {

                MessageBox.Show("Invalid Operation");
            }
        }

        // Tangent button
        private void button10_Click(object sender, EventArgs e)
        {
            try
            {
                TextBoxNumber = ValidatorClass.ValidateEntryReturn(textBox1.Text);
                UitlityClass.ClearTextBox(textBox1);
                label3.Text = UitlityClass.AddTextToString("Tan() ", TextBoxNumber);
                Operation = OperatorCode.TANGENT;
            }
            catch (Exception)
            {
                   MessageBox.Show("Invalid Operation");
            }

        }

        // Sine button
        private void button15_Click(object sender, EventArgs e)
        {

            try
            {
                TextBoxNumber = ValidatorClass.ValidateEntryReturn(textBox1.Text);
                UitlityClass.ClearTextBox(textBox1);
                label3.Text = UitlityClass.AddTextToString("Sin() ", TextBoxNumber);
                Operation = OperatorCode.SINE;

            }
            catch (Exception)
            {

                Console.WriteLine("Invalid Operation");
            }
         
        }


        // Calculate button
        private void button24_Click(object sender, EventArgs e)
        {

            textBox1.Text = calOperation.SetOperator(textBox1, Result, TextBoxNumber, Operation);
            label3.Text = "";
        }
    }

    internal class Public
    {
    }
}
