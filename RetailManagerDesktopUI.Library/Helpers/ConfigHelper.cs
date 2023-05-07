using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetailManagerDesktopUI.Library.Helpers
{
    public class ConfigHelper : IConfigHelper
    {
        public decimal GetTaxRate()
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
