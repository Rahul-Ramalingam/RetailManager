using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetailManager.Library
{
    public class ConfigHelper
    {
        public static decimal GetTaxRate()
        {
            string rateText = ConfigurationManager.AppSettings["taxRate"];
            bool isvalidTaxRate = decimal.TryParse(rateText, out decimal output);

            if (!isvalidTaxRate)
            {
                throw new ConfigurationErrorsException("The TAx reate is not set up properly");
            }

            return output;
        }
    }
}
