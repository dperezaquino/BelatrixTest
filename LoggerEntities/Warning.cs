using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggerEntities
{
    public class Warning : GenericMessage
    {
        public Warning(string strMessageText) : base(strMessageText)
        {
        }
    }
}
