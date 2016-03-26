using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggerEntities
{
    public class Message : GenericMessage
    {
        public Message(string strMessageText) : base(strMessageText)
        {
        }
    }
}
