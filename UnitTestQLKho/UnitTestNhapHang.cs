using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuanLyKhoHang;
using DAO;
using DTO;
using BUS;

namespace UnitTestQLKho
{
    /// <summary>
    /// Summary description for UnitTestNhapHang
    /// </summary>
    [TestClass]
    public class UnitTestNhapHang
    {
        private DataProvider daPro;
        private NhapHangDAO NHD;

        [TestInitialize] //phương thức thực thi trước khi chạy các test case.
        public void setUp()
        {
            daPro = new DataProvider();
            NHD = new NhapHangDAO();
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
            Assert.AreEqual(0, a);
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
            Assert.AreEqual(0, a);
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
            Assert.AreEqual(0, a);
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
            Assert.AreEqual(0, a);
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
            Assert.AreEqual(0, a);
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
            Assert.AreEqual(0, a);
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
            Assert.AreEqual(0, a);
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
            Assert.AreEqual(0, a);
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
            Assert.AreEqual(0, a);
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
            Assert.AreEqual(0, a);
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
            Assert.AreEqual(0, a);
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
            Assert.AreEqual(0, a);
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
            Assert.AreEqual(0, a);
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
            Assert.AreEqual(0, a);
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
            Assert.AreEqual(0, a);
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
            Assert.AreEqual(0, a);
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
            Assert.AreEqual(0, a);
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
            Assert.AreEqual(0, a);
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
            Assert.AreEqual(0, a);
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
            Assert.AreEqual(0, a);
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
            Assert.AreEqual(0, a);
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
            Assert.AreEqual(0, a);
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
            Assert.AreEqual(0, a);
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
            Assert.AreEqual(0, a);
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
            Assert.AreEqual(0, a);
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
            Assert.AreEqual(0, a);
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
            Assert.AreEqual(0, a);
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
            Assert.AreEqual(0, a);
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
            Assert.AreEqual(0, a);
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
            Assert.AreEqual(0, a);
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
            Assert.AreEqual(0, a);
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
            Assert.AreEqual(0, a);
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
            Assert.AreEqual(0, a);
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
            Assert.AreEqual(0, a);
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
            Assert.AreEqual(0, a);
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
            Assert.AreEqual(0, a);
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
            Assert.AreEqual(0, a);
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
            Assert.AreEqual(0, a);
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
            Assert.AreEqual(0, a);
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
            Assert.AreEqual(0, a);
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
            Assert.AreEqual(0, a);
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
            Assert.AreEqual(0, a);
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
            Assert.AreEqual(0, a);
        }







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
            Assert.AreEqual(0, a);
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
            Assert.AreEqual(0, a);
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
            Assert.AreEqual(0, a);
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
            Assert.AreEqual(0, a);
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
            Assert.AreEqual(0, a);
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
            Assert.AreEqual(0, a);
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
            Assert.AreEqual(0, a);
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
            Assert.AreEqual(0, a);
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
            Assert.AreEqual(0, a);
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
            Assert.AreEqual(0, a);
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
            Assert.AreEqual(0, a);
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
            Assert.AreEqual(0, a);
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
            Assert.AreEqual(0, a);
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
            Assert.AreEqual(0, a);
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
            Assert.AreEqual(0, a);
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
            Assert.AreEqual(0, a);
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
            Assert.AreEqual(0, a);
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
            Assert.AreEqual(0, a);
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
            Assert.AreEqual(0, a);
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
            Assert.AreEqual(0, a);
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
            Assert.AreEqual(0, a);
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
            Assert.AreEqual(0, a);
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
            Assert.AreEqual(0, a);
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
            Assert.AreEqual(0, a);
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
            Assert.AreEqual(0, a);
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
            Assert.AreEqual(0, a);
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
            Assert.AreEqual(0, a);
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
            Assert.AreEqual(0, a);
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
            Assert.AreEqual(0, a);
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
            Assert.AreEqual(0, a);
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
            Assert.AreEqual(0, a);
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
            Assert.AreEqual(0, a);
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
            Assert.AreEqual(0, a);
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
            Assert.AreEqual(0, a);
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
            Assert.AreEqual(0, a);
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
            Assert.AreEqual(0, a);
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
            Assert.AreEqual(0, a);
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
            Assert.AreEqual(0, a);
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
            Assert.AreEqual(0, a);
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
            Assert.AreEqual(0, a);
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
            Assert.AreEqual(0, a);
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
            Assert.AreEqual(0, a);
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
            Assert.AreEqual(0, a);
        }

        /// <summary>
        /// TestNhapHang_Xóa
        /// </summary>
        [TestMethod]
        public void TestNhapHang_Xoa()
        {
            NhapHangBUS NHBus = new NhapHangBUS();
            int a;
            string mathung = "T01";
            string masp = "95486";
            string tensp = "Pin sạc dự phòng";
            string soluong = "1000";
            string ngaynhap = (DateTime.Now).ToString();
            string nguoinhap = "cuong";
            NhapHang NH = new NhapHang(mathung, masp, tensp, soluong, ngaynhap, nguoinhap);
            a = NHBus.xoa(NH);
            Assert.AreEqual(0, a);
        }

        /// <summary>
        /// TestNhapHang_Xóa_Thiếu 1 đối tượng
        /// </summary>
        [TestMethod]
        public void TestNhapHang_Xoa_ThieuMaThung()
        {
            NhapHangBUS NHBus = new NhapHangBUS();
            int a;
            string mathung = "";
            string masp = "95486";
            string tensp = "Pin sạc dự phòng";
            string soluong = "1000";
            string ngaynhap = (DateTime.Now).ToString();
            string nguoinhap = "cuong";
            NhapHang NH = new NhapHang(mathung, masp, tensp, soluong, ngaynhap, nguoinhap);
            a = NHBus.xoa(NH);
            Assert.AreEqual(1, a);
        }

        [TestMethod]
        public void TestNhapHang_Xoa_ThieuMaSP()
        {
            NhapHangBUS NHBus = new NhapHangBUS();
            int a;
            string mathung = "T01";
            string masp = "";
            string tensp = "Pin sạc dự phòng";
            string soluong = "1000";
            string ngaynhap = (DateTime.Now).ToString();
            string nguoinhap = "cuong";
            NhapHang NH = new NhapHang(mathung, masp, tensp, soluong, ngaynhap, nguoinhap);
            a = NHBus.xoa(NH);
            Assert.AreEqual(1, a);
        }

        [TestMethod]
        public void TestNhapHang_Xoa_ThieuTenSP()
        {
            NhapHangBUS NHBus = new NhapHangBUS();
            int a;
            string mathung = "T01";
            string masp = "95486";
            string tensp = "";
            string soluong = "1000";
            string ngaynhap = (DateTime.Now).ToString();
            string nguoinhap = "cuong";
            NhapHang NH = new NhapHang(mathung, masp, tensp, soluong, ngaynhap, nguoinhap);
            a = NHBus.xoa(NH);
            Assert.AreEqual(1, a);
        }

        [TestMethod]
        public void TestNhapHang_Xoa_ThieuSoLuong()
        {
            NhapHangBUS NHBus = new NhapHangBUS();
            int a;
            string mathung = "T01";
            string masp = "95486";
            string tensp = "Pin sạc dự phòng";
            string soluong = "";
            string ngaynhap = (DateTime.Now).ToString();
            string nguoinhap = "cuong";
            NhapHang NH = new NhapHang(mathung, masp, tensp, soluong, ngaynhap, nguoinhap);
            a = NHBus.xoa(NH);
            Assert.AreEqual(1, a);
        }

        [TestMethod]
        public void TestNhapHang_Xoa_ThieuNgayNhap()
        {
            NhapHangBUS NHBus = new NhapHangBUS();
            int a;
            string mathung = "T01";
            string masp = "95486";
            string tensp = "Pin sạc dự phòng";
            string soluong = "1000";
            string ngaynhap = "";
            string nguoinhap = "cuong";
            NhapHang NH = new NhapHang(mathung, masp, tensp, soluong, ngaynhap, nguoinhap);
            a = NHBus.xoa(NH);
            Assert.AreEqual(1, a);
        }

        [TestMethod]
        public void TestNhapHang_Xoa_ThieuNguoiNhap()
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



        /// <summary>
        /// TestNhapHang_Xoa_Thieu 2 đối tượng
        /// </summary>
        [TestMethod]
        public void TestNhapHang_Xoa_ThieuMaThung_MaSP()
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
            a = NHBus.xoa(NH);
            Assert.AreEqual(1, a);
        }

        [TestMethod]
        public void TestNhapHang_Xoa_ThieuMaThung_TenSP()
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
            a = NHBus.xoa(NH);
            Assert.AreEqual(1, a);
        }

        [TestMethod]
        public void TestNhapHang_Xoa_ThieuMaThung_SoLuong()
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
            a = NHBus.xoa(NH);
            Assert.AreEqual(1, a);
        }

        [TestMethod]
        public void TestNhapHang_Xoa_ThieuMaThung_NguoiNhap()
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
            a = NHBus.xoa(NH);
            Assert.AreEqual(1, a);
        }

        [TestMethod]
        public void TestNhapHang_Xoa_ThieuMaThung_NgayNhap()
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
            a = NHBus.xoa(NH);
            Assert.AreEqual(1, a);
        }

        [TestMethod]
        public void TestNhapHang_Xoa_ThieuMaSP_TenSP()
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
            a = NHBus.xoa(NH);
            Assert.AreEqual(1, a);
        }

        [TestMethod]
        public void TestNhapHang_Xoa_ThieuMaSP_SoLuong()
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
            a = NHBus.xoa(NH);
            Assert.AreEqual(1, a);
        }

        [TestMethod]
        public void TestNhapHang_Xoa_ThieuMaSP_NgayNhap()
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
            a = NHBus.xoa(NH);
            Assert.AreEqual(1, a);
        }

        [TestMethod]
        public void TestNhapHang_Xoa_ThieuMaSP_NguoiNhap()
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
            a = NHBus.xoa(NH);
            Assert.AreEqual(1, a);
        }

        [TestMethod]
        public void TestNhapHang_Xoa_ThieuTenSP_SoLuong()
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
            a = NHBus.xoa(NH);
            Assert.AreEqual(1, a);
        }

        [TestMethod]
        public void TestNhapHang_Xoa_ThieuTenSP_NgayNhap()
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
            a = NHBus.xoa(NH);
            Assert.AreEqual(1, a);
        }

        [TestMethod]
        public void TestNhapHang_Xoa_ThieuTenSP_NguoiNhap()
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
            a = NHBus.xoa(NH);
            Assert.AreEqual(1, a);
        }

        [TestMethod]
        public void TestNhapHang_Xoa_ThieuSoLuong_NgayNhap()
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
            a = NHBus.xoa(NH);
            Assert.AreEqual(1, a);
        }

        [TestMethod]
        public void TestNhapHang_Xoa_ThieuSoLuong_NguoiNhap()
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
            a = NHBus.xoa(NH);
            Assert.AreEqual(1, a);
        }

        /// <summary>
        /// TestNhapHang_Xoa_Thieu 3 đối tượng
        /// </summary>
        [TestMethod]
        public void TestNhapHang_Xoa_ThieuMaThung_MaSP_TenSP()
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
            a = NHBus.xoa(NH);
            Assert.AreEqual(1, a);
        }

        [TestMethod]
        public void TestNhapHang_Xoa_ThieuMaThung_MaSP_SoLuong()
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
            a = NHBus.xoa(NH);
            Assert.AreEqual(1, a);
        }

        [TestMethod]
        public void TestNhapHang_Xoa_ThieuMaThung_MaSP_NgayNhap()
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
            a = NHBus.xoa(NH);
            Assert.AreEqual(1, a);
        }

        [TestMethod]
        public void TestNhapHang_Xoa_ThieuMaThung_MaSP_NguoiNhap()
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
            a = NHBus.xoa(NH);
            Assert.AreEqual(1, a);
        }

        [TestMethod]
        public void TestNhapHang_Xoa_ThieuMaSP_TenSP_SoLuong()
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
            a = NHBus.xoa(NH);
            Assert.AreEqual(1, a);
        }

        [TestMethod]
        public void TestNhapHang_Xoa_ThieuMaSP_TenSP_NgayNhap()
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
            a = NHBus.xoa(NH);
            Assert.AreEqual(1, a);
        }

        [TestMethod]
        public void TestNhapHang_Xoa_ThieuMaSP_TenSP_NguoiNhap()
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
            a = NHBus.xoa(NH);
            Assert.AreEqual(1, a);
        }

        [TestMethod]
        public void TestNhapHang_Xoa_ThieuTenSP_SoLuong_NgayNhap()
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
            a = NHBus.xoa(NH);
            Assert.AreEqual(1, a);
        }

        [TestMethod]
        public void TestNhapHang_Xoa_ThieuTenSP_SoLuong_NguoiNhap()
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
            a = NHBus.xoa(NH);
            Assert.AreEqual(1, a);
        }

        [TestMethod]
        public void TestNhapHang_Xoa_ThieuSoLuong_NgayNhap_NguoiNhap()
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
            a = NHBus.xoa(NH);
            Assert.AreEqual(1, a);
        }

        /// <summary>
        /// TestNhapHang_Xoa_Thieu 4 đối tượng
        /// </summary>
        [TestMethod]
        public void TestNhapHang_Xoa_ThieuMaThung_MaSP_TenSP_SoLuong()
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
            a = NHBus.xoa(NH);
            Assert.AreEqual(1, a);
        }

        [TestMethod]
        public void TestNhapHang_Xoa_ThieuMaThung_MaSP_TenSP_NgayNhap()
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
            a = NHBus.xoa(NH);
            Assert.AreEqual(1, a);
        }

        [TestMethod]
        public void TestNhapHang_Xoa_ThieuMaThung_MaSP_TenSP_NguoiNhap()
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
            a = NHBus.xoa(NH);
            Assert.AreEqual(1, a);
        }

        [TestMethod]
        public void TestNhapHang_Xoa_ThieuMaSP_TenSP_SoLuong_NgayNhap()
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
            a = NHBus.xoa(NH);
            Assert.AreEqual(1, a);
        }

        [TestMethod]
        public void TestNhapHang_Xoa_ThieuMaSP_TenSP_SoLuong_NguoiNhap()
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
            a = NHBus.xoa(NH);
            Assert.AreEqual(1, a);
        }

        [TestMethod]
        public void TestNhapHang_Xoa_ThieuTenSP_SoLuong_NgayNhap_NguoiNhap()
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
            a = NHBus.xoa(NH);
            Assert.AreEqual(1, a);
        }

        /// <summary>
        /// TestNhapHang_Xoa_Thieu 5 đối tượng
        /// </summary>
        [TestMethod]
        public void TestNhapHang_Xoa_ThieuMaThung_MaSP_TenSP_SoLuong_NgayNhap()
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
            a = NHBus.xoa(NH);
            Assert.AreEqual(1, a);
        }

        [TestMethod]
        public void TestNhapHang_Xoa_ThieuMaThung_MaSP_TenSP_SoLuong_NguoiNhap()
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
            a = NHBus.xoa(NH);
            Assert.AreEqual(1, a);
        }

        [TestMethod]
        public void TestNhapHang_Xoa_ThieuMaThung_MaSP_TenSP_NgayNguoiNhap()
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
            a = NHBus.xoa(NH);
            Assert.AreEqual(1, a);
        }

        [TestMethod]
        public void TestNhapHang_Xoa_ThieuMaThung_MaSP_SoLuong_NgayNhap_NguoiNhap()
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
            a = NHBus.xoa(NH);
            Assert.AreEqual(1, a);
        }

        [TestMethod]
        public void TestNhapHang_Xoa_ThieuMaThung_TenSP_SoLuong_NgayNhap_NguoiNhap()
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
            a = NHBus.xoa(NH);
            Assert.AreEqual(1, a);
        }

        [TestMethod]
        public void TestNhapHang_Xoa_ThieuMaSP_TenSP_SoLuong_NgayNhap_NguoiNhap()
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
            a = NHBus.xoa(NH);
            Assert.AreEqual(1, a);
        }

        /// <summary>
        /// TestNhapHang_Xoa_Rỗng
        /// </summary>
        [TestMethod]
        public void TestNhapHang_Xoa_ThieuMaThung_MaSP_TenSP_SoLuong_NgayNhap_NguoiNhap()
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
            a = NHBus.xoa(NH);
            Assert.AreEqual(1, a);
        }


    }
}
