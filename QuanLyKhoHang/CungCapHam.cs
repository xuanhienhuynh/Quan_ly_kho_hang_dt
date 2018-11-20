using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace QuanLyKhoHang
{
    
    public class CungCapHam
    {
        
        public bool KetNoi(SqlConnection cnn)
        {
            try 
            {
                cnn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\cuong\OneDrive\Máy tính\Quan_ly_kho_hang_dt1\Quan_ly_kho_hang_dt\Quan_ly_kho_hang_dt\QuanLyKhoHang\KhoHangCSDL.mdf;Integrated Security=True;");
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool KT_TaiKhoan_Rong(string tk, string mk)
        {
            if (string.IsNullOrEmpty(tk) || string.IsNullOrWhiteSpace(tk) && string.IsNullOrEmpty(mk) || string.IsNullOrWhiteSpace(mk))
                return false;
            else
                return true;
        }
        public bool ktTrung(object a)
        {
            if (a != null)
                return true;
            else
                return false;
        }

        public DateTime day(DateTime d)
        {
            return DateTime.Now;
        }
    }
}
