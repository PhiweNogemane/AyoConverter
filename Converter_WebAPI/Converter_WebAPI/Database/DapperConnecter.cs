using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Configuration;
using Microsoft.IdentityModel.Protocols;

namespace Converter_WebAPI.Database
{
    public class DapperConnecter
    {
        public static string connStr = $"Data Source=localHost;Initial Catalog=ConverterDB;Integrated Security=True";
        public static void ExecuteWithoutReturn(string procname, DynamicParameters dataParams)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                conn.Execute(procname, dataParams, commandType: CommandType.StoredProcedure);
            }

        }
        public static T ExecuteReturnScalar<T>(string procname, DynamicParameters dataParams)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                List<T> ts = conn.Query<T>(procname, dataParams, commandType: CommandType.StoredProcedure).ToList();
                return (T)Convert.ChangeType(conn.QueryFirst<T>(procname, dataParams, commandType: CommandType.StoredProcedure), typeof(T));
            }
        }
    }
}
