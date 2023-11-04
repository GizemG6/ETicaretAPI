using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Persistence
{
    static class Configuration
    {
        static public string ConnectionString
        {
            get
            {
                ConfigurationManager configuratiınManager = new();
                configuratiınManager.SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "C:\\Users\\cang8\\Desktop\\ETicaretApp\\ETicaretAPI\\Presentation\\ETicaretAPI.API"));
                configuratiınManager.AddJsonFile("appsettings.json");

                return configuratiınManager.GetConnectionString("PostgreSQL");
            }
        }
    }
}
