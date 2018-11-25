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
    public class CatHangDAO:DataProvider
    {
        public List<CatHang> GetCatHangDAO()
        {
            string select = "SELECT * FROM CatHang";
            string mathung;
            string make;
            string masp;
            string tensp;
            string soluong;
            string ngaycat;
            string nguoicat;

            List<CatHang> list = new List<CatHang>();
            connect();
            try
            {
                SqlDataReader sda = layDuLieuTuBang(select);
                while (sda.Read())
                {
                    mathung = sda[0].ToString();  
                    make = sda[1].ToString();
                    masp = sda[2].ToString();
                    tensp = sda[3].ToString();
                    soluong = sda[4].ToString();
                    ngaycat = sda[5].ToString();
                    nguoicat = sda[6].ToString();

                    CatHang item = new CatHang(mathung, make, masp, tensp, soluong, ngaycat, nguoicat);
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

        public int Them(CatHang CH)
        {
            string select = "INSERT INTO CatHang (MaThung, MaKe, MaSP, TenSP, SoLuong, NgayCat, NguoiCat) "
                        + "VALUES('" + CH.MaThung + "','" + CH.MaKe + "','" + CH.MaSP + "','" + CH.TenSP + "','"
                      + CH.SoLuong + "','" + CH.NgayCat + "','" + CH.NgayCat + "');";
            try
            {
                return myExcuteNoneQuery(select);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public int ThemLS(CatHang CH)
        {
            string select = "INSERT INTO LSCatHang (MaThung, MaKe, MaSP, TenSP, SoLuong, NgayCat, NguoiCat) "
                        + "VALUES('" + CH.MaThung + "','" + CH.MaKe + "','" + CH.MaSP + "','" + CH.TenSP + "','"
                      + CH.SoLuong + "','" + CH.NgayCat + "','" + CH.NgayCat + "');";
            try
            {
                return myExcuteNoneQuery(select);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public int Xoa(CatHang CH)
        {
            string delete = "DELETE FROM NhapHang WHERE MaThung = '" + CH.MaThung + "';";
            try
            {
                return myExcuteNoneQuery(delete);
            }
            catch (SqlException ex)
            {
                throw ex;
            }

        }
    }
}
