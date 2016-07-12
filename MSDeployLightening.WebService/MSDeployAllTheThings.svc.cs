using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace MSDeployLightening.WebService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "MSDeployAllTheThings" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select MSDeployAllTheThings.svc or MSDeployAllTheThings.svc.cs at the Solution Explorer and start debugging.
    public class MSDeployAllTheThings : IMSDeployAllTheThings
    {
        public bool ShouldIUseMSDeploy()
        {
            return true;
        }

        public DateTime WhenShouldIUseMSDeploy()
        {
            return DateTime.UtcNow.AddDays(-7);
        }

        public string WhoShouldUseMSDeploy(string yourName)
        {
            return yourName;
        }
    }
}
