using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhapHang
    {
        public string MaThung { get; set; }
        public string MaSP { get; set; }
        public string TenSP{ get; set; }
        public string SoLuong { get; set; }
        public string NgayNhap { get; set; }
        public string NguoiNhap { get; set; }
        public NhapHang(string mathung,string masp, string tensp, string soluong, string ngaynhap, string nguoinhap)
        {
            this.MaThung = mathung;
            this.MaSP = masp;
            this.TenSP = tensp;
            this.SoLuong = soluong;
            this.NgayNhap = ngaynhap;
            this.NguoiNhap = nguoinhap;
        }
    }
}
