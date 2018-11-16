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

// M chịu khó đổi đường dẫn CSDL thành đường dẫn chứa CSDL máy m thì mới chạy được nha

namespace QuanLyKhoHang
{
    public partial class QuanLyKhoHang : Form
    {
        SqlConnection sqlcnn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\cuong\OneDrive\Máy tính\Test3\QuanLyKhoHang\KhoHang.mdf;Integrated Security=True;");
        DataTable productTable, LocationProduct; // khai báo producttable nhằm thêm dữ liệu vào datagridview
        DataSet ds, ds1; 
        public QuanLyKhoHang()
        {
            InitializeComponent();
        }
        private void QuanLyKhoHang_Load(object sender, EventArgs e)
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
            txtNgayCat.Text = today.ToString();

            ds = getProduct();
            productTable = ds.Tables[0];
            dataGridView1.DataSource = productTable;

            ds1 = getLocationProduct();
            LocationProduct = ds1.Tables[0];
            dataGridView2.DataSource = LocationProduct;
        }

        DataSet getProduct()
        {
            ds = new DataSet();
            string sql = "SELECT * FROM NhapHang";
            SqlDataAdapter da = new SqlDataAdapter(sql, sqlcnn);
            int number = da.Fill(ds);
            return ds;
        }

        DataSet getLocationProduct()
        {
            ds1 = new DataSet();
            string sql1 = "SELECT * FROM CatHang";
            SqlDataAdapter da1 = new SqlDataAdapter(sql1, sqlcnn);
            int number = da1.Fill(ds1);
            return ds1;
        }

        private void nhậpVàoKhoHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Show();
        }

        private void sắpXếpHàngHóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Hide();
            
        }

        private void btThem1_Click(object sender, EventArgs e)
        {
            try
            {
                sqlcnn.Open();
                string sq = "select * from NhapHang WHERE MaThung ='" + txtMaThung1.Text + "'";
                SqlCommand kt = new SqlCommand(sq, sqlcnn);
                object o = kt.ExecuteScalar();
                if (o != null)
                    MessageBox.Show("Lỗi trùng khóa chính");
                else if(txtTenSP1.Text == "" || txtMaSP1.Text == "" || txtSL1.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ các ô");
                }
                else
                {
                    String sql1 = "INSERT INTO NhapHang (MaThung, MaSP, TenSP, SoLuong, NgayNhap) "
                        + "VALUES('" + this.txtMaThung1.Text + "','" + this.txtMaSP1.Text + "','" + this.txtTenSP1.Text + "','"
                      + this.txtSL1.Text + "','" + this.txtNgayNhap.Text + "');";
                    SqlCommand sqlcmd = new SqlCommand(sql1, sqlcnn);
                    sqlcmd.ExecuteNonQuery();
                    MessageBox.Show("Thanh cong");

                    dataGridView1.DataSource = productTable;
                    DataRow row = productTable.NewRow();
                    row["MaThung"] = this.txtMaThung1.Text;
                    row["MaSP"] = this.txtMaSP1.Text;
                    row["TenSP"] = this.txtTenSP1.Text;
                    row["SoLuong"] = this.txtSL1.Text;
                    row["NgayNhap"] = this.txtNgayNhap.Text;

                    productTable.Rows.Add(row);
                }
                sqlcnn.Close();
            }
            catch
            {
                MessageBox.Show("Lỗi kết nối");
            }
        }

        private void btHuy1_Click(object sender, EventArgs e)
        {
            this.txtMaThung1.Text = this.txtMaSP1.Text = this.txtTenSP1.Text = this.txtSL1.Text =  "";
        }

        private void btnTimThung_Click(object sender, EventArgs e)
        {
            int rowIndex = -1;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[0].Value.ToString().Trim().Equals(txtMaThung2.Text))
                {
                    rowIndex = row.Index;
                    MessageBox.Show("success");
                    break;
                }
            }
            ds = getProduct();
            txtMaSP2.Text = ds.Tables[0].Rows[rowIndex][1].ToString();
            txtTenSP2.Text = ds.Tables[0].Rows[rowIndex][2].ToString();
            txtSL2.Text = ds.Tables[0].Rows[rowIndex][3].ToString();
        }

        private void btThem2_Click(object sender, EventArgs e)
        {
            try
            {
                sqlcnn.Open();
                if (txtTenSP2.Text == "" || txtMaSP2.Text == "" || txtSL2.Text == "" || txtMaKe.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ các ô");
                }
                else
                {
                    String sql2 = "INSERT INTO CatHang (MaThung, MaKe, MaSP, TenSP, SoLuong, NgayCat) "
                        + "VALUES('" + this.txtMaThung2.Text + "','" + this.txtMaKe.Text + "','" + this.txtMaSP2.Text.Trim() + "','"
                        + this.txtTenSP2.Text + "','" + this.txtSL2.Text + "','" + this.txtNgayCat.Text + "');" ;
                    SqlCommand cmd = new SqlCommand(sql2,sqlcnn);
                    cmd.ExecuteNonQuery();


                    // loi
                    String sql3 = "INSERT INTO SanPham (MaSP, TenSP, MaKe, GhiChu) " + "VALUES('" + this.txtMaSP2.Text + "','" + this.txtTenSP2.Text + "','" + this.txtMaKe.Text + "','" + this.txtMaKe.Text + "');";
                    SqlCommand cmd1 = new SqlCommand(sql3, sqlcnn);
                    cmd1.ExecuteNonQuery(); // loi ngay day
                    MessageBox.Show("Thanh cong");

                    DataRow row = LocationProduct.NewRow();
                    row["MaThung"] = this.txtMaThung2.Text;
                    row["MaKe"] = this.txtMaKe.Text;
                    row["MaSP"] = this.txtMaSP2.Text;
                    row["TenSP"] = this.txtTenSP2.Text;
                    row["SoLuong"] = this.txtSL2.Text;
                    row["NgayCat"] = this.txtNgayCat.Text;

                    LocationProduct.Rows.Add(row);
                }
                sqlcnn.Close();
            }
            catch
            {
                MessageBox.Show("Lỗi Kết Nối");
            }
        }
    }
}
