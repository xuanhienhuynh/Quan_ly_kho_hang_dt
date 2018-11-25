using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace DAO
{
    public class DataProvider
    {
        SqlConnection sqlcnn;
        //public dataProvider()
        //{
        //    string cnSql = "server = .; database = CoffeeShop; integrated security = true;";
        //    sqlcnn = new SqlConnection(cnSql);
        //}

        public DataProvider()
        {
            string cnn = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\Programing\11. Tester (KTPM)\Ql\KhoHangCSDL.mdf;Integrated Security=True;";
            sqlcnn = new SqlConnection(cnn);
        }

        public void connect()
        {
            if (sqlcnn != null && sqlcnn.State == ConnectionState.Closed)
            {
                try
                {
                    sqlcnn.Open();
                }
                catch (SqlException ex)
                {

                    throw ex;
                }
            }  
        }

        public void disConnect()
        {
            if (sqlcnn != null && sqlcnn.State == ConnectionState.Open)
                sqlcnn.Close();
        }

        public int myExecuteScalar(string sql)
        {
            connect();
            
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = sqlcnn;
            cmd.CommandText = sql;
            cmd.CommandType = CommandType.Text;
            try
            {
                int number = (int)cmd.ExecuteScalar();
                return number;
                
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                disConnect();
            }
        }

        public SqlDataReader layDuLieuTuBang(string sql)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = sqlcnn;
            cmd.CommandText = sql;
            cmd.CommandType = CommandType.Text;
            try
            {
                return (cmd.ExecuteReader());
            }
            catch (SqlException ex)
            {
                
                throw ex;
            }
        }


        public int myExcuteNoneQuery(string sql)
        {
            SqlCommand cmd = new SqlCommand(sql,sqlcnn);
            cmd.CommandType = CommandType.Text;
            connect();
            try
            {
                return cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                
                throw ex;
            }
            finally
            {
                disConnect();
            }
        }

        
    }
}
