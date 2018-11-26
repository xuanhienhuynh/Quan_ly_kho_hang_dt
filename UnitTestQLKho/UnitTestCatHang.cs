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

    }
}
