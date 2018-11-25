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
    public class LayHangDAO : DataProvider
    {
        public List<LayHang> GetLayHangDAO()
        {
            string select = "SELECT * FROM XuatHang";
            string make;
            string masp;
            string tensp;
            string soluong;
            string ngaylay;
            string nguoilay;

            List<LayHang> list = new List<LayHang>();
            connect();
            try
            {
                SqlDataReader sda = layDuLieuTuBang(select);
                while (sda.Read())
                {
                    make = sda[0].ToString();
                    masp = sda[1].ToString();
                    tensp = sda[2].ToString();
                    soluong = sda[3].ToString();
                    ngaylay = sda[4].ToString();
                    nguoilay = sda[5].ToString();

                    LayHang item = new LayHang(make, masp, tensp, soluong, ngaylay, nguoilay);
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

        public int ThemLS(LayHang LH)
        {
            string select = "INSERT INTO LSXuatHang (MaKe, MaSP, TenSP, SoLuong, NgayLay, NguoiLay) "
                        + "VALUES('" + LH.MaKe + "','" + LH.MaSP + "','" + LH.TenSP + "','"
                      + LH.SoLuong + "','" + LH.NgayLay + "','" + LH.NguoiLay + "');";
            try
            {
                return myExcuteNoneQuery(select);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public int Xoa(LayHang LH)
        {
            string delete = "DELETE FROM SanPham WHERE MaSP = '" + LH.MaSP + "';";
            try
            {
                return myExcuteNoneQuery(delete);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public int LaySL(LayHang LH, string a)
        {
            string laysl = "SELECT SoLuong FROM SanPham WHERE MaSP = '" + LH.SoLuong + "';";
            try
            {
                a = myExecuteScalar(laysl).ToString();
                return int.Parse(a);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
    }
}
