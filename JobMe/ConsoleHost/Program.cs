using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using WCFJobMe;

namespace ConsoleHost
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost host = new ServiceHost(typeof(SecureService)))
            {
                foreach (var hostedEndpoint in host.BaseAddresses)
                {
                    Console.WriteLine(hostedEndpoint.AbsoluteUri);
                    Console.WriteLine(hostedEndpoint.LocalPath);
                }

                host.Open();
                Console.WriteLine(host.State);
                //Do readline here--> if you exit the using block, the connection is closed
                Console.WriteLine("Listening");
                Console.ReadLine();
            }
        }
        }
    }
