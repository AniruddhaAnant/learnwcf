using ServicesLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Host
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost host = new ServiceHost(typeof(Calc));
            host.Open();
            Console.WriteLine("Calc server is ready.");
            Console.WriteLine("Press any key to stop the server.");
            Console.ReadKey();
            host.Close();
        }
    }
}
