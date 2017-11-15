using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using WCFJobMeService;

namespace ConsoleHost
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost host = new ServiceHost(typeof(ApplierService)))
            {
                foreach (var hostedEndpoint in host.BaseAddresses)
                {
                    Console.WriteLine(hostedEndpoint.AbsoluteUri);
                    Console.WriteLine(hostedEndpoint.LocalPath);
                }
                host.Open();
                printInfo(host);
            }
            using (ServiceHost host = new ServiceHost(typeof(CompanyService)))
            {
                foreach (var hostedEndpoint in host.BaseAddresses)
                {
                    Console.WriteLine(hostedEndpoint.AbsoluteUri);
                    Console.WriteLine(hostedEndpoint.LocalPath);
                }
                host.Open();
                printInfo(host);
            }
            using (ServiceHost host = new ServiceHost(typeof(JobPostService)))
            {
                foreach (var hostedEndpoint in host.BaseAddresses)
                {
                    Console.WriteLine(hostedEndpoint.AbsoluteUri);
                    Console.WriteLine(hostedEndpoint.LocalPath);
                }
                host.Open();
                printInfo(host);
            }
            Console.ReadLine();
        }

        static public void printInfo(ServiceHost host)
        {
            Console.WriteLine(host.State);
            //Do readline here--> if you exit the using block, the connection is closed
            Console.WriteLine("Listening");
            
        }
        
    }
}
