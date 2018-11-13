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
        SqlConnection sqlcnn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\cuong\OneDrive\Máy tính\Test2\Quan_ly_kho_hang_dt\QuanLyKhoHang\KhoHang.mdf;Integrated Security=True;");
        DataTable productTable, productTable2; // khai báo producttable nhằm thêm dữ liệu vào datagridview
        DataSet ds1; 
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

            DataSet ds = getProduct();

            productTable = ds.Tables[0];
            productTable2 = ds.Tables[0];

            dataGridView1.DataSource = productTable;
            dataGridView2.DataSource = productTable2;
        }

        DataSet getProduct()
        {
            DataSet ds = new DataSet();
            string sql = "SELECT * FROM NhapHang";
            SqlDataAdapter da = new SqlDataAdapter(sql, sqlcnn);
            int number = da.Fill(ds);
            return ds;
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
            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                if (row.Cells[0].Value.ToString().Trim().Equals(txtMaThung2.Text))
                {
                    rowIndex = row.Index;
                    MessageBox.Show("success");
                    break;
                }
            }
            ds1 = getProduct();
            txtMaSP2.Text = ds1.Tables[0].Rows[rowIndex][1].ToString();
            txtTenSP2.Text = ds1.Tables[0].Rows[rowIndex][2].ToString();
            txtSL2.Text = ds1.Tables[0].Rows[rowIndex][3].ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
