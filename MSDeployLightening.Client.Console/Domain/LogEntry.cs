using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSDeployLightening.Client.Console.Domain
{
    public class Log
    {
        public DateTime LoggedAt { get; set; }
        public string Method { get; set; }
        public string Response { get; set; }
    }
}
