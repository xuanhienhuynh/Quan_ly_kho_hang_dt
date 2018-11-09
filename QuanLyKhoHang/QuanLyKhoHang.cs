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


namespace QuanLyKhoHang
{
    public partial class QuanLyKhoHang : Form
    {
        SqlConnection sqlcnn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|Kho (1).mdf;Integrated Security=True;");
        DataTable productTable; // khai báo producttable nhằm thêm dữ liệu vào datagridview
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
            dataGridView1.DataSource = productTable;
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


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
                String sql1 = "INSERT INTO NhapHang (MaThung, MaSP, TenSP, SoLuong, NgayNhap) "
                    + "VALUES('" + this.txtMaThung1.Text + "','" + this.txtMaSP1.Text + "','" + this.txtTenSP1.Text + "','"
                  + this.txtSL1.Text + "','" + this.txtNgayNhap.Text + "');";
                SqlCommand sqlcmd = new SqlCommand(sql1, sqlcnn);
                sqlcmd.ExecuteNonQuery();

                MessageBox.Show("Thanh cong");

                sqlcnn.Close();
                /*Chỗ này t vẫn chưa thêm được vào datagridview, có gì biết làm dùm*/

                dataGridView1.DataSource = productTable;
                DataRow row = productTable.NewRow();
                row["MaThung"] = this.txtMaThung1.Text;
                row["MaSP"] = this.txtMaSP1.Text;
                row["TenSP"] = this.txtTenSP1.Text;
                row["SoLuong"] = this.txtSL1.Text;
                row["NgayNhap"] = this.txtNgayNhap.Text;

                productTable.Rows.Add(row);

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


        



    }
}
