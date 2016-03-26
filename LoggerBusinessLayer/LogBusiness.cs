using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LoggerDataLayer;

namespace LoggerBusinessLayer
{
    public class LogBusiness
    {
        public void SaveLog(string strMessage, int intMessageId)
        {
            LogData objLogData = new LogData();
            objLogData.SaveLog(strMessage, intMessageId);
        }
    }
}
