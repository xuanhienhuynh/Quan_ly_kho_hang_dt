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
    public class SanPhamBUS
    {
        SanPhamDAO spDAO = new SanPhamDAO();
        DataTable SanPhamTable;
        public List<SanPham> GetSanPham()
        {
            try
            {
                return spDAO.GetSanPhamDAO();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public int them(SanPham SP)
        {
            try
            {
                return spDAO.Them(SP);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public int xoa(SanPham SP)
        {
            try
            {
                return spDAO.Xoa(SP);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public int capnhap(SanPham SP, int total)
        {
            try
            {
                return spDAO.CapNhap(SP, total);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

    }
}
