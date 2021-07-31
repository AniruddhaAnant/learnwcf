using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ContractsLib
{
    [ServiceContract]
    public interface ICalc
    {
        [OperationContract]
        double Add(double firstNumber, double secondNumber);

        [OperationContract]
        double Substract(double firstNumber, double secondNumber);

        [OperationContract]
        double Multiply(double firstNumber, double secondNumber);

        [OperationContract]
        double Divide(double firstNumber, double secondNumber);

    }
}
