using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LayHang
    {
        public string MaKe { get; set; }
        public string MaSP { get; set; }
        public string TenSP{ get; set; }
        public string SoLuong { get; set; }
        public string NgayLay { get; set; }
        public string NguoiLay { get; set; }
        public LayHang(string make,string masp, string tensp, string soluong, string ngaylay, string nguoilay)
        {
            this.MaKe = make;
            this.MaSP = masp;
            this.TenSP = tensp;
            this.SoLuong = soluong;
            this.NgayLay = ngaylay;
            this.NguoiLay = nguoilay;
        }
    }
}
