using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using LoggerEntities;
using LoggerCommon;

namespace Logger
{ 
    public class JobLogger 
    {                       
        private static ConsoleLog _objConsoleLog;
        private static FileLog _objFileLog;
        private static DatabaseLog _objDatabaseLog;

        public JobLogger(bool blLogToFile, bool blLogToConsole, bool blLogToDatabase, bool blLogMessage, bool blLogWarning, bool blLogError) 
        {
            if (!blLogToFile && !blLogToConsole && !blLogToDatabase || (!blLogMessage && !blLogWarning && !blLogError))
            {
                 Console.WriteLine("Invalid configuration");
            }            
            else
            {
                Log.LogMessage = blLogMessage;
                Log.LogError = blLogError;
                Log.LogWarning = blLogWarning;

                if (blLogToConsole)
                    _objConsoleLog = new ConsoleLog();

                if (blLogToFile)
                {
                    string strLogFileDirectory = ConfigurationManager.AppSettings["LogFileDirectory"].ToString();
                    _objFileLog = new FileLog(strLogFileDirectory);
                }  
                
                if (blLogToDatabase)
                {
                    _objDatabaseLog = new DatabaseLog();
                }
            }                                
        } 
 
        public static string LogMessage(GenericMessage objGenericMessage) 
        {
            string strMessage = objGenericMessage.MessageText.Trim();

            try
            {
                if (strMessage == null || strMessage.Length == 0)
                    return "";

                if (_objConsoleLog != null)
                    _objConsoleLog.SaveLog(objGenericMessage);

                if (_objFileLog != null)
                    _objFileLog.SaveLog(objGenericMessage);

                if (_objDatabaseLog != null)
                {
                    _objDatabaseLog.SaveLog(objGenericMessage);
                }

                return CommonEnums.LogResultType.OK.ToString();
            }                
            catch (Exception e)
            {
                Console.WriteLine(e.InnerException);
                return e.Message;
            }            
        }
    }
}
