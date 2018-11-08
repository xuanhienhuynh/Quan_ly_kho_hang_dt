using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

/*m sửa chỗ nào thì đóng băng lại chứ đừng xóa nha*/
/*m đóng băng đường dẫn SQL của t lại rồi sửa lại đường dẫn của m mới chạy đc nha*/

namespace QuanLyKhoHang
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void Form1_Load(object sender, EventArgs e)
        {

        }
       

        private void btn_signin_Click_1(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\source 2013\QuanLyKhoHang\QuanLyKhoHang\App_Data\Kho (1).mdf;Integrated Security=True;");
            try
            {
                cnn.Open();
                String tk = txt_username.Text;
                String mk = txt_password.Text;
                String sql = "SELECT * FROM NguoiDung WHERE TaiKhoan = '" + tk + "' AND MatKhau = '" + mk + "'";
                SqlCommand cmd = new SqlCommand(sql, cnn);
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
                cnn.Close();
            }
            catch
            {
                MessageBox.Show("Lỗi kết nối");
            }
        }

    }
}
