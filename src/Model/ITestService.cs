using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Model
{
    [ServiceContract]
    public interface ITestService
    {     
        [OperationContract]
        string GetHello();
    }
}
