using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace CalculatorApp.CalculatorLib
{
    public class ValidatorClass
    {

        public static float ValidateEntryReturn( string data)
        {
            if (string.IsNullOrWhiteSpace(data))
            {
                throw new ArgumentOutOfRangeException("Invalid Data Entry");
            }

            return float.Parse(data);

        }

        public static bool ValidateOperator(TextBox box, string operation)
        {
            string text = box.Text;
            bool value = false;

            if (text.Contains("."))
            {
                value =  true;
            }

            return value;

        }
    }
}
