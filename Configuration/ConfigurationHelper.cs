using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
namespace Trawick.DataExceptions.Configuration
{
    public static class ConfigurationHelper
    {
        public static DataExceptionTypeElementCollection GetExceptionTypes()
        {
            var section = ConfigurationManager.GetSection("dataExectionTypes");
            if (section != null)
            {
                return (section as DataExceptionTypesSection).ExceptionTypes;
              
            }
            return new Configuration.DataExceptionTypeElementCollection();
        }
    }
}
