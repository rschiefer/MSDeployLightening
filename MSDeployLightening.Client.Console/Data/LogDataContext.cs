using MSDeployLightening.Client.Console.Domain;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSDeployLightening.Client.Console.Data
{
    public class LogDataContext : DbContext
    {
        public DbSet<Log> Logs { get; set; }
    }
}
