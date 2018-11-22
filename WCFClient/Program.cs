using System;
using System.Collections.Generic;
using System.Text;

using System.ServiceModel;
using MultiplyPortClient = BTSPracCourse_Orchestrations_Processor_WcfMultiplierServiceClient_Port_BTSMultiplyRequestClient;


namespace Microsoft.Samples.BizTalk.WCFBasicHttpReceiveAdapter.WCFClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Root rt = new Root();
            rt.Multiply = new RootMultiply();
            rt.Multiply.AVal = "10";
            rt.Multiply.BVal = "500";

            MultiplyPortClient multiplyProcessClient = new MultiplyPortClient("BasicHttpBinding_ITwoWayAsync");
            Root1 result = multiplyProcessClient.Operation_1(rt);

            Console.WriteLine(result.Result.Value);
            Console.ReadLine();
        }
    }
}
