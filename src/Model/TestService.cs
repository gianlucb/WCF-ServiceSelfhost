using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Model
{    
    public class TestService : ITestService
    {
        public static Uri WCFBaseAddress = new Uri("http://localhost:5555");
        public static String ServicePublicName = "TestService";
        public static Uri WCFAddress = new Uri(WCFBaseAddress.AbsoluteUri + ServicePublicName);

        public string GetHello()
        {
            Console.WriteLine(DateTime.Now.ToShortTimeString() + ": Got a call for GetHello");
            return "HELLO";
        }
    }
}
