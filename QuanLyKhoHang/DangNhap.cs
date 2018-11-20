using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
/*m sửa chỗ nào thì đóng băng lại chứ đừng xóa nha*/
/*m đóng băng đường dẫn SQL của t lại rồi sửa lại đường dẫn của m mới chạy đc nha*/

namespace QuanLyKhoHang
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        

        public void Form1_Load(object sender, EventArgs e)
        {
        }

        public void ktRong(String a, String b)
        {
 
        }


        private void btn_signin_Click_1(object sender, EventArgs e)
        {
            SqlConnection sqlcnn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\Programing\11. Tester (KTPM)\Ql\KhoHangCSDL.mdf;Integrated Security=True;");
            //SqlConnection cnn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\cuong\OneDrive\Máy tính\Test3\QuanLyKhoHang\KhoHang.mdf;Integrated Security=True;");
            //Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\cuong\OneDrive\Máy tính\Test2\Quan_ly_kho_hang_dt\QuanLyKhoHang\KhoHang.mdf;Integrated Security=True;
            try
            {
                sqlcnn.Open();
                String tk = txt_username.Text;
                String mk = txt_password.Text;
                QLKhoHang.strUser = txt_username.Text;
                String sql = "SELECT * FROM NguoiDung WHERE TaiKhoan = '" + tk + "' AND MatKhau = '" + mk + "'";
                SqlCommand cmd = new SqlCommand(sql, sqlcnn);
                SqlDataReader data = cmd.ExecuteReader();
                if (data.Read() == true)
                {
                    MessageBox.Show("Success");
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Đăng nhập thất bại, thử lại!!!", "Đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_username.Text = txt_password.Text = "";
                    txt_username.Focus();
                }
                sqlcnn.Close();
            }
            catch
            {
                MessageBox.Show("Lỗi kết nối");
            }
        }

    }
}
