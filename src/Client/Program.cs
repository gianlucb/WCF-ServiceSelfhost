using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                BasicHttpBinding binding = new BasicHttpBinding();
                EndpointAddress wcfServiceEndpoint = new EndpointAddress(TestService.WCFAddress);
                ChannelFactory<ITestService> factory = new ChannelFactory<ITestService>(binding, wcfServiceEndpoint);

                var client = factory.CreateChannel();
                for (int i = 0; i < 10; i++)
                {
                    var res = client.GetHello();
                    Console.WriteLine(res);
                }
                
                ((IClientChannel)client).Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
            finally
            {
                Console.ReadKey();
            }
    
        }
    }
}
