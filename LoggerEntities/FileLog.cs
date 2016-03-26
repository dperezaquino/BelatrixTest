using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using LoggerCommon;

namespace LoggerEntities
{
    public class FileLog : Log
    {
        private string _strLogFileDirectory = string.Empty;
        private const string LOG_FILE_NAME = "LogFile";
        private const string LOG_FILE_EXTENSION = ".txt";

        public FileLog (string strLogFileDirectory)
        {
            _strLogFileDirectory = strLogFileDirectory;            
        }

        public override void SaveLog(GenericMessage objGenericMessage)
        {
            string strLogFileText = string.Empty;
            string strLogFileDate = DateTime.Now.ToString("ddMMyyyy");
            string strLogFileNow = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + " ";
            string strLogFileName = _strLogFileDirectory + LOG_FILE_NAME + strLogFileDate + LOG_FILE_EXTENSION;

            try
            {
                if (System.IO.File.Exists(strLogFileName))
                {
                    strLogFileText = System.IO.File.ReadAllText(strLogFileName);
                }

                if (_blLogError && objGenericMessage is Error)
                {
                    strLogFileText = strLogFileText + strLogFileNow + objGenericMessage.MessageText + System.Environment.NewLine;
                    System.IO.File.WriteAllText(strLogFileName, strLogFileText);
                }
                else if (_blLogWarning && objGenericMessage is Warning)
                {
                    strLogFileText = strLogFileText + strLogFileNow + objGenericMessage.MessageText + System.Environment.NewLine;
                    System.IO.File.WriteAllText(strLogFileName, strLogFileText);
                }
                else if (_blLogMessage && objGenericMessage is Message)
                {
                    strLogFileText = strLogFileText + strLogFileNow + objGenericMessage.MessageText + System.Environment.NewLine;
                    System.IO.File.WriteAllText(strLogFileName, strLogFileText);
                }            
            }            
            catch (Exception e)
            {
                throw new Exception(CommonEnums.LogResultType.FileLogError.ToString(), e);
            }
        }
    }
}
