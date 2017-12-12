using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trawick.DataExceptions.ExceptionClasses
{
    class EnrollmentMissingBaseform : IDataExceptionFactory
    {
        public List<CorrectionById> CorrectById(List<string> Ids)
        {
            throw new NotImplementedException();
        }

     

        public List<DataException> GetDataExceptions(ExceptionListParamaters parms)
        {
            var cont = new Models.TrackingCubeModels();
            var list = cont.sp_DataExceptions_EnrollmentsWithoutBaseform(parms.BeginDate, parms.EndDate);
            var exceptions = new List<DataException>();
            foreach (var item in list)
            {
                exceptions.Add(ExceptionFromResult(item));
            }
            return exceptions;
        }

        private DataException ExceptionFromResult(Models.sp_DataExceptions_EnrollmentsWithoutBaseform_Result result)
        {
            var item = new DataException()
            {
                CanCorrect = true,
                FactoryType = this.GetType().AssemblyQualifiedName,
                Id = result.master_enrollment_id,
                Message = string.Format("The Enrollment with Id {0} has a missing Base Form.", result.master_enrollment_id.ToString())
                ,
                ExceptionDate = result.dt_cr.GetValueOrDefault()
            };

            return item;
        }
    }
}
