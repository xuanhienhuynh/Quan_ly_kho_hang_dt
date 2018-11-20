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
    public partial class QLKhoHang : Form
    {
        //SqlConnection sqlcnn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\Programing\11. Tester (KTPM)\Ql\Quan_ly_kho_hang_dt\QuanLyKhoHang\KhoHang.mdf;Integrated Security=True;");
        SqlConnection sqlcnn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\Programing\11. Tester (KTPM)\Ql\KhoHangCSDL.mdf;Integrated Security=True;");
        DataTable productTable, LocationProduct, sapxep; // khai báo producttable nhằm thêm dữ liệu vào datagridview
        DataSet ds, ds1, ds2;
        public static string strUser;
        CungCapHam cc = new CungCapHam();
        public QLKhoHang()
        {
            
            InitializeComponent();
        }
       
        private void QuanLyKhoHang_Load(object sender, EventArgs e)
        {
            
            this.Hide();
            tabControl1.Hide();
            tabControl2.Hide();
            tabControl3.Hide();
            DangNhap fm = new DangNhap();
            DialogResult result = fm.ShowDialog();
            if (result == DialogResult.OK)
            {
                this.Show();
            }
            else
            {
                Application.Exit();
            }

            lbgetUser.Text = "Xin chào " + strUser;
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

            ds2 = SapXep();
            sapxep = ds2.Tables[0];
            dataGridView3.DataSource = sapxep;

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

        DataSet SapXep()
        {
            ds2 = new DataSet();
            string sql1 = "SELECT * FROM SanPham";
            SqlDataAdapter da2 = new SqlDataAdapter(sql1, sqlcnn);
            int number = da2.Fill(ds2);
            return ds2;
        }

        private void nhapVaoKhoHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //panel1.Show();
            tabControl1.Show();
            tabControl2.Hide();
            tabControl3.Hide();
        }

        private void sapXepToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //panel1.Hide();
            tabControl2.Show();
            tabControl1.Hide();
            tabControl3.Hide();
        }

        private void tonKhoDinhKiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl3.Show();
            tabControl1.Hide();
            tabControl2.Hide();
        }



        //public int ktTrung2(int a)
        //{
        //    string b = "SX0" + a;
        //    string c;
        //    textBox1.Text = "SX0" + a;
        //    sqlcnn.Open();
        //    while (b == textBox1.Text)
        //    {
        //        String kt = "SELECT * FROM NhapHang WHERE MaThung = '" + b + "'";
        //        SqlCommand kt1 = new SqlCommand(kt, sqlcnn);
        //        c = kt1.ExecuteScalar().ToString();
        //        if (b != c) break;
        //        a++;
        //        b = "SX" + a;
        //        textBox1.Text = "SX0" + a;
        //    }
        //    sqlcnn.Close();
        //    return a;
        //}

        private void btThem1_Click(object sender, EventArgs e)
        {
            try
            {
                sqlcnn.Open();
                string sq = "select * from NhapHang WHERE MaThung ='" + txtMaThung1.Text + "'";
                string sq1 = "SELECT * FROM NhapHang WHERE MaSP ='" + txtMaSP1.Text + "'";
                SqlCommand kt1 = new SqlCommand(sq1, sqlcnn);
                SqlCommand kt = new SqlCommand(sq, sqlcnn);
                object o = kt.ExecuteScalar();
                object y = kt1.ExecuteScalar();
                if (cc.ktTrung(o) == true)
                    MessageBox.Show("Mã thùng đã được sử dụng");
                else if (txtTenSP1.Text == "" || txtMaSP1.Text == "" || txtSL1.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ các ô");
                }
                else if (cc.ktTrung(y) == true)
                    MessageBox.Show("Mã sản phẩm bị trùng");
                else
                {
                    txtNgayNhap.Text = (DateTime.Now).ToString();
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
                    this.Refresh();
                }
                sqlcnn.Close();
                this.txtMaThung1.Text = this.txtMaSP1.Text = this.txtTenSP1.Text = this.txtSL1.Text = this.txtNgayNhap.Text = "";
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
                if (row.Cells[0].Value.ToString().Trim().Equals(txtMaThung2.Text.Trim()))
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
                    this.txtNgayCat.Text = (DateTime.Now).ToString();
                    String sql2 = "INSERT INTO CatHang (MaThung, MaKe, MaSP, TenSP, SoLuong, NgayCat) "
                        + "VALUES('" + this.txtMaThung2.Text + "','" + this.txtMaKe.Text + "','" + this.txtMaSP2.Text.Trim() + "','"
                        + this.txtTenSP2.Text + "','" + this.txtSL2.Text + "','" + this.txtNgayCat.Text + "');";
                    SqlCommand cmd = new SqlCommand(sql2, sqlcnn);
                    cmd.ExecuteNonQuery();

                    String sql3 = "INSERT INTO SanPham (MaSP, TenSP, MaKe, SoLuong) " + "VALUES('" + this.txtMaSP2.Text + "','" + this.txtTenSP2.Text + "','" + this.txtMaKe.Text + "','" + this.txtSL2.Text + "');";
                    SqlCommand cmd1 = new SqlCommand(sql3, sqlcnn);
                    cmd1.ExecuteNonQuery();
                    MessageBox.Show("Thanh cong");

                    DataRow row = LocationProduct.NewRow();
                    row["MaThung"] = this.txtMaThung2.Text;
                    row["MaKe"] = this.txtMaKe.Text;
                    row["MaSP"] = this.txtMaSP2.Text;
                    row["TenSP"] = this.txtTenSP2.Text;
                    row["SoLuong"] = this.txtSL2.Text;
                    row["NgayCat"] = this.txtNgayCat.Text;
                    LocationProduct.Rows.Add(row);

                    String delete = "DELETE FROM NhapHang WHERE MaThung = '" + txtMaThung2.Text + "';";
                    SqlCommand deleteCmd = new SqlCommand(delete, sqlcnn);
                    deleteCmd.ExecuteNonQuery();
                    MessageBox.Show("Xóa thành công");
                }
                sqlcnn.Close();

                int rowIndex = -1;
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells[0].Value.ToString().Trim().Equals(txtMaThung2.Text.Trim()))
                    {
                        rowIndex = row.Index;
                        MessageBox.Show("success");
                        break;
                    }
                }

                dataGridView1.Rows.RemoveAt(rowIndex);

                this.txtMaThung2.Text = this.txtMaSP2.Text = this.txtTenSP2.Text = this.txtSL2.Text = this.txtMaKe.Text = "";
            }
            catch
            {
                MessageBox.Show("Lỗi Kết Nối");
            }
        }
        private void btSapXep_Click(object sender, EventArgs e)
        {
            int rowIndex1 = -1;
            int rowIndex2 = -1;
            foreach (DataGridViewRow row in dataGridView3.Rows)
            {
                if (row.Cells[2].Value.ToString().Trim().Equals(txtMaKe3.Text.Trim()))
                {
                    rowIndex1 = row.Index;
                    MessageBox.Show("success");
                    foreach (DataGridViewRow rows in dataGridView3.Rows)
                    {
                        if (rows.Cells[0].Value.ToString().Trim().Equals(txtMaSP3.Text.Trim()))
                        {
                            rowIndex2 = rows.Index;
                            MessageBox.Show("success");
                            if (Convert.ToInt32(this.txtSL3.Text) < Convert.ToInt32(ds2.Tables[0].Rows[rowIndex2][3]))
                            {
                                MessageBox.Show("convert");
                                textBox1.Text = this.txtSL3.Text;
                                textBox2.Text = (ds2.Tables[0].Rows[rowIndex2][3]).ToString();
                                int a = int.Parse(textBox1.Text);
                                int b = int.Parse(textBox2.Text);
                                int total = b - a;
                                try
                                {
                                    sqlcnn.Open();
                                    String update = "UPDATE SanPham SET SoLuong = '" + total.ToString() + "' WHERE MaSP = '" + ((ds2.Tables[0].Rows[rowIndex1][0]).ToString().Trim()) + "';";
                                    SqlCommand updatecmd = new SqlCommand(update, sqlcnn);
                                    updatecmd.ExecuteNonQuery();
                                    MessageBox.Show("Cap nhap thành công");
                                    sqlcnn.Close();
                                }
                                catch
                                { 

                                }
                            }
                            else if (Convert.ToInt32(this.txtSL3.Text) > Convert.ToInt32(ds2.Tables[0].Rows[rowIndex2][3]))
                                MessageBox.Show("Lỗi SP xuất ra lớn hơn SP tồn");
                            else
                            {
                                sqlcnn.Open();                                
                                String insert = "INSERT INTO NhapHang (MaThung, MaSP, TenSP, SoLuong, NgayNhap) "
                        + "VALUES('" + textBox1.Text + "','" + this.txtMaSP3.Text + "','" + this.textBox2.Text + "','" 
                        + this.txtSL3.Text + "','" + textBox2.Text + "');";
                                SqlCommand insertcmd = new SqlCommand(insert, sqlcnn);
                                insertcmd.ExecuteNonQuery();
                                MessageBox.Show("insert thanh cong");

                                String delete = "DELETE FROM SanPham WHERE MaSP = '" + ((ds2.Tables[0].Rows[rowIndex1][0]).ToString().Trim()) + "';";
                                SqlCommand deleteCmd = new SqlCommand(delete, sqlcnn);
                                deleteCmd.ExecuteNonQuery();
                                MessageBox.Show("Xóa thành công");
                                sqlcnn.Close();
                                
                            }
                            break;
                        }
                    }
                    break;
                }
            }
        }
        
    }
}
