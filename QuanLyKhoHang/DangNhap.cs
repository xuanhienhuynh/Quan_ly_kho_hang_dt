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
using DTO;
using BUS;
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
        LoginBus lgBUS;
        public void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'khoHangCSDLDataSet.NguoiDung' table. You can move, or remove it, as needed.
            this.nguoiDungTableAdapter.Fill(this.khoHangCSDLDataSet.NguoiDung);
            lgBUS = new LoginBus();
        }
        private void btn_signin_Click_1(object sender, EventArgs e)
        {
            string name = txt_username.Text, pass = txt_password.Text;
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(pass))
            {
                MessageBox.Show("ban phai nhap day du thong tin ", "chua nhap thong tin", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                QLKhoHang.strUser = txt_username.Text;
                //if (txtUseName.Text == "admin" && txtPassWord.Text == "123")\
                //if (name == "admin" && pass == "123")
                bool b = false;
                try
                {
                    Account acc = new Account(name, pass);
                    b = lgBUS.loginbus(acc);
                }
                catch (SqlException ex)
                {

                    MessageBox.Show("may ngu qua \n" + ex.Message);
                }
                if (b) // 
                {
                    
                    this.DialogResult = DialogResult.Yes; // dong lenh nay dung de gan gia tri ok vo form 2
                    this.Close();
                    // neu nhap dung mat khau thi form 2 se co gia tri dialog la ok, form 1 se xet gia tri
                    // neu bang ok thi tat form 2, mo form 1 , va enable cac gia tri ca form 1
                }
                else
                {
                    DialogResult result = MessageBox.Show("ban nhap sai tai khoan hoac mat khau !", "wrong", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    if (result == DialogResult.Cancel)
                        Application.Exit();
                }
            }
        }
    }
}
