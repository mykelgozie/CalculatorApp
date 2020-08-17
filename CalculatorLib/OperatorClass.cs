using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace CalculatorApp.CalculatorLib
{
    public class OperatorClass: IOperation
    {

        //public  OperatorCode Operation { get; set; }
        //public double Result { get; set; }
        //public  double TextBoxNumber { get; set; }

        public  string SetOperator(TextBox text, double result, Double textBoxNumber, OperatorCode ops)
        {
            string calculatedValue = "";


            switch (ops)
            {

                case OperatorCode.ADDITION:
                    result = textBoxNumber + float.Parse(text.Text);
                    calculatedValue = result.ToString();
                  
                    break;
                case OperatorCode.SUBTRATION:
                    result = textBoxNumber - float.Parse(text.Text);
                    calculatedValue = result.ToString();
                    break;
                case OperatorCode.MULTIPLICATION:
                    result = textBoxNumber * float.Parse(text.Text);
                    calculatedValue = result.ToString();
                    break;
                case OperatorCode.DIVISION:
                    result = textBoxNumber / float.Parse(text.Text);
                    calculatedValue = result.ToString();
                    break;
                case OperatorCode.COSINE:

                    double rad = textBoxNumber * (Math.PI / 180);
                    calculatedValue = Math.Cos(rad).ToString();

                    break;

                case OperatorCode.SINE:

                    double sinRad = textBoxNumber * (Math.PI / 180);
                    calculatedValue = Math.Sin(sinRad).ToString();

                    break;


                case OperatorCode.TANGENT:

                    double tanRad = textBoxNumber * (Math.PI / 180);

                    calculatedValue = Math.Tan(tanRad).ToString();

                    break;
                case OperatorCode.POWER:

                    double power = double.Parse(text.Text);
                    calculatedValue = Math.Pow(textBoxNumber, power).ToString();
                    break;
                default:
                    break;
            }

            return calculatedValue;


        }


    }
}
