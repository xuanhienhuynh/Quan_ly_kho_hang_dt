namespace QuanLyKhoHang
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MaThung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtMaThung = new System.Windows.Forms.TextBox();
            this.lbMaThung = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.txtNgayNhap = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtMaSP = new System.Windows.Forms.TextBox();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.lbMaSP = new System.Windows.Forms.Label();
            this.lbNgayNhap = new System.Windows.Forms.Label();
            this.lbSoLuong = new System.Windows.Forms.Label();
            this.lbTenSP = new System.Windows.Forms.Label();
            this.quảnLýTồnKhoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kiêmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhậpHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cấtHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sắpXếpHàngHóaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lấyHàngKhỏiKệToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cấtHàngVàoKệToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýTồnKhođịnhKìToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kiểmKêToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, 46);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1892, 768);
            this.panel1.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaThung,
            this.MaSP,
            this.TenSP,
            this.SoLuong,
            this.NgayNhap});
            this.dataGridView1.Location = new System.Drawing.Point(149, 241);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1083, 171);
            this.dataGridView1.TabIndex = 11;
            // 
            // MaThung
            // 
            this.MaThung.DataPropertyName = "MaThung";
            this.MaThung.HeaderText = "Mã Thùng";
            this.MaThung.Name = "MaThung";
            // 
            // MaSP
            // 
            this.MaSP.HeaderText = "Mã SP";
            this.MaSP.Name = "MaSP";
            // 
            // TenSP
            // 
            this.TenSP.HeaderText = "Tên SP";
            this.TenSP.Name = "TenSP";
            // 
            // SoLuong
            // 
            this.SoLuong.HeaderText = "Số Lượng";
            this.SoLuong.Name = "SoLuong";
            // 
            // NgayNhap
            // 
            this.NgayNhap.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NgayNhap.HeaderText = "Ngày Nhập";
            this.NgayNhap.Name = "NgayNhap";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.txtMaThung);
            this.panel2.Controls.Add(this.lbMaThung);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.txtNgayNhap);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.txtMaSP);
            this.panel2.Controls.Add(this.txtTenSP);
            this.panel2.Controls.Add(this.txtSoLuong);
            this.panel2.Controls.Add(this.lbMaSP);
            this.panel2.Controls.Add(this.lbNgayNhap);
            this.panel2.Controls.Add(this.lbSoLuong);
            this.panel2.Controls.Add(this.lbTenSP);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1892, 196);
            this.panel2.TabIndex = 10;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // txtMaThung
            // 
            this.txtMaThung.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaThung.Location = new System.Drawing.Point(149, 32);
            this.txtMaThung.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaThung.Name = "txtMaThung";
            this.txtMaThung.Size = new System.Drawing.Size(161, 27);
            this.txtMaThung.TabIndex = 12;
            // 
            // lbMaThung
            // 
            this.lbMaThung.AutoSize = true;
            this.lbMaThung.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaThung.Location = new System.Drawing.Point(43, 34);
            this.lbMaThung.Name = "lbMaThung";
            this.lbMaThung.Size = new System.Drawing.Size(102, 25);
            this.lbMaThung.TabIndex = 11;
            this.lbMaThung.Text = "Mã Thùng";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(1792, 91);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 64);
            this.button2.TabIndex = 10;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // txtNgayNhap
            // 
            this.txtNgayNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNgayNhap.Location = new System.Drawing.Point(1536, 27);
            this.txtNgayNhap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNgayNhap.Name = "txtNgayNhap";
            this.txtNgayNhap.Size = new System.Drawing.Size(308, 27);
            this.txtNgayNhap.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1651, 91);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 64);
            this.button1.TabIndex = 9;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtMaSP
            // 
            this.txtMaSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaSP.Location = new System.Drawing.Point(465, 34);
            this.txtMaSP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.Size = new System.Drawing.Size(177, 27);
            this.txtMaSP.TabIndex = 0;
            // 
            // txtTenSP
            // 
            this.txtTenSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenSP.Location = new System.Drawing.Point(760, 30);
            this.txtTenSP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(196, 27);
            this.txtTenSP.TabIndex = 1;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoLuong.Location = new System.Drawing.Point(1079, 27);
            this.txtSoLuong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(288, 27);
            this.txtSoLuong.TabIndex = 7;
            // 
            // lbMaSP
            // 
            this.lbMaSP.AutoSize = true;
            this.lbMaSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaSP.Location = new System.Drawing.Point(377, 33);
            this.lbMaSP.Name = "lbMaSP";
            this.lbMaSP.Size = new System.Drawing.Size(72, 25);
            this.lbMaSP.TabIndex = 2;
            this.lbMaSP.Text = "Mã SP";
            // 
            // lbNgayNhap
            // 
            this.lbNgayNhap.AutoSize = true;
            this.lbNgayNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNgayNhap.Location = new System.Drawing.Point(1423, 28);
            this.lbNgayNhap.Name = "lbNgayNhap";
            this.lbNgayNhap.Size = new System.Drawing.Size(107, 25);
            this.lbNgayNhap.TabIndex = 6;
            this.lbNgayNhap.Text = "Ngày nhập";
            // 
            // lbSoLuong
            // 
            this.lbSoLuong.AutoSize = true;
            this.lbSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSoLuong.Location = new System.Drawing.Point(979, 30);
            this.lbSoLuong.Name = "lbSoLuong";
            this.lbSoLuong.Size = new System.Drawing.Size(90, 25);
            this.lbSoLuong.TabIndex = 3;
            this.lbSoLuong.Text = "Số lượng";
            // 
            // lbTenSP
            // 
            this.lbTenSP.AutoSize = true;
            this.lbTenSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenSP.Location = new System.Drawing.Point(675, 30);
            this.lbTenSP.Name = "lbTenSP";
            this.lbTenSP.Size = new System.Drawing.Size(79, 25);
            this.lbTenSP.TabIndex = 5;
            this.lbTenSP.Text = "Tên SP";
            // 
            // quảnLýTồnKhoToolStripMenuItem
            // 
            this.quảnLýTồnKhoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kiêmToolStripMenuItem,
            this.nhậpHàngToolStripMenuItem,
            this.cấtHàngToolStripMenuItem});
            this.quảnLýTồnKhoToolStripMenuItem.Name = "quảnLýTồnKhoToolStripMenuItem";
            this.quảnLýTồnKhoToolStripMenuItem.Size = new System.Drawing.Size(259, 38);
            this.quảnLýTồnKhoToolStripMenuItem.Text = "Nhập hàng vào kho";
            // 
            // kiêmToolStripMenuItem
            // 
            this.kiêmToolStripMenuItem.Name = "kiêmToolStripMenuItem";
            this.kiêmToolStripMenuItem.Size = new System.Drawing.Size(344, 38);
            this.kiêmToolStripMenuItem.Text = "Nhận và kiểm hàng";
            this.kiêmToolStripMenuItem.Click += new System.EventHandler(this.kiêmToolStripMenuItem_Click);
            // 
            // nhậpHàngToolStripMenuItem
            // 
            this.nhậpHàngToolStripMenuItem.Name = "nhậpHàngToolStripMenuItem";
            this.nhậpHàngToolStripMenuItem.Size = new System.Drawing.Size(344, 38);
            this.nhậpHàngToolStripMenuItem.Text = "Cất hàng từ phiếu";
            // 
            // cấtHàngToolStripMenuItem
            // 
            this.cấtHàngToolStripMenuItem.Name = "cấtHàngToolStripMenuItem";
            this.cấtHàngToolStripMenuItem.Size = new System.Drawing.Size(344, 38);
            this.cấtHàngToolStripMenuItem.Text = "Cập nhập kích thước";
            // 
            // sắpXếpHàngHóaToolStripMenuItem
            // 
            this.sắpXếpHàngHóaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lấyHàngKhỏiKệToolStripMenuItem,
            this.cấtHàngVàoKệToolStripMenuItem});
            this.sắpXếpHàngHóaToolStripMenuItem.Name = "sắpXếpHàngHóaToolStripMenuItem";
            this.sắpXếpHàngHóaToolStripMenuItem.Size = new System.Drawing.Size(246, 38);
            this.sắpXếpHàngHóaToolStripMenuItem.Text = "Sắp xếp hàng hóa ";
            // 
            // lấyHàngKhỏiKệToolStripMenuItem
            // 
            this.lấyHàngKhỏiKệToolStripMenuItem.Name = "lấyHàngKhỏiKệToolStripMenuItem";
            this.lấyHàngKhỏiKệToolStripMenuItem.Size = new System.Drawing.Size(300, 38);
            this.lấyHàngKhỏiKệToolStripMenuItem.Text = "Lấy hàng khỏi kệ";
            // 
            // cấtHàngVàoKệToolStripMenuItem
            // 
            this.cấtHàngVàoKệToolStripMenuItem.Name = "cấtHàngVàoKệToolStripMenuItem";
            this.cấtHàngVàoKệToolStripMenuItem.Size = new System.Drawing.Size(300, 38);
            this.cấtHàngVàoKệToolStripMenuItem.Text = "Cất hàng vào kệ";
            // 
            // quảnLýTồnKhođịnhKìToolStripMenuItem
            // 
            this.quảnLýTồnKhođịnhKìToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kiểmKêToolStripMenuItem});
            this.quảnLýTồnKhođịnhKìToolStripMenuItem.Name = "quảnLýTồnKhođịnhKìToolStripMenuItem";
            this.quảnLýTồnKhođịnhKìToolStripMenuItem.Size = new System.Drawing.Size(330, 38);
            this.quảnLýTồnKhođịnhKìToolStripMenuItem.Text = "Quản lý tồn kho (định kì)";
            // 
            // kiểmKêToolStripMenuItem
            // 
            this.kiểmKêToolStripMenuItem.Name = "kiểmKêToolStripMenuItem";
            this.kiểmKêToolStripMenuItem.Size = new System.Drawing.Size(196, 38);
            this.kiểmKêToolStripMenuItem.Text = "Kiểm kê";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýTồnKhoToolStripMenuItem,
            this.sắpXếpHàngHóaToolStripMenuItem,
            this.quảnLýTồnKhođịnhKìToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1339, 42);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1339, 814);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbSoLuong;
        private System.Windows.Forms.Label lbMaSP;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.TextBox txtMaSP;
        private System.Windows.Forms.Label lbNgayNhap;
        private System.Windows.Forms.Label lbTenSP;
        private System.Windows.Forms.TextBox txtNgayNhap;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtMaThung;
        private System.Windows.Forms.Label lbMaThung;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaThung;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayNhap;
        private System.Windows.Forms.ToolStripMenuItem quảnLýTồnKhoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kiêmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhậpHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cấtHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sắpXếpHàngHóaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lấyHàngKhỏiKệToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cấtHàngVàoKệToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýTồnKhođịnhKìToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kiểmKêToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }

}
