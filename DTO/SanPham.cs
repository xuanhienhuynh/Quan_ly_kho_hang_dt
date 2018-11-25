using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class SanPham
    {
        public string MaKe { get; set; }
        public string MaSP { get; set; }
        public string TenSP{ get; set; }
        public string SoLuong { get; set; }
        public SanPham(string masp, string tensp, string make, string soluong)
        {
            this.MaSP = masp;
            this.MaKe = make;
            this.TenSP = tensp;
            this.SoLuong = soluong;
        }
    }
}
