using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggerEntities
{
    public abstract class Log
    {
        protected static bool _blLogMessage;
        protected static bool _blLogWarning;
        protected static bool _blLogError;

        public static bool LogMessage
        {
            get { return _blLogMessage; }
            set { _blLogMessage = value; }
        }

        public static bool LogWarning
        {
            get { return _blLogWarning; }
            set { _blLogWarning = value; }
        }

        public static bool LogError
        {
            get { return _blLogError; }
            set { _blLogError = value; }
        }

        public abstract void SaveLog(GenericMessage objGenericMessage);
    }
}
