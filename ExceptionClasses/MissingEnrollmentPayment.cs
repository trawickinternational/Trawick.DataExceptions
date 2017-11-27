using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trawick.DataExceptions.ExceptionClasses
{
    public class MissingEnrollmentPaymentFactory : IDataExceptionFactory
    {

        public MissingEnrollmentPaymentFactory() { }
        public bool CorrectById(int Id)
        {
            throw new NotImplementedException();
        }

        public List<DataException> GetDataExceptions(ExceptionListParamaters parms)
        {
            var cont = new Models.TrackingCubeModels();
            var list = cont.sp_DataExceptions_MissingEnrollmentPaymentRecords(parms.BeginDate, parms.EndDate);
            var exceptions = new List<DataException>();
            foreach (var item in list)
            {
                exceptions.Add(ExceptionFromResult(item));
            }
            return exceptions;
        }


        private DataException ExceptionFromResult(Models.sp_DataExceptions_MissingEnrollmentPaymentRecords_Result  result)
        {
            var item = new DataException()
            {
                CanCorrect = false,
                FactoryType = this.GetType().AssemblyQualifiedName,
                Id = result.master_enrollment_id.GetValueOrDefault(),
                Message = string.Format("The Enrollment with Id {0} has a missing Enrollment Payment Record.  Payment Id Id {1}", result.master_enrollment_id.ToString(), result.payment_id.ToString())
                ,ExceptionDate = result.pmt_date.GetValueOrDefault()
            };

            return item;
        }

    }
}

