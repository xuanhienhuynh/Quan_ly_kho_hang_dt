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
    public class LayHangBUS
    {
        LayHangDAO lhDAO = new LayHangDAO();
        DataTable LayHangTable;
        public List<LayHang> GetLayHang()
        {
            try
            {
                return lhDAO.GetLayHangDAO();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public int themLS(LayHang LH)
        {
            try
            {
                return lhDAO.ThemLS(LH);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public int Xoa(LayHang LH)
        {
            try
            {
                return lhDAO.Xoa(LH);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
    }
}
