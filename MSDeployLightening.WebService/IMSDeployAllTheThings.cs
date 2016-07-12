using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace MSDeployLightening.WebService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IMSDeployAllTheThings" in both code and config file together.
    [ServiceContract]
    public interface IMSDeployAllTheThings
    {
        [OperationContract]
        bool ShouldIUseMSDeploy();
        [OperationContract]
        DateTime WhenShouldIUseMSDeploy();
        [OperationContract]
        string WhoShouldUseMSDeploy(string yourName);


    }
}
