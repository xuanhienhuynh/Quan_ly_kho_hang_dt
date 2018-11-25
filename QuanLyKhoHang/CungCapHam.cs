using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;


namespace QuanLyKhoHang
{

    public class CungCapHam
    {
        public SqlConnection sqlcnn;

        public DataSet getProduct()
        {
            DataSet ds = new DataSet();
            string sql = "SELECT * FROM NhapHang";
            SqlDataAdapter da = new SqlDataAdapter(sql, sqlcnn);
            int number = da.Fill(ds);
            return ds;
        }
        public DataSet getLocationProduct()
        {
            DataSet ds = new DataSet();
            string sql = "SELECT * FROM CatHang";
            SqlDataAdapter da = new SqlDataAdapter(sql, sqlcnn);
            int number = da.Fill(ds);
            return ds;
        }
        public DataSet SapXep()
        {
            DataSet ds = new DataSet();
            string sql = "SELECT * FROM SanPham";
            SqlDataAdapter da = new SqlDataAdapter(sql, sqlcnn);
            int number = da.Fill(ds);
            return ds;
        }
        public DataSet getPick()
        {
            DataSet ds = new DataSet();
            string sql = "SELECT * FROM XuatHang";
            SqlDataAdapter da = new SqlDataAdapter(sql, sqlcnn);
            int number = da.Fill(ds);
            return ds;
        }

<<<<<<< HEAD
        public void INSERTNhapHang(DataTable table, string mathung, string masp, string tensp, string soluong, string ngaynhap, string nguoinhap)
        {
            foreach (DataRow r in table.Rows)
            {
                if (string.Compare(r["MaThung"].ToString(), mathung) == 0)
=======
        public void INSERTNhapHang (DataTable table, string mathung, string masp, string tensp, string soluong, string ngaynhap, string nguoinhap)
        {
            foreach(DataRow r in table.Rows)
            {
                if (string.Compare(r["MaThung"].ToString(),mathung) == 0)
>>>>>>> feature-backend
                {
                    MessageBox.Show("Trùng mã thùng");
                    return;
                }
            }
            DataRow row = table.NewRow();
            row["MaThung"] = mathung;
            row["MaSP"] = masp;
            row["TenSP"] = tensp;
            row["SoLuong"] = soluong;
            row["NgayNhap"] = ngaynhap;
            table.Rows.Add(row);
        }

<<<<<<< HEAD
        public void INSERTCatHang(DataTable table, string mathung, string make, string masp, string tensp, int soluong, string ngaycat)
=======
        public void INSERTCatHang (DataTable table, string mathung, string make, string masp, string tensp, int soluong, string ngaycat)
>>>>>>> feature-backend
        {
            DataRow row = table.NewRow();
            row["MaThung"] = mathung;
            row["MaSP"] = masp;
            row["TenSP"] = tensp;
            row["SoLuong"] = soluong;
            row["NgayNhap"] = ngaycat;
            table.Rows.Add(row);
        }
<<<<<<< HEAD

=======
        
>>>>>>> feature-backend
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

<<<<<<< HEAD

=======
        
>>>>>>> feature-backend
    }
}
