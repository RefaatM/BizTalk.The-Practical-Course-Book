using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfMultiplier
{
    // NOTE: If you change the interface name "IWcfMultiplierService" here, you must also update the reference to "IWcfMultiplierService" in Web.config.
    [ServiceContract(Namespace = "http://www.MoustafaRefaat.com/Orchestrations.WCF.BasicHttpSendAdapter.BasicHttpWcfServiceConsuming")]
    public interface IWcfMultiplierService
    {

        [OperationContract]
        MultiplyResponse Multiply(MultiplyRequest composite);

        
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class MultiplyRequest
    {
        int aValue = 0;
        int bValue = 0;

        [DataMember]
        public int AValue
        {
            get { return aValue; }
            set { aValue = value; }
        }
        [DataMember]
        public int BValue
        {
            get { return bValue; }
            set { bValue = value; }
        }

    }

    public class MultiplyResponse
    {
        int rValue = 0;

        [DataMember]
        public int RValue
        {
            get { return rValue; }
            set { rValue = value; }
        }
    }

}
