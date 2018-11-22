using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfMultiplier
{
    // NOTE: If you change the class name "WcfMultiplierService" here, you must also update the reference to "WcfMultiplierService" in Web.config and in the associated .svc file.
    public class WcfMultiplierService : IWcfMultiplierService
    {
        
        #region IWcfMultiplierService Members

        public MultiplyResponse Multiply(MultiplyRequest composite)
        {
            MultiplyResponse mr = new MultiplyResponse();
            mr.RValue = composite.AValue * composite.BValue;
            return mr;
        }

        #endregion
    }
}
