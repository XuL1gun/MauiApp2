using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp2.Model
{
    internal class CalculatorModel
    {

        private double _firstNumber;

        private char _action;

        public string EqAction(string Digit)
        {
            return _action switch
            {
                '+' => (_firstNumber + Convert.ToDouble(Digit.Split('\n').Last())).ToString(),
                '÷' => (_firstNumber / Convert.ToDouble(Digit.Split('\n').Last())).ToString(),
                '×' => (_firstNumber * Convert.ToDouble(Digit.Split('\n').Last())).ToString(),
                '-' => (_firstNumber - Convert.ToDouble(Digit.Split('\n').Last())).ToString(),
                _ => throw new NotImplementedException("This action was not implemented")
            };
        }

        public void ActionPressed(string Digit, string action)
        {
            _firstNumber = Convert.ToDouble(Digit.Split("\n").First());
            _action = Convert.ToChar(action);
        }
    }
}
