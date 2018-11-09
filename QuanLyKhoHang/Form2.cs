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


namespace QuanLyKhoHang
{
    public partial class Form2 : Form
    {
        DataTable productTable; // khai báo producttable nhằm thêm dữ liệu vào datagridview
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.Hide();
            panel1.Hide();
            Form1 fm = new Form1();
            DialogResult result = fm.ShowDialog();
            if (result == DialogResult.OK)
            {
                this.Show();
            }
            else
            {
                Application.Exit();
            }

            this.WindowState = FormWindowState.Maximized;
            DateTime today = DateTime.Today;
            txtNgayNhap.Text = today.ToString();
            
        }

        private void kiêmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //SqlConnection sqlcnn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\Programing\11. Tester (KTPM)\Ql\Quan_ly_kho_hang_dt\QuanLyKhoHang\Kho (1).mdf;Integrated Security=True;");
            SqlConnection sqlcnn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|Kho (1).mdf;Integrated Security=True;");
            try
            {
                sqlcnn.Open();
                String sql1 = "INSERT INTO NhapHang (MaThung, MaSP, TenSP, SoLuong, NgayNhap) "
                    + "VALUES('" + this.txtMaThung.Text + "','" + this.txtMaSP.Text + "','" + this.txtTenSP.Text + "','"
                  + this.txtSoLuong.Text + "','" + this.txtNgayNhap.Text + "');";
                SqlCommand sqlcmd = new SqlCommand(sql1, sqlcnn);
                sqlcmd.ExecuteNonQuery();

                MessageBox.Show("Thanh cong");
               
                sqlcnn.Close();
                /*Chỗ này t vẫn chưa thêm được vào datagridview, có gì biết làm dùm*/
                dataGridView1.DataSource = productTable;
                DataRow row = productTable.NewRow();
                row["MaThung"] = this.txtMaThung.Text;
                row["MaSP"] = this.txtMaSP.Text;
                row["TenSP"] = this.txtTenSP.Text;
                row["SoLuong"] = this.txtSoLuong.Text;
                row["NgayNhap"] = this.txtNgayNhap.Text;

                productTable.Rows.Add(row);
                
            }
            catch
            {
                MessageBox.Show("Lỗi kết nối");
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        } 



    }
}
