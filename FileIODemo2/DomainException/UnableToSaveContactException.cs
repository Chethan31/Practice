using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIODemo2.DomainException
{
    public class UnableToSaveContactException : ApplicationException
    {
        public UnableToSaveContactException(string msg=null, Exception innerExxp = null):base(msg,innerExxp)
        {

        }
    }
}
