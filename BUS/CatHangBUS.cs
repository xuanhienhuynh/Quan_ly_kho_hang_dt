using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DAO;
using DTO;

namespace BUS
{
    public class CatHangBUS
    {
        CatHangDAO chDAO = new CatHangDAO();
        DataTable CatHangTable;
        public List<CatHang> GetCatHang()
        {
            try
            {
                return chDAO.GetCatHangDAO();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public int them(CatHang CH)
        {
            try
            {
                return chDAO.Them(CH);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public int themLS(CatHang CH)
        {
            try
            {
                return chDAO.ThemLS(CH);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
    }
}
