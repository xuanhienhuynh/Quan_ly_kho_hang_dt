using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhoHang
{
    public abstract class QLKH
    {
        public string MaSP { get; set; }
        public string TenSP{ get; set; }
        public string SoLuong { get; set; }
        public string NgayNhap { get; set; }
        public string MaKe { get; set; }
        public string  MaThung { get; set; }
        public QLKH()
        {

        }

        public QLKH(string mathung,string masp, string make, string tensp, string soluong, string ngaynhap)
        {
            this.MaThung = mathung;
            this.MaSP = masp;
            this.MaKe = make;
            this.TenSP = tensp;
            this.SoLuong = soluong;
            this.NgayNhap = ngaynhap;
        }
    }
    
}
