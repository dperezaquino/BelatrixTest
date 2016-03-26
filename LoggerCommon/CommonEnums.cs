using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggerCommon
{
    public static  class CommonEnums
    {
        public enum MessageType
        {
            Message = 1,
            Error = 2,
            Warning = 3
        };

        public enum LogResultType
        {
            OK = 1,
            ConsoleLogError = 2,
            FileLogError = 3,
            DatabaseLogError = 4
        };
    }
}
