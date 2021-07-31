using Client.CalcService.Proxy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("http or tcp");
            var channel = Console.ReadLine().ToLower();

            CalcClient calcClient = null;

            switch (channel)
            {
                case "http":
                    calcClient = new CalcClient("BasicHttpBinding_ICalc");
                    break;
                case "tcp":
                    calcClient = new CalcClient("NetTcpBinding_ICalc");
                    break;
                default:
                    Console.WriteLine("Invalid");
                    break;
            }

            calcClient?.Open();
            Console.WriteLine($"Addition is {calcClient?.Add(10,20)}");
            Console.WriteLine($"Substraction is {calcClient?.Substract(10,20)}");
            Console.WriteLine($"Multiplication is {calcClient?.Multiply(10,20)}");
            Console.WriteLine($"Divison is {calcClient?.Divide(10,20)}");
            calcClient.Close();
            Console.ReadKey();
        }
    }
}
