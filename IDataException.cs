using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trawick.DataExceptions
{
  public interface IDataExceptionFactory
    {
        List<DataException> GetDataExceptions(ExceptionListParamaters parms);
        List<CorrectionById> CorrectById(List<string> Ids);

    }

    public  class DataException
    {
        public string Message { get; set; }
        public  int Id { get; set; }
        public Boolean CanCorrect { get; set; }
        public string FactoryType { get; set; }
        public DateTime ExceptionDate { get; set; }
    }


    public class ExceptionListParamaters
    {
        public DateTime BeginDate { get; set; }
       public  DateTime EndDate { get; set; }
    }

    public class CorrectionById
    {
        public string Id { get; set; }
        public Boolean Corrected { get; set; }
        public string Message { get; set; }
    }

}
