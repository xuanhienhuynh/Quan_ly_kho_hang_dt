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
    public class NhapHangDAO:DataProvider
    {
        public List<NhapHang> GetNhapHangDAO()
        {
            string select = "SELECT * FROM NhapHang";
            string mathung;
            string masp;
            string tensp;
            string soluong;
            string ngaynhap;
            string nguoinhap;

            List<NhapHang> list = new List<NhapHang>();
            connect();
            try
            {
                SqlDataReader sda = layDuLieuTuBang(select);
                while (sda.Read())
                {
                    mathung = sda[0].ToString();
                    masp = sda[1].ToString();
                    tensp = sda[2].ToString();
                    soluong = sda[3].ToString();
                    ngaynhap = sda[4].ToString();
                    nguoinhap = sda[5].ToString();

                    NhapHang item = new NhapHang(mathung, masp, tensp, soluong, ngaynhap, nguoinhap);
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
        public int Them(NhapHang NH)
        {
            string select = "INSERT INTO NhapHang (MaThung, MaSP, TenSP, SoLuong, NgayNhap, NguoiNhap) "
                        + "VALUES('" + NH.MaThung + "','" + NH.MaSP + "','" + NH.TenSP + "','"
                      + NH.SoLuong + "','" + NH.NgayNhap + "','" + NH.NguoiNhap + "');";
            if (NH.MaThung == "" || NH.MaSP == "" || NH.TenSP == "" || NH.SoLuong == "" || NH.NgayNhap == "" ||
                 NH.NguoiNhap == "")
                return 0;
            else
            {
                try
                {
                    return myExcuteNoneQuery(select);
                }
                catch (SqlException ex)
                {
                    throw ex;
                }
            }
        }

        public int ThemLS(NhapHang NH)
        {
            string select = "INSERT INTO LSNhapHang (MaThung, MaSP, TenSP, SoLuong, NgayNhap, NguoiNhap) "
                        + "VALUES('" + NH.MaThung + "','" + NH.MaSP + "','" + NH.TenSP + "','"
                      + NH.SoLuong + "','" + NH.NgayNhap + "','" + NH.NguoiNhap + "');";
            if (NH.MaThung == "" || NH.MaSP == "" || NH.TenSP == "" || NH.SoLuong == "" || NH.NgayNhap == "" ||
                 NH.NguoiNhap == "")
                return 0;
            else
            {
                try
                {
                    return myExcuteNoneQuery(select);
                }
                catch (SqlException ex)
                {
                    throw ex;
                }
            }
            
        }

        public int Xoa(NhapHang NH)
        {
            string delete = "DELETE FROM NhapHang WHERE MaThung = '" + NH.MaThung + "';";
            if (NH.MaThung == "" || NH.MaSP == "" || NH.TenSP == "" || NH.SoLuong == "" || NH.NgayNhap == "" ||
                 NH.NguoiNhap == "")
            {
                return 1;
            }
            else
            {
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
}
