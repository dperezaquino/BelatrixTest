using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LoggerEntities;
using LoggerBusinessLayer;
using LoggerCommon;

namespace LoggerEntities
{
    public class DatabaseLog : Log
    {  
        public override void SaveLog(GenericMessage objGenericMessage)
        {            
            if (_blLogMessage && objGenericMessage is Message)
            {
                LogBusiness objLogBusiness = new LogBusiness();
                objLogBusiness.SaveLog(objGenericMessage.MessageText, (int)CommonEnums.MessageType.Message);
            }
            else if (_blLogWarning && objGenericMessage is Warning)
            {
                LogBusiness objLogBusiness = new LogBusiness();
                objLogBusiness.SaveLog(objGenericMessage.MessageText, (int)CommonEnums.MessageType.Warning);
            }
            else if (_blLogError && objGenericMessage is Error)
            {
                LogBusiness objLogBusiness = new LogBusiness();
                objLogBusiness.SaveLog(objGenericMessage.MessageText, (int)CommonEnums.MessageType.Error);
            }            
        }
    }
}
