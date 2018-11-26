using System;
using System.Data;
using System.Data.SqlClient;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuanLyKhoHang;
using DAO;
using DTO;
using BUS;

namespace UnitTestQLKho
{
    [TestClass]
    public class UnitTestQLKho
    {
        private DataProvider daPro;
        private NhapHangDAO NHD;
        private CatHangDAO CHD;
        private LayHangDAO LHD;

        [TestInitialize] //phương thức thực thi trước khi chạy các test case.
        public void setUp()
        {
            daPro = new DataProvider();
            NHD = new NhapHangDAO();
            CHD = new CatHangDAO();
            LHD = new LayHangDAO();
        }

        /// <summary>
        /// TestDangNhap
        /// </summary>
        [TestMethod]
        public void TestDangNhap()
        {
            LoginBus lgBUS = new LoginBus();
            string user = "admin";
            string pass = "admin";
            bool b = true;
            Account acc = new Account(user, pass);
            LoginBus DN = new LoginBus();
            b = lgBUS.loginbus(acc);
            Assert.AreEqual(true, b);
        }

        [TestMethod]
        public void TestDangNhap_Thieu_User()
        {
            LoginBus lgBUS = new LoginBus();
            string user = "";
            string pass = "admin";
            bool b = true;
            Account acc = new Account(user, pass);
            LoginBus DN = new LoginBus();
            b = lgBUS.loginbus(acc);
            Assert.AreNotEqual(true, b);
        }

        [TestMethod]
        public void TestDangNhap_Thieu_Pass()
        {
            LoginBus lgBUS = new LoginBus();
            string user = "admin";
            string pass = "";
            bool b = true;
            Account acc = new Account(user, pass);
            LoginBus DN = new LoginBus();
            b = lgBUS.loginbus(acc);
            Assert.AreNotEqual(true, b);
        }

        [TestMethod]
        public void TestDangNhap_Rong()
        {
            LoginBus lgBUS = new LoginBus();
            string user = "";
            string pass = "";
            bool b = true;
            Account acc = new Account(user, pass);
            LoginBus DN = new LoginBus();
            b = lgBUS.loginbus(acc);
            Assert.AreEqual(false, b);
        }

        /// <summary>
        /// TestNhapHang_Them
        /// </summary>
        [TestMethod]
        public void TestNhapHang_Them()
        {
            NhapHangBUS NHBus = new NhapHangBUS();
            int a;
            string mathung = "T01";
            string masp = "95486";
            string tensp = "Pin sạc dự phòng";
            string soluong = "1000";
            string ngaynhap = (DateTime.Now).ToString();
            string nguoinhap = "cuong.suhuy";
            NhapHang NH = new NhapHang(mathung, masp, tensp, soluong, ngaynhap, nguoinhap);
            a = NHBus.them(NH);
            Assert.AreEqual(1, a);
        }

        /// <summary>
        /// TestNhapHang_Them_Thieu 1 đối tượng
        /// </summary>
        [TestMethod]
        public void TestNhapHang_Them_ThieuMaThung()
        {
            NhapHangBUS NHBus = new NhapHangBUS();
            int a;
            string mathung = "";
            string masp = "123";
            string tensp = "Pin sạc dự phòng";
            string soluong = "1000";
            string nguoinhap = "admin";
            string ngaynhap = (DateTime.Now).ToString();
            NhapHang NH = new NhapHang(mathung, masp, tensp, soluong, ngaynhap, nguoinhap);
            a = NHBus.them(NH);
            Assert.AreEqual(1, a);
        }

        [TestMethod]
        public void TestNhapHang_Them_ThieuMaSP()
        {
            NhapHangBUS NHBus = new NhapHangBUS();
            int a;
            string mathung = "T01";
            string masp = "";
            string tensp = "Pin sạc dự phòng";
            string soluong = "1000";
            string nguoinhap = "admin";
            string ngaynhap = (DateTime.Now).ToString();
            NhapHang NH = new NhapHang(mathung, masp, tensp, soluong, ngaynhap, nguoinhap);
            a = NHBus.them(NH);
            Assert.AreEqual(1, a);
        }

        [TestMethod]
        public void TestNhapHang_Them_ThieuTenSP()
        {
            NhapHangBUS NHBus = new NhapHangBUS();
            int a;
            string mathung = "T01";
            string masp = "123";
            string tensp = "";
            string soluong = "1000";
            string nguoinhap = "admin";
            string ngaynhap = (DateTime.Now).ToString();
            NhapHang NH = new NhapHang(mathung, masp, tensp, soluong, ngaynhap, nguoinhap);
            a = NHBus.them(NH);
            Assert.AreEqual(1, a);
        }

        [TestMethod]
        public void TestNhapHang_Them_ThieuSoLuong()
        {
            NhapHangBUS NHBus = new NhapHangBUS();
            int a;
            string mathung = "T01";
            string masp = "123";
            string tensp = "Pin sạc dự phòng";
            string soluong = "";
            string nguoinhap = "admin";
            string ngaynhap = (DateTime.Now).ToString();
            NhapHang NH = new NhapHang(mathung, masp, tensp, soluong, ngaynhap, nguoinhap);
            a = NHBus.them(NH);
            Assert.AreEqual(1, a);
        }

        [TestMethod]
        public void TestNhapHang_Them_ThieuNgayNhap()
        {
            NhapHangBUS NHBus = new NhapHangBUS();
            int a;
            string mathung = "T01";
            string masp = "123";
            string tensp = "Pin sạc dự phòng";
            string soluong = "1000";
            string nguoinhap = "admin";
            string ngaynhap = "";
            NhapHang NH = new NhapHang(mathung, masp, tensp, soluong, ngaynhap, nguoinhap);
            a = NHBus.them(NH);
            Assert.AreEqual(1, a);
        }

        [TestMethod]
        public void TestNhapHang_Them_ThieuNguoiNhap()
        {
            NhapHangBUS NHBus = new NhapHangBUS();
            int a;
            string mathung = "T01";
            string masp = "123";
            string tensp = "Pin sạc dự phòng";
            string soluong = "1000";
            string ngaynhap = (DateTime.Now).ToString();
            string nguoinhap = "";
            NhapHang NH = new NhapHang(mathung, masp, tensp, soluong, ngaynhap, nguoinhap);
            a = NHBus.them(NH);
            Assert.AreEqual(1, a);
        }

        /// <summary>
        /// TestNhapHang_Them_Thieu 2 đối tượng
        /// </summary>
        [TestMethod]
        public void TestNhapHang_Them_ThieuMaThung_MaSP()
        {
            NhapHangBUS NHBus = new NhapHangBUS();
            int a;
            string mathung = "";
            string masp = "";
            string tensp = "Pin sạc dự phòng";
            string soluong = "1000";
            string nguoinhap = "admin";
            string ngaynhap = (DateTime.Now).ToString();
            NhapHang NH = new NhapHang(mathung, masp, tensp, soluong, ngaynhap, nguoinhap);
            a = NHBus.them(NH);
            Assert.AreEqual(1, a);
        }

        [TestMethod]
        public void TestNhapHang_Them_ThieuMaThung_TenSP()
        {
            NhapHangBUS NHBus = new NhapHangBUS();
            int a;
            string mathung = "";
            string masp = "123";
            string tensp = "";
            string soluong = "1000";
            string nguoinhap = "admin";
            string ngaynhap = (DateTime.Now).ToString();
            NhapHang NH = new NhapHang(mathung, masp, tensp, soluong, ngaynhap, nguoinhap);
            a = NHBus.them(NH);
            Assert.AreEqual(1, a);
        }

        [TestMethod]
        public void TestNhapHang_Them_ThieuMaThung_SoLuong()
        {
            NhapHangBUS NHBus = new NhapHangBUS();
            int a;
            string mathung = "";
            string masp = "123";
            string tensp = "Pin sạc dự phòng";
            string soluong = "";
            string nguoinhap = "admin";
            string ngaynhap = (DateTime.Now).ToString();
            NhapHang NH = new NhapHang(mathung, masp, tensp, soluong, ngaynhap, nguoinhap);
            a = NHBus.them(NH);
            Assert.AreEqual(1, a);
        }

        [TestMethod]
        public void TestNhapHang_Them_ThieuMaThung_NguoiNhap()
        {
            NhapHangBUS NHBus = new NhapHangBUS();
            int a;
            string mathung = "";
            string masp = "123";
            string tensp = "Pin sạc dự phòng";
            string soluong = "1000";
            string nguoinhap = "";
            string ngaynhap = (DateTime.Now).ToString();
            NhapHang NH = new NhapHang(mathung, masp, tensp, soluong, ngaynhap, nguoinhap);
            a = NHBus.them(NH);
            Assert.AreEqual(1, a);
        }

        [TestMethod]
        public void TestNhapHang_Them_ThieuMaThung_NgayNhap()
        {
            NhapHangBUS NHBus = new NhapHangBUS();
            int a;
            string mathung = "";
            string masp = "123";
            string tensp = "Pin sạc dự phòng";
            string soluong = "1000";
            string nguoinhap = "admin";
            string ngaynhap = "";
            NhapHang NH = new NhapHang(mathung, masp, tensp, soluong, ngaynhap, nguoinhap);
            a = NHBus.them(NH);
            Assert.AreEqual(1, a);
        }

        [TestMethod]
        public void TestNhapHang_Them_ThieuMaSP_TenSP()
        {
            NhapHangBUS NHBus = new NhapHangBUS();
            int a;
            string mathung = "T01";
            string masp = "";
            string tensp = "";
            string soluong = "1000";
            string ngaynhap = (DateTime.Now).ToString();
            string nguoinhap = "hien";
            NhapHang NH = new NhapHang(mathung, masp, tensp, soluong, ngaynhap, nguoinhap);
            a = NHBus.them(NH);
            Assert.AreEqual(1, a);
        }

        [TestMethod]
        public void TestNhapHang_Them_ThieuMaSP_SoLuong()
        {
            NhapHangBUS NHBus = new NhapHangBUS();
            int a;
            string mathung = "T01";
            string masp = "";
            string tensp = "Pin sạc dự phòng";
            string soluong = "";
            string ngaynhap = (DateTime.Now).ToString();
            string nguoinhap = "hien";
            NhapHang NH = new NhapHang(mathung, masp, tensp, soluong, ngaynhap, nguoinhap);
            a = NHBus.them(NH);
            Assert.AreEqual(1, a);
        }

        [TestMethod]
        public void TestNhapHang_Them_ThieuMaSP_NgayNhap()
        {
            NhapHangBUS NHBus = new NhapHangBUS();
            int a;
            string mathung = "T01";
            string masp = "";
            string tensp = "Pin sạc dự phòng";
            string soluong = "1000";
            string ngaynhap = "";
            string nguoinhap = "hien";
            NhapHang NH = new NhapHang(mathung, masp, tensp, soluong, ngaynhap, nguoinhap);
            a = NHBus.them(NH);
            Assert.AreEqual(1, a);
        }

        [TestMethod]
        public void TestNhapHang_Them_ThieuMaSP_NguoiNhap()
        {
            NhapHangBUS NHBus = new NhapHangBUS();
            int a;
            string mathung = "T01";
            string masp = "";
            string tensp = "Pin sạc dự phòng";
            string soluong = "1000";
            string ngaynhap = (DateTime.Now).ToString();
            string nguoinhap = "";
            NhapHang NH = new NhapHang(mathung, masp, tensp, soluong, ngaynhap, nguoinhap);
            a = NHBus.them(NH);
            Assert.AreEqual(1, a);
        }

        [TestMethod]
        public void TestNhapHang_Them_ThieuTenSP_SoLuong()
        {
            NhapHangBUS NHBus = new NhapHangBUS();
            int a;
            string mathung = "T01";
            string masp = "123";
            string tensp = "";
            string soluong = "";
            string ngaynhap = (DateTime.Now).ToString();
            string nguoinhap = "hien";
            NhapHang NH = new NhapHang(mathung, masp, tensp, soluong, ngaynhap, nguoinhap);
            a = NHBus.them(NH);
            Assert.AreEqual(1, a);
        }

        [TestMethod]
        public void TestNhapHang_Them_ThieuTenSP_NgayNhap()
        {
            NhapHangBUS NHBus = new NhapHangBUS();
            int a;
            string mathung = "T01";
            string masp = "123";
            string tensp = "";
            string soluong = "1000";
            string ngaynhap = "";
            string nguoinhap = "hien";
            NhapHang NH = new NhapHang(mathung, masp, tensp, soluong, ngaynhap, nguoinhap);
            a = NHBus.them(NH);
            Assert.AreEqual(1, a);
        }

        [TestMethod]
        public void TestNhapHang_Them_ThieuTenSP_NguoiNhap()
        {
            NhapHangBUS NHBus = new NhapHangBUS();
            int a;
            string mathung = "T01";
            string masp = "123";
            string tensp = "";
            string soluong = "1000";
            string ngaynhap = (DateTime.Now).ToString();
            string nguoinhap = "";
            NhapHang NH = new NhapHang(mathung, masp, tensp, soluong, ngaynhap, nguoinhap);
            a = NHBus.them(NH);
            Assert.AreEqual(1, a);
        }

        [TestMethod]
        public void TestNhapHang_Them_ThieuSoLuong_NgayNhap()
        {
            NhapHangBUS NHBus = new NhapHangBUS();
            int a;
            string mathung = "T01";
            string masp = "123";
            string tensp = "Pin sạc dự phòng";
            string soluong = "";
            string ngaynhap = "";
            string nguoinhap = "hien";
            NhapHang NH = new NhapHang(mathung, masp, tensp, soluong, ngaynhap, nguoinhap);
            a = NHBus.them(NH);
            Assert.AreEqual(1, a);
        }

        [TestMethod]
        public void TestNhapHang_Them_ThieuSoLuong_NguoiNhap()
        {
            NhapHangBUS NHBus = new NhapHangBUS();
            int a;
            string mathung = "T01";
            string masp = "123";
            string tensp = "Pin sạc dự phòng";
            string soluong = "";
            string ngaynhap = (DateTime.Now).ToString();
            string nguoinhap = "";
            NhapHang NH = new NhapHang(mathung, masp, tensp, soluong, ngaynhap, nguoinhap);
            a = NHBus.them(NH);
            Assert.AreEqual(1, a);
        }

        /// <summary>
        /// TestNhapHang_Them_Thieu 3 đối tượng
        /// </summary>
        [TestMethod]
        public void TestNhapHang_Them_ThieuMaThung_MaSP_TenSP()
        {
            NhapHangBUS NHBus = new NhapHangBUS();
            int a;
            string mathung = "";
            string masp = "";
            string tensp = "";
            string soluong = "1000";
            string ngaynhap = (DateTime.Now).ToString();
            string nguoinhap = "hien";
            NhapHang NH = new NhapHang(mathung, masp, tensp, soluong, ngaynhap, nguoinhap);
            a = NHBus.them(NH);
            Assert.AreEqual(1, a);
        }

        [TestMethod]
        public void TestNhapHang_Them_ThieuMaThung_MaSP_SoLuong()
        {
            NhapHangBUS NHBus = new NhapHangBUS();
            int a;
            string mathung = "";
            string masp = "";
            string tensp = "Pin sạc dự phòng";
            string soluong = "";
            string ngaynhap = (DateTime.Now).ToString();
            string nguoinhap = "hien";
            NhapHang NH = new NhapHang(mathung, masp, tensp, soluong, ngaynhap, nguoinhap);
            a = NHBus.them(NH);
            Assert.AreEqual(1, a);
        }

        [TestMethod]
        public void TestNhapHang_Them_ThieuMaThung_MaSP_NgayNhap()
        {
            NhapHangBUS NHBus = new NhapHangBUS();
            int a;
            string mathung = "";
            string masp = "";
            string tensp = "Pin sạc dự phòng";
            string soluong = "1000";
            string ngaynhap = "";
            string nguoinhap = "hien";
            NhapHang NH = new NhapHang(mathung, masp, tensp, soluong, ngaynhap, nguoinhap);
            a = NHBus.them(NH);
            Assert.AreEqual(1, a);
        }

        [TestMethod]
        public void TestNhapHang_Them_ThieuMaThung_MaSP_NguoiNhap()
        {
            NhapHangBUS NHBus = new NhapHangBUS();
            int a;
            string mathung = "";
            string masp = "";
            string tensp = "Pin sạc dự phòng";
            string soluong = "1000";
            string ngaynhap = (DateTime.Now).ToString();
            string nguoinhap = "";
            NhapHang NH = new NhapHang(mathung, masp, tensp, soluong, ngaynhap, nguoinhap);
            a = NHBus.them(NH);
            Assert.AreEqual(1, a);
        }

        [TestMethod]
        public void TestNhapHang_Them_ThieuMaSP_TenSP_SoLuong()
        {
            NhapHangBUS NHBus = new NhapHangBUS();
            int a;
            string mathung = "T01";
            string masp = "";
            string tensp = "";
            string soluong = "";
            string ngaynhap = (DateTime.Now).ToString();
            string nguoinhap = "hien";
            NhapHang NH = new NhapHang(mathung, masp, tensp, soluong, ngaynhap, nguoinhap);
            a = NHBus.them(NH);
            Assert.AreEqual(1, a);
        }

        [TestMethod]
        public void TestNhapHang_Them_ThieuMaSP_TenSP_NgayNhap()
        {
            NhapHangBUS NHBus = new NhapHangBUS();
            int a;
            string mathung = "T01";
            string masp = "";
            string tensp = "";
            string soluong = "1000";
            string ngaynhap = "";
            string nguoinhap = "hien";
            NhapHang NH = new NhapHang(mathung, masp, tensp, soluong, ngaynhap, nguoinhap);
            a = NHBus.them(NH);
            Assert.AreEqual(1, a);
        }

        [TestMethod]
        public void TestNhapHang_Them_ThieuMaSP_TenSP_NguoiNhap()
        {
            NhapHangBUS NHBus = new NhapHangBUS();
            int a;
            string mathung = "T01";
            string masp = "";
            string tensp = "";
            string soluong = "1000";
            string ngaynhap = (DateTime.Now).ToString();
            string nguoinhap = "";
            NhapHang NH = new NhapHang(mathung, masp, tensp, soluong, ngaynhap, nguoinhap);
            a = NHBus.them(NH);
            Assert.AreEqual(1, a);
        }

        [TestMethod]
        public void TestNhapHang_Them_ThieuTenSP_SoLuong_NgayNhap()
        {
            NhapHangBUS NHBus = new NhapHangBUS();
            int a;
            string mathung = "T01";
            string masp = "123";
            string tensp = "";
            string soluong = "";
            string ngaynhap = "";
            string nguoinhap = "hien";
            NhapHang NH = new NhapHang(mathung, masp, tensp, soluong, ngaynhap, nguoinhap);
            a = NHBus.them(NH);
            Assert.AreEqual(1, a);
        }

        [TestMethod]
        public void TestNhapHang_Them_ThieuTenSP_SoLuong_NguoiNhap()
        {
            NhapHangBUS NHBus = new NhapHangBUS();
            int a;
            string mathung = "T01";
            string masp = "123";
            string tensp = "";
            string soluong = "";
            string ngaynhap = (DateTime.Now).ToString();
            string nguoinhap = "";
            NhapHang NH = new NhapHang(mathung, masp, tensp, soluong, ngaynhap, nguoinhap);
            a = NHBus.them(NH);
            Assert.AreEqual(1, a);
        }

        [TestMethod]
        public void TestNhapHang_Them_ThieuSoLuong_NgayNhap_NguoiNhap()
        {
            NhapHangBUS NHBus = new NhapHangBUS();
            int a;
            string mathung = "T01";
            string masp = "123";
            string tensp = "Pin sạc dự phòng";
            string soluong = "";
            string ngaynhap = "";
            string nguoinhap = "";
            NhapHang NH = new NhapHang(mathung, masp, tensp, soluong, ngaynhap, nguoinhap);
            a = NHBus.them(NH);
            Assert.AreEqual(1, a);
        }

        /// <summary>
        /// TestNhapHang_Them_Thieu 4 đối tượng
        /// </summary>
        [TestMethod]
        public void TestNhapHang_Them_ThieuMaThung_MaSP_TenSP_SoLuong()
        {
            NhapHangBUS NHBus = new NhapHangBUS();
            int a;
            string mathung = "";
            string masp = "";
            string tensp = "";
            string soluong = "";
            string ngaynhap = (DateTime.Now).ToString();
            string nguoinhap = "hien";
            NhapHang NH = new NhapHang(mathung, masp, tensp, soluong, ngaynhap, nguoinhap);
            a = NHBus.them(NH);
            Assert.AreEqual(1, a);
        }

        [TestMethod]
        public void TestNhapHang_Them_ThieuMaThung_MaSP_TenSP_NgayNhap()
        {
            NhapHangBUS NHBus = new NhapHangBUS();
            int a;
            string mathung = "";
            string masp = "";
            string tensp = "";
            string soluong = "1000";
            string ngaynhap = "";
            string nguoinhap = "hien";
            NhapHang NH = new NhapHang(mathung, masp, tensp, soluong, ngaynhap, nguoinhap);
            a = NHBus.them(NH);
            Assert.AreEqual(1, a);
        }

        [TestMethod]
        public void TestNhapHang_Them_ThieuMaThung_MaSP_TenSP_NguoiNhap()
        {
            NhapHangBUS NHBus = new NhapHangBUS();
            int a;
            string mathung = "";
            string masp = "";
            string tensp = "";
            string soluong = "1000";
            string ngaynhap = (DateTime.Now).ToString();
            string nguoinhap = "";
            NhapHang NH = new NhapHang(mathung, masp, tensp, soluong, ngaynhap, nguoinhap);
            a = NHBus.them(NH);
            Assert.AreEqual(1, a);
        }

        [TestMethod]
        public void TestNhapHang_Them_ThieuMaSP_TenSP_SoLuong_NgayNhap()
        {
            NhapHangBUS NHBus = new NhapHangBUS();
            int a;
            string mathung = "T01";
            string masp = "";
            string tensp = "";
            string soluong = "";
            string ngaynhap = "";
            string nguoinhap = "hien";
            NhapHang NH = new NhapHang(mathung, masp, tensp, soluong, ngaynhap, nguoinhap);
            a = NHBus.them(NH);
            Assert.AreEqual(1, a);
        }

        [TestMethod]
        public void TestNhapHang_Them_ThieuMaSP_TenSP_SoLuong_NguoiNhap()
        {
            NhapHangBUS NHBus = new NhapHangBUS();
            int a;
            string mathung = "T01";
            string masp = "";
            string tensp = "";
            string soluong = "";
            string ngaynhap = (DateTime.Now).ToString();
            string nguoinhap = "";
            NhapHang NH = new NhapHang(mathung, masp, tensp, soluong, ngaynhap, nguoinhap);
            a = NHBus.them(NH);
            Assert.AreEqual(1, a);
        }

        [TestMethod]
        public void TestNhapHang_Them_ThieuTenSP_SoLuong_NgayNhap_NguoiNhap()
        {
            NhapHangBUS NHBus = new NhapHangBUS();
            int a;
            string mathung = "T01";
            string masp = "123";
            string tensp = "";
            string soluong = "";
            string ngaynhap = "";
            string nguoinhap = "";
            NhapHang NH = new NhapHang(mathung, masp, tensp, soluong, ngaynhap, nguoinhap);
            a = NHBus.them(NH);
            Assert.AreEqual(1, a);
        }

        /// <summary>
        /// TestNhapHang_Them_Thieu 5 đối tượng
        /// </summary>
        [TestMethod]
        public void TestNhapHang_Them_ThieuMaThung_MaSP_TenSP_SoLuong_NgayNhap()
        {
            NhapHangBUS NHBus = new NhapHangBUS();
            int a;
            string mathung = "";
            string masp = "";
            string tensp = "";
            string soluong = "";
            string ngaynhap = "";
            string nguoinhap = "hien";
            NhapHang NH = new NhapHang(mathung, masp, tensp, soluong, ngaynhap, nguoinhap);
            a = NHBus.them(NH);
            Assert.AreEqual(1, a);
        }

        [TestMethod]
        public void TestNhapHang_Them_ThieuMaThung_MaSP_TenSP_SoLuong_NguoiNhap()
        {
            NhapHangBUS NHBus = new NhapHangBUS();
            int a;
            string mathung = "";
            string masp = "";
            string tensp = "";
            string soluong = "";
            string ngaynhap = (DateTime.Now).ToString();
            string nguoinhap = "";
            NhapHang NH = new NhapHang(mathung, masp, tensp, soluong, ngaynhap, nguoinhap);
            a = NHBus.them(NH);
            Assert.AreEqual(1, a);
        }

        [TestMethod]
        public void TestNhapHang_Them_ThieuMaThung_MaSP_TenSP_NgayNguoiNhap()
        {
            NhapHangBUS NHBus = new NhapHangBUS();
            int a;
            string mathung = "";
            string masp = "";
            string tensp = "";
            string soluong = "1000";
            string ngaynhap = "";
            string nguoinhap = "";
            NhapHang NH = new NhapHang(mathung, masp, tensp, soluong, ngaynhap, nguoinhap);
            a = NHBus.them(NH);
            Assert.AreEqual(1, a);
        }

        [TestMethod]
        public void TestNhapHang_Them_ThieuMaThung_MaSP_SoLuong_NgayNhap_NguoiNhap()
        {
            NhapHangBUS NHBus = new NhapHangBUS();
            int a;
            string mathung = "";
            string masp = "";
            string tensp = "Pin sạc dự phòng";
            string soluong = "";
            string ngaynhap = "";
            string nguoinhap = "";
            NhapHang NH = new NhapHang(mathung, masp, tensp, soluong, ngaynhap, nguoinhap);
            a = NHBus.them(NH);
            Assert.AreEqual(1, a);
        }

        [TestMethod]
        public void TestNhapHang_Them_ThieuMaThung_TenSP_SoLuong_NgayNhap_NguoiNhap()
        {
            NhapHangBUS NHBus = new NhapHangBUS();
            int a;
            string mathung = "";
            string masp = "123";
            string tensp = "";
            string soluong = "";
            string ngaynhap = "";
            string nguoinhap = "";
            NhapHang NH = new NhapHang(mathung, masp, tensp, soluong, ngaynhap, nguoinhap);
            a = NHBus.them(NH);
            Assert.AreEqual(1, a);
        }

        [TestMethod]
        public void TestNhapHang_Them_ThieuMaSP_TenSP_SoLuong_NgayNhap_NguoiNhap()
        {
            NhapHangBUS NHBus = new NhapHangBUS();
            int a;
            string mathung = "T01";
            string masp = "";
            string tensp = "";
            string soluong = "";
            string ngaynhap = "";
            string nguoinhap = "";
            NhapHang NH = new NhapHang(mathung, masp, tensp, soluong, ngaynhap, nguoinhap);
            a = NHBus.them(NH);
            Assert.AreEqual(1, a);
        }

        /// <summary>
        /// TestNhapHang_Them_Rỗng
        /// </summary>
        [TestMethod]
        public void TestNhapHang_Them_ThieuMaThung_MaSP_TenSP_SoLuong_NgayNhap_NguoiNhap()
        {
            NhapHangBUS NHBus = new NhapHangBUS();
            int a;
            string mathung = "";
            string masp = "";
            string tensp = "";
            string soluong = "";
            string ngaynhap = "";
            string nguoinhap = "";
            NhapHang NH = new NhapHang(mathung, masp, tensp, soluong, ngaynhap, nguoinhap);
            a = NHBus.them(NH);
            Assert.AreEqual(1, a);
        }




        /// <summary>
        /// 
        /// </summary>


        /// <summary>
        /// TestNhapHang_ThemLS
        /// </summary>
        [TestMethod]
        public void TestNhapHang_ThemLS()
        {
            NhapHangBUS NHBus = new NhapHangBUS();
            int a;
            string mathung = "T01";
            string masp = "95486";
            string tensp = "Pin sạc dự phòng";
            string soluong = "1000";
            string ngaynhap = (DateTime.Now).ToString();
            string nguoinhap = "cuong.suhuy";
            NhapHang NH = new NhapHang(mathung, masp, tensp, soluong, ngaynhap, nguoinhap);
            a = NHBus.them(NH);
            Assert.AreEqual(1, a);
        }

        /// <summary>
        /// TestNhapHang_ThemLS_Thieu 1 đối tượng
        /// </summary>
        [TestMethod]
        public void TestNhapHang_ThemLS_ThieuMaThung()
        {
            NhapHangBUS NHBus = new NhapHangBUS();
            int a;
            string mathung = "";
            string masp = "123";
            string tensp = "Pin sạc dự phòng";
            string soluong = "1000";
            string nguoinhap = "admin";
            string ngaynhap = (DateTime.Now).ToString();
            NhapHang NH = new NhapHang(mathung, masp, tensp, soluong, ngaynhap, nguoinhap);
            a = NHBus.them(NH);
            Assert.AreEqual(1, a);
        }

        [TestMethod]
        public void TestNhapHang_ThemLS_ThieuMaSP()
        {
            NhapHangBUS NHBus = new NhapHangBUS();
            int a;
            string mathung = "T01";
            string masp = "";
            string tensp = "Pin sạc dự phòng";
            string soluong = "1000";
            string nguoinhap = "admin";
            string ngaynhap = (DateTime.Now).ToString();
            NhapHang NH = new NhapHang(mathung, masp, tensp, soluong, ngaynhap, nguoinhap);
            a = NHBus.them(NH);
            Assert.AreEqual(1, a);
        }

        [TestMethod]
        public void TestNhapHang_ThemLS_ThieuTenSP()
        {
            NhapHangBUS NHBus = new NhapHangBUS();
            int a;
            string mathung = "T01";
            string masp = "123";
            string tensp = "";
            string soluong = "1000";
            string nguoinhap = "admin";
            string ngaynhap = (DateTime.Now).ToString();
            NhapHang NH = new NhapHang(mathung, masp, tensp, soluong, ngaynhap, nguoinhap);
            a = NHBus.them(NH);
            Assert.AreEqual(1, a);
        }

        [TestMethod]
        public void TestNhapHang_ThemLS_ThieuSoLuong()
        {
            NhapHangBUS NHBus = new NhapHangBUS();
            int a;
            string mathung = "T01";
            string masp = "123";
            string tensp = "Pin sạc dự phòng";
            string soluong = "";
            string nguoinhap = "admin";
            string ngaynhap = (DateTime.Now).ToString();
            NhapHang NH = new NhapHang(mathung, masp, tensp, soluong, ngaynhap, nguoinhap);
            a = NHBus.them(NH);
            Assert.AreEqual(1, a);
        }

        [TestMethod]
        public void TestNhapHang_ThemLS_ThieuNgayNhap()
        {
            NhapHangBUS NHBus = new NhapHangBUS();
            int a;
            string mathung = "T01";
            string masp = "123";
            string tensp = "Pin sạc dự phòng";
            string soluong = "1000";
            string nguoinhap = "admin";
            string ngaynhap = "";
            NhapHang NH = new NhapHang(mathung, masp, tensp, soluong, ngaynhap, nguoinhap);
            a = NHBus.them(NH);
            Assert.AreEqual(1, a);
        }

        [TestMethod]
        public void TestNhapHang_ThemLS_ThieuNguoiNhap()
        {
            NhapHangBUS NHBus = new NhapHangBUS();
            int a;
            string mathung = "T01";
            string masp = "123";
            string tensp = "Pin sạc dự phòng";
            string soluong = "1000";
            string ngaynhap = (DateTime.Now).ToString();
            string nguoinhap = "";
            NhapHang NH = new NhapHang(mathung, masp, tensp, soluong, ngaynhap, nguoinhap);
            a = NHBus.them(NH);
            Assert.AreEqual(1, a);
        }

        /// <summary>
        /// TestNhapHang_Them_Thieu 2 đối tượng
        /// </summary>
        [TestMethod]
        public void TestNhapHang_ThemLS_ThieuMaThung_MaSP()
        {
            NhapHangBUS NHBus = new NhapHangBUS();
            int a;
            string mathung = "";
            string masp = "";
            string tensp = "Pin sạc dự phòng";
            string soluong = "1000";
            string nguoinhap = "admin";
            string ngaynhap = (DateTime.Now).ToString();
            NhapHang NH = new NhapHang(mathung, masp, tensp, soluong, ngaynhap, nguoinhap);
            a = NHBus.them(NH);
            Assert.AreEqual(1, a);
        }

        [TestMethod]
        public void TestNhapHang_ThemLS_ThieuMaThung_TenSP()
        {
            NhapHangBUS NHBus = new NhapHangBUS();
            int a;
            string mathung = "";
            string masp = "123";
            string tensp = "";
            string soluong = "1000";
            string nguoinhap = "admin";
            string ngaynhap = (DateTime.Now).ToString();
            NhapHang NH = new NhapHang(mathung, masp, tensp, soluong, ngaynhap, nguoinhap);
            a = NHBus.them(NH);
            Assert.AreEqual(1, a);
        }

        [TestMethod]
        public void TestNhapHang_ThemLS_ThieuMaThung_SoLuong()
        {
            NhapHangBUS NHBus = new NhapHangBUS();
            int a;
            string mathung = "";
            string masp = "123";
            string tensp = "Pin sạc dự phòng";
            string soluong = "";
            string nguoinhap = "admin";
            string ngaynhap = (DateTime.Now).ToString();
            NhapHang NH = new NhapHang(mathung, masp, tensp, soluong, ngaynhap, nguoinhap);
            a = NHBus.them(NH);
            Assert.AreEqual(1, a);
        }

        [TestMethod]
        public void TestNhapHang_ThemLS_ThieuMaThung_NguoiNhap()
        {
            NhapHangBUS NHBus = new NhapHangBUS();
            int a;
            string mathung = "";
            string masp = "123";
            string tensp = "Pin sạc dự phòng";
            string soluong = "1000";
            string nguoinhap = "";
            string ngaynhap = (DateTime.Now).ToString();
            NhapHang NH = new NhapHang(mathung, masp, tensp, soluong, ngaynhap, nguoinhap);
            a = NHBus.them(NH);
            Assert.AreEqual(1, a);
        }

        [TestMethod]
        public void TestNhapHang_ThemLS_ThieuMaThung_NgayNhap()
        {
            NhapHangBUS NHBus = new NhapHangBUS();
            int a;
            string mathung = "";
            string masp = "123";
            string tensp = "Pin sạc dự phòng";
            string soluong = "1000";
            string nguoinhap = "admin";
            string ngaynhap = "";
            NhapHang NH = new NhapHang(mathung, masp, tensp, soluong, ngaynhap, nguoinhap);
            a = NHBus.them(NH);
            Assert.AreEqual(1, a);
        }

        [TestMethod]
        public void TestNhapHang_ThemLS_ThieuMaSP_TenSP()
        {
            NhapHangBUS NHBus = new NhapHangBUS();
            int a;
            string mathung = "T01";
            string masp = "";
            string tensp = "";
            string soluong = "1000";
            string ngaynhap = (DateTime.Now).ToString();
            string nguoinhap = "hien";
            NhapHang NH = new NhapHang(mathung, masp, tensp, soluong, ngaynhap, nguoinhap);
            a = NHBus.them(NH);
            Assert.AreEqual(1, a);
        }

        [TestMethod]
        public void TestNhapHang_ThemLS_ThieuMaSP_SoLuong()
        {
            NhapHangBUS NHBus = new NhapHangBUS();
            int a;
            string mathung = "T01";
            string masp = "";
            string tensp = "Pin sạc dự phòng";
            string soluong = "";
            string ngaynhap = (DateTime.Now).ToString();
            string nguoinhap = "hien";
            NhapHang NH = new NhapHang(mathung, masp, tensp, soluong, ngaynhap, nguoinhap);
            a = NHBus.them(NH);
            Assert.AreEqual(1, a);
        }

        [TestMethod]
        public void TestNhapHang_ThemLS_ThieuMaSP_NgayNhap()
        {
            NhapHangBUS NHBus = new NhapHangBUS();
            int a;
            string mathung = "T01";
            string masp = "";
            string tensp = "Pin sạc dự phòng";
            string soluong = "1000";
            string ngaynhap = "";
            string nguoinhap = "hien";
            NhapHang NH = new NhapHang(mathung, masp, tensp, soluong, ngaynhap, nguoinhap);
            a = NHBus.them(NH);
            Assert.AreEqual(1, a);
        }

        [TestMethod]
        public void TestNhapHang_ThemLS_ThieuMaSP_NguoiNhap()
        {
            NhapHangBUS NHBus = new NhapHangBUS();
            int a;
            string mathung = "T01";
            string masp = "";
            string tensp = "Pin sạc dự phòng";
            string soluong = "1000";
            string ngaynhap = (DateTime.Now).ToString();
            string nguoinhap = "";
            NhapHang NH = new NhapHang(mathung, masp, tensp, soluong, ngaynhap, nguoinhap);
            a = NHBus.them(NH);
            Assert.AreEqual(1, a);
        }

        [TestMethod]
        public void TestNhapHang_ThemLS_ThieuTenSP_SoLuong()
        {
            NhapHangBUS NHBus = new NhapHangBUS();
            int a;
            string mathung = "T01";
            string masp = "123";
            string tensp = "";
            string soluong = "";
            string ngaynhap = (DateTime.Now).ToString();
            string nguoinhap = "hien";
            NhapHang NH = new NhapHang(mathung, masp, tensp, soluong, ngaynhap, nguoinhap);
            a = NHBus.them(NH);
            Assert.AreEqual(1, a);
        }

        [TestMethod]
        public void TestNhapHang_ThemLS_ThieuTenSP_NgayNhap()
        {
            NhapHangBUS NHBus = new NhapHangBUS();
            int a;
            string mathung = "T01";
            string masp = "123";
            string tensp = "";
            string soluong = "1000";
            string ngaynhap = "";
            string nguoinhap = "hien";
            NhapHang NH = new NhapHang(mathung, masp, tensp, soluong, ngaynhap, nguoinhap);
            a = NHBus.them(NH);
            Assert.AreEqual(1, a);
        }

        [TestMethod]
        public void TestNhapHang_ThemLS_ThieuTenSP_NguoiNhap()
        {
            NhapHangBUS NHBus = new NhapHangBUS();
            int a;
            string mathung = "T01";
            string masp = "123";
            string tensp = "";
            string soluong = "1000";
            string ngaynhap = (DateTime.Now).ToString();
            string nguoinhap = "";
            NhapHang NH = new NhapHang(mathung, masp, tensp, soluong, ngaynhap, nguoinhap);
            a = NHBus.them(NH);
            Assert.AreEqual(1, a);
        }

        [TestMethod]
        public void TestNhapHang_ThemLS_ThieuSoLuong_NgayNhap()
        {
            NhapHangBUS NHBus = new NhapHangBUS();
            int a;
            string mathung = "T01";
            string masp = "123";
            string tensp = "Pin sạc dự phòng";
            string soluong = "";
            string ngaynhap = "";
            string nguoinhap = "hien";
            NhapHang NH = new NhapHang(mathung, masp, tensp, soluong, ngaynhap, nguoinhap);
            a = NHBus.them(NH);
            Assert.AreEqual(1, a);
        }

        [TestMethod]
        public void TestNhapHang_ThemLS_ThieuSoLuong_NguoiNhap()
        {
            NhapHangBUS NHBus = new NhapHangBUS();
            int a;
            string mathung = "T01";
            string masp = "123";
            string tensp = "Pin sạc dự phòng";
            string soluong = "";
            string ngaynhap = (DateTime.Now).ToString();
            string nguoinhap = "";
            NhapHang NH = new NhapHang(mathung, masp, tensp, soluong, ngaynhap, nguoinhap);
            a = NHBus.them(NH);
            Assert.AreEqual(1, a);
        }

        /// <summary>
        /// TestNhapHang_Them_Thieu 3 đối tượng
        /// </summary>
        [TestMethod]
        public void TestNhapHang_ThemLS_ThieuMaThung_MaSP_TenSP()
        {
            NhapHangBUS NHBus = new NhapHangBUS();
            int a;
            string mathung = "";
            string masp = "";
            string tensp = "";
            string soluong = "1000";
            string ngaynhap = (DateTime.Now).ToString();
            string nguoinhap = "hien";
            NhapHang NH = new NhapHang(mathung, masp, tensp, soluong, ngaynhap, nguoinhap);
            a = NHBus.them(NH);
            Assert.AreEqual(1, a);
        }

        [TestMethod]
        public void TestNhapHang_ThemLS_ThieuMaThung_MaSP_SoLuong()
        {
            NhapHangBUS NHBus = new NhapHangBUS();
            int a;
            string mathung = "";
            string masp = "";
            string tensp = "Pin sạc dự phòng";
            string soluong = "";
            string ngaynhap = (DateTime.Now).ToString();
            string nguoinhap = "hien";
            NhapHang NH = new NhapHang(mathung, masp, tensp, soluong, ngaynhap, nguoinhap);
            a = NHBus.them(NH);
            Assert.AreEqual(1, a);
        }

        [TestMethod]
        public void TestNhapHang_ThemLS_ThieuMaThung_MaSP_NgayNhap()
        {
            NhapHangBUS NHBus = new NhapHangBUS();
            int a;
            string mathung = "";
            string masp = "";
            string tensp = "Pin sạc dự phòng";
            string soluong = "1000";
            string ngaynhap = "";
            string nguoinhap = "hien";
            NhapHang NH = new NhapHang(mathung, masp, tensp, soluong, ngaynhap, nguoinhap);
            a = NHBus.them(NH);
            Assert.AreEqual(1, a);
        }

        [TestMethod]
        public void TestNhapHang_ThemLS_ThieuMaThung_MaSP_NguoiNhap()
        {
            NhapHangBUS NHBus = new NhapHangBUS();
            int a;
            string mathung = "";
            string masp = "";
            string tensp = "Pin sạc dự phòng";
            string soluong = "1000";
            string ngaynhap = (DateTime.Now).ToString();
            string nguoinhap = "";
            NhapHang NH = new NhapHang(mathung, masp, tensp, soluong, ngaynhap, nguoinhap);
            a = NHBus.them(NH);
            Assert.AreEqual(1, a);
        }

        [TestMethod]
        public void TestNhapHang_ThemLS_ThieuMaSP_TenSP_SoLuong()
        {
            NhapHangBUS NHBus = new NhapHangBUS();
            int a;
            string mathung = "T01";
            string masp = "";
            string tensp = "";
            string soluong = "";
            string ngaynhap = (DateTime.Now).ToString();
            string nguoinhap = "hien";
            NhapHang NH = new NhapHang(mathung, masp, tensp, soluong, ngaynhap, nguoinhap);
            a = NHBus.them(NH);
            Assert.AreEqual(1, a);
        }

        [TestMethod]
        public void TestNhapHang_ThemLS_ThieuMaSP_TenSP_NgayNhap()
        {
            NhapHangBUS NHBus = new NhapHangBUS();
            int a;
            string mathung = "T01";
            string masp = "";
            string tensp = "";
            string soluong = "1000";
            string ngaynhap = "";
            string nguoinhap = "hien";
            NhapHang NH = new NhapHang(mathung, masp, tensp, soluong, ngaynhap, nguoinhap);
            a = NHBus.them(NH);
            Assert.AreEqual(1, a);
        }

        [TestMethod]
        public void TestNhapHang_ThemLS_ThieuMaSP_TenSP_NguoiNhap()
        {
            NhapHangBUS NHBus = new NhapHangBUS();
            int a;
            string mathung = "T01";
            string masp = "";
            string tensp = "";
            string soluong = "1000";
            string ngaynhap = (DateTime.Now).ToString();
            string nguoinhap = "";
            NhapHang NH = new NhapHang(mathung, masp, tensp, soluong, ngaynhap, nguoinhap);
            a = NHBus.them(NH);
            Assert.AreEqual(1, a);
        }

        [TestMethod]
        public void TestNhapHang_ThemLS_ThieuTenSP_SoLuong_NgayNhap()
        {
            NhapHangBUS NHBus = new NhapHangBUS();
            int a;
            string mathung = "T01";
            string masp = "123";
            string tensp = "";
            string soluong = "";
            string ngaynhap = "";
            string nguoinhap = "hien";
            NhapHang NH = new NhapHang(mathung, masp, tensp, soluong, ngaynhap, nguoinhap);
            a = NHBus.them(NH);
            Assert.AreEqual(1, a);
        }

        [TestMethod]
        public void TestNhapHang_ThemLS_ThieuTenSP_SoLuong_NguoiNhap()
        {
            NhapHangBUS NHBus = new NhapHangBUS();
            int a;
            string mathung = "T01";
            string masp = "123";
            string tensp = "";
            string soluong = "";
            string ngaynhap = (DateTime.Now).ToString();
            string nguoinhap = "";
            NhapHang NH = new NhapHang(mathung, masp, tensp, soluong, ngaynhap, nguoinhap);
            a = NHBus.them(NH);
            Assert.AreEqual(1, a);
        }

        [TestMethod]
        public void TestNhapHang_ThemLS_ThieuSoLuong_NgayNhap_NguoiNhap()
        {
            NhapHangBUS NHBus = new NhapHangBUS();
            int a;
            string mathung = "T01";
            string masp = "123";
            string tensp = "Pin sạc dự phòng";
            string soluong = "";
            string ngaynhap = "";
            string nguoinhap = "";
            NhapHang NH = new NhapHang(mathung, masp, tensp, soluong, ngaynhap, nguoinhap);
            a = NHBus.them(NH);
            Assert.AreEqual(1, a);
        }

        /// <summary>
        /// TestNhapHang_Them_Thieu 4 đối tượng
        /// </summary>
        [TestMethod]
        public void TestNhapHang_ThemLS_ThieuMaThung_MaSP_TenSP_SoLuong()
        {
            NhapHangBUS NHBus = new NhapHangBUS();
            int a;
            string mathung = "";
            string masp = "";
            string tensp = "";
            string soluong = "";
            string ngaynhap = (DateTime.Now).ToString();
            string nguoinhap = "hien";
            NhapHang NH = new NhapHang(mathung, masp, tensp, soluong, ngaynhap, nguoinhap);
            a = NHBus.them(NH);
            Assert.AreEqual(1, a);
        }

        [TestMethod]
        public void TestNhapHang_ThemLS_ThieuMaThung_MaSP_TenSP_NgayNhap()
        {
            NhapHangBUS NHBus = new NhapHangBUS();
            int a;
            string mathung = "";
            string masp = "";
            string tensp = "";
            string soluong = "1000";
            string ngaynhap = "";
            string nguoinhap = "hien";
            NhapHang NH = new NhapHang(mathung, masp, tensp, soluong, ngaynhap, nguoinhap);
            a = NHBus.them(NH);
            Assert.AreEqual(1, a);
        }

        [TestMethod]
        public void TestNhapHang_ThemLS_ThieuMaThung_MaSP_TenSP_NguoiNhap()
        {
            NhapHangBUS NHBus = new NhapHangBUS();
            int a;
            string mathung = "";
            string masp = "";
            string tensp = "";
            string soluong = "1000";
            string ngaynhap = (DateTime.Now).ToString();
            string nguoinhap = "";
            NhapHang NH = new NhapHang(mathung, masp, tensp, soluong, ngaynhap, nguoinhap);
            a = NHBus.them(NH);
            Assert.AreEqual(1, a);
        }

        [TestMethod]
        public void TestNhapHang_ThemLS_ThieuMaSP_TenSP_SoLuong_NgayNhap()
        {
            NhapHangBUS NHBus = new NhapHangBUS();
            int a;
            string mathung = "T01";
            string masp = "";
            string tensp = "";
            string soluong = "";
            string ngaynhap = "";
            string nguoinhap = "hien";
            NhapHang NH = new NhapHang(mathung, masp, tensp, soluong, ngaynhap, nguoinhap);
            a = NHBus.them(NH);
            Assert.AreEqual(1, a);
        }

        [TestMethod]
        public void TestNhapHang_ThemLS_ThieuMaSP_TenSP_SoLuong_NguoiNhap()
        {
            NhapHangBUS NHBus = new NhapHangBUS();
            int a;
            string mathung = "T01";
            string masp = "";
            string tensp = "";
            string soluong = "";
            string ngaynhap = (DateTime.Now).ToString();
            string nguoinhap = "";
            NhapHang NH = new NhapHang(mathung, masp, tensp, soluong, ngaynhap, nguoinhap);
            a = NHBus.them(NH);
            Assert.AreEqual(1, a);
        }

        [TestMethod]
        public void TestNhapHang_ThemLS_ThieuTenSP_SoLuong_NgayNhap_NguoiNhap()
        {
            NhapHangBUS NHBus = new NhapHangBUS();
            int a;
            string mathung = "T01";
            string masp = "123";
            string tensp = "";
            string soluong = "";
            string ngaynhap = "";
            string nguoinhap = "";
            NhapHang NH = new NhapHang(mathung, masp, tensp, soluong, ngaynhap, nguoinhap);
            a = NHBus.them(NH);
            Assert.AreEqual(1, a);
        }

        /// <summary>
        /// TestNhapHang_Them_Thieu 5 đối tượng
        /// </summary>
        [TestMethod]
        public void TestNhapHang_ThemLS_ThieuMaThung_MaSP_TenSP_SoLuong_NgayNhap()
        {
            NhapHangBUS NHBus = new NhapHangBUS();
            int a;
            string mathung = "";
            string masp = "";
            string tensp = "";
            string soluong = "";
            string ngaynhap = "";
            string nguoinhap = "hien";
            NhapHang NH = new NhapHang(mathung, masp, tensp, soluong, ngaynhap, nguoinhap);
            a = NHBus.them(NH);
            Assert.AreEqual(1, a);
        }

        [TestMethod]
        public void TestNhapHang_ThemLS_ThieuMaThung_MaSP_TenSP_SoLuong_NguoiNhap()
        {
            NhapHangBUS NHBus = new NhapHangBUS();
            int a;
            string mathung = "";
            string masp = "";
            string tensp = "";
            string soluong = "";
            string ngaynhap = (DateTime.Now).ToString();
            string nguoinhap = "";
            NhapHang NH = new NhapHang(mathung, masp, tensp, soluong, ngaynhap, nguoinhap);
            a = NHBus.them(NH);
            Assert.AreEqual(1, a);
        }

        [TestMethod]
        public void TestNhapHang_ThemLS_ThieuMaThung_MaSP_TenSP_NgayNguoiNhap()
        {
            NhapHangBUS NHBus = new NhapHangBUS();
            int a;
            string mathung = "";
            string masp = "";
            string tensp = "";
            string soluong = "1000";
            string ngaynhap = "";
            string nguoinhap = "";
            NhapHang NH = new NhapHang(mathung, masp, tensp, soluong, ngaynhap, nguoinhap);
            a = NHBus.them(NH);
            Assert.AreEqual(1, a);
        }

        [TestMethod]
        public void TestNhapHang_ThemLS_ThieuMaThung_MaSP_SoLuong_NgayNhap_NguoiNhap()
        {
            NhapHangBUS NHBus = new NhapHangBUS();
            int a;
            string mathung = "";
            string masp = "";
            string tensp = "Pin sạc dự phòng";
            string soluong = "";
            string ngaynhap = "";
            string nguoinhap = "";
            NhapHang NH = new NhapHang(mathung, masp, tensp, soluong, ngaynhap, nguoinhap);
            a = NHBus.them(NH);
            Assert.AreEqual(1, a);
        }

        [TestMethod]
        public void TestNhapHang_ThemLS_ThieuMaThung_TenSP_SoLuong_NgayNhap_NguoiNhap()
        {
            NhapHangBUS NHBus = new NhapHangBUS();
            int a;
            string mathung = "";
            string masp = "123";
            string tensp = "";
            string soluong = "";
            string ngaynhap = "";
            string nguoinhap = "";
            NhapHang NH = new NhapHang(mathung, masp, tensp, soluong, ngaynhap, nguoinhap);
            a = NHBus.them(NH);
            Assert.AreEqual(1, a);
        }

        [TestMethod]
        public void TestNhapHang_ThemLS_ThieuMaSP_TenSP_SoLuong_NgayNhap_NguoiNhap()
        {
            NhapHangBUS NHBus = new NhapHangBUS();
            int a;
            string mathung = "T01";
            string masp = "";
            string tensp = "";
            string soluong = "";
            string ngaynhap = "";
            string nguoinhap = "";
            NhapHang NH = new NhapHang(mathung, masp, tensp, soluong, ngaynhap, nguoinhap);
            a = NHBus.them(NH);
            Assert.AreEqual(1, a);
        }

        /// <summary>
        /// TestNhapHang_Them_Rỗng
        /// </summary>
        [TestMethod]
        public void TestNhapHang_ThemLS_ThieuMaThung_MaSP_TenSP_SoLuong_NgayNhap_NguoiNhap()
        {
            NhapHangBUS NHBus = new NhapHangBUS();
            int a;
            string mathung = "";
            string masp = "";
            string tensp = "";
            string soluong = "";
            string ngaynhap = "";
            string nguoinhap = "";
            NhapHang NH = new NhapHang(mathung, masp, tensp, soluong, ngaynhap, nguoinhap);
            a = NHBus.them(NH);
            Assert.AreEqual(1, a);
        }





















        [TestMethod]
        public void TestNhapHangLS()
        {
            NhapHangBUS NHBus = new NhapHangBUS();
            int a;
            string mathung = "T01";
            string masp = "95486";
            string tensp = "Pin sạc dự phòng";
            string soluong = "1000";
            string ngaynhap = (DateTime.Now).ToString();
            string nguoinhap = "cuong.suhuy";
            NhapHang NH = new NhapHang(mathung, masp, tensp, soluong, ngaynhap, nguoinhap);
            a = NHBus.themLS(NH);
            Assert.AreEqual(1, a);
        }

        [TestMethod]
        public void TestNhapHang_ThieuMTLS()
        {
            NhapHangBUS NHBus = new NhapHangBUS();
            int a;
            string mathung = "";
            string masp = "123";
            string tensp = "Pin sạc dự phòng";
            string soluong = "1000";
            string nguoinhap = "admin";
            string ngaynhap = (DateTime.Now).ToString();
            NhapHang NH = new NhapHang(mathung, masp, tensp, soluong, ngaynhap, nguoinhap);
            a = NHBus.themLS(NH);
            Assert.AreEqual(0, a);
        }

        [TestMethod]
        public void TestNhapHang_ThieuMSPLS()
        {
            NhapHangBUS NHBus = new NhapHangBUS();
            int a;
            string mathung = "T01";
            string masp = "";
            string tensp = "Pin sạc dự phòng";
            string soluong = "1000";
            string nguoinhap = "admin";
            string ngaynhap = (DateTime.Now).ToString();
            NhapHang NH = new NhapHang(mathung, masp, tensp, soluong, ngaynhap, nguoinhap);
            a = NHBus.themLS(NH);
            Assert.AreEqual(0, a);
        }

        [TestMethod]
        public void TestNhapHang_ThieuTSPLS()
        {
            NhapHangBUS NHBus = new NhapHangBUS();
            int a;
            string mathung = "T01";
            string masp = "123";
            string tensp = "";
            string soluong = "1000";
            string nguoinhap = "admin";
            string ngaynhap = (DateTime.Now).ToString();
            NhapHang NH = new NhapHang(mathung, masp, tensp, soluong, ngaynhap, nguoinhap);
            a = NHBus.themLS(NH);
            Assert.AreEqual(0, a);
        }

        [TestMethod]
        public void TestNhapHang_ThieuSLLS()
        {
            NhapHangBUS NHBus = new NhapHangBUS();
            int a;
            string mathung = "T01";
            string masp = "123";
            string tensp = "Pin sạc dự phòng";
            string soluong = "";
            string nguoinhap = "admin";
            string ngaynhap = (DateTime.Now).ToString();
            NhapHang NH = new NhapHang(mathung, masp, tensp, soluong, ngaynhap, nguoinhap);
            a = NHBus.themLS(NH);
            Assert.AreEqual(0, a);
        }

        [TestMethod]
        public void TestNhapHang_ThieuNNLS()
        {
            NhapHangBUS NHBus = new NhapHangBUS();
            int a;
            string mathung = "T01";
            string masp = "123";
            string tensp = "Pin sạc dự phòng";
            string soluong = "1000";
            string nguoinhap = "";
            string ngaynhap = (DateTime.Now).ToString();
            NhapHang NH = new NhapHang(mathung, masp, tensp, soluong, ngaynhap, nguoinhap);
            a = NHBus.themLS(NH);
            Assert.AreEqual(0, a);
        }

        [TestMethod]
        public void TestNhapHang_ThieuNgNhLS()
        {
            NhapHangBUS NHBus = new NhapHangBUS();
            int a;
            string mathung = "T01";
            string masp = "123";
            string tensp = "Pin sạc dự phòng";
            string soluong = "1000";
            string nguoinhap = "admin";
            string ngaynhap = "";
            NhapHang NH = new NhapHang(mathung, masp, tensp, soluong, ngaynhap, nguoinhap);
            a = NHBus.themLS(NH);
            Assert.AreEqual(0, a);
        }

        [TestMethod]
        public void TestXoaNhapHang()
        {
            NhapHangBUS NHBus = new NhapHangBUS();
            int a;
            string mathung = "T01";
            string masp = "95486";
            string tensp = "Pin sạc dự phòng";
            string soluong = "1000";
            string ngaynhap = (DateTime.Now).ToString();
            string nguoinhap = "cuong.suhuy";
            NhapHang NH = new NhapHang(mathung, masp, tensp, soluong, ngaynhap, nguoinhap);
            a = NHBus.xoa(NH);
            Assert.AreEqual(0, a);
        }


        [TestMethod]
        public void TestXoaNhapHang_ThieuMT()
        {
            NhapHangBUS NHBus = new NhapHangBUS();
            int a;
            string mathung = "";
            string masp = "95486";
            string tensp = "Pin sạc dự phòng";
            string soluong = "1000";
            string ngaynhap = (DateTime.Now).ToString();
            string nguoinhap = "cuong.suhuy";
            NhapHang NH = new NhapHang(mathung, masp, tensp, soluong, ngaynhap, nguoinhap);
            a = NHBus.xoa(NH);
            Assert.AreEqual(1, a);
        }

        [TestMethod]
        public void TestXoaNhapHang_ThieuMSP()
        {
            NhapHangBUS NHBus = new NhapHangBUS();
            int a;
            string mathung = "T01";
            string masp = "";
            string tensp = "Pin sạc dự phòng";
            string soluong = "1000";
            string ngaynhap = (DateTime.Now).ToString();
            string nguoinhap = "cuong.suhuy";
            NhapHang NH = new NhapHang(mathung, masp, tensp, soluong, ngaynhap, nguoinhap);
            a = NHBus.xoa(NH);
            Assert.AreEqual(1, a);
        }

        [TestMethod]
        public void TestXoaNhapHang_ThieuTSP()
        {
            NhapHangBUS NHBus = new NhapHangBUS();
            int a;
            string mathung = "T01";
            string masp = "95486";
            string tensp = "";
            string soluong = "1000";
            string ngaynhap = (DateTime.Now).ToString();
            string nguoinhap = "cuong.suhuy";
            NhapHang NH = new NhapHang(mathung, masp, tensp, soluong, ngaynhap, nguoinhap);
            a = NHBus.xoa(NH);
            Assert.AreEqual(1, a);
        }

        [TestMethod]
        public void TestXoaNhapHang_ThieuSL()
        {
            NhapHangBUS NHBus = new NhapHangBUS();
            int a;
            string mathung = "T01";
            string masp = "95486";
            string tensp = "Pin sạc dự phòng";
            string soluong = "";
            string ngaynhap = (DateTime.Now).ToString();
            string nguoinhap = "cuong.suhuy";
            NhapHang NH = new NhapHang(mathung, masp, tensp, soluong, ngaynhap, nguoinhap);
            a = NHBus.xoa(NH);
            Assert.AreEqual(1, a);
        }

        [TestMethod]
        public void TestXoaNhapHang_ThieuNN()
        {
            NhapHangBUS NHBus = new NhapHangBUS();
            int a;
            string mathung = "T01";
            string masp = "95486";
            string tensp = "Pin sạc dự phòng";
            string soluong = "1000";
            string ngaynhap = "";
            string nguoinhap = "cuong.suhuy";
            NhapHang NH = new NhapHang(mathung, masp, tensp, soluong, ngaynhap, nguoinhap);
            a = NHBus.xoa(NH);
            Assert.AreEqual(1, a);
        }

        [TestMethod]
        public void TestXoaNhapHang_ThieuNguoiNhap()
        {
            NhapHangBUS NHBus = new NhapHangBUS();
            int a;
            string mathung = "T01";
            string masp = "95486";
            string tensp = "Pin sạc dự phòng";
            string soluong = "1000";
            string ngaynhap = (DateTime.Now).ToString();
            string nguoinhap = "";
            NhapHang NH = new NhapHang(mathung, masp, tensp, soluong, ngaynhap, nguoinhap);
            a = NHBus.xoa(NH);
            Assert.AreEqual(1, a);
        }

        

        [TestMethod]
        public void TestCatHang()
        {
            CatHangBUS CHBus = new CatHangBUS();
            int a;
            string mathung = "T01";
            string make = "KA01";
            string masp = "123";
            string tensp = "Apple";
            string soluong = "1000";
            string ngaycat = (DateTime.Now).ToString();
            string nguoicat = "admin";
            CatHang CH = new CatHang(mathung, make, masp, tensp, soluong, ngaycat, nguoicat);
            a = CHBus.them(CH);
            Assert.AreEqual(1,a);
        }

        [TestMethod]
        public void TestCatHang_ThieuMT()
        {
            CatHangBUS CHBus = new CatHangBUS();
            int a;
            string mathung = "";
            string make = "KA01";
            string masp = "123";
            string tensp = "Apple";
            string soluong = "1000";
            string ngaycat = (DateTime.Now).ToString();
            string nguoicat = "admin";
            CatHang CH = new CatHang(mathung, make, masp, tensp, soluong, ngaycat, nguoicat);
            a = CHBus.them(CH);
            Assert.AreEqual(0, a);
        }

        [TestMethod]
        public void TestCatHang_ThieuMK()
        {
            CatHangBUS CHBus = new CatHangBUS();
            int a;
            string mathung = "T01";
            string make = "";
            string masp = "123";
            string tensp = "Apple";
            string soluong = "1000";
            string ngaycat = (DateTime.Now).ToString();
            string nguoicat = "admin";
            CatHang CH = new CatHang(mathung, make, masp, tensp, soluong, ngaycat, nguoicat);
            a = CHBus.them(CH);
            Assert.AreEqual(0, a);
        }

        [TestMethod]
        public void TestThemCatHang_ThieuMSP()
        {
            CatHangBUS CHBus = new CatHangBUS();
            int a;
            string mathung = "T01";
            string make = "KA01";
            string masp = "";
            string tensp = "Apple";
            string soluong = "1000";
            string ngaycat = (DateTime.Now).ToString();
            string nguoicat = "admin";
            CatHang CH = new CatHang(mathung, make, masp, tensp, soluong, ngaycat, nguoicat);
            a = CHBus.them(CH);
            Assert.AreEqual(0, a);
        }

        [TestMethod]
        public void TestCatHang_ThieuTSP()
        {
            CatHangBUS CHBus = new CatHangBUS();
            int a;
            string mathung = "T01";
            string make = "KA01";
            string masp = "123";
            string tensp = "";
            string soluong = "1000";
            string ngaycat = (DateTime.Now).ToString();
            string nguoicat = "admin";
            CatHang CH = new CatHang(mathung, make, masp, tensp, soluong, ngaycat, nguoicat);
            a = CHBus.them(CH);
            Assert.AreEqual(0, a);
        }

        [TestMethod]
        public void TestCatHang_ThieuSL()
        {
            CatHangBUS CHBus = new CatHangBUS();
            int a;
            string mathung = "T01";
            string make = "KA01";
            string masp = "123";
            string tensp = "Apple";
            string soluong = "";
            string ngaycat = (DateTime.Now).ToString();
            string nguoicat = "admin";
            CatHang CH = new CatHang(mathung, make, masp, tensp, soluong, ngaycat, nguoicat);
            a = CHBus.them(CH);
            Assert.AreEqual(0, a);
        }

        [TestMethod]
        public void TestCatHang_ThieuNguoiCat()
        {
            CatHangBUS CHBus = new CatHangBUS();
            int a;
            string mathung = "T01";
            string make = "KA01";
            string masp = "123";
            string tensp = "Apple";
            string soluong = "1000";
            string ngaycat = "1/1/2018";
            string nguoicat = "";
            CatHang CH = new CatHang(mathung, make, masp, tensp, soluong, ngaycat, nguoicat);
            a = CHBus.them(CH);
            Assert.AreEqual(0, a);
        }


        /// <summary>
        /// Test Lấy Hàng
        /// </summary>
        [TestMethod]
        public void TestLayHang()
        {
            LayHangBUS LHBus = new LayHangBUS();
            int a;
            string make = "K01";
            string masp = "95486";
            string tensp = "Pin sạc dự phòng";
            string soluong = "1000";
            string ngaylay = (DateTime.Now).ToString();
            string nguoilay = "hien";
            LayHang LH = new LayHang(make, masp, tensp, soluong, ngaylay, nguoilay);
            a = LHBus.Xoa(LH);
            Assert.AreEqual(0, a);
        } 






        /// <summary>
        /// Thiếu 1 đối tượng
        /// </summary>
        [TestMethod]
        public void TestLayHang_ThieuMaKe()
        {
            LayHangBUS LHBus = new LayHangBUS();
            int a;
            string make = "";
            string masp = "95486";
            string tensp = "Pin sạc dự phòng";
            string soluong = "1000";
            string ngaylay = (DateTime.Now).ToString();
            string nguoilay = "hien";
            LayHang LH = new LayHang(make, masp, tensp, soluong, ngaylay, nguoilay);
            a = LHBus.Xoa(LH);
            Assert.AreEqual(1, a);
        }

        [TestMethod]
        public void TestLayHang_ThieuMaSP()
        {
            LayHangBUS LHBus = new LayHangBUS();
            int a;
            string make = "K01";
            string masp = "";
            string tensp = "Pin sạc dự phòng";
            string soluong = "1000";
            string ngaylay = (DateTime.Now).ToString();
            string nguoilay = "hien";
            LayHang LH = new LayHang(make, masp, tensp, soluong, ngaylay, nguoilay);
            a = LHBus.Xoa(LH);
            Assert.AreEqual(1, a);
        }


        [TestMethod]
        public void TestLayHang_ThieuTenSP()
        {
            LayHangBUS LHBus = new LayHangBUS();
            int a;
            string make = "K01";
            string masp = "95486";
            string tensp = "";
            string soluong = "1000";
            string ngaylay = (DateTime.Now).ToString();
            string nguoilay = "hien";
            LayHang LH = new LayHang(make, masp, tensp, soluong, ngaylay, nguoilay);
            a = LHBus.Xoa(LH);
            Assert.AreEqual(1, a);
        }

        [TestMethod]
        public void TestLayHang_ThieuSoLuong()
        {
            LayHangBUS LHBus = new LayHangBUS();
            int a;
            string make = "K01";
            string masp = "95486";
            string tensp = "Pin sạc dự phòng";
            string soluong = "";
            string ngaylay = (DateTime.Now).ToString();
            string nguoilay = "hien";
            LayHang LH = new LayHang(make, masp, tensp, soluong, ngaylay, nguoilay);
            a = LHBus.Xoa(LH);
            Assert.AreEqual(1, a);
        }


        [TestMethod]
        public void TestLayHang_ThieuNgayLay()
        {
            LayHangBUS LHBus = new LayHangBUS();
            int a;
            string make = "K01";
            string masp = "95486";
            string tensp = "Pin sạc dự phòng";
            string soluong = "1000";
            string ngaylay = "";
            string nguoilay = "hien";
            LayHang LH = new LayHang(make, masp, tensp, soluong, ngaylay, nguoilay);
            a = LHBus.Xoa(LH);
            Assert.AreEqual(1, a);
        }

        [TestMethod]
        public void TestLayHang_ThieuNguoiLay()
        {
            LayHangBUS LHBus = new LayHangBUS();
            int a;
            string make = "K01";
            string masp = "95486";
            string tensp = "Pin sạc dự phòng";
            string soluong = "1000";
            string ngaylay = (DateTime.Now).ToString();
            string nguoilay = "";
            LayHang LH = new LayHang(make, masp, tensp, soluong, ngaylay, nguoilay);
            a = LHBus.Xoa(LH);
            Assert.AreEqual(1, a);
        }


        /// <summary>
        /// Test thiếu 2 đối tượng
        /// </summary>
        [TestMethod]
        public void TestLayHang_ThieuMaKe_MaSP()
        {
            LayHangBUS LHBus = new LayHangBUS();
            int a;
            string make = "";
            string masp = "";
            string tensp = "Pin sạc dự phòng";
            string soluong = "1000";
            string ngaylay = (DateTime.Now).ToString();
            string nguoilay = "hien";
            LayHang LH = new LayHang(make, masp, tensp, soluong, ngaylay, nguoilay);
            a = LHBus.Xoa(LH);
            Assert.AreEqual(1, a);
        }

        [TestMethod]
        public void TestLayHang_ThieuMake_TenSP()
        {
            LayHangBUS LHBus = new LayHangBUS();
            int a;
            string make = "";
            string masp = "95486";
            string tensp = "";
            string soluong = "1000";
            string ngaylay = (DateTime.Now).ToString();
            string nguoilay = "hien";
            LayHang LH = new LayHang(make, masp, tensp, soluong, ngaylay, nguoilay);
            a = LHBus.Xoa(LH);
            Assert.AreEqual(1, a);
        }


        [TestMethod]
        public void TestLayHang_ThieuMaKe_SoLuong()
        {
            LayHangBUS LHBus = new LayHangBUS();
            int a;
            string make = "";
            string masp = "95486";
            string tensp = "Pin sạc dự phòng";
            string soluong = "";
            string ngaylay = (DateTime.Now).ToString();
            string nguoilay = "hien";
            LayHang LH = new LayHang(make, masp, tensp, soluong, ngaylay, nguoilay);
            a = LHBus.Xoa(LH);
            Assert.AreEqual(1, a);
        }

        [TestMethod]
        public void TestLayHang_ThieuMaKe_NgayLay()
        {
            LayHangBUS LHBus = new LayHangBUS();
            int a;
            string make = "";
            string masp = "95486";
            string tensp = "Pin sạc dự phòng";
            string soluong = "1000";
            string ngaylay = "";
            string nguoilay = "hien";
            LayHang LH = new LayHang(make, masp, tensp, soluong, ngaylay, nguoilay);
            a = LHBus.Xoa(LH);
            Assert.AreEqual(1, a);
        }


        [TestMethod]
        public void TestLayHang_ThieuMaKe_NguoiLay()
        {
            LayHangBUS LHBus = new LayHangBUS();
            int a;
            string make = "";
            string masp = "95486";
            string tensp = "Pin sạc dự phòng";
            string soluong = "1000";
            string ngaylay = (DateTime.Now).ToString();
            string nguoilay = "";
            LayHang LH = new LayHang(make, masp, tensp, soluong, ngaylay, nguoilay);
            a = LHBus.Xoa(LH);
            Assert.AreEqual(1, a);
        }

        [TestMethod]
        public void TestLayHang_ThieuMaSP_TenSP()
        {
            LayHangBUS LHBus = new LayHangBUS();
            int a;
            string make = "K01";
            string masp = "";
            string tensp = "";
            string soluong = "1000";
            string ngaylay = (DateTime.Now).ToString();
            string nguoilay = "hien";
            LayHang LH = new LayHang(make, masp, tensp, soluong, ngaylay, nguoilay);
            a = LHBus.Xoa(LH);
            Assert.AreEqual(1, a);
        }

        [TestMethod]
        public void TestLayHang_ThieuMaSP_SoLuong()
        {
            LayHangBUS LHBus = new LayHangBUS();
            int a;
            string make = "K01";
            string masp = "";
            string tensp = "Pin sạc dự phòng";
            string soluong = "";
            string ngaylay = (DateTime.Now).ToString();
            string nguoilay = "hien";
            LayHang LH = new LayHang(make, masp, tensp, soluong, ngaylay, nguoilay);
            a = LHBus.Xoa(LH);
            Assert.AreEqual(1, a);
        }

        [TestMethod]
        public void TestLayHang_ThieuMaSP_NgayLay()
        {
            LayHangBUS LHBus = new LayHangBUS();
            int a;
            string make = "K01";
            string masp = "";
            string tensp = "Pin sạc dự phòng";
            string soluong = "1000";
            string ngaylay = "";
            string nguoilay = "hien";
            LayHang LH = new LayHang(make, masp, tensp, soluong, ngaylay, nguoilay);
            a = LHBus.Xoa(LH);
            Assert.AreEqual(1, a);
        }

        [TestMethod]
        public void TestLayHang_ThieuMaSP_NguoiLay()
        {
            LayHangBUS LHBus = new LayHangBUS();
            int a;
            string make = "K01";
            string masp = "";
            string tensp = "Pin sạc dự phòng";
            string soluong = "1000";
            string ngaylay = (DateTime.Now).ToString();
            string nguoilay = "";
            LayHang LH = new LayHang(make, masp, tensp, soluong, ngaylay, nguoilay);
            a = LHBus.Xoa(LH);
            Assert.AreEqual(1, a);
        }

        [TestMethod]
        public void TestLayHang_ThieuTenSP_SoLuong()
        {
            LayHangBUS LHBus = new LayHangBUS();
            int a;
            string make = "K01";
            string masp = "95486";
            string tensp = "";
            string soluong = "";
            string ngaylay = (DateTime.Now).ToString();
            string nguoilay = "hien";
            LayHang LH = new LayHang(make, masp, tensp, soluong, ngaylay, nguoilay);
            a = LHBus.Xoa(LH);
            Assert.AreEqual(1, a);
        }

        [TestMethod]
        public void TestLayHang_ThieuTenSP_NgayLay()
        {
            LayHangBUS LHBus = new LayHangBUS();
            int a;
            string make = "K01";
            string masp = "95486";
            string tensp = "";
            string soluong = "1000";
            string ngaylay = "";
            string nguoilay = "hien";
            LayHang LH = new LayHang(make, masp, tensp, soluong, ngaylay, nguoilay);
            a = LHBus.Xoa(LH);
            Assert.AreEqual(1, a);
        }

        [TestMethod]
        public void TestLayHang_ThieuTenSP_NguoiLay()
        {
            LayHangBUS LHBus = new LayHangBUS();
            int a;
            string make = "K01";
            string masp = "95486";
            string tensp = "";
            string soluong = "1000";
            string ngaylay = (DateTime.Now).ToString();
            string nguoilay = "";
            LayHang LH = new LayHang(make, masp, tensp, soluong, ngaylay, nguoilay);
            a = LHBus.Xoa(LH);
            Assert.AreEqual(1, a);
        }

        [TestMethod]
        public void TestLayHang_ThieuSoLuong_NgayLay()
        {
            LayHangBUS LHBus = new LayHangBUS();
            int a;
            string make = "K01";
            string masp = "95486";
            string tensp = "Pin sạc dự phòng";
            string soluong = "";
            string ngaylay = "";
            string nguoilay = "hien";
            LayHang LH = new LayHang(make, masp, tensp, soluong, ngaylay, nguoilay);
            a = LHBus.Xoa(LH);
            Assert.AreEqual(1, a);
        }

        [TestMethod]
        public void TestLayHang_ThieuSoLuong_NguoiLay()
        {
            LayHangBUS LHBus = new LayHangBUS();
            int a;
            string make = "K01";
            string masp = "95486";
            string tensp = "Pin sạc dự phòng";
            string soluong = "";
            string ngaylay = (DateTime.Now).ToString();
            string nguoilay = "";
            LayHang LH = new LayHang(make, masp, tensp, soluong, ngaylay, nguoilay);
            a = LHBus.Xoa(LH);
            Assert.AreEqual(1, a);
        }

        [TestMethod]
        public void TestLayHang_ThieuNgayLay_NguoiLay()
        {
            LayHangBUS LHBus = new LayHangBUS();
            int a;
            string make = "K01";
            string masp = "95486";
            string tensp = "Pin sạc dự phòng";
            string soluong = "1000";
            string ngaylay = "";
            string nguoilay = "";
            LayHang LH = new LayHang(make, masp, tensp, soluong, ngaylay, nguoilay);
            a = LHBus.Xoa(LH);
            Assert.AreEqual(1, a);
        }


        /// <summary>
        /// Test Thiếu 3 đối tượng
        /// </summary>
        [TestMethod]
        public void TestLayHang_ThieuMaKe_MaSP_TenSP()
        {
            LayHangBUS LHBus = new LayHangBUS();
            int a;
            string make = "";
            string masp = "";
            string tensp = "";
            string soluong = "1000";
            string ngaylay = (DateTime.Now).ToString();
            string nguoilay = "hien";
            LayHang LH = new LayHang(make, masp, tensp, soluong, ngaylay, nguoilay);
            a = LHBus.Xoa(LH);
            Assert.AreEqual(1, a);
        }

        [TestMethod]
        public void TestLayHang_ThieuMaKe_MaSP_SoLuong()
        {
            LayHangBUS LHBus = new LayHangBUS();
            int a;
            string make = "";
            string masp = "";
            string tensp = "Pin sạc dự phòng";
            string soluong = "";
            string ngaylay = (DateTime.Now).ToString();
            string nguoilay = "hien";
            LayHang LH = new LayHang(make, masp, tensp, soluong, ngaylay, nguoilay);
            a = LHBus.Xoa(LH);
            Assert.AreEqual(1, a);
        }

        [TestMethod]
        public void TestLayHang_ThieuMaKe_MaSP_NgayLay()
        {
            LayHangBUS LHBus = new LayHangBUS();
            int a;
            string make = "";
            string masp = "";
            string tensp = "Pin sạc dự phòng";
            string soluong = "1000";
            string ngaylay = "";
            string nguoilay = "hien";
            LayHang LH = new LayHang(make, masp, tensp, soluong, ngaylay, nguoilay);
            a = LHBus.Xoa(LH);
            Assert.AreEqual(1, a);
        }

        [TestMethod]
        public void TestLayHang_ThieuMaKe_MaSP_NguoiLay()
        {
            LayHangBUS LHBus = new LayHangBUS();
            int a;
            string make = "";
            string masp = "";
            string tensp = "Pin sạc dự phòng";
            string soluong = "1000";
            string ngaylay = (DateTime.Now).ToString();
            string nguoilay = "";
            LayHang LH = new LayHang(make, masp, tensp, soluong, ngaylay, nguoilay);
            a = LHBus.Xoa(LH);
            Assert.AreEqual(1, a);
        }

        [TestMethod]
        public void TestLayHang_ThieuMaSP_TenSP_SoLuong()
        {
            LayHangBUS LHBus = new LayHangBUS();
            int a;
            string make = "K01";
            string masp = "";
            string tensp = "";
            string soluong = "";
            string ngaylay = (DateTime.Now).ToString();
            string nguoilay = "hien";
            LayHang LH = new LayHang(make, masp, tensp, soluong, ngaylay, nguoilay);
            a = LHBus.Xoa(LH);
            Assert.AreEqual(1, a);
        }

        [TestMethod]
        public void TestLayHang_ThieuMaSP_TenSP_NgayLay()
        {
            LayHangBUS LHBus = new LayHangBUS();
            int a;
            string make = "K01";
            string masp = "";
            string tensp = "";
            string soluong = "1000";
            string ngaylay = "";
            string nguoilay = "hien";
            LayHang LH = new LayHang(make, masp, tensp, soluong, ngaylay, nguoilay);
            a = LHBus.Xoa(LH);
            Assert.AreEqual(1, a);
        }

        [TestMethod]
        public void TestLayHang_ThieuMaSP_TenSP_NguoiLay()
        {
            LayHangBUS LHBus = new LayHangBUS();
            int a;
            string make = "K01";
            string masp = "";
            string tensp = "";
            string soluong = "1000";
            string ngaylay = (DateTime.Now).ToString();
            string nguoilay = "";
            LayHang LH = new LayHang(make, masp, tensp, soluong, ngaylay, nguoilay);
            a = LHBus.Xoa(LH);
            Assert.AreEqual(1, a);
        }

        [TestMethod]
        public void TestLayHang_ThieuTenSP_SoLuong_NgayLay()
        {
            LayHangBUS LHBus = new LayHangBUS();
            int a;
            string make = "K01";
            string masp = "95486";
            string tensp = "";
            string soluong = "";
            string ngaylay = "";
            string nguoilay = "hien";
            LayHang LH = new LayHang(make, masp, tensp, soluong, ngaylay, nguoilay);
            a = LHBus.Xoa(LH);
            Assert.AreEqual(1, a);
        }

        [TestMethod]
        public void TestLayHang_ThieuTenSP_SoLuong_NguoiLay()
        {
            LayHangBUS LHBus = new LayHangBUS();
            int a;
            string make = "K01";
            string masp = "95486";
            string tensp = "";
            string soluong = "";
            string ngaylay = (DateTime.Now).ToString();
            string nguoilay = "";
            LayHang LH = new LayHang(make, masp, tensp, soluong, ngaylay, nguoilay);
            a = LHBus.Xoa(LH);
            Assert.AreEqual(1, a);
        }

        [TestMethod]
        public void TestLayHang_ThieuSoLuong_NgayLay_NguoiLay()
        {
            LayHangBUS LHBus = new LayHangBUS();
            int a;
            string make = "K01";
            string masp = "95486";
            string tensp = "Pin sạc dự phòng";
            string soluong = "";
            string ngaylay = "";
            string nguoilay = "";
            LayHang LH = new LayHang(make, masp, tensp, soluong, ngaylay, nguoilay);
            a = LHBus.Xoa(LH);
            Assert.AreEqual(1, a);
        }


        /// <summary>
        /// Test thiếu 4 đối tượng
        /// </summary>
        [TestMethod]
        public void TestLayHang_ThieuMaKe_MaSP_TenSP_SoLuong()
        {
            LayHangBUS LHBus = new LayHangBUS();
            int a;
            string make = "";
            string masp = "";
            string tensp = "";
            string soluong = "";
            string ngaylay = (DateTime.Now).ToString();
            string nguoilay = "hien";
            LayHang LH = new LayHang(make, masp, tensp, soluong, ngaylay, nguoilay);
            a = LHBus.Xoa(LH);
            Assert.AreEqual(1, a);
        }

        [TestMethod]
        public void TestLayHang_ThieuMaKe_MaSP_TenSP_NgayLay()
        {
            LayHangBUS LHBus = new LayHangBUS();
            int a;
            string make = "";
            string masp = "";
            string tensp = "";
            string soluong = "1000";
            string ngaylay = "";
            string nguoilay = "hien";
            LayHang LH = new LayHang(make, masp, tensp, soluong, ngaylay, nguoilay);
            a = LHBus.Xoa(LH);
            Assert.AreEqual(1, a);
        }

        [TestMethod]
        public void TestLayHang_ThieuMaKe_MaSP_TenSP_NguoiLay()
        {
            LayHangBUS LHBus = new LayHangBUS();
            int a;
            string make = "";
            string masp = "";
            string tensp = "";
            string soluong = "1000";
            string ngaylay = (DateTime.Now).ToString();
            string nguoilay = "";
            LayHang LH = new LayHang(make, masp, tensp, soluong, ngaylay, nguoilay);
            a = LHBus.Xoa(LH);
            Assert.AreEqual(1, a);
        }

        [TestMethod]
        public void TestLayHang_ThieuMaSP_TenSP_SoLuong_NgayLay()
        {
            LayHangBUS LHBus = new LayHangBUS();
            int a;
            string make = "K01";
            string masp = "";
            string tensp = "";
            string soluong = "";
            string ngaylay = "";
            string nguoilay = "hien";
            LayHang LH = new LayHang(make, masp, tensp, soluong, ngaylay, nguoilay);
            a = LHBus.Xoa(LH);
            Assert.AreEqual(1, a);
        }

        [TestMethod]
        public void TestLayHang_ThieuMaSP_TenSP_SoLuong_NguoiLay()
        {
            LayHangBUS LHBus = new LayHangBUS();
            int a;
            string make = "K01";
            string masp = "";
            string tensp = "";
            string soluong = "";
            string ngaylay = (DateTime.Now).ToString();
            string nguoilay = "";
            LayHang LH = new LayHang(make, masp, tensp, soluong, ngaylay, nguoilay);
            a = LHBus.Xoa(LH);
            Assert.AreEqual(1, a);
        }

        [TestMethod]
        public void TestLayHang_ThieuTenSP_SoLuong_NgayLay_NguoiLay()
        {
            LayHangBUS LHBus = new LayHangBUS();
            int a;
            string make = "K01";
            string masp = "95486";
            string tensp = "";
            string soluong = "";
            string ngaylay = "";
            string nguoilay = "";
            LayHang LH = new LayHang(make, masp, tensp, soluong, ngaylay, nguoilay);
            a = LHBus.Xoa(LH);
            Assert.AreEqual(1, a);
        }


        /// <summary>
        /// Test thiếu 5 đối tượng
        /// </summary>
        [TestMethod]
        public void TestLayHang_ThieuMaKe_MaSP_TenSP_SoLuong_NgayLay()
        {
            LayHangBUS LHBus = new LayHangBUS();
            int a;
            string make = "";
            string masp = "";
            string tensp = "";
            string soluong = "";
            string ngaylay = "";
            string nguoilay = "hien";
            LayHang LH = new LayHang(make, masp, tensp, soluong, ngaylay, nguoilay);
            a = LHBus.Xoa(LH);
            Assert.AreEqual(1, a);
        }

        [TestMethod]
        public void TestLayHang_ThieuMaKe_MaSP_TenSP_SoLuong_NguoiLay()
        {
            LayHangBUS LHBus = new LayHangBUS();
            int a;
            string make = "";
            string masp = "";
            string tensp = "";
            string soluong = "";
            string ngaylay = (DateTime.Now).ToString();
            string nguoilay = "";
            LayHang LH = new LayHang(make, masp, tensp, soluong, ngaylay, nguoilay);
            a = LHBus.Xoa(LH);
            Assert.AreEqual(1, a);
        }

        [TestMethod]
        public void TestLayHang_ThieuMaKe_MaSP_TenSP_NgayLay_NguoiLay()
        {
            LayHangBUS LHBus = new LayHangBUS();
            int a;
            string make = "";
            string masp = "";
            string tensp = "";
            string soluong = "1000";
            string ngaylay = "";
            string nguoilay = "";
            LayHang LH = new LayHang(make, masp, tensp, soluong, ngaylay, nguoilay);
            a = LHBus.Xoa(LH);
            Assert.AreEqual(1, a);
        }

        [TestMethod]
        public void TestLayHang_ThieuMaKe_MaSP_SoLuong_NgayLay_NguoiLay()
        {
            LayHangBUS LHBus = new LayHangBUS();
            int a;
            string make = "";
            string masp = "";
            string tensp = "Pin sạc dự phòng";
            string soluong = "";
            string ngaylay = "";
            string nguoilay = "";
            LayHang LH = new LayHang(make, masp, tensp, soluong, ngaylay, nguoilay);
            a = LHBus.Xoa(LH);
            Assert.AreEqual(1, a);
        }

        [TestMethod]
        public void TestLayHang_ThieuMaKe__TenSP_SoLuong_NgayLay_NguoiLay()
        {
            LayHangBUS LHBus = new LayHangBUS();
            int a;
            string make = "";
            string masp = "95486";
            string tensp = "";
            string soluong = "";
            string ngaylay = "";
            string nguoilay = "";
            LayHang LH = new LayHang(make, masp, tensp, soluong, ngaylay, nguoilay);
            a = LHBus.Xoa(LH);
            Assert.AreEqual(1, a);
        }


        [TestMethod]
        public void TestLayHang_ThieuMaSP_TenSP_SoLuong_NgayLay_NguoiLay()
        {
            LayHangBUS LHBus = new LayHangBUS();
            int a;
            string make = "K01";
            string masp = "";
            string tensp = "";
            string soluong = "";
            string ngaylay = "";
            string nguoilay = "";
            LayHang LH = new LayHang(make, masp, tensp, soluong, ngaylay, nguoilay);
            a = LHBus.Xoa(LH);
            Assert.AreEqual(1, a);
        }

        /// <summary>
        /// Test Rỗng 
        /// </summary>
        [TestMethod]
        public void TestLayHang_ThieuMaKe_MaSP_TenSP_SoLuong_NgayLay_NguoiLay()
        {
            LayHangBUS LHBus = new LayHangBUS();
            int a;
            string make = "";
            string masp = "";
            string tensp = "";
            string soluong = "";
            string ngaylay = "";
            string nguoilay = "";
            LayHang LH = new LayHang(make, masp, tensp, soluong, ngaylay, nguoilay);
            a = LHBus.Xoa(LH);
            Assert.AreEqual(1, a);
        }
    }
}
