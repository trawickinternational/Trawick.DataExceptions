using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trawick.DataExceptions.ExceptionClasses
{
    class MissingEnrollmentPaymentRecords : IDataExceptionFactory
    {
        public bool CorrectById(int Id)
        {
            throw new NotImplementedException();
        }

        public List<DataException> GetDataExceptions(ExceptionListParamaters parms)
        {
            throw new NotImplementedException();
        }
    }
}
