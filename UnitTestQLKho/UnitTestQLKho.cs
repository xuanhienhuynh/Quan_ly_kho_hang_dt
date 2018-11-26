using System;
using System.Data;
using System.Data.SqlClient;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuanLyKhoHang;
using System.Data;
using System.Data.SqlClient;
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
        }

        [TestMethod]
        public void TestLogin()
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
        public void TestLoginNull_Username()
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
        public void TestLoginNull_Password()
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
        public void TestLoginNull()
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

        [TestMethod]
        public void TestThemNhapHang()
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
        public void TestThemNhapHang_ThieuMT()
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
        public void TestThemNhapHang_ThieuMSP()
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
        public void TestThemNhapHang_ThieuTSP()
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
        public void TestThemNhapHang_ThieuSL()
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
        public void TestThemNhapHang_ThieuNN()
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
            a = NHBus.them(NH);
            Assert.AreEqual(0, a);
        }

        [TestMethod]
        public void TestThemNhapHang_ThieuNgNh()
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
        public void TestThemNhapHangLS()
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
        public void TestThemNhapHang_ThieuMTLS()
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
        public void TestThemNhapHang_ThieuMSPLS()
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
        public void TestThemNhapHang_ThieuTSPLS()
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
        public void TestThemNhapHang_ThieuSLLS()
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
        public void TestThemNhapHang_ThieuNNLS()
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
        public void TestThemNhapHang_ThieuNgNhLS()
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
        public void TestThemCatHang()
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
        public void TestThemCatHang_ThieuMT()
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
        public void TestThemCatHang_ThieuMK()
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
        public void TestThemCatHang_ThieuTSP()
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
        public void TestThemCatHang_ThieuSL()
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
        public void TestThemCatHang_ThieuNguoiCat()
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
