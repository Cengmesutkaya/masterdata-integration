using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace masterdata_integration.config
{
    public class Configuration
    {
        public static int getDistributorId()
        {
            return Convert.ToInt32(ConfigurationManager.AppSettings["DistributorId"]);
        }
        public static string getApiUrl()
        {
            return ConfigurationManager.AppSettings["ApiURL"];
        }
    }
}
