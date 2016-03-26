using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LoggerCommon;

namespace LoggerEntities
{
    public class ConsoleLog : Log
    {
        public override void SaveLog(GenericMessage objGenericMessage)
        {
            string strLogFileNow = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + " ";

            try
            { 
                if (_blLogMessage && objGenericMessage is Message)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(strLogFileNow + " " + objGenericMessage.MessageText);                
                }
                else if (_blLogWarning && objGenericMessage is Warning)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(strLogFileNow + " " + objGenericMessage.MessageText);                
                }
                else if (_blLogError && objGenericMessage is Error)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(strLogFileNow + " " + objGenericMessage.MessageText);                
                }

                //Restore default console's foregroundcolor
                Console.ForegroundColor = ConsoleColor.Gray;
            }
            catch (Exception e)
            {
                throw new Exception(CommonEnums.LogResultType.ConsoleLogError.ToString(), e);                
            }
        }
    }
}
