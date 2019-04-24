using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.InteropServices;

namespace RameshUtilityLibrary.DataRepository
{
    public static class SqlUtility
    {


        private static SqlConnection SetConnection()
        {
            var connection = new SqlConnection("Data Source=Manikanta;Initial Catalog=Sravani_Training;Integrated Security=True");
            connection.Open();
            return connection;
        }

        public static string ExecuteQuery(string storedProcedure, Dictionary<string, SqlParameter> procParameters)
        {
            string output = string.Empty;
            using (var cn = SetConnection())
            {
                // create a SQL command to execute the stored procedure
                using (var cmd = cn.CreateCommand())
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = storedProcedure;
                    // assign parameters passed in to the command
                    foreach (var procParameter in procParameters)
                    {
                        cmd.Parameters.Add(procParameter.Value);
                    }
                    var x = cmd.ExecuteNonQuery();
                    output = x.ToString();
                }
            }
            return output;
        }

        public static DataSet GetData(string storedProcedure, Dictionary<string, SqlParameter> procParameters)
        {
            var data = new DataSet();
            using (var cn = SetConnection())
            {
                // create a SQL command to execute the stored procedure
                using (var cmd = cn.CreateCommand())
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = storedProcedure;
                    // assign parameters passed in to the command
                    foreach (var procParameter in procParameters)
                    {
                        cmd.Parameters.Add(procParameter.Value);
                    }
                    using (var da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(data);
                    }
                }
            }
            return data;
        }

    }
}
