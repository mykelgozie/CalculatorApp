using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace CalculatorApp.CalculatorLib
{
    public class UitlityClass
    {

        public static void ClearTextBox(TextBox box)
        {
            box.Clear();
            box.Focus();
        }

        public static string AddTextToString(double value, string Operation)
        {
          return  value.ToString() + Operation;

        }
        public static string AddTextToString(string Operation, double value )
        {
            return Operation + value.ToString();

        }



        public static void AppendToTextBox(TextBox box, int number)
        {
            box.Text = box.Text + number;
        }

        public static string AppendPlusMinusOperator(string value)
        {

            //string value = textBox1.Text;
            int size = value.Length;
            string result = value[0].ToString();
            string data = "";

            if (result != "-")
            {
                data += "-";
                for (int i = 0; i < size; i++)
                {
                    data += value[i];

                }

            }

            if (result == "-")
            {
                for (int i = 1; i < size; i++)
                {
                    data += value[i];

                }
            }

            return data;


        }


        public static string RemoveLast(TextBox box)
        {

            int textLen = box.TextLength - 1;
            string text = box.Text;
            box.Clear();
            string data = "";

            for (int i = 0; i < textLen; i++)
            {
                data += text[i].ToString();


            }

            return data;


        }
    }
}
