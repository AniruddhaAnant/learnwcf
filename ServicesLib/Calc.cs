using ContractsLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicesLib
{
    public class Calc : ICalc
    {
        public double Add(double firstNumber, double secondNumber)
        {
            return firstNumber + secondNumber;
        }

        public double Divide(double firstNumber, double secondNumber)
        {
            return firstNumber / secondNumber;
        }

        public double Multiply(double firstNumber, double secondNumber)
        {
            return firstNumber * secondNumber;
        }

        public double Substract(double firstNumber, double secondNumber)
        {
            return firstNumber - secondNumber;
        }
    }
}
