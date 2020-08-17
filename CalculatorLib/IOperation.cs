using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace CalculatorApp.CalculatorLib
{
    public interface IOperation
    {
         //OperatorCode Operation { get; set; }
         //double Result { get; set; }
         //double TextBoxNumber { get; set; }
         string SetOperator(TextBox text, double result, Double textBoxNumber, OperatorCode ops);

    }
}
