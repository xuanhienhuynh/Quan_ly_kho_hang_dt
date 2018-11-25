using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CatHang
    {
        public string MaThung { get; set; }
        public string MaKe { get; set; }
        public string MaSP { get; set; }
        public string TenSP{ get; set; }
        public string SoLuong { get; set; }
        public string NgayCat { get; set; }
        public string NguoiCat { get; set; }
        public CatHang(string mathung, string make, string masp, string tensp, string soluong, string ngaycat, string nguoicat)
        {
            this.MaThung = mathung;
            this.MaKe = make;
            this.MaSP = masp;
            this.TenSP = tensp;
            this.SoLuong = soluong;
            this.NgayCat = nguoicat;
            this.NguoiCat = nguoicat;
        }
    }
}
