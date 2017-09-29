using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLayer;
using DataAccessLayer;
using BusinessLogicLayer;
using System.ServiceModel;
using JobProject.Service;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost host = new ServiceHost(typeof(JobProjectUserService));
            host.Open();
            Console.WriteLine("Host is running on: " + host.BaseAddresses.First());
            Console.ReadLine();

        }
    }
}
