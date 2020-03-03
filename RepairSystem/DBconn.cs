/**
*┌──────────────────────────────────────────────────────────────┐
*│　描   述：数据库连接                                                    
*│　作   者：LiJian                                             
*│　版   本：1.0                                                 
*│　创建时间：19/12/26 10:15:22                             
*└──────────────────────────────────────────────────────────────┘
*┌──────────────────────────────────────────────────────────────┐
*│　命名空间: RepairSystem                                   
*│　类   名：DBconn                                      
*└──────────────────────────────────────────────────────────────┘
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace RepairSystem
{
    class DBconn
    {
        // 声明一个用于连接数据库的字符串
        public static string ConnStr = "server=.;database=RepairSystem;Trusted_Connection=SSPI";
        public static SqlConnection conn = new SqlConnection(ConnStr);

        // 读取数据
        public static DataSet getData(string sqlStr)
        {
            conn.Open();
            SqlDataAdapter sda = new SqlDataAdapter(sqlStr, conn);
            DataSet ds = new DataSet();
            ds.Clear();
            sda.Fill(ds);
            conn.Close();
            return ds;
        }

        // 更新数据
        public static DataSet upData(string sqlStr)
        {
            try
            {
                conn.Open();
                SqlCommand comm = new SqlCommand(sqlStr, conn);
                comm.CommandType = CommandType.Text;
                // 执行sql
                comm.ExecuteNonQuery();
                conn.Close();
            }
            catch
            {
                conn.Close();
            }

            return null;
        }

        //判断是否更新记录
        public static bool PDData(string sqlStr)
        {
            try
            {
                conn.Open();
                SqlCommand comm = new SqlCommand(sqlStr, conn);
                comm.CommandType = CommandType.Text;
                //执行sql语句
                comm.ExecuteNonQuery();
                conn.Close();
                return true;
            }
            catch
            {
                conn.Close();
                return false;
            }
        }
    }
}
