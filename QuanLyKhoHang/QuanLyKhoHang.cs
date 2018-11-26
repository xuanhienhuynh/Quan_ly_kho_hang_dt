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
using BUS;
using DTO;
using DAO;
// Hi hien
// M chịu khó đổi đường dẫn CSDL thành đường dẫn chứa CSDL máy m thì mới chạy được nha

namespace QuanLyKhoHang
{
    public partial class QLKhoHang : Form
    {
        SqlConnection sqlcnn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\Programing\11. Tester (KTPM)\Ql\KhoHang25.mdf;Integrated Security=True;");
        DataTable productTable, CHTable, SPTable, LHTable; // khai báo producttable nhằm thêm dữ liệu vào datagridview
        DataSet ds;
        public static string strUser;
        public static string intLoai;
        CungCapHam cc = new CungCapHam();
        DangNhap fm;
        DialogResult result;
        DataProvider dapro = new DataProvider();
        public QLKhoHang()
        {

            InitializeComponent();
        }


        private void QuanLyKhoHang_Load(object sender, EventArgs e)
        {
            this.Refresh();
            this.txtNgayNhap.Text = this.txtNgayCat.Text = (DateTime.Now).ToString();
            if (cc.KetNoi(sqlcnn) == true)
            {
                this.Hide();
                tabControl1.Hide();
                tabControl2.Hide();
                tabControl3.Hide();
                tabControl4.Hide();
                tabControlHistory.Hide();
                this.tabControl6.Hide();
                label11.Hide();
                tabControl5.Hide();
                fm = new DangNhap();
                result = fm.ShowDialog();
                if (result == DialogResult.Yes)
                {
                    this.Show();
                }
                else
                {
                    this.Hide();
                }

                label11.Text = intLoai;
                lbgetUser.Text =strUser;
                this.WindowState = FormWindowState.Maximized;
                DateTime today = DateTime.Today;
                txtNgayNhap.Text = today.ToString();
                txtNgayCat.Text = today.ToString();

                ds = getNhapHang();
                productTable = ds.Tables[0];
                dataGridView1.DataSource = productTable;
                dataGridViewInPut.DataSource = productTable;
                dataGridView8.DataSource = productTable;

                ds = getCatHang();
                CHTable = ds.Tables[0];
                dataGridView2.DataSource = CHTable;
                dataGridView6.DataSource = CHTable;
                //ds1 = getLocationProduct();
                //LocationProduct = ds1.Tables[0];
                //dataGridView2.DataSource = LocationProduct;
                //dataGridView6.DataSource = LocationProduct;

                ds = getSanPham();
                SPTable = ds.Tables[0];
                dataGridView3.DataSource = SPTable;
                dataGridView4.DataSource = SPTable;
                dataGridView5.DataSource = SPTable;
                dataGridView10.DataSource = SPTable;
                //ds2 = SapXep();
                //sapxep = ds2.Tables[0];
                //dataGridView3.DataSource = sapxep;
                //dataGridView4.DataSource = sapxep;
                //dataGridView5.DataSource = sapxep;

                ds = getLayHang();
                LHTable = ds.Tables[0];
                dataGridView7.DataSource = LHTable;
                dataGridView9.DataSource = LHTable;
                //dataGridView7.DataSource = pick;
                
            }
            else
            {
                MessageBox.Show("Chưa kết nối với CSDL");
            }

        }

        DataSet getNhapHang()
        {
            ds = new DataSet();
            string sql = "SELECT * FROM NhapHang";
            SqlDataAdapter da = new SqlDataAdapter(sql, sqlcnn);
            int number = da.Fill(ds);
            return ds;
        }

        DataSet getCatHang()
        {
            ds = new DataSet();
            string sql = "SELECT * FROM CatHang";
            SqlDataAdapter da = new SqlDataAdapter(sql, sqlcnn);
            int number = da.Fill(ds);
            return ds;
        }

        DataSet getSanPham()
        {
            ds = new DataSet();
            string sql = "SELECT * FROM SanPham";
            SqlDataAdapter da = new SqlDataAdapter(sql, sqlcnn);
            int number = da.Fill(ds);
            return ds;
        }

        DataSet getLayHang()
        {
            ds = new DataSet();
            string sql = "SELECT * FROM XuatHang";
            SqlDataAdapter da = new SqlDataAdapter(sql, sqlcnn);
            int number = da.Fill(ds);
            return ds;
        }
        private void btThem1_Click(object sender, EventArgs e)
        {
            sqlcnn.Open();
            object x, y;
            string select = "SELECT * FROM NhapHang WHERE MaThung = '" + this.txtMaThung1.Text + "';";
            string select1 = "SELECT * FROM NhapHang WHERE MaSP = '" + this.txtMaSP1.Text + "';";
            SqlCommand cmd = new SqlCommand(select, sqlcnn);
            SqlCommand cmd1 = new SqlCommand(select1, sqlcnn);
            x = cmd.ExecuteScalar();
            y = cmd1.ExecuteScalar();
            if (x != null)
                MessageBox.Show("Mã Thùng bị trùng");
            else if (y != null)
                MessageBox.Show("Mã SP bị trùng");
            else
            {
                string mathung = this.txtMaThung1.Text;
                string masp = this.txtMaSP1.Text;
                string tensp = this.txtTenSP1.Text;
                string soluong = this.txtSL1.Text;
                string ngaynhap = this.txtNgayNhap.Text;
                string nguoinhap = this.lbgetUser.Text;
                if(mathung == "" || masp == "" || tensp == "" || soluong == "" || ngaynhap == "" || nguoinhap == "")
                {
                    MessageBox.Show("Vui Lòng Nhập đầy đủ Các Ô");
                }
                NhapHang NH = new NhapHang(mathung, masp, tensp, soluong, ngaynhap, nguoinhap);
                int SoDong = new NhapHangBUS().them(NH);
                SoDong = new NhapHangBUS().themLS(NH);
                MessageBox.Show("success");
                loadData();
                this.txtMaThung1.Text = this.txtMaSP1.Text = this.txtTenSP1.Text = this.txtSL1.Text = this.txtNgayNhap.Text = "";
                this.txtMaThung1.Focus();
            }
            sqlcnn.Close();
            loadData();
        }

        private void btHuy1_Click(object sender, EventArgs e)
        {
            this.txtMaThung1.Text = this.txtMaSP1.Text = this.txtTenSP1.Text = this.txtSL1.Text = "";
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
            ds = getNhapHang();
            txtMaSP2.Text = ds.Tables[0].Rows[rowIndex][1].ToString();
            txtTenSP2.Text = ds.Tables[0].Rows[rowIndex][2].ToString();
            txtSL2.Text = ds.Tables[0].Rows[rowIndex][3].ToString();
        }

        private void btThem2_Click(object sender, EventArgs e)
        {
            string mathung = this.txtMaThung2.Text;
            string make = this.txtMaKe.Text;
            string masp = this.txtMaSP2.Text;
            string tensp = this.txtTenSP2.Text;
            string soluong = this.txtSL2.Text;
            string ngaycat = (DateTime.Now).ToString();
            string nguoicat = this.lbgetUser.Text;
            if (mathung == "" || masp == "" || tensp == "" || soluong == "" || ngaycat == "" || nguoicat == "" || make == "")
            {
                MessageBox.Show("Vui Lòng Nhập đầy đủ Các Ô");
            }
            NhapHang NH = new NhapHang(mathung, masp, tensp, soluong, ngaycat, nguoicat);
            CatHang CH = new CatHang(mathung, make, masp, tensp, soluong, ngaycat, nguoicat);
            SanPham SP = new SanPham(masp, tensp, make, soluong);
            int SoDong = new CatHangDAO().Them(CH);
            SoDong = new CatHangDAO().ThemLS(CH);
            SoDong = new SanPhamDAO().Them(SP);
            SoDong = new NhapHangDAO().Xoa(NH);
            MessageBox.Show("success");
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
            loadData();
            this.txtMaThung2.Text = this.txtMaSP2.Text = this.txtTenSP2.Text = this.txtSL2.Text = this.txtNgayCat.Text = this.txtMaKe.Text = "";
            this.txtMaThung2.Focus();
            loadData();
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
                            if (Convert.ToInt32(this.txtSL3.Text) < Convert.ToInt32(ds.Tables[0].Rows[rowIndex2][3]))
                            {
                                MessageBox.Show("convert");
                                textBox1.Text = this.txtSL3.Text;
                                textBox2.Text = (ds.Tables[0].Rows[rowIndex2][3]).ToString();
                                int a = int.Parse(textBox1.Text);
                                int b = int.Parse(textBox2.Text);
                                int total = b - a;
                                string mathung = this.txtMaThung3.Text;
                                string masp = this.txtMaSP3.Text;
                                string tensp = this.txtTenSP3.Text;
                                string make = this.txtMaKe3.Text;
                                string soluong = a.ToString();
                                string ngaylay = (DateTime.Now).ToString();
                                string nguoilay = lbgetUser.Text;
                                SanPham SP = new SanPham(masp, tensp, make, soluong);
                                NhapHang NH = new NhapHang(mathung, masp, tensp, soluong, ngaylay, nguoilay);
                                int SoDong = new SanPhamDAO().CapNhap(SP, total);
                                SoDong = new NhapHangDAO().Them(NH);
                                SoDong = new NhapHangDAO().ThemLS(NH);
                                MessageBox.Show("Cap nhap thành công");
                                loadData();
                            }
                            else if (Convert.ToInt32(this.txtSL3.Text) > Convert.ToInt32(ds.Tables[0].Rows[rowIndex2][3]))
                                MessageBox.Show("Lỗi SP xuất ra lớn hơn SP tồn");
                            else
                            {
                                string mathung = this.txtMaThung3.Text;
                                string masp = this.txtMaSP3.Text;
                                string tensp = this.txtTenSP3.Text;
                                string make = this.txtMaKe3.Text;
                                string soluong = this.txtSL3.Text;
                                string ngaylay = (DateTime.Now).ToString();
                                string nguoilay = lbgetUser.Text;
                                NhapHang NH = new NhapHang(mathung, masp, tensp, soluong, ngaylay, nguoilay);
                                SanPham SP = new SanPham(masp, tensp, make, soluong);
                                int SoDong = new NhapHangDAO().Them(NH);
                                SoDong = new NhapHangDAO().ThemLS(NH);
                                SoDong = new SanPhamDAO().Xoa(SP);
                            }
                            break;
                        }
                    }
                    break;
                }
            }
            loadData();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            fm = new DangNhap();
            result = fm.ShowDialog();
            this.Refresh();
            this.txtNgayNhap.Text = this.txtNgayCat.Text = (DateTime.Now).ToString();
            if (cc.KetNoi(sqlcnn) == true)
            {
                this.Hide();
                tabControl1.Hide();
                tabControl2.Hide();
                tabControl3.Hide();
                tabControl4.Hide();
                tabControlHistory.Hide();
                if (result == DialogResult.Yes)
                {
                    this.Show();
                }
                else
                {
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Chưa kết nối với CSDL");
            }
            label11.Text = intLoai;
            lbgetUser.Text = strUser;
            this.WindowState = FormWindowState.Maximized;
            tabControl1.Hide();
            tabControl2.Hide();
            tabControl3.Hide();
            tabControl4.Hide();
            tabControlHistory.Hide();
            tabControl5.Hide();
            tabControl6.Hide();
        }

        private void btnLayHang_Click(object sender, EventArgs e)
        {
            sqlcnn.Open();
            String a;
            String select = "SELECT SoLuong FROM SanPham WHERE MaSP = '" + txtMaSP5.Text + "';";
            SqlCommand selectcmd = new SqlCommand(select, sqlcnn);
            a = selectcmd.ExecuteScalar().ToString();
            sqlcnn.Close();
            int total;
            this.textBox1.Text = this.txtSL5.Text;
            string make = this.txtMaKe5.Text;
            string masp = this.txtMaSP5.Text;
            string tensp = this.txtTenSP5.Text;
            string soluong = this.txtSL5.Text;
            string ngaylay = (DateTime.Now).ToString();
            string nguoilay = lbgetUser.Text;
            LayHang LH = new LayHang(make, masp, tensp, soluong, ngaylay, nguoilay);
            SanPham SP = new SanPham(masp, tensp, make, soluong);
            int SoDong;
            int y = int.Parse(a);
            int x = int.Parse(textBox1.Text);
            if( x < y)
            {
                total = y - x;
                SoDong = new SanPhamDAO().CapNhap(SP, total);
                SoDong = new LayHangDAO().ThemLS(LH);
            }
            else if (x == y)
            {
                SoDong = new SanPhamDAO().Xoa(SP);
                SoDong = new LayHangDAO().ThemLS(LH);
            }
            else
            {
                MessageBox.Show("SL lấy ra lớn hơn SL có trong kho");
            }
            loadData();
        }

        public void loadData()
        {
            ds = getNhapHang();
            productTable = ds.Tables[0];
            dataGridView1.DataSource = productTable;

            ds = getCatHang();
            CHTable = ds.Tables[0];
            dataGridView2.DataSource = CHTable;

            ds = getSanPham();
            SPTable = ds.Tables[0];
            dataGridView3.DataSource = SPTable;
            dataGridView4.DataSource = SPTable;
            dataGridView5.DataSource = SPTable;

            dataGridViewInPut.DataSource = productTable;
            dataGridView8.DataSource = productTable;
            dataGridView6.DataSource = CHTable;
            dataGridView10.DataSource = SPTable;
            dataGridView7.DataSource = LHTable;
            dataGridView9.DataSource = LHTable;
        }

        private void ToolStripMenuItemInput_Click(object sender, EventArgs e)
        {
            tabControl1.Show();
            tabControl2.Hide();
            tabControl3.Hide();
            tabControl4.Hide();
            tabControlHistory.Hide();
            this.tabControl6.Hide();
            tabControl5.Hide();
        }

        private void ToolStripMenuItemSort_Click(object sender, EventArgs e)
        {
            tabControl2.Show();
            tabControl1.Hide();
            tabControl3.Hide();
            tabControl4.Hide();
            tabControlHistory.Hide();
            this.tabControl6.Hide();
            tabControl5.Hide();
        }

        private void ToolStripMenuItemOutput_Click(object sender, EventArgs e)
        {
            tabControl3.Hide();
            tabControl1.Hide();
            tabControl2.Hide();
            tabControl4.Show();
            tabControlHistory.Hide();
            this.tabControl6.Hide();
            tabControl5.Hide();
        }
        private void ToolStripMenuItemTonKho_Click(object sender, EventArgs e)
        {
            tabControl3.Show();
            tabControl1.Hide();
            tabControl2.Hide();
            tabControl4.Hide();
            tabControlHistory.Hide();
            this.tabControl6.Hide();
            tabControl5.Hide();
        }
        private void HistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl3.Hide();
            tabControl1.Hide();
            tabControl2.Hide();
            tabControl4.Hide();
            tabControlHistory.Show();
            this.tabControl6.Hide();
            tabControl5.Hide();
        }
        private void StatisticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int a = int.Parse(label11.Text);
            if (a >= 3)
            {
                this.tabControl5.Hide();
                this.tabControl6.Hide();
            }
            else
            {
                this.tabControl5.Show();
                tabControl3.Hide();
                tabControl1.Hide();
                tabControl2.Hide();
                tabControl4.Hide();
                tabControlHistory.Hide();
                this.tabControl6.Hide();
            }
        }

        private void PrintReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int a = int.Parse(label11.Text);
            if (a >= 3)
            {
                this.tabControl5.Hide();
                this.tabControl6.Hide();
            }
            else
            {
                this.tabControl5.Hide();
                tabControl3.Hide();
                tabControl1.Hide();
                tabControl2.Hide();
                tabControl4.Hide();
                tabControlHistory.Hide();
                this.tabControl6.Show();
            }
        }


    }
}
