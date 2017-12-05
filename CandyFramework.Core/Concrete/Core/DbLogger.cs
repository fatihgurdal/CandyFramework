using CandyFramework.Core.Interface.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CandyFramework.Core.Enum;
using System.Data.SqlClient;

namespace CandyFramework.Core.Concrete.Core
{
    public class DbLogger : ILogger
    {
        public void WriteLog(CandyLogType type, string detail)
        {
            WriteLog(type, "No Title", detail);
        }

        public void WriteLog(CandyLogType type, string title, string detail)
        {
            var conStr = Common.ConnectionProvider.GetConnectionString();
            using (SqlConnection con = new SqlConnection(conStr))
            {
                var sql = @"INSERT INTO [dbo].[LOGS] ([TYPE] ,[LEVEL] ,[ERROR_MESSAGE] ,[ERROR_DETAIL] ,[INNER_EXCEPTION] ,[CREATE_USER] ,[CREATE_DATE])
                         VALUES (@type,@level,@errorMessage,@errorDetail,@innerExp,@createUser,@createDate)";
                using (SqlCommand com = new SqlCommand(sql, con))
                {

                    com.Parameters.AddWithValue("@type", (int)type);
                    com.Parameters.AddWithValue("@level", 1);
                    com.Parameters.AddWithValue("@errorMessage", title);
                    com.Parameters.AddWithValue("@errorDetail", detail);
                    com.Parameters.AddWithValue("@innerExp", "");
                    var userName = "";
                    if (Common.ConnectionProvider.IsLogon)
                    {
                        userName = Common.ConnectionProvider.LogonUser.UserName;
                    }
                    com.Parameters.AddWithValue("@createUser", userName);
                    com.Parameters.AddWithValue("@createDate", DateTime.Now);
                    con.Open();
                    com.ExecuteNonQuery();
                    con.Close();
                }
            }
        }

        public void WriteLog(string title, Exception exception)
        {
            WriteLog(CandyLogType.Error, title, exception.ToString());
        }
    }
}
