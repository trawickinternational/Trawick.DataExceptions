using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trawick.DataExceptions.ExceptionClasses
{
    public class MissingEnrollmentDatesFactory : IDataExceptionFactory
    {

        public MissingEnrollmentDatesFactory() { }

        public List<CorrectionById> CorrectById(List<string> Ids)
        {
            throw new NotImplementedException();
        }

      

        public List<DataException> GetDataExceptions(ExceptionListParamaters parms)
        {
            var cont = new Models.TrackingCubeModels();
            var list = cont.sp_DataExceptions_MissingEnrollmentDates(parms.BeginDate, parms.EndDate);
            var exceptions = new List<DataException>();
            foreach (var item in list)
            {
                exceptions.Add(ExceptionFromResult(item));
            }
            return exceptions;
        }


        private DataException ExceptionFromResult(Models.sp_DataExceptions_MissingEnrollmentDates_Result   result)
        {
            var item = new DataException()
            {
                CanCorrect = false,
                FactoryType = this.GetType().AssemblyQualifiedName,
                Id = result.master_enrollment_id,
                Message = string.Format("The Enrollment with Id {0} has a missing Enrollment Dates for Enrollment Premium  {1}", result.master_enrollment_id.ToString(), result.enrollment_premium_id.ToString())
                ,ExceptionDate = result.PremiumDate.GetValueOrDefault()
            };

            return item;
        }

    }
}

