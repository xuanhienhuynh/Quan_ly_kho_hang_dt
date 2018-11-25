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
        public bool login(Account acc)
        {
            string cmdSql = "SELECT COUNT(TaiKhoan) FROM NguoiDung WHERE TaiKhoan = '" + acc.UserName + "' AND MatKhau = '" + acc.Password + "'";
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
