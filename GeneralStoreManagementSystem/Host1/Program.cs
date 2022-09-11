using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace Host1
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost host = new ServiceHost(typeof(GeneralStoreManagementSystem.Service1)))
            {
                host.Open();
                Console.WriteLine("Host is Started");
                Console.ReadLine();
            }
        }
    }
}
