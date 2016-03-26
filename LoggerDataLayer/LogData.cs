using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using LoggerCommon;

namespace LoggerDataLayer
{
    public class LogData
    {
        public void SaveLog(string strMessage, int intMessageId)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"].ToString()))
                {
                    using (SqlCommand command = new SqlCommand("SP_SAVE_LOG", connection))
                    {                    
                        connection.Open();
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add(new SqlParameter("@MESSAGE", strMessage));
                        command.Parameters.Add(new SqlParameter("@MESSAGE_ID", intMessageId));
                        command.ExecuteNonQuery();
                    }                             
                }
            }
            catch (Exception e)
            {
                throw new Exception(CommonEnums.LogResultType.DatabaseLogError.ToString(), e);
            }
        }
    }
}
