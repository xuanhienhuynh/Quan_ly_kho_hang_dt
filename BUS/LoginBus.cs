using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DAO;
using DTO;
namespace BUS
{
    public class LoginBus
    {
        public bool loginbus(Account acc)
        {
            try
            {

                return new LoginByDAO().login(acc);
            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }
    }
}
