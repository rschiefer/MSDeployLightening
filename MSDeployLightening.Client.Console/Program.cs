using MSDeployLightening.Client.Console.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSDeployLightening.Client.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            using(var client = new ServiceReference1.MSDeployAllTheThingsClient())
            {
                var shouldIUseMSDeploy = client.ShouldIUseMSDeploy();
                using (var context = new LogDataContext())
                {
                    context.Logs.Add(new Domain.Log {
                        LoggedAt = DateTime.UtcNow,
                        Method = "ShouldIUseMSDeploy",
                        Response = shouldIUseMSDeploy.ToString()
                    });
                }
            }
        }
    }
}
