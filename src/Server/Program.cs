using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;


namespace Server
{
    class Program
    {

        static void Main(string[] args)
        {
            try
            {
                //selfhosting WCF service (to be ran as administrator)
                using (ServiceHost host = new ServiceHost(typeof(TestService), TestService.WCFBaseAddress))
                {                 
                    BasicHttpBinding binding = new BasicHttpBinding();
                    host.AddServiceEndpoint(typeof(ITestService), binding, TestService.ServicePublicName);

                    host.Open();

                    Console.WriteLine("The service is ready at {0}", TestService.WCFAddress);
                    Console.WriteLine("Press <Enter> to stop the service.");
                    Console.ReadLine();

                    host.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                Console.WriteLine(ex.StackTrace);
            }
            finally
            {
                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
            }

        }
    }
}
