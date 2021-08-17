using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trawick.DataExceptions.ExceptionClasses
{
    public class MissingPaymentsFactory : IDataExceptionFactory
    {

        public MissingPaymentsFactory() { }

        public bool CorrectById(int Id)
        {
            throw new NotImplementedException();
        }

        public List<CorrectionById> CorrectById(List<string> Ids)
        {
            throw new NotImplementedException();
        }


        public List<DataException> GetDataExceptions(ExceptionListParamaters parms)
        {
            var cont = new Models.TrackingCubeModels();
            var list = cont.sp_DataExceptions_MissingPaymentCodes(parms.BeginDate, parms.EndDate);
            var exceptions = new List<DataException>();
            foreach (var item in list)
            {
                exceptions.Add(ExceptionFromResult(item));
            }
            return exceptions;
        }


        private DataException ExceptionFromResult(Models.sp_DataExceptions_MissingPaymentCodes_Result result)
        {
            var item = new DataException() {
                CanCorrect = false,
                FactoryType = this.GetType().AssemblyQualifiedName,
                Id = result.payment_id ,
                Message = string.Format("The Payment with Id {0} has a missing Error Pop Code.  Payment for Enrollment Id {1}",result.payment_id,result.master_enrollment_id == null?0:result.master_enrollment_id),
                ExceptionDate = result.pmt_date.GetValueOrDefault()
            };

            return item;
        }

    }
}
