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
    public class NhapHangBUS
    {
        NhapHangDAO nhDAO = new NhapHangDAO();
        DataTable NhapHangTable;
        public List<NhapHang> GetNhapHang()
        {
            try
            {
                return nhDAO.GetNhapHangDAO();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public int them(NhapHang NH)
        {
            try
            {
                return nhDAO.Them(NH);
            }
            catch(SqlException ex)
            {
                throw ex;
            }
        }

        public int themLS(NhapHang NH)
        {
            try
            {
                return nhDAO.ThemLS(NH);
                
            }
            catch(SqlException ex)
            {
                throw ex;
            }
        }

    }
}
