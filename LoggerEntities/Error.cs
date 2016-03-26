using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggerEntities
{
    public class Error : GenericMessage
    {
        public Error(string strMessageText) : base(strMessageText)
        {
        }
    }
}
