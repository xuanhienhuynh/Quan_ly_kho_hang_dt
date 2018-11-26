using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAO
{
    public class LoginByDAO:DataProvider
    {
        //public bool login(Account acc)
        //{
        //    string cmdSql = "SELECT COUNT(TaiKhoan) FROM NguoiDung WHERE TaiKhoan = '" + acc.UserName + "' AND MatKhau = '" + acc.Password + "'";
        //    int number;
        //    try
        //    {
        //        number = myExecuteScalar(cmdSql);
        //    }
        //    catch (SqlException ex)
        //    {

        //        throw ex;
        //    }
        //    if (number > 0)
        //        return true;
        //    else
        //        return false;
        //}
        public bool login(Account acc)
        {
            string cmdSql = "SELECT TaiKhoan FROM NguoiDung WHERE TaiKhoan = '" + acc.UserName + "' AND MatKhau = '" + acc.Password + "'";
            string cmdSql1 = "SELECT MatKhau FROM NguoiDung WHERE TaiKhoan = '" + acc.UserName + "' AND MatKhau = '" + acc.Password + "'";
            string x, y;
            int number = 0, a, b;
            try
            {
                x = myExecuteScalar1(cmdSql);
                y = myExecuteScalar1(cmdSql1);
            }
            catch (SqlException ex)
            {

                throw ex;
            }
            if (x == acc.UserName && y == acc.Password)
                return true;
            else return false;
        }

        public bool loginType (Account acc)
        {
            string cmdSql = "SELECT Loai FROM NguoiDung WHERE TaiKhoan = '" + acc.UserName + "'";
            int number;
            try
            {
                number = myExecuteScalar(cmdSql);
            }
            catch (SqlException ex)
            {

                throw ex;
            }
            if (number > 0)
                return true;
            else
                return false;
        }
    }
}
