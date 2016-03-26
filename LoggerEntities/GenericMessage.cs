using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggerEntities
{
    public class GenericMessage
    {
        private string _strMessageText;

        public string MessageText
        {
            get { return _strMessageText; }
            set { _strMessageText = value; }
        }

        public GenericMessage(string strMessageText)
        {
            MessageText = strMessageText;
        }
    }
}
