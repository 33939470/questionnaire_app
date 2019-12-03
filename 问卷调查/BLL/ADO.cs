using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 问卷调查.BLL
{
    public static class ADO
    {
        //static string connectionString { get { return ConnectionStringClass.ConnectionString; } set { ConnectionStringClass.ConnectionString = value; } }
        static string connectionString = @"Data Source =.\;Initial Catalog = paper_Questionnaire; User Id = sa; Password=Nsoft123";
        static SqlConnection conn = new SqlConnection(connectionString);

        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="str"></param>
        public static DataTable query(string sql)
        {
            conn.Close();
            SqlDataAdapter dr = new SqlDataAdapter(sql, conn);
            conn.Open();
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            var table = dr.Fill(ds);
            dt = ds.Tables[0];
            conn.Close();
            return dt;
        }


        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="str"></param>
        public static bool update(string sql)
        {
            conn.Close();
            SqlCommand cmd = new SqlCommand();
            conn.CreateCommand();
            cmd.CommandText = sql;
            cmd.Connection = conn;
            conn.Open();
            int updateCount = cmd.ExecuteNonQuery();
            conn.Close();
            if (updateCount > 0)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// 带参数的修改函数入口（比如插入字节数据）
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="bytePram"></param>
        /// <param name="ParametersName"></param>
        /// <param name="sqlType"></param>
        /// <param name="connectionStr"></param>
        /// <returns></returns>
        public static bool updateHaveByte(string sql, byte[] bytePram, string ParametersName, SqlDbType sqlType, string connectionStr)
        {
            conn.Close();
            SqlCommand cmd = new SqlCommand();
            conn.CreateCommand();
            cmd.CommandText = sql;
            cmd.Connection = conn;
            conn.Open();
            cmd.Parameters.Add(ParametersName, sqlType);
            cmd.Parameters[0].Value = bytePram;
            int updateCount = cmd.ExecuteNonQuery();
            conn.Close();
            if (updateCount > 0)
            {
                return true;
            }
            return false;
        }
    }
}
