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
    /// Summary description for UnitTestCatHang
    /// </summary>
    [TestClass]
    public class UnitTestCatHang
    {
        private DataProvider daPro;
        private CatHangDAO CHD;

        [TestInitialize] //phương thức thực thi trước khi chạy các test case.
        public void setUp()
        {
            daPro = new DataProvider();
            CHD = new CatHangDAO();
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
            Assert.AreEqual(1, a);
        }

        /// <summary>
        /// TestCatHang_Thieu 1 đối tượng
        /// </summary>
        [TestMethod]
        public void TestCatHang_Them_ThieuMaTh()
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
        public void TestCatHang_Them_ThieuMK()
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
        public void TestCatHang_Them_ThieuMSP()
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
        public void TestCatHang_Them_ThieuTSP()
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
        public void TestCatHang_Them_ThieuSL()
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
        public void TestCatHang_Them_ThieuNgayCat()
        {
            CatHangBUS CHBus = new CatHangBUS();
            int a;
            string mathung = "T01";
            string make = "KA01";
            string masp = "123";
            string tensp = "Apple";
            string soluong = "1000";
            string ngaycat = "";
            string nguoicat = "hien";
            CatHang CH = new CatHang(mathung, make, masp, tensp, soluong, ngaycat, nguoicat);
            a = CHBus.them(CH);
            Assert.AreEqual(0, a);
        }

        [TestMethod]
        public void TestCatHang_Them_ThieuNguoiCat()
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




        [TestMethod]
        public void TestCatHangLS()
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
            Assert.AreEqual(1, a);
        }

        /// <summary>
        /// TestCatHang_Thieu 1 đối tượng
        /// </summary>
        [TestMethod]
        public void TestCatHang_ThemLS_ThieuMaTh()
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
        public void TestCatHang_ThemLS_ThieuMK()
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
        public void TestCatHang_ThemLS_ThieuMSP()
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
        public void TestCatHang_ThemLS_ThieuTSP()
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
        public void TestCatHang_ThemLS_ThieuSL()
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
        public void TestCatHang_ThemLS_ThieuNgayCat()
        {
            CatHangBUS CHBus = new CatHangBUS();
            int a;
            string mathung = "T01";
            string make = "KA01";
            string masp = "123";
            string tensp = "Apple";
            string soluong = "1000";
            string ngaycat = "";
            string nguoicat = "hien";
            CatHang CH = new CatHang(mathung, make, masp, tensp, soluong, ngaycat, nguoicat);
            a = CHBus.them(CH);
            Assert.AreEqual(0, a);
        }

        [TestMethod]
        public void TestCatHang_ThemLS_ThieuNguoiCat()
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



    }
}
