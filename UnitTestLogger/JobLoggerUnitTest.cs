using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Logger;
using LoggerCommon;
using LoggerEntities;

namespace UnitTestLogger
{
    [TestClass]
    public class JobLoggerUnitTest
    {
        [TestMethod]
        public void TestLogWarningToAll()
        {
            bool blLogToFile = true;
            bool blLogToConsole = true;
            bool blLogToDatabase = true;
            bool blLogMessage = true;
            bool blLogWarning = true;
            bool blLogError = true;
            string strMessage = "Alerta daniel";
            Warning objWarning = new Warning(strMessage);

            JobLogger objJobLogger = new JobLogger(blLogToFile, blLogToConsole, blLogToDatabase, blLogMessage, blLogWarning, blLogError);
            Assert.AreEqual(CommonEnums.LogResultType.OK.ToString(), JobLogger.LogMessage(objWarning));

            Console.Read();
        }

        [TestMethod]
        public void TestLogWarningToConsole()
        {
            bool blLogToFile = false;
            bool blLogToConsole = true;
            bool blLogToDatabase = false;
            bool blLogMessage = true;
            bool blLogWarning = true;
            bool blLogError = true;
            string strMessage = "Alerta daniel";
            Warning objWarning = new Warning(strMessage);

            JobLogger objJobLogger = new JobLogger(blLogToFile, blLogToConsole, blLogToDatabase, blLogMessage, blLogWarning, blLogError);
            Assert.AreEqual(CommonEnums.LogResultType.OK.ToString(), JobLogger.LogMessage(objWarning));
        }

        [TestMethod]
        public void TestLogMesageToAll()
        {
            bool blLogToFile = true;
            bool blLogToConsole = true;
            bool blLogToDatabase = true;
            bool blLogMessage = true;
            bool blLogWarning = true;
            bool blLogError = true;
            string strMessage = "Mensaje daniel";
            Message objMessage = new Message(strMessage);

            JobLogger objJobLogger = new JobLogger(blLogToFile, blLogToConsole, blLogToDatabase, blLogMessage, blLogWarning, blLogError);
            Assert.AreEqual(CommonEnums.LogResultType.OK.ToString(), JobLogger.LogMessage(objMessage));
        }

        [TestMethod]
        public void TestLogMesageToFile()
        {
            bool blLogToFile = true;
            bool blLogToConsole = false;
            bool blLogToDatabase = false;
            bool blLogMessage = true;
            bool blLogWarning = true;
            bool blLogError = true;
            string strMessage = "Mensaje daniel";
            Message objMessage = new Message(strMessage);

            JobLogger objJobLogger = new JobLogger(blLogToFile, blLogToConsole, blLogToDatabase, blLogMessage, blLogWarning, blLogError);
            Assert.AreEqual(CommonEnums.LogResultType.OK.ToString(), JobLogger.LogMessage(objMessage));
        }

        [TestMethod]
        public void TestLogErrorToAll()
        {
            bool blLogToFile = true;
            bool blLogToConsole = true;
            bool blLogToDatabase = true;
            bool blLogMessage = true;
            bool blLogWarning = true;
            bool blLogError = true;
            string strMessage = "Error daniel";
            Error objError = new Error(strMessage);

            JobLogger objJobLogger = new JobLogger(blLogToFile, blLogToConsole, blLogToDatabase, blLogMessage, blLogWarning, blLogError);
            Assert.AreEqual(CommonEnums.LogResultType.OK.ToString(), JobLogger.LogMessage(objError));
        }

        [TestMethod]
        public void TestLogErrorToDatabase()
        {
            bool blLogToFile = false;
            bool blLogToConsole = false;
            bool blLogToDatabase = true;
            bool blLogMessage = true;
            bool blLogWarning = true;
            bool blLogError = true;
            string strMessage = "Error daniel";
            Error objError = new Error(strMessage);

            JobLogger objJobLogger = new JobLogger(blLogToFile, blLogToConsole, blLogToDatabase, blLogMessage, blLogWarning, blLogError);
            Assert.AreEqual(CommonEnums.LogResultType.OK.ToString(), JobLogger.LogMessage(objError));
        }
    }
}
