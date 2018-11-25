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
    public class SanPhamDAO:DataProvider
    {
        public List<SanPham> GetSanPhamDAO()
        {
            string select = "SELECT * FROM SanPham";
            string masp;
            string tensp;
            string make;
            string soluong;

            List<SanPham> list = new List<SanPham>();
            connect();
            try
            {
                SqlDataReader sda = layDuLieuTuBang(select);
                while (sda.Read())
                {
                    masp = sda[0].ToString();
                    tensp = sda[1].ToString();
                    make = sda[2].ToString();
                    soluong = sda[3].ToString();

                    SanPham item = new SanPham(masp, tensp, make, soluong);
                    list.Add(item);
                }
                sda.Close();
                return list;
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
        public int Them(SanPham SP)
        {
            string select = "INSERT INTO SanPham (MaSP, TenSP, MaKe, SoLuong) "
                        + "VALUES('" + SP.MaSP + "','" + SP.TenSP + "','" 
                      + SP.MaKe + "','" + SP.SoLuong + "');";
            try
            {
                return myExcuteNoneQuery(select);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public int Xoa(SanPham SP)
        {
            string delete = "DELETE FROM SanPham WHERE MaSP = '" + SP.MaSP + "';";
            try
            {
                return myExcuteNoneQuery(delete);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public int CapNhap(SanPham SP, int total)
        {
            string update = "UPDATE SanPham SET SoLuong = '" + total.ToString() + "' WHERE MaSP = '" + SP.MaSP + "';";
            try
            {
                return myExcuteNoneQuery(update);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
    }
}
